using System.Windows.Forms;
using InvoiceManage.App.Forms.Invoice.Controls;
using InvoiceManage.App.Services.Infrastructures;

namespace InvoiceManage.App.Forms.Invoice
{
    public partial class FrmInvoice : Form
    {
        public FrmInvoice()
        {
            InitializeComponent();

            PanelSlider.Controls.Add(new InvoiceStep());
            PanelSlider.Controls.Add(new SellerStep());
            PanelSlider.Controls.Add(new BuyerStep());
            PanelSlider.Controls.Add(new ItemStep());
            PanelSlider.Controls.Add(new SumStep());
            PanelSlider.Controls.Add(new PayStep());
        }

        private void FrmAddInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmMain.Show();
        }

        private void FrmAddInvoice_Load(object sender, System.EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void BtnMinimize_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmAddInvoice_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsApi.ReleaseCapture();
            WindowsApi.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
                SendKeys.Send("{TAB}");
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
