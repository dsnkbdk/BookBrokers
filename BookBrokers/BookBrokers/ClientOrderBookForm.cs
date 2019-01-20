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
    public partial class ClientOrderBookForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmClientOrder;
        private CurrencyManager cmClientBook;
        private CurrencyManager cmClient;
        private CurrencyManager cmBookInfo;
        private CurrencyManager cmBook;

        public ClientOrderBookForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmClientOrder = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "ClientOrder"];
            cmClientBook = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "ClientOrder.ClientOrder_Book"];
            cmClient = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Client"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BookInfo"];
            cmBook = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Book"];
            BindControls();
        }
        public void BindControls()
        {
            dgvClientOrder.DataSource = DM.dsBookBrokers;
            dgvClientOrder.DataMember = "ClientOrder";

            dgvClientBook.DataSource = DM.dsBookBrokers;
            dgvClientBook.DataMember = "ClientOrder.ClientOrder_Book";

            DM.BookView.RowFilter = "ClientOrderID is NULL";
            dgvBookNullClientOrderID.DataSource = DM.BookView;
            dgvBookNullClientOrderID.Columns["ClientOrderID"].Visible = false;

            lblClientID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientID");
            lblBookInfoID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientOrder_Book.BookInfoID");
            lblBookInfoID2.DataBindings.Add("Text", DM.BookView, "BookInfoID");
            lblBookID.DataBindings.Add("Text", DM.BookView, "BookID");

            txtClientLastName.Enabled = false;
            txtClientFirstName.Enabled = false;
            txtTitle.Enabled = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (DM.dtClientOrder.Rows[cmClientOrder.Position]["Status"].ToString() == "Current")
            {
                string BookID = lblBookID.Text;
                string BookInfoID = lblBookInfoID2.Text;
                int row = 0;
                for (int i = 0; i < DM.dtBook.Rows.Count; i++)
                {
                    string bID = DM.dtBook.Rows[i]["BookID"].ToString();
                    string biID = DM.dtBook.Rows[i]["BookInfoID"].ToString();
                    if (BookID == bID && BookInfoID == biID)
                    {
                        row = i;
                    }
                }

                DataRow updateBookRow = DM.dtBook.Rows[row];
                updateBookRow["ClientOrderID"] = dgvClientOrder["ClientOrderID", cmClientOrder.Position].Value;
                cmBook.EndCurrentEdit();
                DM.UpdateBook();
            }
            else
            {
                MessageBox.Show("Books can only be added to current orders", "Error");
            }
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (DM.dtClientOrder.Rows[cmClientOrder.Position]["Status"].ToString() == "Current")
            {
                string BookID = dgvClientBook.Rows[cmClientBook.Position].Cells[0].Value.ToString();
                string ClientOrderID = dgvClientBook.Rows[cmClientBook.Position].Cells[6].Value.ToString();
                int row = 0;
                for (int i = 0; i < DM.dtBook.Rows.Count; i++)
                {
                    string bID = DM.dtBook.Rows[i]["BookID"].ToString();
                    string cID = DM.dtBook.Rows[i]["ClientOrderID"].ToString();

                    if (BookID == bID && ClientOrderID == cID)
                    {
                        row = i;
                    }
                }

                DataRow deleteBookRow = DM.dtBook.Rows[row];
                deleteBookRow["ClientOrderID"] = DBNull.Value;
                cmBook.EndCurrentEdit();
                DM.UpdateBook();
            }
            else
            {
                MessageBox.Show("Books can only be removed from current orders", "Error");
            }
        }

        private void lblClientID_TextChanged(object sender, EventArgs e)
        {
            if (lblClientID.Text == "")
            {
                txtClientLastName.Text = "";
                txtClientFirstName.Text = "";
            }
            else
            {
                int aClientID = Convert.ToInt32(lblClientID.Text);
                cmClient.Position = DM.ClientView.Find(aClientID);
                DataRow drClient = DM.dtClient.Rows[cmClient.Position];
                txtClientLastName.Text = drClient["LastName"].ToString();
                txtClientFirstName.Text = drClient["FirstName"].ToString();
            }
        }

        private void lblBookInfoID_TextChanged(object sender, EventArgs e)
        {
            if (lblBookInfoID.Text == "")
            {
                txtTitle.Text = "";
            }
            else
            {
                int aBookInfoID = Convert.ToInt32(lblBookInfoID.Text);
                cmBookInfo.Position = DM.BookInfoView.Find(aBookInfoID);
                DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];
                txtTitle.Text = drBookInfo["Title"].ToString();
            }
        }

        private void lblBookInfoID2_TextChanged(object sender, EventArgs e)
        {
            if (lblBookInfoID2.Text == "")
            {
                txtTitle.Text = "";
            }
            else
            {
                int aBookInfoID = Convert.ToInt32(lblBookInfoID2.Text);
                cmBookInfo.Position = DM.BookInfoView.Find(aBookInfoID);
                DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];
                txtTitle.Text = drBookInfo["Title"].ToString();
            }
        }
    }
}
