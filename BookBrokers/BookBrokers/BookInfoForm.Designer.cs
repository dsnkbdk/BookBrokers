namespace BookBrokers
{
    partial class BookInfoForm
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
            this.txtAuthorFirstName = new System.Windows.Forms.TextBox();
            this.lblAuthorFirstName = new System.Windows.Forms.Label();
            this.txtAuthorLastName = new System.Windows.Forms.TextBox();
            this.lblAuthorLastName = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.txtBookInfoID = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.lblBookInfoID = new System.Windows.Forms.Label();
            this.lstBookTitles = new System.Windows.Forms.ListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteBookInfo = new System.Windows.Forms.Button();
            this.btnUpdateBookInfo = new System.Windows.Forms.Button();
            this.btnAddBookInfo = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pnlAddBookInfo = new System.Windows.Forms.Panel();
            this.btnSaveBookInfo = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.cboAddAuthorFirstName = new System.Windows.Forms.ComboBox();
            this.cboAddAuthorLastName = new System.Windows.Forms.ComboBox();
            this.cboAddAuthorID = new System.Windows.Forms.ComboBox();
            this.lblAddAuthor = new System.Windows.Forms.Label();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.txtAddNotes = new System.Windows.Forms.TextBox();
            this.lblAddNotes = new System.Windows.Forms.Label();
            this.pnlUpdateBookInfo = new System.Windows.Forms.Panel();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.txtUpdateAuthorFirstName = new System.Windows.Forms.TextBox();
            this.lblUpdateAuthorFirstName = new System.Windows.Forms.Label();
            this.txtUpdateAuthorLastName = new System.Windows.Forms.TextBox();
            this.lblUpdateAuthorLastName = new System.Windows.Forms.Label();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.txtUpdateNotes = new System.Windows.Forms.TextBox();
            this.txtUpdateAuthorID = new System.Windows.Forms.TextBox();
            this.txtUpdateBookInfoID = new System.Windows.Forms.TextBox();
            this.lblUpdateNotes = new System.Windows.Forms.Label();
            this.lblUpdateAuthorID = new System.Windows.Forms.Label();
            this.lblUpdateBookInfoID = new System.Windows.Forms.Label();
            this.pnlAddBookInfo.SuspendLayout();
            this.pnlUpdateBookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAuthorFirstName
            // 
            this.txtAuthorFirstName.Location = new System.Drawing.Point(358, 183);
            this.txtAuthorFirstName.Name = "txtAuthorFirstName";
            this.txtAuthorFirstName.Size = new System.Drawing.Size(156, 21);
            this.txtAuthorFirstName.TabIndex = 76;
            // 
            // lblAuthorFirstName
            // 
            this.lblAuthorFirstName.AutoSize = true;
            this.lblAuthorFirstName.Location = new System.Drawing.Point(239, 186);
            this.lblAuthorFirstName.Name = "lblAuthorFirstName";
            this.lblAuthorFirstName.Size = new System.Drawing.Size(113, 12);
            this.lblAuthorFirstName.TabIndex = 75;
            this.lblAuthorFirstName.Text = "Author First Name:";
            // 
            // txtAuthorLastName
            // 
            this.txtAuthorLastName.Location = new System.Drawing.Point(358, 143);
            this.txtAuthorLastName.Name = "txtAuthorLastName";
            this.txtAuthorLastName.Size = new System.Drawing.Size(156, 21);
            this.txtAuthorLastName.TabIndex = 74;
            // 
            // lblAuthorLastName
            // 
            this.lblAuthorLastName.AutoSize = true;
            this.lblAuthorLastName.Location = new System.Drawing.Point(245, 146);
            this.lblAuthorLastName.Name = "lblAuthorLastName";
            this.lblAuthorLastName.Size = new System.Drawing.Size(107, 12);
            this.lblAuthorLastName.TabIndex = 73;
            this.lblAuthorLastName.Text = "Author Last Name:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(358, 63);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(390, 21);
            this.txtTitle.TabIndex = 72;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(311, 66);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 12);
            this.lblTitle.TabIndex = 71;
            this.lblTitle.Text = "Title:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(358, 221);
            this.txtNotes.MinimumSize = new System.Drawing.Size(298, 50);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(390, 71);
            this.txtNotes.TabIndex = 70;
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Location = new System.Drawing.Point(358, 102);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(65, 21);
            this.txtAuthorID.TabIndex = 69;
            this.txtAuthorID.TextChanged += new System.EventHandler(this.txtAuthorID_TextChanged);
            // 
            // txtBookInfoID
            // 
            this.txtBookInfoID.Location = new System.Drawing.Point(358, 26);
            this.txtBookInfoID.Name = "txtBookInfoID";
            this.txtBookInfoID.Size = new System.Drawing.Size(65, 21);
            this.txtBookInfoID.TabIndex = 68;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(311, 224);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(41, 12);
            this.lblNotes.TabIndex = 67;
            this.lblNotes.Text = "Notes:";
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Location = new System.Drawing.Point(287, 105);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(65, 12);
            this.lblAuthorID.TabIndex = 66;
            this.lblAuthorID.Text = "Author ID:";
            // 
            // lblBookInfoID
            // 
            this.lblBookInfoID.AutoSize = true;
            this.lblBookInfoID.Location = new System.Drawing.Point(269, 29);
            this.lblBookInfoID.Name = "lblBookInfoID";
            this.lblBookInfoID.Size = new System.Drawing.Size(83, 12);
            this.lblBookInfoID.TabIndex = 65;
            this.lblBookInfoID.Text = "Book Info ID:";
            // 
            // lstBookTitles
            // 
            this.lstBookTitles.FormattingEnabled = true;
            this.lstBookTitles.ItemHeight = 12;
            this.lstBookTitles.Location = new System.Drawing.Point(12, 12);
            this.lstBookTitles.Name = "lstBookTitles";
            this.lstBookTitles.Size = new System.Drawing.Size(221, 280);
            this.lstBookTitles.TabIndex = 64;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(641, 360);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(140, 31);
            this.btnReturn.TabIndex = 82;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteBookInfo
            // 
            this.btnDeleteBookInfo.Location = new System.Drawing.Point(641, 308);
            this.btnDeleteBookInfo.Name = "btnDeleteBookInfo";
            this.btnDeleteBookInfo.Size = new System.Drawing.Size(140, 31);
            this.btnDeleteBookInfo.TabIndex = 81;
            this.btnDeleteBookInfo.Text = "Delete Book Info";
            this.btnDeleteBookInfo.UseVisualStyleBackColor = true;
            this.btnDeleteBookInfo.Click += new System.EventHandler(this.btnDeleteBookInfo_Click);
            // 
            // btnUpdateBookInfo
            // 
            this.btnUpdateBookInfo.Location = new System.Drawing.Point(482, 308);
            this.btnUpdateBookInfo.Name = "btnUpdateBookInfo";
            this.btnUpdateBookInfo.Size = new System.Drawing.Size(140, 31);
            this.btnUpdateBookInfo.TabIndex = 80;
            this.btnUpdateBookInfo.Text = "Update Book Info";
            this.btnUpdateBookInfo.UseVisualStyleBackColor = true;
            this.btnUpdateBookInfo.Click += new System.EventHandler(this.btnUpdateBookInfo_Click);
            // 
            // btnAddBookInfo
            // 
            this.btnAddBookInfo.Location = new System.Drawing.Point(324, 308);
            this.btnAddBookInfo.Name = "btnAddBookInfo";
            this.btnAddBookInfo.Size = new System.Drawing.Size(140, 31);
            this.btnAddBookInfo.TabIndex = 79;
            this.btnAddBookInfo.Text = "Add Book Info";
            this.btnAddBookInfo.UseVisualStyleBackColor = true;
            this.btnAddBookInfo.Click += new System.EventHandler(this.btnAddBookInfo_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(166, 308);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(140, 31);
            this.btnNext.TabIndex = 78;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 308);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(140, 31);
            this.btnPrevious.TabIndex = 77;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // pnlAddBookInfo
            // 
            this.pnlAddBookInfo.Controls.Add(this.txtAddNotes);
            this.pnlAddBookInfo.Controls.Add(this.lblAddNotes);
            this.pnlAddBookInfo.Controls.Add(this.txtAddTitle);
            this.pnlAddBookInfo.Controls.Add(this.lblAddTitle);
            this.pnlAddBookInfo.Controls.Add(this.btnSaveBookInfo);
            this.pnlAddBookInfo.Controls.Add(this.btnAddCancel);
            this.pnlAddBookInfo.Controls.Add(this.cboAddAuthorFirstName);
            this.pnlAddBookInfo.Controls.Add(this.cboAddAuthorLastName);
            this.pnlAddBookInfo.Controls.Add(this.cboAddAuthorID);
            this.pnlAddBookInfo.Controls.Add(this.lblAddAuthor);
            this.pnlAddBookInfo.Location = new System.Drawing.Point(12, 345);
            this.pnlAddBookInfo.Name = "pnlAddBookInfo";
            this.pnlAddBookInfo.Size = new System.Drawing.Size(542, 280);
            this.pnlAddBookInfo.TabIndex = 83;
            this.pnlAddBookInfo.Visible = false;
            // 
            // btnSaveBookInfo
            // 
            this.btnSaveBookInfo.Location = new System.Drawing.Point(30, 193);
            this.btnSaveBookInfo.Name = "btnSaveBookInfo";
            this.btnSaveBookInfo.Size = new System.Drawing.Size(140, 31);
            this.btnSaveBookInfo.TabIndex = 20;
            this.btnSaveBookInfo.Text = "Save Book Info";
            this.btnSaveBookInfo.UseVisualStyleBackColor = true;
            this.btnSaveBookInfo.Click += new System.EventHandler(this.btnSaveBookInfo_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(322, 193);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(140, 31);
            this.btnAddCancel.TabIndex = 21;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // cboAddAuthorFirstName
            // 
            this.cboAddAuthorFirstName.FormattingEnabled = true;
            this.cboAddAuthorFirstName.Location = new System.Drawing.Point(258, 64);
            this.cboAddAuthorFirstName.Name = "cboAddAuthorFirstName";
            this.cboAddAuthorFirstName.Size = new System.Drawing.Size(110, 20);
            this.cboAddAuthorFirstName.TabIndex = 5;
            // 
            // cboAddAuthorLastName
            // 
            this.cboAddAuthorLastName.FormattingEnabled = true;
            this.cboAddAuthorLastName.Location = new System.Drawing.Point(142, 64);
            this.cboAddAuthorLastName.Name = "cboAddAuthorLastName";
            this.cboAddAuthorLastName.Size = new System.Drawing.Size(110, 20);
            this.cboAddAuthorLastName.TabIndex = 4;
            // 
            // cboAddAuthorID
            // 
            this.cboAddAuthorID.FormattingEnabled = true;
            this.cboAddAuthorID.Location = new System.Drawing.Point(72, 64);
            this.cboAddAuthorID.Name = "cboAddAuthorID";
            this.cboAddAuthorID.Size = new System.Drawing.Size(64, 20);
            this.cboAddAuthorID.TabIndex = 3;
            // 
            // lblAddAuthor
            // 
            this.lblAddAuthor.AutoSize = true;
            this.lblAddAuthor.Location = new System.Drawing.Point(19, 67);
            this.lblAddAuthor.Name = "lblAddAuthor";
            this.lblAddAuthor.Size = new System.Drawing.Size(47, 12);
            this.lblAddAuthor.TabIndex = 1;
            this.lblAddAuthor.Text = "Author:";
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(72, 24);
            this.txtAddTitle.MaxLength = 50;
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(390, 21);
            this.txtAddTitle.TabIndex = 74;
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Location = new System.Drawing.Point(25, 27);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(41, 12);
            this.lblAddTitle.TabIndex = 73;
            this.lblAddTitle.Text = "Title:";
            // 
            // txtAddNotes
            // 
            this.txtAddNotes.Location = new System.Drawing.Point(72, 100);
            this.txtAddNotes.MaxLength = 100;
            this.txtAddNotes.MinimumSize = new System.Drawing.Size(298, 50);
            this.txtAddNotes.Multiline = true;
            this.txtAddNotes.Name = "txtAddNotes";
            this.txtAddNotes.Size = new System.Drawing.Size(390, 71);
            this.txtAddNotes.TabIndex = 76;
            // 
            // lblAddNotes
            // 
            this.lblAddNotes.AutoSize = true;
            this.lblAddNotes.Location = new System.Drawing.Point(25, 103);
            this.lblAddNotes.Name = "lblAddNotes";
            this.lblAddNotes.Size = new System.Drawing.Size(41, 12);
            this.lblAddNotes.TabIndex = 75;
            this.lblAddNotes.Text = "Notes:";
            // 
            // pnlUpdateBookInfo
            // 
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateAuthorFirstName);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateAuthorFirstName);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateAuthorLastName);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateAuthorLastName);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateTitle);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateTitle);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateNotes);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateAuthorID);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateBookInfoID);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateNotes);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateAuthorID);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateBookInfoID);
            this.pnlUpdateBookInfo.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateBookInfo.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateBookInfo.Location = new System.Drawing.Point(245, 12);
            this.pnlUpdateBookInfo.Name = "pnlUpdateBookInfo";
            this.pnlUpdateBookInfo.Size = new System.Drawing.Size(552, 290);
            this.pnlUpdateBookInfo.TabIndex = 77;
            this.pnlUpdateBookInfo.Visible = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(11, 254);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(140, 31);
            this.btnSaveChanges.TabIndex = 18;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(382, 254);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(140, 31);
            this.btnUpdateCancel.TabIndex = 19;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // txtUpdateAuthorFirstName
            // 
            this.txtUpdateAuthorFirstName.Location = new System.Drawing.Point(118, 160);
            this.txtUpdateAuthorFirstName.Name = "txtUpdateAuthorFirstName";
            this.txtUpdateAuthorFirstName.Size = new System.Drawing.Size(156, 21);
            this.txtUpdateAuthorFirstName.TabIndex = 88;
            // 
            // lblUpdateAuthorFirstName
            // 
            this.lblUpdateAuthorFirstName.AutoSize = true;
            this.lblUpdateAuthorFirstName.Location = new System.Drawing.Point(-1, 163);
            this.lblUpdateAuthorFirstName.Name = "lblUpdateAuthorFirstName";
            this.lblUpdateAuthorFirstName.Size = new System.Drawing.Size(113, 12);
            this.lblUpdateAuthorFirstName.TabIndex = 87;
            this.lblUpdateAuthorFirstName.Text = "Author First Name:";
            // 
            // txtUpdateAuthorLastName
            // 
            this.txtUpdateAuthorLastName.Location = new System.Drawing.Point(118, 120);
            this.txtUpdateAuthorLastName.Name = "txtUpdateAuthorLastName";
            this.txtUpdateAuthorLastName.Size = new System.Drawing.Size(156, 21);
            this.txtUpdateAuthorLastName.TabIndex = 86;
            // 
            // lblUpdateAuthorLastName
            // 
            this.lblUpdateAuthorLastName.AutoSize = true;
            this.lblUpdateAuthorLastName.Location = new System.Drawing.Point(5, 123);
            this.lblUpdateAuthorLastName.Name = "lblUpdateAuthorLastName";
            this.lblUpdateAuthorLastName.Size = new System.Drawing.Size(107, 12);
            this.lblUpdateAuthorLastName.TabIndex = 85;
            this.lblUpdateAuthorLastName.Text = "Author Last Name:";
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(118, 40);
            this.txtUpdateTitle.MaxLength = 50;
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(390, 21);
            this.txtUpdateTitle.TabIndex = 84;
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.Location = new System.Drawing.Point(71, 43);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(41, 12);
            this.lblUpdateTitle.TabIndex = 83;
            this.lblUpdateTitle.Text = "Title:";
            // 
            // txtUpdateNotes
            // 
            this.txtUpdateNotes.Location = new System.Drawing.Point(118, 198);
            this.txtUpdateNotes.MaxLength = 100;
            this.txtUpdateNotes.MinimumSize = new System.Drawing.Size(298, 50);
            this.txtUpdateNotes.Multiline = true;
            this.txtUpdateNotes.Name = "txtUpdateNotes";
            this.txtUpdateNotes.Size = new System.Drawing.Size(390, 50);
            this.txtUpdateNotes.TabIndex = 82;
            // 
            // txtUpdateAuthorID
            // 
            this.txtUpdateAuthorID.Location = new System.Drawing.Point(118, 79);
            this.txtUpdateAuthorID.Name = "txtUpdateAuthorID";
            this.txtUpdateAuthorID.Size = new System.Drawing.Size(65, 21);
            this.txtUpdateAuthorID.TabIndex = 81;
            this.txtUpdateAuthorID.TextChanged += new System.EventHandler(this.txtUpdateAuthorID_TextChanged);
            // 
            // txtUpdateBookInfoID
            // 
            this.txtUpdateBookInfoID.Location = new System.Drawing.Point(118, 3);
            this.txtUpdateBookInfoID.Name = "txtUpdateBookInfoID";
            this.txtUpdateBookInfoID.Size = new System.Drawing.Size(65, 21);
            this.txtUpdateBookInfoID.TabIndex = 80;
            // 
            // lblUpdateNotes
            // 
            this.lblUpdateNotes.AutoSize = true;
            this.lblUpdateNotes.Location = new System.Drawing.Point(71, 201);
            this.lblUpdateNotes.Name = "lblUpdateNotes";
            this.lblUpdateNotes.Size = new System.Drawing.Size(41, 12);
            this.lblUpdateNotes.TabIndex = 79;
            this.lblUpdateNotes.Text = "Notes:";
            // 
            // lblUpdateAuthorID
            // 
            this.lblUpdateAuthorID.AutoSize = true;
            this.lblUpdateAuthorID.Location = new System.Drawing.Point(47, 82);
            this.lblUpdateAuthorID.Name = "lblUpdateAuthorID";
            this.lblUpdateAuthorID.Size = new System.Drawing.Size(65, 12);
            this.lblUpdateAuthorID.TabIndex = 78;
            this.lblUpdateAuthorID.Text = "Author ID:";
            // 
            // lblUpdateBookInfoID
            // 
            this.lblUpdateBookInfoID.AutoSize = true;
            this.lblUpdateBookInfoID.Location = new System.Drawing.Point(29, 6);
            this.lblUpdateBookInfoID.Name = "lblUpdateBookInfoID";
            this.lblUpdateBookInfoID.Size = new System.Drawing.Size(83, 12);
            this.lblUpdateBookInfoID.TabIndex = 77;
            this.lblUpdateBookInfoID.Text = "Book Info ID:";
            // 
            // BookInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 404);
            this.Controls.Add(this.pnlUpdateBookInfo);
            this.Controls.Add(this.pnlAddBookInfo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteBookInfo);
            this.Controls.Add(this.btnUpdateBookInfo);
            this.Controls.Add(this.btnAddBookInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtAuthorFirstName);
            this.Controls.Add(this.lblAuthorFirstName);
            this.Controls.Add(this.txtAuthorLastName);
            this.Controls.Add(this.lblAuthorLastName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtAuthorID);
            this.Controls.Add(this.txtBookInfoID);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblAuthorID);
            this.Controls.Add(this.lblBookInfoID);
            this.Controls.Add(this.lstBookTitles);
            this.Name = "BookInfoForm";
            this.Text = "Book Info Maintenance";
            this.pnlAddBookInfo.ResumeLayout(false);
            this.pnlAddBookInfo.PerformLayout();
            this.pnlUpdateBookInfo.ResumeLayout(false);
            this.pnlUpdateBookInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAuthorFirstName;
        private System.Windows.Forms.Label lblAuthorFirstName;
        private System.Windows.Forms.TextBox txtAuthorLastName;
        private System.Windows.Forms.Label lblAuthorLastName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.TextBox txtBookInfoID;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.Label lblBookInfoID;
        private System.Windows.Forms.ListBox lstBookTitles;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteBookInfo;
        private System.Windows.Forms.Button btnUpdateBookInfo;
        private System.Windows.Forms.Button btnAddBookInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel pnlAddBookInfo;
        private System.Windows.Forms.TextBox txtAddNotes;
        private System.Windows.Forms.Label lblAddNotes;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Button btnSaveBookInfo;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.ComboBox cboAddAuthorFirstName;
        private System.Windows.Forms.ComboBox cboAddAuthorLastName;
        private System.Windows.Forms.ComboBox cboAddAuthorID;
        private System.Windows.Forms.Label lblAddAuthor;
        private System.Windows.Forms.Panel pnlUpdateBookInfo;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.TextBox txtUpdateAuthorFirstName;
        private System.Windows.Forms.Label lblUpdateAuthorFirstName;
        private System.Windows.Forms.TextBox txtUpdateAuthorLastName;
        private System.Windows.Forms.Label lblUpdateAuthorLastName;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.TextBox txtUpdateNotes;
        private System.Windows.Forms.TextBox txtUpdateAuthorID;
        private System.Windows.Forms.TextBox txtUpdateBookInfoID;
        private System.Windows.Forms.Label lblUpdateNotes;
        private System.Windows.Forms.Label lblUpdateAuthorID;
        private System.Windows.Forms.Label lblUpdateBookInfoID;
    }
}