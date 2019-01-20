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
    public partial class ClientForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmCountry;

        public ClientForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddClient.Left = 250;
            pnlAddClient.Top = 12;
            pnlUpdateClient.Left = 250;
            pnlUpdateClient.Top = 12;
        }
        public void BindControls()
        {
            txtClientID.DataBindings.Add("Text", DM.dsBookBrokers, "Client.ClientID");
            txtLastName.DataBindings.Add("Text", DM.dsBookBrokers, "Client.LastName");
            txtFirstName.DataBindings.Add("Text", DM.dsBookBrokers, "Client.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsBookBrokers, "Client.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.dsBookBrokers, "Client.Suburb");
            txtCity.DataBindings.Add("Text", DM.dsBookBrokers, "Client.City");
            lblCountryID.DataBindings.Add("Text", DM.dsBookBrokers, "Client.CountryID");
            txtEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Client.Email");
            txtCreditStatus.DataBindings.Add("Text", DM.dsBookBrokers, "Client.CreditStatus");

            txtUpdateLastName.DataBindings.Add("Text", DM.dsBookBrokers, "Client.LastName");
            txtUpdateFirstName.DataBindings.Add("Text", DM.dsBookBrokers, "Client.FirstName");
            txtUpdateStreetAddress.DataBindings.Add("Text", DM.dsBookBrokers, "Client.StreetAddress");
            txtUpdateSuburb.DataBindings.Add("Text", DM.dsBookBrokers, "Client.Suburb");
            txtUpdateCity.DataBindings.Add("Text", DM.dsBookBrokers, "Client.City");
            cboUpdateCountryID.DataBindings.Add("Text", DM.dsBookBrokers, "Client.CountryID");
            txtUpdateEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Client.Email");
            cboUpdateCreditStatus.DataBindings.Add("Text", DM.dsBookBrokers, "Client.CreditStatus");

            txtClientID.Enabled = false;
            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtCity.Enabled = false;
            txtCountry.Enabled = false;
            txtEmail.Enabled = false;
            txtCreditStatus.Enabled = false;

            lstClients.DataSource = DM.dsBookBrokers;
            lstClients.DisplayMember = "Client.LastName";
            lstClients.ValueMember = "Client.LastName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENT"];
            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "COUNTRY"];
        }

        private void LoadCountrys()
        {
            cboAddCountryName.DataSource = DM.dsBookBrokers;
            cboAddCountryName.DisplayMember = "Country.CountryName";
            cboAddCountryName.ValueMember = "Country.CountryName";
            cboAddCountryID.DataSource = DM.dsBookBrokers;
            cboAddCountryID.DisplayMember = "Country.CountryID";
            cboAddCountryID.ValueMember = "Country.CountryID";

            cboUpdateCountryName.DataSource = DM.dsBookBrokers;
            cboUpdateCountryName.DisplayMember = "Country.CountryName";
            cboUpdateCountryName.ValueMember = "Client.CountryName";
            cboUpdateCountryID.DataSource = DM.dsBookBrokers;
            cboUpdateCountryID.DisplayMember = "Country.CountryID";
            cboUpdateCountryID.ValueMember = "Client.CountryID";
        }
        private void ClientForm_Load(object sender, EventArgs e)
        {

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

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            pnlAddClient.Show();
            lstClients.Enabled = false;
            lstClients.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateClient.Enabled = false;
            btnDeleteClient.Enabled = false;
            btnReturn.Enabled = false;
            LoadCountrys();
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddClient.Hide();
            lstClients.Enabled = true;
            lstClients.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateClient.Enabled = true;
            btnDeleteClient.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            txtClientID.Text = null;
            DataRow newClientRow = DM.dtClient.NewRow();
            if ((txtAddLastName.Text == "") || (txtAddFirstName.Text == "") || (txtAddStreetAddress.Text == "") ||
                (txtAddSuburb.Text == "") || (txtAddCity.Text == "") || (cboAddCountryID.Text == "") ||
                (txtAddEmail.Text == "") || (cboAddCreditStatus.Text == ""))
            {
                MessageBox.Show("You must enter valid data for all fields", "Error");
            }
            else
            {
                newClientRow["LastName"] = txtAddLastName.Text;
                newClientRow["FirstName"] = txtAddFirstName.Text;
                newClientRow["StreetAddress"] = txtAddStreetAddress.Text;
                newClientRow["Suburb"] = txtAddSuburb.Text;
                newClientRow["City"] = txtAddCity.Text;
                newClientRow["CountryID"] = cboAddCountryID.Text;
                newClientRow["Email"] = txtAddEmail.Text;
                newClientRow["CreditStatus"] = cboAddCreditStatus.Text;
                DM.dtClient.Rows.Add(newClientRow);
                DM.UpdateClient();
                MessageBox.Show("Client added successfully", "Success");
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            pnlUpdateClient.Show();
            lstClients.Enabled = false;
            lstClients.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddClient.Enabled = false;
            btnDeleteClient.Enabled = false;
            btnReturn.Enabled = false;
            LoadCountrys();
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateClient.Hide();
            lstClients.Enabled = true;
            lstClients.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddClient.Enabled = true;
            btnDeleteClient.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateClientRow = DM.dtClient.Rows[currencyManager.Position];
            if ((txtUpdateLastName.Text == "") || (txtUpdateFirstName.Text == "") || (txtUpdateStreetAddress.Text == "") ||
                (txtUpdateSuburb.Text == "") || (txtUpdateCity.Text == "") || (cboUpdateCountryID.Text == "") ||
                (txtUpdateEmail.Text == "") || (cboUpdateCreditStatus.Text == ""))
            {
                MessageBox.Show("You must enter valid data for all fields", "Error");
            }
            else
            {
                updateClientRow["LastName"] = txtUpdateLastName.Text;
                updateClientRow["FirstName"] = txtUpdateFirstName.Text;
                updateClientRow["StreetAddress"] = txtUpdateStreetAddress.Text;
                updateClientRow["Suburb"] = txtUpdateSuburb.Text;
                updateClientRow["City"] = txtUpdateCity.Text;
                updateClientRow["CountryID"] = cboUpdateCountryID.Text;
                updateClientRow["Email"] = txtUpdateEmail.Text;
                updateClientRow["CreditStatus"] = cboUpdateCreditStatus.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateClient();
                MessageBox.Show("Client updated successfully", "Success");
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            DataRow deleteClientRow = DM.dtClient.Rows[currencyManager.Position];
            DataRow[] ClientOrderRow = DM.dtClientOrder.Select("ClientID = " + txtClientID.Text);
            if (ClientOrderRow.Length != 0)
            {
                MessageBox.Show("You may only delete client who have no client orders", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this client?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteClientRow.Delete();
                    DM.UpdateClient();
                    MessageBox.Show("Client deleted successfully", "Success");
                }
            }
        }
        private void lblCountryID_TextChanged(object sender, EventArgs e)
        {
            if (lblCountryID.Text == "CountryID:")
            {
                txtCountry.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(lblCountryID.Text);
                cmCountry.Position = DM.CountryView.Find(aCountryID);
                DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];
                txtCountry.Text = drCountry["CountryName"].ToString();
            }
        }
    }
}
