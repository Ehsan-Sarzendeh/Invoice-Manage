using System;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms
{
    public partial class FrmInvoiceList : Form
    {
        public FrmInvoiceList()
        {
            InitializeComponent();
        }

        private void DeleteInvoiceBtn_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceItemsBtn_Click(object sender, EventArgs e)
        {

        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {

        }

        private void FrmInvoiceList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmMain.Show();
        }
    }
}
