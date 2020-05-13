namespace BoredAPIGen
{
    partial class GeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorForm));
            this.cbxActivities = new System.Windows.Forms.ComboBox();
            this.trbPrice = new System.Windows.Forms.TrackBar();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.backgroundAPIWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trbDifficulty = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupActivity = new System.Windows.Forms.GroupBox();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblAccessible = new System.Windows.Forms.Label();
            this.lblPeople = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstSaved = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbPrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDifficulty)).BeginInit();
            this.groupActivity.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.cbxActivities.Location = new System.Drawing.Point(52, 54);
            this.cbxActivities.Name = "cbxActivities";
            this.cbxActivities.Size = new System.Drawing.Size(167, 24);
            this.cbxActivities.TabIndex = 2;
            // 
            // trbPrice
            // 
            this.trbPrice.Location = new System.Drawing.Point(361, 31);
            this.trbPrice.Name = "trbPrice";
            this.trbPrice.Size = new System.Drawing.Size(131, 56);
            this.trbPrice.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(593, 20);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 34);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // backgroundAPIWorker
            // 
            this.backgroundAPIWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundAPIWorker_DoWork);
            this.backgroundAPIWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundAPIWorker_RunWorkerCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.trbDifficulty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxActivities);
            this.groupBox1.Controls.Add(this.trbPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 123);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(497, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Hard";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(323, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Easy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(497, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Expensive";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Free";
            // 
            // trbDifficulty
            // 
            this.trbDifficulty.Location = new System.Drawing.Point(360, 73);
            this.trbDifficulty.Name = "trbDifficulty";
            this.trbDifficulty.Size = new System.Drawing.Size(131, 56);
            this.trbDifficulty.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Accessibility:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(593, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Activity";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupActivity
            // 
            this.groupActivity.Controls.Add(this.lblLink);
            this.groupActivity.Controls.Add(this.groupBox4);
            this.groupActivity.Controls.Add(this.lblAccessible);
            this.groupActivity.Controls.Add(this.lblPeople);
            this.groupActivity.Controls.Add(this.lblPrice);
            this.groupActivity.Controls.Add(this.lblType);
            this.groupActivity.Controls.Add(this.label8);
            this.groupActivity.Controls.Add(this.label7);
            this.groupActivity.Controls.Add(this.label6);
            this.groupActivity.Controls.Add(this.label5);
            this.groupActivity.Location = new System.Drawing.Point(12, 141);
            this.groupActivity.Name = "groupActivity";
            this.groupActivity.Size = new System.Drawing.Size(258, 255);
            this.groupActivity.TabIndex = 12;
            this.groupActivity.TabStop = false;
            this.groupActivity.Text = "Random Activity";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Enabled = false;
            this.lblLink.Location = new System.Drawing.Point(7, 112);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(82, 17);
            this.lblLink.TabIndex = 20;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Activity Link";
            this.lblLink.Visible = false;
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblActivity);
            this.groupBox4.Location = new System.Drawing.Point(6, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 116);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Activity";
            // 
            // lblActivity
            // 
            this.lblActivity.Location = new System.Drawing.Point(6, 18);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(234, 95);
            this.lblActivity.TabIndex = 20;
            this.lblActivity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAccessible
            // 
            this.lblAccessible.AutoSize = true;
            this.lblAccessible.Location = new System.Drawing.Point(92, 90);
            this.lblAccessible.Name = "lblAccessible";
            this.lblAccessible.Size = new System.Drawing.Size(0, 17);
            this.lblAccessible.TabIndex = 19;
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Location = new System.Drawing.Point(93, 66);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(16, 17);
            this.lblPeople.TabIndex = 18;
            this.lblPeople.Text = "0";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(49, 42);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 17);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Free";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(46, 18);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 17);
            this.lblType.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Accessibility:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Participants:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Type:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstSaved);
            this.groupBox3.Location = new System.Drawing.Point(330, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 255);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saved Activities";
            // 
            // lstSaved
            // 
            this.lstSaved.FormattingEnabled = true;
            this.lstSaved.ItemHeight = 16;
            this.lstSaved.Location = new System.Drawing.Point(6, 21);
            this.lstSaved.Name = "lstSaved";
            this.lstSaved.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstSaved.Size = new System.Drawing.Size(245, 228);
            this.lstSaved.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(593, 362);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 34);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(593, 100);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(104, 34);
            this.btnList.TabIndex = 14;
            this.btnList.Text = "View List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 402);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupActivity);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneratorForm";
            this.Text = "Random Activity Generator";
            ((System.ComponentModel.ISupportInitialize)(this.trbPrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDifficulty)).EndInit();
            this.groupActivity.ResumeLayout(false);
            this.groupActivity.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxActivities;
        private System.Windows.Forms.TrackBar trbPrice;
        private System.Windows.Forms.Button btnSubmit;
        private System.ComponentModel.BackgroundWorker backgroundAPIWorker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trbDifficulty;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupActivity;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblAccessible;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstSaved;
        private System.Windows.Forms.LinkLabel lblLink;
    }
}

