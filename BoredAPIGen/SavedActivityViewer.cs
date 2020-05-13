using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoredAPIGen
{
    public partial class savedActivityForm : Form
    {
        BoredResponse currentActivity;
        int currentIndex = 0;
        List<BoredResponse> Activities;

        public savedActivityForm()
        {
            InitializeComponent();
        }

        private void savedActivityForm_Load(object sender, EventArgs e)
        {
            if (Tag is List<BoredResponse>)
            {
                Activities = Tag as List<BoredResponse>;
                updateView(currentIndex);
            }
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentActivity.showLink();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < Activities.Count - 1)
            {
                currentIndex++;
                updateView(currentIndex);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentIndex != 0)
            {
                currentIndex--;
                updateView(currentIndex);
            }
        }

        private void updateView(int Index)
        {
            BoredResponse activity = Activities[Index];
            currentActivity = activity;

            lblActivity.Text = activity.Activity;
            lblType.Text = activity.Type.Remove(1).ToUpper() + activity.Type.Substring(1);
            lblPeople.Text = activity.Participants.ToString();

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

            if (activity.Link != "")
            {
                lblLink.Visible = true;
                lblLink.Enabled = true;
            } else
            {
                lblLink.Visible = false;
                lblLink.Enabled = false;
            }

            lblCount.Text = $"Activity {currentIndex + 1} of {Activities.Count}";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (Activities.Count != 0)
            {
                DialogResult Verify = MessageBox.Show("Are you sure you want to remove this Activity?", "Confirming Action", MessageBoxButtons.YesNo);

                if (Verify == DialogResult.Yes)
                {
                    Activities.RemoveAt(currentIndex);
                }
            }
        }
    }
}
