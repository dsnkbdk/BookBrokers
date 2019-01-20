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
    public partial class BookInfoForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmAuthor;

        public BookInfoForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddBookInfo.Left = 240;
            pnlAddBookInfo.Top = 25;
            pnlUpdateBookInfo.Left = 240;
            pnlUpdateBookInfo.Top = 10;
        }
        public void BindControls()
        {
            txtBookInfoID.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.BookInfoID");
            txtTitle.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.Title");
            txtAuthorID.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.AuthorID");
            txtNotes.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.Notes");

            txtUpdateBookInfoID.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.BookInfoID");
            txtUpdateTitle.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.Title");
            txtUpdateAuthorID.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.AuthorID");
            txtUpdateNotes.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.Notes");

            txtBookInfoID.Enabled = false;
            txtTitle.Enabled = false;
            txtAuthorID.Enabled = false;
            txtAuthorLastName.Enabled = false;
            txtAuthorFirstName.Enabled = false;
            txtNotes.Enabled = false;

            txtUpdateBookInfoID.Enabled = false;
            txtUpdateAuthorID.Enabled = false;
            txtUpdateAuthorLastName.Enabled = false;
            txtUpdateAuthorFirstName.Enabled = false;

            lstBookTitles.DataSource = DM.dsBookBrokers;
            lstBookTitles.DisplayMember = "BookInfo.Title";
            lstBookTitles.ValueMember = "BookInfo.Title";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];
            cmAuthor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "AUTHOR"];
        }
        private void LoadAuthors()
        {
            cboAddAuthorID.DataSource = DM.dsBookBrokers;
            cboAddAuthorID.DisplayMember = "Author.AuthorID";
            cboAddAuthorID.ValueMember = "Author.AuthorID";
            cboAddAuthorLastName.DataSource = DM.dsBookBrokers;
            cboAddAuthorLastName.DisplayMember = "Author.LastName";
            cboAddAuthorLastName.ValueMember = "Author.LastName";
            cboAddAuthorFirstName.DataSource = DM.dsBookBrokers;
            cboAddAuthorFirstName.DisplayMember = "Author.FirstName";
            cboAddAuthorFirstName.ValueMember = "Author.FirstName";
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

        private void btnAddBookInfo_Click(object sender, EventArgs e)
        {
            pnlAddBookInfo.Show();
            lstBookTitles.Enabled = false;
            lstBookTitles.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateBookInfo.Enabled = false;
            btnDeleteBookInfo.Enabled = false;
            LoadAuthors();
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddBookInfo.Hide();
            lstBookTitles.Enabled = true;
            lstBookTitles.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnUpdateBookInfo.Enabled = true;
            btnDeleteBookInfo.Enabled = true;
        }

        private void btnSaveBookInfo_Click(object sender, EventArgs e)
        {
            txtBookInfoID.Text = null;
            DataRow newBookInfoRow = DM.dtBookInfo.NewRow();
            if ((txtAddTitle.Text == "") || (cboAddAuthorID.Text == "") ||
                (cboAddAuthorLastName.Text == "") || (cboAddAuthorFirstName.Text == ""))
            {
                MessageBox.Show("You must enter valid data for all fields", "Error");
            }
            else
            {
                newBookInfoRow["Title"] = txtAddTitle.Text;
                newBookInfoRow["AuthorID"] = cboAddAuthorID.Text;
                newBookInfoRow["Notes"] = txtAddNotes.Text;
                DM.dtBookInfo.Rows.Add(newBookInfoRow);
                DM.UpdateBookInfo();
                MessageBox.Show("Book Info added successfully", "Success");
            }
        }

        private void btnUpdateBookInfo_Click(object sender, EventArgs e)
        {
            pnlUpdateBookInfo.Show();
            lstBookTitles.Enabled = false;
            lstBookTitles.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnReturn.Enabled = false;
            btnAddBookInfo.Enabled = false;
            btnDeleteBookInfo.Enabled = false;
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateBookInfo.Hide();
            lstBookTitles.Enabled = true;
            lstBookTitles.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnAddBookInfo.Enabled = true;
            btnDeleteBookInfo.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateBookInfoRow = DM.dtBookInfo.Rows[currencyManager.Position];
            if (txtUpdateTitle.Text == "")
            {
                MessageBox.Show("You must enter title", "Error");
            }
            else
            {
                updateBookInfoRow["Title"] = txtUpdateTitle.Text;
                updateBookInfoRow["Notes"] = txtUpdateNotes.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateBookInfo();
                MessageBox.Show("Book Info updated successfully", "Success");
            }
        }

        private void btnDeleteBookInfo_Click(object sender, EventArgs e)
        {
            DataRow deleteBookInfoRow = DM.dtBookInfo.Rows[currencyManager.Position];
            DataRow[] BookRow = DM.dtBook.Select("BookInfoID = " + txtBookInfoID.Text);
            if (BookRow.Length != 0)
            {
                MessageBox.Show("You may only delete book info records that have no books", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this book info ?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteBookInfoRow.Delete();
                    DM.UpdateBookInfo();
                    MessageBox.Show("Book Info deleted successfully", "Success");
                }
            }
        }

        private void txtAuthorID_TextChanged(object sender, EventArgs e)
        {
            if (txtAuthorID.Text == "")
            {
                txtAuthorLastName.Text = "";
                txtAuthorFirstName.Text = "";
            }
            else
            {
                int anAuthorID = Convert.ToInt32(txtAuthorID.Text);
                cmAuthor.Position = DM.AuthorView.Find(anAuthorID);
                DataRow drAuthor = DM.dtAuthor.Rows[cmAuthor.Position];
                txtAuthorLastName.Text = drAuthor["LastName"].ToString();
                txtAuthorFirstName.Text = drAuthor["FirstName"].ToString();
            }
        }

        private void txtUpdateAuthorID_TextChanged(object sender, EventArgs e)
        {
            if (txtUpdateAuthorID.Text == "")
            {
                txtUpdateAuthorLastName.Text = "";
                txtUpdateAuthorFirstName.Text = "";
            }
            else
            {
                int anAuthorID = Convert.ToInt32(txtUpdateAuthorID.Text);
                cmAuthor.Position = DM.AuthorView.Find(anAuthorID);
                DataRow drAuthor = DM.dtAuthor.Rows[cmAuthor.Position];
                txtUpdateAuthorLastName.Text = drAuthor["LastName"].ToString();
                txtUpdateAuthorFirstName.Text = drAuthor["FirstName"].ToString();
            }
        }
    }
}
