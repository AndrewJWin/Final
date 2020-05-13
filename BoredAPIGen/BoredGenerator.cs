using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**********************************\
*                                  *
* Andrew Terwilliger 5/13/2020     *
* Minneapolis College              *
* ITEC 2505-60 C# Programming      *
*                                  *
\**********************************/

namespace BoredAPIGen
{
    /*
     * Primary Generator form, with user modifiable functionality for the Type of activity, price range and difficulty range.
     * After a user generates a random activity, the user is able to add the activity to a list for saving using the Save Activity button..
     * Then when the user has activities that they have saved, they can view each activity again with the View List button.
     */

    public partial class GeneratorForm : Form
    {
        // Pre-initializing values for the currently loaded activity, and a list of saved activities.
        BoredResponse currentActivity;
        private List<BoredResponse> SavedActivities = new List<BoredResponse>();

        public GeneratorForm()
        {
            InitializeComponent();

        }

        // Submit button method, reviews the settings, adds them to their own list for easy reading and submits a request to the API.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            List<string> Options = new List<string>();

            // Setting the link label invisible and disabled.
            lblLink.Enabled = false;
            lblLink.Visible = false;

            // If there is no selected activity, we can't submit a request - Let the user know.
            if (cbxActivities.SelectedIndex == -1)
            {
                MessageBox.Show("Selected Type cannot be empty!", "Missing Selection");
                // Get their attention to where they need to fix.
                cbxActivities.Focus();
            }
            else
            {
                // Add all the settings to the list and submit a request to the API.
                Options.Add(cbxActivities.SelectedItem.ToString().ToLower());
                Options.Add((Decimal.Parse(trbPrice.Value.ToString()) / 10m).ToString());
                Options.Add((Decimal.Parse(trbDifficulty.Value.ToString()) / 10m).ToString());
                RequestAPI(Options);
            }
        }

        // RequestAPI method, takes in a list of Options and requests a background worker to run asynchronously to send a request to the API. 
        private void RequestAPI(List<string> Options)
        {
            // Checking if there already is a request being sent out that hasn't been recieved.
            if (backgroundAPIWorker.IsBusy == false)
            {
                // Run the worker process and send a request.
                backgroundAPIWorker.RunWorkerAsync(Options);
            }
            else // If there's a request still waiting, we must wait for it to complete. 
            {
                MessageBox.Show("Please wait for previous request to complete.");
            }
        }

