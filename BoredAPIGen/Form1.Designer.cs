namespace BoredAPIGen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxActivities = new System.Windows.Forms.ComboBox();
            this.trbPrice = new System.Windows.Forms.TrackBar();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.backgroundAPIWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.trbPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxActivities
            // 
            this.cbxActivities.FormattingEnabled = true;
            this.cbxActivities.Items.AddRange(new object[] {
            "Education",
            "Recreational",
            "Social",
            "Diy",
            "Charity",
            "Cooking",
            "Relaxation",
            "Music",
            "Busywork"});
            this.cbxActivities.Location = new System.Drawing.Point(59, 58);
            this.cbxActivities.Name = "cbxActivities";
            this.cbxActivities.Size = new System.Drawing.Size(121, 24);
            this.cbxActivities.TabIndex = 2;
            // 
            // trbPrice
            // 
            this.trbPrice.Location = new System.Drawing.Point(59, 128);
            this.trbPrice.Name = "trbPrice";
            this.trbPrice.Size = new System.Drawing.Size(104, 56);
            this.trbPrice.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(59, 210);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 34);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "button1";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundAPIWorker
            // 
            this.backgroundAPIWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundAPIWorker_DoWork);
            this.backgroundAPIWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundAPIWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.trbPrice);
            this.Controls.Add(this.cbxActivities);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trbPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxActivities;
        private System.Windows.Forms.TrackBar trbPrice;
        private System.Windows.Forms.Button btnSubmit;
        private System.ComponentModel.BackgroundWorker backgroundAPIWorker;
    }
}

