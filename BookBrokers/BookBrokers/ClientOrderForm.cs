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
    public partial class ClientOrderForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmClient;

        public ClientOrderForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddClientOrder.Left = 200;
            pnlAddClientOrder.Top = 25;
            pnlUpdateClientOrder.Left = 200;
            pnlUpdateClientOrder.Top = 10;
        }
        public void BindControls()
        {
            txtClientOrderID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientOrderID");
            txtClientOrderDate.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.OrderDate", true);
            txtClientID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientID");
            txtStatus.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.Status");

            txtUpdateClientOrderID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientOrderID");
            dtpUpdateClientOrderDate.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.OrderDate");
            txtUpdateStatus.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.Status");
            txtUpdateClientID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientID");

            txtClientOrderID.Enabled = false;
            txtClientOrderDate.Enabled = false;
            txtClientID.Enabled = false;
            txtClientLastName.Enabled = false;
            txtClientFirstName.Enabled = false;
            txtStatus.Enabled = false;

            txtUpdateClientOrderID.Enabled = false;
            txtUpdateStatus.Enabled = false;
            txtUpdateClientID.Enabled = false;
            txtUpdateClientLastName.Enabled = false;
            txtUpdateClientFirstName.Enabled = false;

            lstClientOrderID.DataSource = DM.dsBookBrokers;
            lstClientOrderID.DisplayMember = "ClientOrder.ClientOrderID";
            lstClientOrderID.ValueMember = "ClientOrder.ClientOrderID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENTORDER"];
            cmClient = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENT"];
        }

        private void LoadClients()
        {
            cboAddClientID.DataSource = DM.dsBookBrokers;
            cboAddClientID.DisplayMember = "Client.ClientID";
            cboAddClientID.ValueMember = "Client.ClientID";
            cboAddClientLastName.DataSource = DM.dsBookBrokers;
            cboAddClientLastName.DisplayMember = "Client.LastName";
            cboAddClientLastName.ValueMember = "Client.LastName";
            cboAddClientFirstName.DataSource = DM.dsBookBrokers;
            cboAddClientFirstName.DisplayMember = "Client.FirstName";
            cboAddClientFirstName.ValueMember = "Client.FirstName";
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

        private void btnAddClientOrder_Click(object sender, EventArgs e)
        {
            pnlAddClientOrder.Show();
            lstClientOrderID.Enabled = false;
            lstClientOrderID.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateClientOrder.Enabled = false;
            btnDeleteClientOrder.Enabled = false;
            btnMarkClientOrderasShipped.Enabled = false;
            btnMarkClientOrderasPaid.Enabled = false;
            LoadClients();
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddClientOrder.Hide();
            lstClientOrderID.Enabled = true;
            lstClientOrderID.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnUpdateClientOrder.Enabled = true;
            btnDeleteClientOrder.Enabled = true;
            btnMarkClientOrderasShipped.Enabled = true;
            btnMarkClientOrderasPaid.Enabled = true;
        }

        private void btnSaveClientOrder_Click(object sender, EventArgs e)
        {
            txtClientOrderID.Text = null;
            DataRow newClientOrderRow = DM.dtClientOrder.NewRow();
            if ((dtpAddClientOrderDate.Text == "") || (cboAddClientID.Text == "") ||
                (cboAddClientLastName.Text == "") || (cboAddClientFirstName.Text == ""))
            {
                MessageBox.Show("You must enter valid data for all fields", "Error");
            }
            else
            {
                newClientOrderRow["OrderDate"] = dtpAddClientOrderDate.Text;
                newClientOrderRow["ClientID"] = cboAddClientID.Text;
                newClientOrderRow["Status"] = "Current";
                DM.dtClientOrder.Rows.Add(newClientOrderRow);
                DM.UpdateClientOrder();
                MessageBox.Show("Client order added successfully", "Success");
            }
        }

        private void btnUpdateClientOrder_Click(object sender, EventArgs e)
        {
            pnlUpdateClientOrder.Show();
            lstClientOrderID.Enabled = false;
            lstClientOrderID.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnReturn.Enabled = false;
            btnAddClientOrder.Enabled = false;
            btnDeleteClientOrder.Enabled = false;
            btnMarkClientOrderasShipped.Enabled = false;
            btnMarkClientOrderasPaid.Enabled = false;
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateClientOrder.Hide();
            lstClientOrderID.Enabled = true;
            lstClientOrderID.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnAddClientOrder.Enabled = true;
            btnDeleteClientOrder.Enabled = true;
            btnMarkClientOrderasShipped.Enabled = true;
            btnMarkClientOrderasPaid.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            if (dtpUpdateClientOrderDate.Text == "")
            {
                MessageBox.Show("You must enter valid data for all fields", "Error");
            }
            else
            {
                updateClientOrderRow["OrderDate"] = dtpUpdateClientOrderDate.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateClientOrder();
                MessageBox.Show("Client order updated successfully", "Success");
            }
        }

        private void btnDeleteClientOrder_Click(object sender, EventArgs e)
        {
            DataRow deleteClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            DataRow[] BookRow = DM.dtBook.Select("ClientOrderID = " + txtClientOrderID.Text);
            if (BookRow.Length != 0)
            {
                MessageBox.Show("You may only delete a client order that has no books", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this client order ?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteClientOrderRow.Delete();
                    DM.UpdateClientOrder();
                    MessageBox.Show("Client order deleted successfully", "Success");
                }
            }
        }

        private void txtClientID_TextChanged(object sender, EventArgs e)
        {
            if (txtClientID.Text == "")
            {
                txtClientLastName.Text = "";
                txtClientFirstName.Text = "";
            }
            else
            {
                int aClientID = Convert.ToInt32(txtClientID.Text);
                cmClient.Position = DM.ClientView.Find(aClientID);
                DataRow drClient = DM.dtClient.Rows[cmClient.Position];
                txtClientLastName.Text = drClient["LastName"].ToString();
                txtClientFirstName.Text = drClient["FirstName"].ToString();
            }
        }

        private void txtUpdateClientID_TextChanged(object sender, EventArgs e)
        {
            if (txtUpdateClientID.Text == "")
            {
                txtUpdateClientLastName.Text = "";
                txtUpdateClientFirstName.Text = "";
            }
            else
            {
                int aClientID = Convert.ToInt32(txtUpdateClientID.Text);
                cmClient.Position = DM.ClientView.Find(aClientID);
                DataRow drClient = DM.dtClient.Rows[cmClient.Position];
                txtUpdateClientLastName.Text = drClient["LastName"].ToString();
                txtUpdateClientFirstName.Text = drClient["FirstName"].ToString();
            }
        }

        private void btnMarkClientOrderasShipped_Click(object sender, EventArgs e)
        {
            DataRow updateClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            if (txtStatus.Text == "Shipped" || txtStatus.Text == "Paid")
            {
                MessageBox.Show("Only current client orders can be marked as shipped", "Error");
            }
            else
            {
                updateClientOrderRow["Status"] = "Shipped";
                currencyManager.EndCurrentEdit();
                DM.UpdateClientOrder();
                MessageBox.Show("Client Order marked as shipped", "Success");
            }
        }

        private void btnMarkClientOrderasPaid_Click(object sender, EventArgs e)
        {
            DataRow updateClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            if (txtStatus.Text == "Current" || txtStatus.Text == "Paid")
            {
                MessageBox.Show("Only shipped client orders can be marked as paid", "Error");
            }
            else
            {
                updateClientOrderRow["Status"] = "Paid";
                currencyManager.EndCurrentEdit();
                DM.UpdateClientOrder();
                MessageBox.Show("Client Order marked as paid", "Success");
            }
        }
    }
}
