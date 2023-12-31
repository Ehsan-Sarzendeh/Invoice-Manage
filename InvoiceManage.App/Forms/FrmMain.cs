using System.Windows.Forms;
using InvoiceManage.App.Services.Infrastructures;

namespace InvoiceManage.App.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
                SendKeys.Send("{TAB}");
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsApi.ReleaseCapture();
            WindowsApi.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AddInvoice_Click(object sender, System.EventArgs e)
        {
            var frmAddInvoice = new FrmInvoice();
            frmAddInvoice.Show();
            Hide();
        }

        private void InvoiceList_Click(object sender, System.EventArgs e)
        {
            var frmInvoiceList = new FrmInvoiceList();
            frmInvoiceList.Show();
            Hide();
        }

        private void Settings_Click(object sender, System.EventArgs e)
        {
            var frmSettings = new FrmSettings();
            frmSettings.Show();
            Hide();
        }
    }
}
