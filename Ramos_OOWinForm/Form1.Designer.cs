namespace Week4_BookClassinWindows
{
    partial class userForm
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
            this.lblFName = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtAddLine2 = new System.Windows.Forms.TextBox();
            this.lblAddLine2 = new System.Windows.Forms.Label();
            this.txtAddLine1 = new System.Windows.Forms.TextBox();
            this.lblAddLine1 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnClrScrn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFName.Location = new System.Drawing.Point(51, 35);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name:";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Location = new System.Drawing.Point(39, 65);
            this.lblMName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(72, 13);
            this.lblMName.TabIndex = 1;
            this.lblMName.Text = "Middle Name:";
            this.lblMName.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 6;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(385, 356);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 13);
            this.lblFeedback.TabIndex = 7;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(115, 32);
            this.txtFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(212, 20);
            this.txtFName.TabIndex = 8;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(115, 62);
            this.txtMName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(212, 20);
            this.txtMName.TabIndex = 9;
            this.txtMName.TextChanged += new System.EventHandler(this.txtAuthorFirst_TextChanged);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(115, 93);
            this.txtLName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(212, 20);
            this.txtLName.TabIndex = 11;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(50, 96);
            this.lblLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 10;
            this.lblLName.Text = "Last Name:";
            // 
            // txtAddLine2
            // 
            this.txtAddLine2.Location = new System.Drawing.Point(493, 63);
            this.txtAddLine2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddLine2.Name = "txtAddLine2";
            this.txtAddLine2.Size = new System.Drawing.Size(212, 20);
            this.txtAddLine2.TabIndex = 15;
            this.txtAddLine2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAddLine2
            // 
            this.lblAddLine2.AutoSize = true;
            this.lblAddLine2.Location = new System.Drawing.Point(409, 66);
            this.lblAddLine2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddLine2.Name = "lblAddLine2";
            this.lblAddLine2.Size = new System.Drawing.Size(80, 13);
            this.lblAddLine2.TabIndex = 14;
            this.lblAddLine2.Text = "Address Line 2:";
            this.lblAddLine2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAddLine1
            // 
            this.txtAddLine1.Location = new System.Drawing.Point(493, 32);
            this.txtAddLine1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddLine1.Name = "txtAddLine1";
            this.txtAddLine1.Size = new System.Drawing.Size(212, 20);
            this.txtAddLine1.TabIndex = 13;
            this.txtAddLine1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblAddLine1
            // 
            this.lblAddLine1.AutoSize = true;
            this.lblAddLine1.Location = new System.Drawing.Point(409, 35);
            this.lblAddLine1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddLine1.Name = "lblAddLine1";
            this.lblAddLine1.Size = new System.Drawing.Size(80, 13);
            this.lblAddLine1.TabIndex = 12;
            this.lblAddLine1.Text = "Address Line 1:";
            this.lblAddLine1.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(493, 127);
            this.txtState.Margin = new System.Windows.Forms.Padding(2);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(212, 20);
            this.txtState.TabIndex = 19;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(454, 130);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 18;
            this.lblState.Text = "State:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(493, 96);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(212, 20);
            this.txtCity.TabIndex = 17;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(462, 99);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "City:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 154);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(76, 157);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(115, 123);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(212, 20);
            this.txtPhone.TabIndex = 21;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(60, 126);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(51, 13);
            this.lblPhone.TabIndex = 20;
            this.lblPhone.Text = "Phone #:";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(493, 157);
            this.txtZip.Margin = new System.Windows.Forms.Padding(2);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(212, 20);
            this.txtZip.TabIndex = 25;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(436, 161);
            this.lblZip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(53, 13);
            this.lblZip.TabIndex = 24;
            this.lblZip.Text = "Zip Code:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(12, 282);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 46);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit Response";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResultTitle.Location = new System.Drawing.Point(340, 196);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(45, 13);
            this.lblResultTitle.TabIndex = 27;
            this.lblResultTitle.Text = "Results:";
            this.lblResultTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResults.Location = new System.Drawing.Point(408, 196);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(27, 13);
            this.lblResults.TabIndex = 28;
            this.lblResults.Text = "N/A";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClrScrn
            // 
            this.btnClrScrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClrScrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClrScrn.Location = new System.Drawing.Point(608, 282);
            this.btnClrScrn.Name = "btnClrScrn";
            this.btnClrScrn.Size = new System.Drawing.Size(145, 46);
            this.btnClrScrn.TabIndex = 29;
            this.btnClrScrn.Text = "Clear Screen";
            this.btnClrScrn.UseVisualStyleBackColor = true;
            this.btnClrScrn.Click += new System.EventHandler(this.btnClrScrn_Click);
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 402);
            this.Controls.Add(this.btnClrScrn);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblResultTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtAddLine2);
            this.Controls.Add(this.lblAddLine2);
            this.Controls.Add(this.txtAddLine1);
            this.Controls.Add(this.lblAddLine1);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMName);
            this.Controls.Add(this.lblFName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "userForm";
            this.Text = "User Data Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtAddLine2;
        private System.Windows.Forms.Label lblAddLine2;
        private System.Windows.Forms.TextBox txtAddLine1;
        private System.Windows.Forms.Label lblAddLine1;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnClrScrn;
    }
}

