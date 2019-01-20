using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBrokers
{
    public partial class BookForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmBookInfo;
        private CurrencyManager cmVendor;

        public BookForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddBook.Left = 200;
            pnlAddBook.Top = 12;
            pnlUpdateBook.Left = 200;
            pnlUpdateBook.Top = 12;
        }
        public void BindControls()
        {
            txtBookID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.BookID");
            lblBookInfoID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.BookInfoID");
            txtCost.DataBindings.Add("Text", DM.dsBookBrokers, "Book.Cost");
            txtPrice.DataBindings.Add("Text", DM.dsBookBrokers, "Book.Price");
            txtDatePublished.DataBindings.Add("Text", DM.dsBookBrokers, "Book.DatePublished", true);
            txtVendorID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.VendorID");
            txtClientOrderID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.ClientOrderID");

            txtUpdateBookID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.BookID");
            txtUpdateCost.DataBindings.Add("Text", DM.dsBookBrokers, "Book.Cost");
            txtUpdatePrice.DataBindings.Add("Text", DM.dsBookBrokers, "Book.Price");
            dtpUpdateDatePublished.DataBindings.Add("Text", DM.dsBookBrokers, "Book.DatePublished");
            txtUpdateVendorID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.VendorID");

            txtBookID.Enabled = false;
            txtTitle.Enabled = false;
            txtCost.Enabled = false;
            txtPrice.Enabled = false;
            txtDatePublished.Enabled = false;
            txtVendorID.Enabled = false;
            txtVendorName.Enabled = false;
            txtClientOrderID.Enabled = false;

            txtUpdateBookID.Enabled = false;
            txtUpdateTitle.Enabled = false;
            txtUpdateVendorID.Enabled = false;
            txtUpdateVendorName.Enabled = false;

            lstBookID.DataSource = DM.dsBookBrokers;
            lstBookID.DisplayMember = "Book.BookID";
            lstBookID.ValueMember = "Book.BookID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOK"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];
            cmVendor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "VENDOR"];
        }

        private void LoadBookInfos()
        {
            cboAddBookInfoID.DataSource = DM.dsBookBrokers;
            cboAddBookInfoID.DisplayMember = "BookInfo.BookInfoID";
            cboAddBookInfoID.ValueMember = "BookInfo.BookInfoID";
            cboAddBookTitle.DataSource = DM.dsBookBrokers;
            cboAddBookTitle.DisplayMember = "BookInfo.Title";
            cboAddBookTitle.ValueMember = "BookInfo.Title";
        }
        private void LoadVendors()
        {
            cboAddVendorID.DataSource = DM.dsBookBrokers;
            cboAddVendorID.DisplayMember = "Vendor.VendorID";
            cboAddVendorID.ValueMember = "Vendor.VendorID";
            cboAddVendorName.DataSource = DM.dsBookBrokers;
            cboAddVendorName.DisplayMember = "Vendor.VendorName";
            cboAddVendorName.ValueMember = "Vendor.VendorName";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            pnlAddBook.Show();
            lstBookID.Enabled = false;
            lstBookID.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateBook.Enabled = false;
            btnDeleteBook.Enabled = false;
            btnReturn.Enabled = false;
            LoadBookInfos();
            LoadVendors();
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddBook.Hide();
            lstBookID.Enabled = true;
            lstBookID.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateBook.Enabled = true;
            btnDeleteBook.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            txtBookID.Text = null;
            DataRow newBookRow = DM.dtBook.NewRow();
            if ((cboAddBookInfoID.Text == "") || (cboAddBookTitle.Text == "") || (txtAddCost.Text == "") ||
                (txtAddPrice.Text == "") || (dtpAddDatePublished.Text == "") || (cboAddVendorID.Text == "") ||
                (cboAddVendorName.Text == ""))
            {
                MessageBox.Show("You must enter valid data for all fields", "Error");
            }
            else
            {
                try
                {
                    newBookRow["BookInfoID"] = cboAddBookInfoID.Text;
                    newBookRow["Cost"] = Convert.ToDouble(txtAddCost.Text);
                    newBookRow["Price"] = Convert.ToDouble(txtAddPrice.Text);
                    newBookRow["DatePublished"] = dtpAddDatePublished.Text;
                    newBookRow["VendorID"] = cboAddVendorID.Text;
                    DM.dtBook.Rows.Add(newBookRow);
                    DM.UpdateBook();
                    MessageBox.Show("Book added successfully", "Success");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter numbers for cost and price", "Error");
                }
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (txtClientOrderID.TextLength == 0)
            {
                pnlUpdateBook.Show();
                lstBookID.Enabled = false;
                lstBookID.Visible = false;
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
                btnAddBook.Enabled = false;
                btnDeleteBook.Enabled = false;
                btnReturn.Enabled = false;
            }
            else
            {
                MessageBox.Show("Cannot update a book that is on order", "Error");
            }
            
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateBook.Hide();
            lstBookID.Enabled = true;
            lstBookID.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddBook.Enabled = true;
            btnDeleteBook.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateBookRow = DM.dtBook.Rows[currencyManager.Position];
            if ((txtUpdateCost.Text == "") || (txtUpdatePrice.Text == "") || (dtpUpdateDatePublished.Text == ""))
            {
                MessageBox.Show("You must enter valid data for all fields", "Error");
            }
            else
            {
                try
                {
                    updateBookRow["Cost"] = Convert.ToDouble(txtUpdateCost.Text);
                    updateBookRow["Price"] = Convert.ToDouble(txtUpdatePrice.Text);
                    updateBookRow["DatePublished"] = dtpUpdateDatePublished.Text;
                    currencyManager.EndCurrentEdit();
                    DM.UpdateBook();
                    MessageBox.Show("Book updated successfully", "Success");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter numbers for cost and price", "Error");
                }
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DataRow deleteBookRow = DM.dtBook.Rows[currencyManager.Position];
            if (txtClientOrderID.TextLength != 0)
            {
                MessageBox.Show("You may only delete books that are not on order", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this book?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteBookRow.Delete();
                    DM.UpdateBook();
                    MessageBox.Show("Book deleted successfully", "Success");
                }
            }
        }

        private void txtVendorID_TextChanged(object sender, EventArgs e)
        {
            if (txtVendorID.Text == "")
            {
                txtVendorName.Text = "";
                txtUpdateVendorName.Text = "";
            }
            else
            {
                int aVendorID = Convert.ToInt32(txtVendorID.Text);
                cmVendor.Position = DM.VendorView.Find(aVendorID);
                DataRow drVendor = DM.dtVendor.Rows[cmVendor.Position];
                txtVendorName.Text = drVendor["VendorName"].ToString();
                txtUpdateVendorName.Text = drVendor["VendorName"].ToString();
            }
        }

        private void lblBookInfoID_TextChanged(object sender, EventArgs e)
        {
            if (lblBookInfoID.Text == "BookInfoID")
            {
                txtTitle.Text = "";
                txtUpdateTitle.Text = "";
            }
            else
            {
                int aBookInfoID = Convert.ToInt32(lblBookInfoID.Text);
                cmBookInfo.Position = DM.BookInfoView.Find(aBookInfoID);
                DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];
                txtTitle.Text = drBookInfo["Title"].ToString();
                txtUpdateTitle.Text = drBookInfo["Title"].ToString();
            }
        }
    }
}
