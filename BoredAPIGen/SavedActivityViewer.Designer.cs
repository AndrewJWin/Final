namespace BoredAPIGen
{
    partial class savedActivityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(savedActivityForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLink);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.lblAccessible);
            this.groupBox2.Controls.Add(this.lblPeople);
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.lblType);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 255);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Random Activity";
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(273, 53);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 34);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(345, 53);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(66, 34);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(273, 93);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 34);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(273, 24);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(136, 23);
            this.lblCount.TabIndex = 25;
            this.lblCount.Text = "Activity n of n";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // savedActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 270);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "savedActivityForm";
            this.Text = "Saved Activity Viewer";
            this.Load += new System.EventHandler(this.savedActivityForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lblLink;
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCount;
    }
}