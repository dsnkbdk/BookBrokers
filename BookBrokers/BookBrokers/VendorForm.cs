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
    public partial class VendorForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmCountry;

        public VendorForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddVendor.Left = 320;
            pnlAddVendor.Top = 27;
            pnlUpdateVendor.Left = 320;
            pnlUpdateVendor.Top = 27;
        }
        public void BindControls()
        {
            txtVendorID.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorID");
            txtVendorName.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorName");
            txtPostBoxNumber.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.PostBoxNumber");
            lblCountryID.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.CountryID");
            txtEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.Email");

            txtUpdateVendorID.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorID");
            txtUpdateVendorName.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorName");
            txtUpdatePostBoxNumber.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.PostBoxNumber");
            cboUpdateCountryID.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.CountryID");
            txtUpdateEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.Email");

            txtVendorID.Enabled = false;
            txtVendorName.Enabled = false;
            txtPostBoxNumber.Enabled = false;
            txtCountry.Enabled = false;
            txtEmail.Enabled = false;

            txtUpdateVendorID.Enabled = false;
            cboUpdateCountryID.Enabled = false;
            cboUpdateCountryName.Enabled = false;

            lstVendors.DataSource = DM.dsBookBrokers;
            lstVendors.DisplayMember = "Vendor.VendorName";
            lstVendors.ValueMember = "Vendor.VendorName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "VENDOR"];
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
            cboUpdateCountryName.ValueMember = "Country.CountryName";
            cboUpdateCountryID.DataSource = DM.dsBookBrokers;
            cboUpdateCountryID.DisplayMember = "Vendor.CountryID";
            cboUpdateCountryID.ValueMember = "Vendor.CountryID";
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddVendor.Hide();
            lstVendors.Enabled = true;
            lstVendors.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateVendor.Enabled = true;
            btnDeleteVendor.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            pnlAddVendor.Show();
            lstVendors.Enabled = false;
            lstVendors.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateVendor.Enabled = false;
            btnDeleteVendor.Enabled = false;
            btnReturn.Enabled = false;
            LoadCountrys();
        }

        private void btnSaveVendor_Click(object sender, EventArgs e)
        {
            txtVendorID.Text = null;
            DataRow newVendorRow = DM.dtVendor.NewRow();
            if ((txtAddVendorName.Text == "") || (txtAddPostBoxNumber.Text == "") || 
                (cboAddCountryID.Text == "") || (txtAddEmail.Text == ""))
            {
                MessageBox.Show("You must enter valid data for all fields", "Error");
            }
            else
            {
                newVendorRow["VendorName"] = txtAddVendorName.Text;
                newVendorRow["PostBoxNumber"] = txtAddPostBoxNumber.Text;
                newVendorRow["CountryID"] = cboAddCountryID.Text;
                newVendorRow["Email"] = txtAddEmail.Text;
                DM.dtVendor.Rows.Add(newVendorRow);
                DM.UpdateVendor();
                MessageBox.Show("Vendor added successfully", "Success");
            }
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateVendor.Hide();
            lstVendors.Enabled = true;
            lstVendors.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddVendor.Enabled = true;
            btnDeleteVendor.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateVendorRow = DM.dtVendor.Rows[currencyManager.Position];
            if ((txtUpdateVendorName.Text == "") || (txtUpdatePostBoxNumber.Text == "") || (txtUpdateEmail.Text == ""))
            {
                MessageBox.Show("You must enter valid data for all fields", "Error");
            }
            else
            {
                updateVendorRow["VendorName"] = txtUpdateVendorName.Text;
                updateVendorRow["PostBoxNumber"] = txtUpdatePostBoxNumber.Text;
                updateVendorRow["Email"] = txtUpdateEmail.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateVendor();
                MessageBox.Show("Vendor updated successfully", "Success");
            }
        }

        private void btnUpdateVendor_Click(object sender, EventArgs e)
        {
            pnlUpdateVendor.Show();
            lstVendors.Enabled = false;
            lstVendors.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddVendor.Enabled = false;
            btnDeleteVendor.Enabled = false;
            btnReturn.Enabled = false;
            LoadCountrys();
        }

        private void btnDeleteVendor_Click(object sender, EventArgs e)
        {
            DataRow deleteVendorRow = DM.dtVendor.Rows[currencyManager.Position];
            DataRow[] BookRow = DM.dtBook.Select("VendorID = " + txtVendorID.Text);
            if (BookRow.Length != 0)
            {
                MessageBox.Show("You may only delete vendors that have no books", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this Vendor?", "Warning", 
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVendorRow.Delete();
                    DM.UpdateVendor();
                    MessageBox.Show("Vendor deleted successfully", "Success");
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
