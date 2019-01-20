namespace BookBrokers
{
    partial class VendorForm
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
            this.lstVendors = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddVendor = new System.Windows.Forms.Button();
            this.btnUpdateVendor = new System.Windows.Forms.Button();
            this.btnDeleteVendor = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblPostBoxNumber = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtPostBoxNumber = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlAddVendor = new System.Windows.Forms.Panel();
            this.btnSaveVendor = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboAddCountryName = new System.Windows.Forms.ComboBox();
            this.cboAddCountryID = new System.Windows.Forms.ComboBox();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.txtAddPostBoxNumber = new System.Windows.Forms.TextBox();
            this.txtAddVendorName = new System.Windows.Forms.TextBox();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.lblAddPostBoxNumber = new System.Windows.Forms.Label();
            this.lblAddVendorName = new System.Windows.Forms.Label();
            this.pnlUpdateVendor = new System.Windows.Forms.Panel();
            this.cboUpdateCountryName = new System.Windows.Forms.ComboBox();
            this.cboUpdateCountryID = new System.Windows.Forms.ComboBox();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.txtUpdatePostBoxNumber = new System.Windows.Forms.TextBox();
            this.txtUpdateVendorName = new System.Windows.Forms.TextBox();
            this.txtUpdateVendorID = new System.Windows.Forms.TextBox();
            this.lblUpdateEmail = new System.Windows.Forms.Label();
            this.lblUpdateCountry = new System.Windows.Forms.Label();
            this.lblUpdatePostBoxNumber = new System.Windows.Forms.Label();
            this.lblUpdateVendorName = new System.Windows.Forms.Label();
            this.lblUpdateVendorID = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.lblCountryID = new System.Windows.Forms.Label();
            this.pnlAddVendor.SuspendLayout();
            this.pnlUpdateVendor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVendors
            // 
            this.lstVendors.FormattingEnabled = true;
            this.lstVendors.ItemHeight = 12;
            this.lstVendors.Location = new System.Drawing.Point(23, 28);
            this.lstVendors.Name = "lstVendors";
            this.lstVendors.Size = new System.Drawing.Size(294, 328);
            this.lstVendors.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(23, 372);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(140, 31);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(177, 372);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(140, 31);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.Location = new System.Drawing.Point(335, 372);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(140, 31);
            this.btnAddVendor.TabIndex = 3;
            this.btnAddVendor.Text = "Add Vendor";
            this.btnAddVendor.UseVisualStyleBackColor = true;
            this.btnAddVendor.Click += new System.EventHandler(this.btnAddVendor_Click);
            // 
            // btnUpdateVendor
            // 
            this.btnUpdateVendor.Location = new System.Drawing.Point(493, 372);
            this.btnUpdateVendor.Name = "btnUpdateVendor";
            this.btnUpdateVendor.Size = new System.Drawing.Size(140, 31);
            this.btnUpdateVendor.TabIndex = 4;
            this.btnUpdateVendor.Text = "Update Vendor";
            this.btnUpdateVendor.UseVisualStyleBackColor = true;
            this.btnUpdateVendor.Click += new System.EventHandler(this.btnUpdateVendor_Click);
            // 
            // btnDeleteVendor
            // 
            this.btnDeleteVendor.Location = new System.Drawing.Point(652, 372);
            this.btnDeleteVendor.Name = "btnDeleteVendor";
            this.btnDeleteVendor.Size = new System.Drawing.Size(140, 31);
            this.btnDeleteVendor.TabIndex = 5;
            this.btnDeleteVendor.Text = "Delete Vendor";
            this.btnDeleteVendor.UseVisualStyleBackColor = true;
            this.btnDeleteVendor.Click += new System.EventHandler(this.btnDeleteVendor_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(652, 424);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(140, 31);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Location = new System.Drawing.Point(369, 52);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(65, 12);
            this.lblVendorID.TabIndex = 7;
            this.lblVendorID.Text = "Vendor ID:";
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(357, 100);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(77, 12);
            this.lblVendorName.TabIndex = 8;
            this.lblVendorName.Text = "Vendor Name:";
            // 
            // lblPostBoxNumber
            // 
            this.lblPostBoxNumber.AutoSize = true;
            this.lblPostBoxNumber.Location = new System.Drawing.Point(333, 150);
            this.lblPostBoxNumber.Name = "lblPostBoxNumber";
            this.lblPostBoxNumber.Size = new System.Drawing.Size(101, 12);
            this.lblPostBoxNumber.TabIndex = 9;
            this.lblPostBoxNumber.Text = "Post Box Number:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(381, 197);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(53, 12);
            this.lblCountry.TabIndex = 10;
            this.lblCountry.Text = "Country:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(393, 244);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 12);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(440, 49);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(88, 21);
            this.txtVendorID.TabIndex = 12;
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(440, 97);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(177, 21);
            this.txtVendorName.TabIndex = 13;
            // 
            // txtPostBoxNumber
            // 
            this.txtPostBoxNumber.Location = new System.Drawing.Point(440, 147);
            this.txtPostBoxNumber.Name = "txtPostBoxNumber";
            this.txtPostBoxNumber.Size = new System.Drawing.Size(88, 21);
            this.txtPostBoxNumber.TabIndex = 14;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(440, 194);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(121, 21);
            this.txtCountry.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(440, 241);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 21);
            this.txtEmail.TabIndex = 16;
            // 
            // pnlAddVendor
            // 
            this.pnlAddVendor.Controls.Add(this.btnSaveVendor);
            this.pnlAddVendor.Controls.Add(this.btnCancel);
            this.pnlAddVendor.Controls.Add(this.cboAddCountryName);
            this.pnlAddVendor.Controls.Add(this.cboAddCountryID);
            this.pnlAddVendor.Controls.Add(this.txtAddEmail);
            this.pnlAddVendor.Controls.Add(this.txtAddPostBoxNumber);
            this.pnlAddVendor.Controls.Add(this.txtAddVendorName);
            this.pnlAddVendor.Controls.Add(this.lblAddEmail);
            this.pnlAddVendor.Controls.Add(this.lblAddCountry);
            this.pnlAddVendor.Controls.Add(this.lblAddPostBoxNumber);
            this.pnlAddVendor.Controls.Add(this.lblAddVendorName);
            this.pnlAddVendor.Location = new System.Drawing.Point(652, 28);
            this.pnlAddVendor.Name = "pnlAddVendor";
            this.pnlAddVendor.Size = new System.Drawing.Size(457, 328);
            this.pnlAddVendor.TabIndex = 17;
            this.pnlAddVendor.Visible = false;
            // 
            // btnSaveVendor
            // 
            this.btnSaveVendor.Location = new System.Drawing.Point(36, 266);
            this.btnSaveVendor.Name = "btnSaveVendor";
            this.btnSaveVendor.Size = new System.Drawing.Size(140, 31);
            this.btnSaveVendor.TabIndex = 18;
            this.btnSaveVendor.Text = "Save Vendor";
            this.btnSaveVendor.UseVisualStyleBackColor = true;
            this.btnSaveVendor.Click += new System.EventHandler(this.btnSaveVendor_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 31);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboAddCountryName
            // 
            this.cboAddCountryName.FormattingEnabled = true;
            this.cboAddCountryName.Location = new System.Drawing.Point(184, 166);
            this.cboAddCountryName.Name = "cboAddCountryName";
            this.cboAddCountryName.Size = new System.Drawing.Size(115, 20);
            this.cboAddCountryName.TabIndex = 26;
            // 
            // cboAddCountryID
            // 
            this.cboAddCountryID.FormattingEnabled = true;
            this.cboAddCountryID.Location = new System.Drawing.Point(122, 166);
            this.cboAddCountryID.Name = "cboAddCountryID";
            this.cboAddCountryID.Size = new System.Drawing.Size(56, 20);
            this.cboAddCountryID.TabIndex = 25;
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(122, 213);
            this.txtAddEmail.MaxLength = 30;
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(177, 21);
            this.txtAddEmail.TabIndex = 24;
            // 
            // txtAddPostBoxNumber
            // 
            this.txtAddPostBoxNumber.Location = new System.Drawing.Point(122, 119);
            this.txtAddPostBoxNumber.MaxLength = 15;
            this.txtAddPostBoxNumber.Name = "txtAddPostBoxNumber";
            this.txtAddPostBoxNumber.Size = new System.Drawing.Size(88, 21);
            this.txtAddPostBoxNumber.TabIndex = 22;
            // 
            // txtAddVendorName
            // 
            this.txtAddVendorName.Location = new System.Drawing.Point(122, 69);
            this.txtAddVendorName.MaxLength = 30;
            this.txtAddVendorName.Name = "txtAddVendorName";
            this.txtAddVendorName.Size = new System.Drawing.Size(177, 21);
            this.txtAddVendorName.TabIndex = 21;
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Location = new System.Drawing.Point(75, 216);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(41, 12);
            this.lblAddEmail.TabIndex = 20;
            this.lblAddEmail.Text = "Email:";
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.Location = new System.Drawing.Point(63, 169);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(53, 12);
            this.lblAddCountry.TabIndex = 19;
            this.lblAddCountry.Text = "Country:";
            // 
            // lblAddPostBoxNumber
            // 
            this.lblAddPostBoxNumber.AutoSize = true;
            this.lblAddPostBoxNumber.Location = new System.Drawing.Point(15, 122);
            this.lblAddPostBoxNumber.Name = "lblAddPostBoxNumber";
            this.lblAddPostBoxNumber.Size = new System.Drawing.Size(101, 12);
            this.lblAddPostBoxNumber.TabIndex = 18;
            this.lblAddPostBoxNumber.Text = "Post Box Number:";
            // 
            // lblAddVendorName
            // 
            this.lblAddVendorName.AutoSize = true;
            this.lblAddVendorName.Location = new System.Drawing.Point(39, 72);
            this.lblAddVendorName.Name = "lblAddVendorName";
            this.lblAddVendorName.Size = new System.Drawing.Size(77, 12);
            this.lblAddVendorName.TabIndex = 17;
            this.lblAddVendorName.Text = "Vendor Name:";
            // 
            // pnlUpdateVendor
            // 
            this.pnlUpdateVendor.Controls.Add(this.cboUpdateCountryName);
            this.pnlUpdateVendor.Controls.Add(this.cboUpdateCountryID);
            this.pnlUpdateVendor.Controls.Add(this.txtUpdateEmail);
            this.pnlUpdateVendor.Controls.Add(this.txtUpdatePostBoxNumber);
            this.pnlUpdateVendor.Controls.Add(this.txtUpdateVendorName);
            this.pnlUpdateVendor.Controls.Add(this.txtUpdateVendorID);
            this.pnlUpdateVendor.Controls.Add(this.lblUpdateEmail);
            this.pnlUpdateVendor.Controls.Add(this.lblUpdateCountry);
            this.pnlUpdateVendor.Controls.Add(this.lblUpdatePostBoxNumber);
            this.pnlUpdateVendor.Controls.Add(this.lblUpdateVendorName);
            this.pnlUpdateVendor.Controls.Add(this.lblUpdateVendorID);
            this.pnlUpdateVendor.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateVendor.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateVendor.Location = new System.Drawing.Point(23, 424);
            this.pnlUpdateVendor.Name = "pnlUpdateVendor";
            this.pnlUpdateVendor.Size = new System.Drawing.Size(457, 328);
            this.pnlUpdateVendor.TabIndex = 18;
            this.pnlUpdateVendor.Visible = false;
            // 
            // cboUpdateCountryName
            // 
            this.cboUpdateCountryName.FormattingEnabled = true;
            this.cboUpdateCountryName.Location = new System.Drawing.Point(167, 166);
            this.cboUpdateCountryName.Name = "cboUpdateCountryName";
            this.cboUpdateCountryName.Size = new System.Drawing.Size(115, 20);
            this.cboUpdateCountryName.TabIndex = 31;
            // 
            // cboUpdateCountryID
            // 
            this.cboUpdateCountryID.FormattingEnabled = true;
            this.cboUpdateCountryID.Location = new System.Drawing.Point(105, 166);
            this.cboUpdateCountryID.Name = "cboUpdateCountryID";
            this.cboUpdateCountryID.Size = new System.Drawing.Size(56, 20);
            this.cboUpdateCountryID.TabIndex = 30;
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(105, 213);
            this.txtUpdateEmail.MaxLength = 30;
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(177, 21);
            this.txtUpdateEmail.TabIndex = 29;
            // 
            // txtUpdatePostBoxNumber
            // 
            this.txtUpdatePostBoxNumber.Location = new System.Drawing.Point(105, 119);
            this.txtUpdatePostBoxNumber.MaxLength = 15;
            this.txtUpdatePostBoxNumber.Name = "txtUpdatePostBoxNumber";
            this.txtUpdatePostBoxNumber.Size = new System.Drawing.Size(88, 21);
            this.txtUpdatePostBoxNumber.TabIndex = 27;
            // 
            // txtUpdateVendorName
            // 
            this.txtUpdateVendorName.Location = new System.Drawing.Point(105, 69);
            this.txtUpdateVendorName.MaxLength = 30;
            this.txtUpdateVendorName.Name = "txtUpdateVendorName";
            this.txtUpdateVendorName.Size = new System.Drawing.Size(177, 21);
            this.txtUpdateVendorName.TabIndex = 26;
            // 
            // txtUpdateVendorID
            // 
            this.txtUpdateVendorID.Location = new System.Drawing.Point(105, 21);
            this.txtUpdateVendorID.Name = "txtUpdateVendorID";
            this.txtUpdateVendorID.Size = new System.Drawing.Size(88, 21);
            this.txtUpdateVendorID.TabIndex = 25;
            // 
            // lblUpdateEmail
            // 
            this.lblUpdateEmail.AutoSize = true;
            this.lblUpdateEmail.Location = new System.Drawing.Point(58, 216);
            this.lblUpdateEmail.Name = "lblUpdateEmail";
            this.lblUpdateEmail.Size = new System.Drawing.Size(41, 12);
            this.lblUpdateEmail.TabIndex = 24;
            this.lblUpdateEmail.Text = "Email:";
            // 
            // lblUpdateCountry
            // 
            this.lblUpdateCountry.AutoSize = true;
            this.lblUpdateCountry.Location = new System.Drawing.Point(46, 169);
            this.lblUpdateCountry.Name = "lblUpdateCountry";
            this.lblUpdateCountry.Size = new System.Drawing.Size(53, 12);
            this.lblUpdateCountry.TabIndex = 23;
            this.lblUpdateCountry.Text = "Country:";
            // 
            // lblUpdatePostBoxNumber
            // 
            this.lblUpdatePostBoxNumber.AutoSize = true;
            this.lblUpdatePostBoxNumber.Location = new System.Drawing.Point(-2, 122);
            this.lblUpdatePostBoxNumber.Name = "lblUpdatePostBoxNumber";
            this.lblUpdatePostBoxNumber.Size = new System.Drawing.Size(101, 12);
            this.lblUpdatePostBoxNumber.TabIndex = 22;
            this.lblUpdatePostBoxNumber.Text = "Post Box Number:";
            // 
            // lblUpdateVendorName
            // 
            this.lblUpdateVendorName.AutoSize = true;
            this.lblUpdateVendorName.Location = new System.Drawing.Point(22, 72);
            this.lblUpdateVendorName.Name = "lblUpdateVendorName";
            this.lblUpdateVendorName.Size = new System.Drawing.Size(77, 12);
            this.lblUpdateVendorName.TabIndex = 21;
            this.lblUpdateVendorName.Text = "Vendor Name:";
            // 
            // lblUpdateVendorID
            // 
            this.lblUpdateVendorID.AutoSize = true;
            this.lblUpdateVendorID.Location = new System.Drawing.Point(34, 24);
            this.lblUpdateVendorID.Name = "lblUpdateVendorID";
            this.lblUpdateVendorID.Size = new System.Drawing.Size(65, 12);
            this.lblUpdateVendorID.TabIndex = 20;
            this.lblUpdateVendorID.Text = "Vendor ID:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(36, 266);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(140, 31);
            this.btnSaveChanges.TabIndex = 18;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(290, 266);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(140, 31);
            this.btnUpdateCancel.TabIndex = 19;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // lblCountryID
            // 
            this.lblCountryID.AutoSize = true;
            this.lblCountryID.Location = new System.Drawing.Point(463, 197);
            this.lblCountryID.Name = "lblCountryID";
            this.lblCountryID.Size = new System.Drawing.Size(65, 12);
            this.lblCountryID.TabIndex = 19;
            this.lblCountryID.Text = "CountryID:";
            this.lblCountryID.TextChanged += new System.EventHandler(this.lblCountryID_TextChanged);
            // 
            // VendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 477);
            this.Controls.Add(this.pnlUpdateVendor);
            this.Controls.Add(this.pnlAddVendor);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtPostBoxNumber);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblPostBoxNumber);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.lblVendorID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteVendor);
            this.Controls.Add(this.btnUpdateVendor);
            this.Controls.Add(this.btnAddVendor);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstVendors);
            this.Controls.Add(this.lblCountryID);
            this.Name = "VendorForm";
            this.Text = "Vendor Maintenance";
            this.pnlAddVendor.ResumeLayout(false);
            this.pnlAddVendor.PerformLayout();
            this.pnlUpdateVendor.ResumeLayout(false);
            this.pnlUpdateVendor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVendors;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddVendor;
        private System.Windows.Forms.Button btnUpdateVendor;
        private System.Windows.Forms.Button btnDeleteVendor;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblPostBoxNumber;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.TextBox txtPostBoxNumber;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlAddVendor;
        private System.Windows.Forms.Button btnSaveVendor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboAddCountryName;
        private System.Windows.Forms.ComboBox cboAddCountryID;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddPostBoxNumber;
        private System.Windows.Forms.TextBox txtAddVendorName;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.Label lblAddCountry;
        private System.Windows.Forms.Label lblAddPostBoxNumber;
        private System.Windows.Forms.Label lblAddVendorName;
        private System.Windows.Forms.Panel pnlUpdateVendor;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.TextBox txtUpdatePostBoxNumber;
        private System.Windows.Forms.TextBox txtUpdateVendorName;
        private System.Windows.Forms.TextBox txtUpdateVendorID;
        private System.Windows.Forms.Label lblUpdateEmail;
        private System.Windows.Forms.Label lblUpdateCountry;
        private System.Windows.Forms.Label lblUpdatePostBoxNumber;
        private System.Windows.Forms.Label lblUpdateVendorName;
        private System.Windows.Forms.Label lblUpdateVendorID;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Label lblCountryID;
        private System.Windows.Forms.ComboBox cboUpdateCountryName;
        private System.Windows.Forms.ComboBox cboUpdateCountryID;
    }
}