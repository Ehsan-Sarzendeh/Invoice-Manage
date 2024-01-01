using System.Windows.Forms;
using InvoiceManage.App.Forms.InvoicePanel.Controls;
using InvoiceManage.App.Resources.CustomToolBox;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Forms.InvoicePanel
{
    public partial class FrmInvoice : Form
    {
        public Invoice Invoice { get; set; }

        public bool ShowSemiRequired { get; set; }
        public bool ShowOptional { get; set; }

        public FrmInvoice(Invoice? invoice = null)
        {
            InitializeComponent();

            Invoice = invoice ?? new Invoice();
            
            var frmInvoiceType = invoice == null ? FrmInvoiceType.Add : FrmInvoiceType.Edit;

            PanelSlider.Controls.Add(new InvoiceStep());
            PanelSlider.Controls.Add(new SellerStep());
            PanelSlider.Controls.Add(new BuyerStep());
            PanelSlider.Controls.Add(new ItemStep());
            PanelSlider.Controls.Add(new SumStep());
            PanelSlider.Controls.Add(new PayStep(frmInvoiceType));
        }

        public void ShowOptionalGroupBoxes(bool show)
        {
            foreach (Control step in PanelSlider.Controls)
            {
                foreach (var control in step.Controls)
                {
                    if (control is not CustomGroupBox groupBox)
                        continue;

                    groupBox.ShowOptional = show;
                }
            }
        }

        public void ShowSemiRequiredGroupBoxes(bool show)
        {
            foreach (Control step in PanelSlider.Controls)
            {
                foreach (var control in step.Controls)
                {
                    if (control is not CustomGroupBox groupBox)
                        continue;

                    groupBox.ShowSemiRequired = show;
                }
            }
        }

        public void ChangeModeGroupBoxes()
        {
            if ((int)Invoice.Inty <= 0 || (int)Invoice.Inp <= 0)
                return;

            foreach (Control step in PanelSlider.Controls)
            {
                foreach (var control in step.Controls)
                {
                    if (control is not CustomGroupBox groupBox)
                        continue;

                    var newMode = groupBox.Name.GetMode((int)Invoice.Inty, (int)Invoice.Inp);

                    if (newMode is not null)
                        groupBox.Mode = newMode.Value;
                }
            }
        }

        private void FrmAddInvoice_Load(object sender, System.EventArgs e)
        {
            Program.FrmHome.Show();
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
