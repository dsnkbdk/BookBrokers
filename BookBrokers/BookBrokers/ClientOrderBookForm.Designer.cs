namespace BookBrokers
{
    partial class ClientOrderBookForm
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
            this.dgvClientOrder = new System.Windows.Forms.DataGridView();
            this.lblClientLastName = new System.Windows.Forms.Label();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtClientFirstName = new System.Windows.Forms.TextBox();
            this.lblClientFirstName = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvBookNullClientOrderID = new System.Windows.Forms.DataGridView();
            this.dgvClientBook = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblBookInfoID = new System.Windows.Forms.Label();
            this.lblBookInfoID2 = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookNullClientOrderID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientOrder
            // 
            this.dgvClientOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientOrder.Location = new System.Drawing.Point(12, 12);
            this.dgvClientOrder.Name = "dgvClientOrder";
            this.dgvClientOrder.RowTemplate.Height = 23;
            this.dgvClientOrder.Size = new System.Drawing.Size(480, 180);
            this.dgvClientOrder.TabIndex = 0;
            // 
            // lblClientLastName
            // 
            this.lblClientLastName.AutoSize = true;
            this.lblClientLastName.Location = new System.Drawing.Point(576, 70);
            this.lblClientLastName.Name = "lblClientLastName";
            this.lblClientLastName.Size = new System.Drawing.Size(107, 12);
            this.lblClientLastName.TabIndex = 3;
            this.lblClientLastName.Text = "Client Last Name:";
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Location = new System.Drawing.Point(689, 67);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(152, 21);
            this.txtClientLastName.TabIndex = 4;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(12, 442);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(104, 24);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtClientFirstName
            // 
            this.txtClientFirstName.Location = new System.Drawing.Point(689, 113);
            this.txtClientFirstName.Name = "txtClientFirstName";
            this.txtClientFirstName.Size = new System.Drawing.Size(152, 21);
            this.txtClientFirstName.TabIndex = 7;
            // 
            // lblClientFirstName
            // 
            this.lblClientFirstName.AutoSize = true;
            this.lblClientFirstName.Location = new System.Drawing.Point(570, 116);
            this.lblClientFirstName.Name = "lblClientFirstName";
            this.lblClientFirstName.Size = new System.Drawing.Size(113, 12);
            this.lblClientFirstName.TabIndex = 6;
            this.lblClientFirstName.Text = "Client First Name:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(339, 405);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(242, 21);
            this.txtTitle.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(292, 408);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 12);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title:";
            // 
            // dgvBookNullClientOrderID
            // 
            this.dgvBookNullClientOrderID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookNullClientOrderID.Location = new System.Drawing.Point(480, 211);
            this.dgvBookNullClientOrderID.Name = "dgvBookNullClientOrderID";
            this.dgvBookNullClientOrderID.RowTemplate.Height = 23;
            this.dgvBookNullClientOrderID.Size = new System.Drawing.Size(450, 180);
            this.dgvBookNullClientOrderID.TabIndex = 10;
            // 
            // dgvClientBook
            // 
            this.dgvClientBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientBook.Location = new System.Drawing.Point(12, 211);
            this.dgvClientBook.Name = "dgvClientBook";
            this.dgvClientBook.RowTemplate.Height = 23;
            this.dgvClientBook.Size = new System.Drawing.Size(450, 180);
            this.dgvClientBook.TabIndex = 11;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(826, 442);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(104, 24);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(422, 442);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(104, 24);
            this.btnRemoveBook.TabIndex = 13;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(702, 70);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(53, 12);
            this.lblClientID.TabIndex = 14;
            this.lblClientID.Text = "ClientID";
            this.lblClientID.TextChanged += new System.EventHandler(this.lblClientID_TextChanged);
            // 
            // lblBookInfoID
            // 
            this.lblBookInfoID.AutoSize = true;
            this.lblBookInfoID.Location = new System.Drawing.Point(349, 408);
            this.lblBookInfoID.Name = "lblBookInfoID";
            this.lblBookInfoID.Size = new System.Drawing.Size(65, 12);
            this.lblBookInfoID.TabIndex = 15;
            this.lblBookInfoID.Text = "BookInfoID";
            this.lblBookInfoID.TextChanged += new System.EventHandler(this.lblBookInfoID_TextChanged);
            // 
            // lblBookInfoID2
            // 
            this.lblBookInfoID2.AutoSize = true;
            this.lblBookInfoID2.Location = new System.Drawing.Point(498, 408);
            this.lblBookInfoID2.Name = "lblBookInfoID2";
            this.lblBookInfoID2.Size = new System.Drawing.Size(71, 12);
            this.lblBookInfoID2.TabIndex = 16;
            this.lblBookInfoID2.Text = "BookInfoID2";
            this.lblBookInfoID2.TextChanged += new System.EventHandler(this.lblBookInfoID2_TextChanged);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(485, 368);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(41, 12);
            this.lblBookID.TabIndex = 17;
            this.lblBookID.Text = "BookID";
            // 
            // ClientOrderBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 478);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvClientBook);
            this.Controls.Add(this.dgvBookNullClientOrderID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtClientFirstName);
            this.Controls.Add(this.lblClientFirstName);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txtClientLastName);
            this.Controls.Add(this.lblClientLastName);
            this.Controls.Add(this.dgvClientOrder);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblBookInfoID2);
            this.Controls.Add(this.lblBookInfoID);
            this.Controls.Add(this.lblBookID);
            this.Name = "ClientOrderBookForm";
            this.Text = "Add Book to a Client Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookNullClientOrderID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientOrder;
        private System.Windows.Forms.Label lblClientLastName;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtClientFirstName;
        private System.Windows.Forms.Label lblClientFirstName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvBookNullClientOrderID;
        private System.Windows.Forms.DataGridView dgvClientBook;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblBookInfoID;
        private System.Windows.Forms.Label lblBookInfoID2;
        private System.Windows.Forms.Label lblBookID;
    }
}