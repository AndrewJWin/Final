using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
     * Secondary Viewing form, with user functionality to go through the list of activities saved.
     */
    public partial class savedActivityForm : Form
    {
        // Pre-initiazliation for variables being used throughout the form.
        BoredResponse currentActivity;
        // Index of the currently view activity.
        int currentIndex = 0;
        // List of all Activites saved.
        List<BoredResponse> Activities;

        public savedActivityForm()
        {
            InitializeComponent();
        }

        // Form loading function, verifies that the tag is in fact a list of activities.
        private void savedActivityForm_Load(object sender, EventArgs e)
        {
            if (Tag is List<BoredResponse>)
            {
                // Here we're setting the pre-initialized list of Activites to the one provided by the primary form.
                Activities = Tag as List<BoredResponse>;
                // And now we update the viewer.
                updateView(currentIndex);
            }
        }

        // Activity link clicking method, opens the link attached with the Activity.
        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   
            // Method function for utilizing Process.Open().
            currentActivity.showLink();
        }

        // Exit button method, self-explainitory - Closes this form.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Next button method, advances the current index and shows the activity for that index.
        private void btnNext_Click(object sender, EventArgs e)
        {
            // As long as we don't advance past the availible activites, we can show the user the next activity.
            if (currentIndex < Activities.Count - 1)
            {
                currentIndex++;
                updateView(currentIndex);
            }
        }

        // Back button method, subtracts the current index and shows the previous activity for that index.
        private void btnBack_Click(object sender, EventArgs e)
        {
            // As long as we don't go into negative, we'll go to the previous index.
            if (currentIndex != 0)
            {
                currentIndex--;
                updateView(currentIndex);
            }
        }

        // Activity view update method, takes an integer index and shows updates the model for that specific activity.
        private void updateView(int Index)
        {
            // Get that specific activity for the index.
            BoredResponse activity = Activities[Index];
            // Set the current activity.
            currentActivity = activity;

            // And set all the items to their respective values.
            lblActivity.Text = activity.Activity;
            lblType.Text = activity.Type.Remove(1).ToUpper() + activity.Type.Substring(1);
            lblPeople.Text = activity.Participants.ToString();

            // Switch casing for Price range, with 1 being the most expensive and 0 being essentially free.
            switch (activity.Price)
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

            // Switch casing for Accessibility, a range with 1 being the most difficult and 0 being easy to accomplish.
            switch (activity.Accessibility)
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

            // Setting the link label enabled or disabled depending on wether or not the Activity has a link attached.
            if (activity.Link != "")
            {
                lblLink.Visible = true;
                lblLink.Enabled = true;
            } else
            {
                lblLink.Visible = false;
                lblLink.Enabled = false;
            }

            // Settting the text for the current activity index of however many activites we have.
            lblCount.Text = $"Activity {currentIndex + 1} of {Activities.Count}";
        }
    }
}
