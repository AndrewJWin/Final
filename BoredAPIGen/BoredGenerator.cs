﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoredAPIGen
{
    public partial class GeneratorForm : Form
    {

        BoredResponse currentActivity;
        List<BoredResponse> SavedActivities = new List<BoredResponse>();

        public GeneratorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> Options = new List<string>();

            Options.Add(cbxActivities.SelectedItem.ToString().ToLower());
            Options.Add((trbPrice.Value / 10).ToString());
            RequestAPI(Options);
        }

        private void RequestAPI(List<string> Options)
        {
            if (backgroundAPIWorker.IsBusy == false)
            {
                backgroundAPIWorker.RunWorkerAsync(Options);
            }
            else   // A request is already in progress, ask user to wait.
            {
                MessageBox.Show("Please wait for previous request to complete.");
            }
        }

        private void backgroundAPIWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // If the argument is a List, we will forward it as List options.
            if (e.Argument is List<string> options)
            {
                BoredResponse apiResponse = BoredAPI.FetchAPI(out string error, options);  // Make the request!
                e.Result = (reponse: apiResponse, error);   // A tuple https://docs.microsoft.com/en-us/dotnet/csharp/tuples
                Debug.WriteLine(e.Result);
            }
            else
            {
                Debug.WriteLine("Background worker error - argument not a List" + e.Argument);
                throw new Exception("Incorrect Argument type, must be a List");
            }
        }

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
                    currentActivity = response;
                    lblActivity.Text = currentActivity.Activity.ToString();
                    lblType.Text = currentActivity.Type.ToString();


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

                    lblPeople.Text = currentActivity.Participants.ToString();
                }
                catch (Exception err)
                {
                    // These are probably issues with the program that a user can't reasonable fix.
                    Debug.WriteLine($"Unexpected response from API request worker: {e.Result} causing error {err}");
                    MessageBox.Show($"Unexpected data returned from API request", "Error");
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SavedActivities.Add(currentActivity);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trbPeople_Scroll(object sender, EventArgs e)
        {
            lblPeopleBar.Text = (trbPeople.Value / 10).ToString();
        }
    }
}