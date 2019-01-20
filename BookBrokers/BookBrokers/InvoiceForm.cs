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
    public partial class InvoiceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfInvoicesPrinted, pagesAmountExpected;
        private DataRow[] invoicesForPrint;

        public InvoiceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        private void btnPrintInvoices_Click(object sender, EventArgs e)
        {
            amountOfInvoicesPrinted = 0;
            string strFilter = "Status = 'Shipped'";
            string strSort = "ClientOrderID";
            invoicesForPrint = DM.dsBookBrokers.Tables["CLIENTORDER"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = invoicesForPrint.Length;
            prvInvoices.Show();
        }

        private void printInvoices_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 20, FontStyle.Regular);
            Font headingFont = new Font("Arial", 15, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Black);
            var format = new StringFormat() { Alignment = StringAlignment.Far };
            DataRow drClientOrder = invoicesForPrint[amountOfInvoicesPrinted];
            CurrencyManager cmClient;
            CurrencyManager cmCountry;
            CurrencyManager cmBookInfo;
            CurrencyManager cmBook;
            double ClientOrderTotal = 0;

            cmClient = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENT"];
            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "COUNTRY"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];
            cmBook = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOK"];

            //margins
            int leftMargin = e.MarginBounds.Left;
            int rightMargin = e.MarginBounds.Right;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 30;
            
            //get the Client record matching the Client ID from the ClientOrder record
            int aClientID = Convert.ToInt32(drClientOrder["ClientID"].ToString());
            cmClient.Position = DM.ClientView.Find(aClientID);
            DataRow drClient = DM.dtClient.Rows[cmClient.Position];

            //get the Country record matching the Country ID from the Client record
            int aCountryID = Convert.ToInt32(drClient["CountryID"].ToString());
            cmCountry.Position = DM.CountryView.Find(aCountryID);
            DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];

            //heading
            g.DrawString("Client ID:  " + drClient["ClientID"],
                         headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            g.DrawString(drClient["LastName"] + " " + drClient["FirstName"],
                         headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drClient["StreetAddress"] + "",
                         headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drClient["Suburb"] + "",
                         headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drClient["City"] + "",
                         headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drCountry["CountryName"] + "",
                         headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            g.DrawString("Client Order ID:  " + drClientOrder["ClientOrderID"] + "      " + "Date:  " +
                         Convert.ToDateTime(drClientOrder["OrderDate"]).ToString("d/M/yyyy"),
                         headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            g.DrawString("Books:",
                         headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;

            DataRow[] drBooks = drClientOrder.GetChildRows(DM.dtClientOrder.ChildRelations["CLIENTORDER_BOOK"]);
            if (drBooks.Length == 0)
            {
                g.DrawString("This client has no books",
                             headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            }
            else
            {
                foreach (DataRow drClientOrderBook in drBooks)
                {
                    //get the BookInfo record matching the BookInfo ID from the Book record
                    int aBookInfoID = Convert.ToInt32(drClientOrderBook["BookInfoID"].ToString());
                    cmBookInfo.Position = DM.BookInfoView.Find(aBookInfoID);
                    DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];

                    double bookPrice;
                    bookPrice = Convert.ToDouble(drClientOrderBook["Price"]);
                    ClientOrderTotal += bookPrice;

                    g.DrawString(drClientOrderBook["BookID"] + "    " + drBookInfo["Title"],
                                 headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString("$" + Convert.ToDouble(drClientOrderBook["Price"]).ToString("0.00"),
                                 headingFont, brush, rightMargin-30, topMargin + (linesSoFarHeading * textFont.Height), format);
                    linesSoFarHeading++;
                    linesSoFarHeading++;
                }
                g.DrawString("Total:  " + Convert.ToDouble(ClientOrderTotal).ToString("0.00"),
                             headingFont, brush, rightMargin - 30, topMargin + (linesSoFarHeading * textFont.Height), format);
                linesSoFarHeading++;
                linesSoFarHeading++;
                linesSoFarHeading++;
            }

            ClientOrderTotal = 0;
            amountOfInvoicesPrinted++;

            if (!(amountOfInvoicesPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
