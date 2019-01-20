namespace BookBrokers
{
    partial class ClientOrderForm
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
            this.txtClientFirstName = new System.Windows.Forms.TextBox();
            this.lblClientFirstName = new System.Windows.Forms.Label();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.lblClientLastName = new System.Windows.Forms.Label();
            this.txtClientOrderDate = new System.Windows.Forms.TextBox();
            this.lblClientOrderDate = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtClientOrderID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblClientOrderID = new System.Windows.Forms.Label();
            this.lstClientOrderID = new System.Windows.Forms.ListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteClientOrder = new System.Windows.Forms.Button();
            this.btnUpdateClientOrder = new System.Windows.Forms.Button();
            this.btnAddClientOrder = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnMarkClientOrderasShipped = new System.Windows.Forms.Button();
            this.btnMarkClientOrderasPaid = new System.Windows.Forms.Button();
            this.pnlAddClientOrder = new System.Windows.Forms.Panel();
            this.lblAddClientOrderDate = new System.Windows.Forms.Label();
            this.lblAddClient = new System.Windows.Forms.Label();
            this.cboAddClientID = new System.Windows.Forms.ComboBox();
            this.cboAddClientLastName = new System.Windows.Forms.ComboBox();
            this.cboAddClientFirstName = new System.Windows.Forms.ComboBox();
            this.btnSaveClientOrder = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.dtpAddClientOrderDate = new System.Windows.Forms.DateTimePicker();
            this.pnlUpdateClientOrder = new System.Windows.Forms.Panel();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.txtUpdateClientFirstName = new System.Windows.Forms.TextBox();
            this.lblUpdateClientFirstName = new System.Windows.Forms.Label();
            this.txtUpdateClientLastName = new System.Windows.Forms.TextBox();
            this.lblUpdateClientLastName = new System.Windows.Forms.Label();
            this.lblUpdateClientOrderDate = new System.Windows.Forms.Label();
            this.txtUpdateStatus = new System.Windows.Forms.TextBox();
            this.txtUpdateClientID = new System.Windows.Forms.TextBox();
            this.txtUpdateClientOrderID = new System.Windows.Forms.TextBox();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.lblUpdateClientID = new System.Windows.Forms.Label();
            this.lblUpdateClientOrderID = new System.Windows.Forms.Label();
            this.dtpUpdateClientOrderDate = new System.Windows.Forms.DateTimePicker();
            this.pnlAddClientOrder.SuspendLayout();
            this.pnlUpdateClientOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClientFirstName
            // 
            this.txtClientFirstName.Location = new System.Drawing.Point(323, 197);
            this.txtClientFirstName.Name = "txtClientFirstName";
            this.txtClientFirstName.Size = new System.Drawing.Size(141, 21);
            this.txtClientFirstName.TabIndex = 63;
            // 
            // lblClientFirstName
            // 
            this.lblClientFirstName.AutoSize = true;
            this.lblClientFirstName.Location = new System.Drawing.Point(204, 200);
            this.lblClientFirstName.Name = "lblClientFirstName";
            this.lblClientFirstName.Size = new System.Drawing.Size(113, 12);
            this.lblClientFirstName.TabIndex = 62;
            this.lblClientFirstName.Text = "Client First Name:";
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Location = new System.Drawing.Point(323, 157);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(141, 21);
            this.txtClientLastName.TabIndex = 61;
            // 
            // lblClientLastName
            // 
            this.lblClientLastName.AutoSize = true;
            this.lblClientLastName.Location = new System.Drawing.Point(210, 160);
            this.lblClientLastName.Name = "lblClientLastName";
            this.lblClientLastName.Size = new System.Drawing.Size(107, 12);
            this.lblClientLastName.TabIndex = 60;
            this.lblClientLastName.Text = "Client Last Name:";
            // 
            // txtClientOrderDate
            // 
            this.txtClientOrderDate.Location = new System.Drawing.Point(324, 77);
            this.txtClientOrderDate.Name = "txtClientOrderDate";
            this.txtClientOrderDate.Size = new System.Drawing.Size(106, 21);
            this.txtClientOrderDate.TabIndex = 59;
            // 
            // lblClientOrderDate
            // 
            this.lblClientOrderDate.AutoSize = true;
            this.lblClientOrderDate.Location = new System.Drawing.Point(205, 80);
            this.lblClientOrderDate.Name = "lblClientOrderDate";
            this.lblClientOrderDate.Size = new System.Drawing.Size(113, 12);
            this.lblClientOrderDate.TabIndex = 58;
            this.lblClientOrderDate.Text = "Client Order Date:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(324, 235);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(65, 21);
            this.txtStatus.TabIndex = 54;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(323, 116);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(66, 21);
            this.txtClientID.TabIndex = 53;
            this.txtClientID.TextChanged += new System.EventHandler(this.txtClientID_TextChanged);
            // 
            // txtClientOrderID
            // 
            this.txtClientOrderID.Location = new System.Drawing.Point(324, 40);
            this.txtClientOrderID.Name = "txtClientOrderID";
            this.txtClientOrderID.Size = new System.Drawing.Size(65, 21);
            this.txtClientOrderID.TabIndex = 52;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(271, 238);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 12);
            this.lblStatus.TabIndex = 49;
            this.lblStatus.Text = "Status:";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(252, 119);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(65, 12);
            this.lblClientID.TabIndex = 48;
            this.lblClientID.Text = "Client ID:";
            // 
            // lblClientOrderID
            // 
            this.lblClientOrderID.AutoSize = true;
            this.lblClientOrderID.Location = new System.Drawing.Point(217, 43);
            this.lblClientOrderID.Name = "lblClientOrderID";
            this.lblClientOrderID.Size = new System.Drawing.Size(101, 12);
            this.lblClientOrderID.TabIndex = 47;
            this.lblClientOrderID.Text = "Client Order ID:";
            // 
            // lstClientOrderID
            // 
            this.lstClientOrderID.FormattingEnabled = true;
            this.lstClientOrderID.ItemHeight = 12;
            this.lstClientOrderID.Location = new System.Drawing.Point(12, 12);
            this.lstClientOrderID.Name = "lstClientOrderID";
            this.lstClientOrderID.Size = new System.Drawing.Size(166, 280);
            this.lstClientOrderID.TabIndex = 46;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(641, 360);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(140, 31);
            this.btnReturn.TabIndex = 71;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteClientOrder
            // 
            this.btnDeleteClientOrder.Location = new System.Drawing.Point(641, 308);
            this.btnDeleteClientOrder.Name = "btnDeleteClientOrder";
            this.btnDeleteClientOrder.Size = new System.Drawing.Size(140, 31);
            this.btnDeleteClientOrder.TabIndex = 70;
            this.btnDeleteClientOrder.Text = "Delete Client Order";
            this.btnDeleteClientOrder.UseVisualStyleBackColor = true;
            this.btnDeleteClientOrder.Click += new System.EventHandler(this.btnDeleteClientOrder_Click);
            // 
            // btnUpdateClientOrder
            // 
            this.btnUpdateClientOrder.Location = new System.Drawing.Point(482, 308);
            this.btnUpdateClientOrder.Name = "btnUpdateClientOrder";
            this.btnUpdateClientOrder.Size = new System.Drawing.Size(140, 31);
            this.btnUpdateClientOrder.TabIndex = 69;
            this.btnUpdateClientOrder.Text = "Update Client Order";
            this.btnUpdateClientOrder.UseVisualStyleBackColor = true;
            this.btnUpdateClientOrder.Click += new System.EventHandler(this.btnUpdateClientOrder_Click);
            // 
            // btnAddClientOrder
            // 
            this.btnAddClientOrder.Location = new System.Drawing.Point(324, 308);
            this.btnAddClientOrder.Name = "btnAddClientOrder";
            this.btnAddClientOrder.Size = new System.Drawing.Size(140, 31);
            this.btnAddClientOrder.TabIndex = 68;
            this.btnAddClientOrder.Text = "Add Client Order";
            this.btnAddClientOrder.UseVisualStyleBackColor = true;
            this.btnAddClientOrder.Click += new System.EventHandler(this.btnAddClientOrder_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(166, 308);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(140, 31);
            this.btnNext.TabIndex = 67;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 308);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(140, 31);
            this.btnPrevious.TabIndex = 66;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnMarkClientOrderasShipped
            // 
            this.btnMarkClientOrderasShipped.Location = new System.Drawing.Point(12, 360);
            this.btnMarkClientOrderasShipped.Name = "btnMarkClientOrderasShipped";
            this.btnMarkClientOrderasShipped.Size = new System.Drawing.Size(294, 31);
            this.btnMarkClientOrderasShipped.TabIndex = 72;
            this.btnMarkClientOrderasShipped.Text = "Mark Client Order as Shipped";
            this.btnMarkClientOrderasShipped.UseVisualStyleBackColor = true;
            this.btnMarkClientOrderasShipped.Click += new System.EventHandler(this.btnMarkClientOrderasShipped_Click);
            // 
            // btnMarkClientOrderasPaid
            // 
            this.btnMarkClientOrderasPaid.Location = new System.Drawing.Point(323, 360);
            this.btnMarkClientOrderasPaid.Name = "btnMarkClientOrderasPaid";
            this.btnMarkClientOrderasPaid.Size = new System.Drawing.Size(298, 31);
            this.btnMarkClientOrderasPaid.TabIndex = 73;
            this.btnMarkClientOrderasPaid.Text = "Mark Client Order as Paid";
            this.btnMarkClientOrderasPaid.UseVisualStyleBackColor = true;
            this.btnMarkClientOrderasPaid.Click += new System.EventHandler(this.btnMarkClientOrderasPaid_Click);
            // 
            // pnlAddClientOrder
            // 
            this.pnlAddClientOrder.Controls.Add(this.dtpAddClientOrderDate);
            this.pnlAddClientOrder.Controls.Add(this.btnSaveClientOrder);
            this.pnlAddClientOrder.Controls.Add(this.btnAddCancel);
            this.pnlAddClientOrder.Controls.Add(this.cboAddClientFirstName);
            this.pnlAddClientOrder.Controls.Add(this.cboAddClientLastName);
            this.pnlAddClientOrder.Controls.Add(this.cboAddClientID);
            this.pnlAddClientOrder.Controls.Add(this.lblAddClient);
            this.pnlAddClientOrder.Controls.Add(this.lblAddClientOrderDate);
            this.pnlAddClientOrder.Location = new System.Drawing.Point(453, 40);
            this.pnlAddClientOrder.Name = "pnlAddClientOrder";
            this.pnlAddClientOrder.Size = new System.Drawing.Size(483, 234);
            this.pnlAddClientOrder.TabIndex = 74;
            this.pnlAddClientOrder.Visible = false;
            // 
            // lblAddClientOrderDate
            // 
            this.lblAddClientOrderDate.AutoSize = true;
            this.lblAddClientOrderDate.Location = new System.Drawing.Point(41, 37);
            this.lblAddClientOrderDate.Name = "lblAddClientOrderDate";
            this.lblAddClientOrderDate.Size = new System.Drawing.Size(113, 12);
            this.lblAddClientOrderDate.TabIndex = 0;
            this.lblAddClientOrderDate.Text = "Client Order Date:";
            // 
            // lblAddClient
            // 
            this.lblAddClient.AutoSize = true;
            this.lblAddClient.Location = new System.Drawing.Point(107, 91);
            this.lblAddClient.Name = "lblAddClient";
            this.lblAddClient.Size = new System.Drawing.Size(47, 12);
            this.lblAddClient.TabIndex = 1;
            this.lblAddClient.Text = "Client:";
            // 
            // cboAddClientID
            // 
            this.cboAddClientID.FormattingEnabled = true;
            this.cboAddClientID.Location = new System.Drawing.Point(160, 88);
            this.cboAddClientID.Name = "cboAddClientID";
            this.cboAddClientID.Size = new System.Drawing.Size(64, 20);
            this.cboAddClientID.TabIndex = 3;
            // 
            // cboAddClientLastName
            // 
            this.cboAddClientLastName.FormattingEnabled = true;
            this.cboAddClientLastName.Location = new System.Drawing.Point(230, 88);
            this.cboAddClientLastName.Name = "cboAddClientLastName";
            this.cboAddClientLastName.Size = new System.Drawing.Size(110, 20);
            this.cboAddClientLastName.TabIndex = 4;
            // 
            // cboAddClientFirstName
            // 
            this.cboAddClientFirstName.FormattingEnabled = true;
            this.cboAddClientFirstName.Location = new System.Drawing.Point(346, 88);
            this.cboAddClientFirstName.Name = "cboAddClientFirstName";
            this.cboAddClientFirstName.Size = new System.Drawing.Size(110, 20);
            this.cboAddClientFirstName.TabIndex = 5;
            // 
            // btnSaveClientOrder
            // 
            this.btnSaveClientOrder.Location = new System.Drawing.Point(43, 173);
            this.btnSaveClientOrder.Name = "btnSaveClientOrder";
            this.btnSaveClientOrder.Size = new System.Drawing.Size(140, 31);
            this.btnSaveClientOrder.TabIndex = 20;
            this.btnSaveClientOrder.Text = "Save Client Order";
            this.btnSaveClientOrder.UseVisualStyleBackColor = true;
            this.btnSaveClientOrder.Click += new System.EventHandler(this.btnSaveClientOrder_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(316, 173);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(140, 31);
            this.btnAddCancel.TabIndex = 21;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // dtpAddClientOrderDate
            // 
            this.dtpAddClientOrderDate.Location = new System.Drawing.Point(160, 31);
            this.dtpAddClientOrderDate.Name = "dtpAddClientOrderDate";
            this.dtpAddClientOrderDate.Size = new System.Drawing.Size(87, 21);
            this.dtpAddClientOrderDate.TabIndex = 22;
            // 
            // pnlUpdateClientOrder
            // 
            this.pnlUpdateClientOrder.Controls.Add(this.dtpUpdateClientOrderDate);
            this.pnlUpdateClientOrder.Controls.Add(this.txtUpdateClientFirstName);
            this.pnlUpdateClientOrder.Controls.Add(this.lblUpdateClientFirstName);
            this.pnlUpdateClientOrder.Controls.Add(this.txtUpdateClientLastName);
            this.pnlUpdateClientOrder.Controls.Add(this.lblUpdateClientLastName);
            this.pnlUpdateClientOrder.Controls.Add(this.lblUpdateClientOrderDate);
            this.pnlUpdateClientOrder.Controls.Add(this.txtUpdateStatus);
            this.pnlUpdateClientOrder.Controls.Add(this.txtUpdateClientID);
            this.pnlUpdateClientOrder.Controls.Add(this.txtUpdateClientOrderID);
            this.pnlUpdateClientOrder.Controls.Add(this.lblUpdateStatus);
            this.pnlUpdateClientOrder.Controls.Add(this.lblUpdateClientID);
            this.pnlUpdateClientOrder.Controls.Add(this.lblUpdateClientOrderID);
            this.pnlUpdateClientOrder.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateClientOrder.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateClientOrder.Location = new System.Drawing.Point(42, 12);
            this.pnlUpdateClientOrder.Name = "pnlUpdateClientOrder";
            this.pnlUpdateClientOrder.Size = new System.Drawing.Size(388, 290);
            this.pnlUpdateClientOrder.TabIndex = 63;
            this.pnlUpdateClientOrder.Visible = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(19, 249);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(140, 31);
            this.btnSaveChanges.TabIndex = 18;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(230, 250);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(140, 31);
            this.btnUpdateCancel.TabIndex = 19;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // txtUpdateClientFirstName
            // 
            this.txtUpdateClientFirstName.Location = new System.Drawing.Point(165, 223);
            this.txtUpdateClientFirstName.Name = "txtUpdateClientFirstName";
            this.txtUpdateClientFirstName.Size = new System.Drawing.Size(141, 21);
            this.txtUpdateClientFirstName.TabIndex = 75;
            // 
            // lblUpdateClientFirstName
            // 
            this.lblUpdateClientFirstName.AutoSize = true;
            this.lblUpdateClientFirstName.Location = new System.Drawing.Point(46, 226);
            this.lblUpdateClientFirstName.Name = "lblUpdateClientFirstName";
            this.lblUpdateClientFirstName.Size = new System.Drawing.Size(113, 12);
            this.lblUpdateClientFirstName.TabIndex = 74;
            this.lblUpdateClientFirstName.Text = "Client First Name:";
            // 
            // txtUpdateClientLastName
            // 
            this.txtUpdateClientLastName.Location = new System.Drawing.Point(165, 185);
            this.txtUpdateClientLastName.Name = "txtUpdateClientLastName";
            this.txtUpdateClientLastName.Size = new System.Drawing.Size(141, 21);
            this.txtUpdateClientLastName.TabIndex = 73;
            // 
            // lblUpdateClientLastName
            // 
            this.lblUpdateClientLastName.AutoSize = true;
            this.lblUpdateClientLastName.Location = new System.Drawing.Point(52, 188);
            this.lblUpdateClientLastName.Name = "lblUpdateClientLastName";
            this.lblUpdateClientLastName.Size = new System.Drawing.Size(107, 12);
            this.lblUpdateClientLastName.TabIndex = 72;
            this.lblUpdateClientLastName.Text = "Client Last Name:";
            // 
            // lblUpdateClientOrderDate
            // 
            this.lblUpdateClientOrderDate.AutoSize = true;
            this.lblUpdateClientOrderDate.Location = new System.Drawing.Point(46, 68);
            this.lblUpdateClientOrderDate.Name = "lblUpdateClientOrderDate";
            this.lblUpdateClientOrderDate.Size = new System.Drawing.Size(113, 12);
            this.lblUpdateClientOrderDate.TabIndex = 70;
            this.lblUpdateClientOrderDate.Text = "Client Order Date:";
            // 
            // txtUpdateStatus
            // 
            this.txtUpdateStatus.Location = new System.Drawing.Point(165, 104);
            this.txtUpdateStatus.Name = "txtUpdateStatus";
            this.txtUpdateStatus.Size = new System.Drawing.Size(65, 21);
            this.txtUpdateStatus.TabIndex = 69;
            // 
            // txtUpdateClientID
            // 
            this.txtUpdateClientID.Location = new System.Drawing.Point(165, 145);
            this.txtUpdateClientID.Name = "txtUpdateClientID";
            this.txtUpdateClientID.Size = new System.Drawing.Size(66, 21);
            this.txtUpdateClientID.TabIndex = 68;
            this.txtUpdateClientID.TextChanged += new System.EventHandler(this.txtUpdateClientID_TextChanged);
            // 
            // txtUpdateClientOrderID
            // 
            this.txtUpdateClientOrderID.Location = new System.Drawing.Point(165, 28);
            this.txtUpdateClientOrderID.Name = "txtUpdateClientOrderID";
            this.txtUpdateClientOrderID.Size = new System.Drawing.Size(65, 21);
            this.txtUpdateClientOrderID.TabIndex = 67;
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Location = new System.Drawing.Point(112, 107);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(47, 12);
            this.lblUpdateStatus.TabIndex = 66;
            this.lblUpdateStatus.Text = "Status:";
            // 
            // lblUpdateClientID
            // 
            this.lblUpdateClientID.AutoSize = true;
            this.lblUpdateClientID.Location = new System.Drawing.Point(94, 148);
            this.lblUpdateClientID.Name = "lblUpdateClientID";
            this.lblUpdateClientID.Size = new System.Drawing.Size(65, 12);
            this.lblUpdateClientID.TabIndex = 65;
            this.lblUpdateClientID.Text = "Client ID:";
            // 
            // lblUpdateClientOrderID
            // 
            this.lblUpdateClientOrderID.AutoSize = true;
            this.lblUpdateClientOrderID.Location = new System.Drawing.Point(58, 31);
            this.lblUpdateClientOrderID.Name = "lblUpdateClientOrderID";
            this.lblUpdateClientOrderID.Size = new System.Drawing.Size(101, 12);
            this.lblUpdateClientOrderID.TabIndex = 64;
            this.lblUpdateClientOrderID.Text = "Client Order ID:";
            // 
            // dtpUpdateClientOrderDate
            // 
            this.dtpUpdateClientOrderDate.Location = new System.Drawing.Point(164, 62);
            this.dtpUpdateClientOrderDate.Name = "dtpUpdateClientOrderDate";
            this.dtpUpdateClientOrderDate.Size = new System.Drawing.Size(127, 21);
            this.dtpUpdateClientOrderDate.TabIndex = 76;
            // 
            // ClientOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 404);
            this.Controls.Add(this.pnlUpdateClientOrder);
            this.Controls.Add(this.pnlAddClientOrder);
            this.Controls.Add(this.btnMarkClientOrderasPaid);
            this.Controls.Add(this.btnMarkClientOrderasShipped);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteClientOrder);
            this.Controls.Add(this.btnUpdateClientOrder);
            this.Controls.Add(this.btnAddClientOrder);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtClientFirstName);
            this.Controls.Add(this.lblClientFirstName);
            this.Controls.Add(this.txtClientLastName);
            this.Controls.Add(this.lblClientLastName);
            this.Controls.Add(this.txtClientOrderDate);
            this.Controls.Add(this.lblClientOrderDate);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtClientOrderID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblClientOrderID);
            this.Controls.Add(this.lstClientOrderID);
            this.Name = "ClientOrderForm";
            this.Text = "Client Order Maintenance";
            this.pnlAddClientOrder.ResumeLayout(false);
            this.pnlAddClientOrder.PerformLayout();
            this.pnlUpdateClientOrder.ResumeLayout(false);
            this.pnlUpdateClientOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtClientFirstName;
        private System.Windows.Forms.Label lblClientFirstName;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.Label lblClientLastName;
        private System.Windows.Forms.TextBox txtClientOrderDate;
        private System.Windows.Forms.Label lblClientOrderDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtClientOrderID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblClientOrderID;
        private System.Windows.Forms.ListBox lstClientOrderID;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteClientOrder;
        private System.Windows.Forms.Button btnUpdateClientOrder;
        private System.Windows.Forms.Button btnAddClientOrder;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnMarkClientOrderasShipped;
        private System.Windows.Forms.Button btnMarkClientOrderasPaid;
        private System.Windows.Forms.Panel pnlAddClientOrder;
        private System.Windows.Forms.ComboBox cboAddClientFirstName;
        private System.Windows.Forms.ComboBox cboAddClientLastName;
        private System.Windows.Forms.ComboBox cboAddClientID;
        private System.Windows.Forms.Label lblAddClient;
        private System.Windows.Forms.Label lblAddClientOrderDate;
        private System.Windows.Forms.Button btnSaveClientOrder;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.DateTimePicker dtpAddClientOrderDate;
        private System.Windows.Forms.Panel pnlUpdateClientOrder;
        private System.Windows.Forms.DateTimePicker dtpUpdateClientOrderDate;
        private System.Windows.Forms.TextBox txtUpdateClientFirstName;
        private System.Windows.Forms.Label lblUpdateClientFirstName;
        private System.Windows.Forms.TextBox txtUpdateClientLastName;
        private System.Windows.Forms.Label lblUpdateClientLastName;
        private System.Windows.Forms.Label lblUpdateClientOrderDate;
        private System.Windows.Forms.TextBox txtUpdateStatus;
        private System.Windows.Forms.TextBox txtUpdateClientID;
        private System.Windows.Forms.TextBox txtUpdateClientOrderID;
        private System.Windows.Forms.Label lblUpdateStatus;
        private System.Windows.Forms.Label lblUpdateClientID;
        private System.Windows.Forms.Label lblUpdateClientOrderID;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnUpdateCancel;
    }
}