using System.Data.OleDb;
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
    public partial class DataModule : Form
    {
        public DataTable dtVendor;
        public DataTable dtClient;
        public DataTable dtBookInfo;
        public DataTable dtBook;
        public DataTable dtClientOrder;
        public DataTable dtCountry;
        public DataTable dtAuthor;

        public DataView VendorView;
        public DataView ClientView;
        public DataView BookInfoView;
        public DataView BookView;
        public DataView ClientOrderView;
        public DataView CountryView;
        public DataView AuthorView;

        public DataModule()
        {
            InitializeComponent();
            dsBookBrokers.EnforceConstraints = false;
            daVendor.Fill(dsBookBrokers);
            daClient.Fill(dsBookBrokers);
            daBookInfo.Fill(dsBookBrokers);
            daBook.Fill(dsBookBrokers);
            daClientOrder.Fill(dsBookBrokers);
            daCountry.Fill(dsBookBrokers);
            daAuthor.Fill(dsBookBrokers);

            dtVendor = dsBookBrokers.Tables["Vendor"];
            dtClient = dsBookBrokers.Tables["Client"];
            dtBookInfo = dsBookBrokers.Tables["BookInfo"];
            dtBook = dsBookBrokers.Tables["Book"];
            dtClientOrder = dsBookBrokers.Tables["ClientOrder"];
            dtCountry = dsBookBrokers.Tables["Country"];
            dtAuthor = dsBookBrokers.Tables["Author"];

            VendorView = new DataView(dtVendor);
            VendorView.Sort = "VendorID";
            ClientView = new DataView(dtClient);
            ClientView.Sort = "ClientID";
            BookInfoView = new DataView(dtBookInfo);
            BookInfoView.Sort = "BookInfoID";
            BookView = new DataView(dtBook);
            BookView.Sort = "BookID";
            ClientOrderView = new DataView(dtClientOrder);
            ClientOrderView.Sort = "ClientOrderID";
            CountryView = new DataView(dtCountry);
            CountryView.Sort = "CountryID";
            AuthorView = new DataView(dtAuthor);
            AuthorView.Sort = "AuthorID";
            dsBookBrokers.EnforceConstraints = true;
        }
        public void UpdateVendor()
        {
            daVendor.Update(dtVendor);
        }
        private void daVendor_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["VendorID"] = newID;
            }
        }

        public void UpdateClient()
        {
            daClient.Update(dtClient);
        }
        private void daClient_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ClientID"] = newID;
            }
        }

        public void UpdateClientOrder()
        {
            daClientOrder.Update(dtClientOrder);
        }
        private void daClientOrder_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ClientOrderID"] = newID;
            }
        }

        public void UpdateBookInfo()
        {
            daBookInfo.Update(dtBookInfo);
        }
        private void daBookInfo_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["BookInfoID"] = newID;
            }
        }

        public void UpdateBook()
        {
            daBook.Update(dtBook);
        }
        private void daBook_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["BookID"] = newID;
            }
        }
    }
}
