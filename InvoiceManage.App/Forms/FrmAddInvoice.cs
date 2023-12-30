using System.Windows.Forms;

namespace InvoiceManage.App.Forms
{
    public partial class FrmAddInvoice : Form
    {
        public FrmAddInvoice()
        {
            InitializeComponent();
        }

        private void FrmAddInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            var frmMain = new FrmMain();
            frmMain.Show();
        }
    }
}
