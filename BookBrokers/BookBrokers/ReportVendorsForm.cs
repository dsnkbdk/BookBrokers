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
    public partial class ReportVendorsForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfVendorsPrinted, pagesAmountExpected;
        private DataRow[] vendorsForPrint;

        public ReportVendorsForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        private void btnPrintVendors_Click(object sender, EventArgs e)
        {
            amountOfVendorsPrinted = 0;
            vendorsForPrint = DM.dtVendor.Select();
            pagesAmountExpected = vendorsForPrint.Length;
            prvVendors.Show();
        }

        private void printVendors_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 15, FontStyle.Regular);
            Font headingFont = new Font("Arial", 12, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Black);
            var format = new StringFormat() { Alignment = StringAlignment.Far };
            DataRow drVendor = vendorsForPrint[amountOfVendorsPrinted];
            CurrencyManager cmCountry;
            CurrencyManager cmBookInfo;
            CurrencyManager cmBook;
            CurrencyManager cmAuthor;

            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "COUNTRY"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];
            cmBook = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOK"];
            cmAuthor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "AUTHOR"];;

            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 5;

            //get the Country record matching the Country ID from the Vendor record
            int aCountryID = Convert.ToInt32(drVendor["CountryID"].ToString());
            cmCountry.Position = DM.CountryView.Find(aCountryID);
            DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];

            //heading
            g.DrawString("Vendor ID: " + drVendor["VendorID"],
                         headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            g.DrawString(drVendor["VendorName"] + "",
                         headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString("PO Box    " + drVendor["PostBoxNumber"],
                         headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drCountry["CountryName"] + "",
                         headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drVendor["Email"] + "",
                         headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            g.DrawString("Books:",
                         headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;

            DataRow[] drBooks = drVendor.GetChildRows(DM.dtVendor.ChildRelations["VENDOR_BOOK"]);
            if (drBooks.Length == 0)
            {
                g.DrawString("This vendor has no books at all",
                             headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            }
            else
            {
                int BookCount = 0;
                foreach (DataRow drVendorBook in drBooks)
                {
                    if (drVendorBook["ClientOrderID"] != DBNull.Value)
                    {
                        //get the BookInfo record matching the BookInfo ID from the Book record
                        int aBookInfoID = Convert.ToInt32(drVendorBook["BookInfoID"].ToString());
                        cmBookInfo.Position = DM.BookInfoView.Find(aBookInfoID);
                        DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];

                        //get the Author record matching the Author ID from the BookInfo record
                        int aAuthorID = Convert.ToInt32(drBookInfo["AuthorID"].ToString());
                        cmAuthor.Position = DM.BookInfoView.Find(aAuthorID);
                        DataRow drAuthor = DM.dtAuthor.Rows[cmAuthor.Position];

                        g.DrawString(drVendorBook["BookID"] + "",
                            headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                        g.DrawString(drBookInfo["Title"] + "",
                            headingFont, brush, leftMargin + headingLeftMargin + 50, topMargin + (linesSoFarHeading * textFont.Height));
                        g.DrawString("$" + Convert.ToDouble(drVendorBook["Cost"]).ToString("0.00") + "",
                            headingFont, brush, leftMargin + headingLeftMargin + 320, topMargin + (linesSoFarHeading * textFont.Height));
                        g.DrawString("$" + Convert.ToDouble(drVendorBook["Price"]).ToString("0.00") + "",
                            headingFont, brush, leftMargin + headingLeftMargin + 380, topMargin + (linesSoFarHeading * textFont.Height));
                        g.DrawString(Convert.ToDateTime(drVendorBook["DatePublished"]).ToString("d/M/yyyy") + "",
                            headingFont, brush, leftMargin + headingLeftMargin + 440, topMargin + (linesSoFarHeading * textFont.Height));
                        g.DrawString(drAuthor["LastName"] + "  " + drAuthor["FirstName"],
                            headingFont, brush, leftMargin + headingLeftMargin + 540, topMargin + (linesSoFarHeading * textFont.Height));
                        linesSoFarHeading++;
                        BookCount++;
                    }
                }
                if (BookCount == 0)
                {
                    g.DrawString("This vendor has no available books",
                            headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                }
            }
            amountOfVendorsPrinted++;
            if (!(amountOfVendorsPrinted == pagesAmountExpected))
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
