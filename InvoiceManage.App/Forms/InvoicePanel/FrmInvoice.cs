using System.Windows.Forms;
using InvoiceManage.App.Forms.InvoicePanel.Controls;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Forms.InvoicePanel
{
    public partial class FrmInvoice : Form
    {
        public FrmInvoiceType Type { get; set; }

        public Invoice Invoice { get; set; }

        public bool ShowSemiRequired { get; set; }
        public bool ShowOptional { get; set; }

        public FrmInvoice(FrmInvoiceType type)
        {
            InitializeComponent();

            Type = type;

            Invoice = new Invoice();

            PanelSlider.Controls.Add(new InvoiceStep());
            PanelSlider.Controls.Add(new SellerStep());
            PanelSlider.Controls.Add(new BuyerStep());
            PanelSlider.Controls.Add(new ItemStep());
            PanelSlider.Controls.Add(new SumStep());
            PanelSlider.Controls.Add(new PayStep(type));
        }

        private void FrmAddInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmHome.Show();
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

    public enum FrmInvoiceType
    {
        Add = 1,
        Edit = 2
    }
}
