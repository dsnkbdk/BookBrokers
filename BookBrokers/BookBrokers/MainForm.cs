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
    public partial class MainForm : Form
    {
        private DataModule DM;
        private VendorForm frmVendor;
        private ClientForm frmClient;
        private BookInfoForm frmBookInfo;
        private BookForm frmBook;
        private ClientOrderForm frmClientOrder;
        private ClientOrderBookForm frmClientOrderBook;
        private InvoiceForm frmInvoice;
        private ReportVendorsForm frmReportVendors;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }

        private void btnVendorMaintenance_Click(object sender, EventArgs e)
        {
            if (frmVendor == null)
            {
                frmVendor = new VendorForm(DM, this);
            }
            frmVendor.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClientMaintenance_Click(object sender, EventArgs e)
        {
            if (frmClient == null)
            {
                frmClient = new ClientForm(DM, this);
            }
            frmClient.ShowDialog();
        }

        private void btnBookInfoMaintenance_Click(object sender, EventArgs e)
        {
            if (frmBookInfo == null)
            {
                frmBookInfo = new BookInfoForm(DM, this);
            }
            frmBookInfo.ShowDialog();
        }

        private void btnBookMaintenance_Click(object sender, EventArgs e)
        {
            if (frmBook == null)
            {
                frmBook = new BookForm(DM, this);
            }
            frmBook.ShowDialog();
        }

        private void btnClientOrderMaintenance_Click(object sender, EventArgs e)
        {
            if (frmClientOrder == null)
            {
                frmClientOrder = new ClientOrderForm(DM, this);
            }
            frmClientOrder.ShowDialog();
        }

        private void btnAddBooktoaClientOrder_Click(object sender, EventArgs e)
        {
            if (frmClientOrderBook == null)
            {
                frmClientOrderBook = new ClientOrderBookForm(DM, this);
            }
            frmClientOrderBook.ShowDialog();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoice == null)
            {
                frmInvoice = new InvoiceForm(DM, this);
            }
            frmInvoice.ShowDialog();
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            if (frmReportVendors == null)
            {
                frmReportVendors = new ReportVendorsForm(DM, this);
            }
            frmReportVendors.ShowDialog();
        }
    }
}