        // BackgroundWorker work method, what specifically the background process will do for us.
        private void backgroundAPIWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // If the argument is a List, we will forward it as a List options.
            if (e.Argument is List<string> options)
            {
                BoredResponse apiResponse = BoredAPI.FetchAPI(options, out string error);  // Make the request!
                e.Result = (reponse: apiResponse, error);   // Tuple response, using the API response and an error message as arguments.
            }
            else
            {
                // Error catching, though this should never occur - The arugument should be a list of settings.
                Debug.WriteLine("Background worker error - argument not a List" + e.Argument);
                throw new Exception("Incorrect Argument type, must be a List");
            }
        }

        // BackgroundWorker completed work method, returns the event arguments which are APIResponse and an error message.
        private void backgroundAPIWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                // If the background worker throws an error, e.Error will have a value
                MessageBox.Show($"Unexpected Error fetching data", "Error");
                Debug.WriteLine($"Background Worker error {e.Error}");
            }
            else
            {
                try
                {
                    // Read the result from the background worker 
                    var (response, error) = ((BoredResponse, string))e.Result;
                    // Update the user interface with the data returned. 
                    // This method also shows the user an error, if there is one
                    // These errors are generally things the user can fix, for example, no internet connection
                    if (response == null)
                    {
                        // If somehow everything was missing, we throw an error.
                        MessageBox.Show(error.ToString(), "API Error");
                    }
                    else
                    {
                        // Elsewise we set everything to their respective values.
                        currentActivity = response;
                        lblActivity.Text = currentActivity.Activity;
                        lblType.Text = currentActivity.Type.Remove(1).ToUpper() + currentActivity.Type.Substring(1); ;

                        // Switch case, since price is effectively a range - With 1 being the most expensive and 0 being free.
                        switch (currentActivity.Price)
                        {
                            case decimal n when n >= 1.0m:
                                {
                                    lblPrice.Text = "Expensive";
                                };
                                break;
                            case decimal n when n <= 0.5m:
                                {
                                    lblPrice.Text = "Pricy";
                                };
                                break;
                            case decimal n when n <= 0.3m:
                                {
                                    lblPrice.Text = "Cheap";
                                };
                                break;
                            case decimal n when n == 0.0m:
                                {
                                    lblPrice.Text = "Free";
                                };
                                break;
                        }

                        // Same switch idea here, since Accessibility is a range - 1 being most difficult and 0 being a breeze.
                        switch (currentActivity.Accessibility)
                        {
                            case decimal n when n >= 1.0m:
                                {
                                    lblAccessible.Text = "Difficult";
                                };
                                break;
                            case decimal n when n <= 0.5m:
                                {
                                    lblAccessible.Text = "Challenging";
                                };
                                break;
                            case decimal n when n == 0.0m:
                                {
                                    lblAccessible.Text = "Easy";
                                };
                                break;
                        }

                        // If the Link string is not empty, we have a link - and therefore we set the label as visible and enabled.
                        if (currentActivity.Link != "")
                        {
                            lblLink.Visible = true;
                            lblLink.Enabled = true;
                        }

                        // Here we set how many people are expected to do this Activity.
                        lblPeople.Text = currentActivity.Participants.ToString();

                    }
                }
                catch (Exception err)
                {
                    // If some data returned all jumbled up - This cannot be fixed, so we just tell the user.
                    Debug.WriteLine($"Unexpected response from API request worker: {e.Result} causing error {err}");
                    MessageBox.Show($"Unexpected data returned from API request", "Error");
                }
            }
        }

        // Close button method, self-explanitory - Closes the application.
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Activity saving method, takes in the provided Activity and adds it to the saved list and to the list label. 
        private void addActivity(BoredResponse Activity)
        {
            if (Activity != null)
            {
            // Add to the list.
            SavedActivities.Add(Activity);
            // Clear the list label and readd everything.
            lstSaved.Items.Clear();
            // Loop through each activity we've saved and add their shortened Activities.
            SavedActivities.ForEach(activity => { lstSaved.Items.Add(activity.shortActivity()); });

            }
        }

        // Save Activity button method, checks if the current activity is the same as one previously saved elsewises runs the addActivity method.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Go through all the activities, if it exists - We let the user know.
            if (SavedActivities.Exists(activity => activity.Activity == currentActivity.Activity))
            {
                MessageBox.Show("Activity is already saved!", "Saving Error");
            }
            else
            // Else we actually add the activity.
            {
                addActivity(currentActivity);
            }
        }

        // Link clicking function, lets the user view the link of the activity their currently viewing.
        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // The class has the method to open the default browser and show the activities link.
            currentActivity.showLink();
        }

        // Saved List button method, opens the SavedActivityViewer form as a Dialog - So the user has to close it before requesting more activities.
        private void btnList_Click(object sender, EventArgs e)
        {
            // If there are no saved activities - There's no reason to open the form, we'll inform the user.
            if (SavedActivities.Count == 0)
            {
                MessageBox.Show("There is no saved Activities to view.", "Missing Activities");
            }
            else
            // Elsewise we create the form.
            {
                // Create the form.
                savedActivityForm frmSavedActivities = new savedActivityForm();
                // Set the tag as the saved activities list.
                frmSavedActivities.Tag = SavedActivities;
                // Show the form as a new window.
                frmSavedActivities.ShowDialog();
            }        
        }

    }
}
