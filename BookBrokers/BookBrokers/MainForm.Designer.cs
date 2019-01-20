namespace BookBrokers
{
    partial class MainForm
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
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnAddBooktoaClientOrder = new System.Windows.Forms.Button();
            this.btnClientOrderMaintenance = new System.Windows.Forms.Button();
            this.btnBookMaintenance = new System.Windows.Forms.Button();
            this.btnBookInfoMaintenance = new System.Windows.Forms.Button();
            this.btnClientMaintenance = new System.Windows.Forms.Button();
            this.btnVendorMaintenance = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnAddBooktoaClientOrder);
            this.grpMaintenance.Controls.Add(this.btnClientOrderMaintenance);
            this.grpMaintenance.Controls.Add(this.btnBookMaintenance);
            this.grpMaintenance.Controls.Add(this.btnBookInfoMaintenance);
            this.grpMaintenance.Controls.Add(this.btnClientMaintenance);
            this.grpMaintenance.Controls.Add(this.btnVendorMaintenance);
            this.grpMaintenance.Location = new System.Drawing.Point(45, 29);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(258, 375);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnAddBooktoaClientOrder
            // 
            this.btnAddBooktoaClientOrder.Location = new System.Drawing.Point(35, 315);
            this.btnAddBooktoaClientOrder.Name = "btnAddBooktoaClientOrder";
            this.btnAddBooktoaClientOrder.Size = new System.Drawing.Size(194, 39);
            this.btnAddBooktoaClientOrder.TabIndex = 5;
            this.btnAddBooktoaClientOrder.Text = "Add Book to a Client Order";
            this.btnAddBooktoaClientOrder.UseVisualStyleBackColor = true;
            this.btnAddBooktoaClientOrder.Click += new System.EventHandler(this.btnAddBooktoaClientOrder_Click);
            // 
            // btnClientOrderMaintenance
            // 
            this.btnClientOrderMaintenance.Location = new System.Drawing.Point(35, 256);
            this.btnClientOrderMaintenance.Name = "btnClientOrderMaintenance";
            this.btnClientOrderMaintenance.Size = new System.Drawing.Size(194, 39);
            this.btnClientOrderMaintenance.TabIndex = 4;
            this.btnClientOrderMaintenance.Text = "Client Order Maintenance";
            this.btnClientOrderMaintenance.UseVisualStyleBackColor = true;
            this.btnClientOrderMaintenance.Click += new System.EventHandler(this.btnClientOrderMaintenance_Click);
            // 
            // btnBookMaintenance
            // 
            this.btnBookMaintenance.Location = new System.Drawing.Point(35, 199);
            this.btnBookMaintenance.Name = "btnBookMaintenance";
            this.btnBookMaintenance.Size = new System.Drawing.Size(194, 39);
            this.btnBookMaintenance.TabIndex = 3;
            this.btnBookMaintenance.Text = "Book Maintenance";
            this.btnBookMaintenance.UseVisualStyleBackColor = true;
            this.btnBookMaintenance.Click += new System.EventHandler(this.btnBookMaintenance_Click);
            // 
            // btnBookInfoMaintenance
            // 
            this.btnBookInfoMaintenance.Location = new System.Drawing.Point(35, 141);
            this.btnBookInfoMaintenance.Name = "btnBookInfoMaintenance";
            this.btnBookInfoMaintenance.Size = new System.Drawing.Size(194, 39);
            this.btnBookInfoMaintenance.TabIndex = 2;
            this.btnBookInfoMaintenance.Text = "Book Info Maintenance";
            this.btnBookInfoMaintenance.UseVisualStyleBackColor = true;
            this.btnBookInfoMaintenance.Click += new System.EventHandler(this.btnBookInfoMaintenance_Click);
            // 
            // btnClientMaintenance
            // 
            this.btnClientMaintenance.Location = new System.Drawing.Point(35, 85);
            this.btnClientMaintenance.Name = "btnClientMaintenance";
            this.btnClientMaintenance.Size = new System.Drawing.Size(194, 39);
            this.btnClientMaintenance.TabIndex = 1;
            this.btnClientMaintenance.Text = "Client Maintenance";
            this.btnClientMaintenance.UseVisualStyleBackColor = true;
            this.btnClientMaintenance.Click += new System.EventHandler(this.btnClientMaintenance_Click);
            // 
            // btnVendorMaintenance
            // 
            this.btnVendorMaintenance.Location = new System.Drawing.Point(35, 30);
            this.btnVendorMaintenance.Name = "btnVendorMaintenance";
            this.btnVendorMaintenance.Size = new System.Drawing.Size(194, 39);
            this.btnVendorMaintenance.TabIndex = 0;
            this.btnVendorMaintenance.Text = "Vendor Maintenance";
            this.btnVendorMaintenance.UseVisualStyleBackColor = true;
            this.btnVendorMaintenance.Click += new System.EventHandler(this.btnVendorMaintenance_Click);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.btnInvoices);
            this.grpReport.Controls.Add(this.btnVendors);
            this.grpReport.Controls.Add(this.btnExit);
            this.grpReport.Location = new System.Drawing.Point(379, 29);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(258, 375);
            this.grpReport.TabIndex = 1;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reporting";
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(33, 30);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(194, 39);
            this.btnInvoices.TabIndex = 6;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnVendors
            // 
            this.btnVendors.Location = new System.Drawing.Point(33, 85);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(194, 39);
            this.btnVendors.TabIndex = 7;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.UseVisualStyleBackColor = true;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(33, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 39);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 440);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnAddBooktoaClientOrder;
        private System.Windows.Forms.Button btnClientOrderMaintenance;
        private System.Windows.Forms.Button btnBookMaintenance;
        private System.Windows.Forms.Button btnBookInfoMaintenance;
        private System.Windows.Forms.Button btnClientMaintenance;
        private System.Windows.Forms.Button btnVendorMaintenance;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnExit;
    }
}

