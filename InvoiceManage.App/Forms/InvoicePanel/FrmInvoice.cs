using InvoiceManage.App.Forms.InvoicePanel.Controls;
using InvoiceManage.App.Resources.CustomToolBox;
using InvoiceManage.Database.Entities;
using System.ComponentModel;
using System.Windows.Forms;
using InvoiceManage.App.Services.CommonService;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.App.Services.InvoiceService;

namespace InvoiceManage.App.Forms.InvoicePanel
{
    public partial class FrmInvoice : Form
    {
        public Invoice Invoice { get; set; }
        private readonly FrmInvoiceType _frmInvoiceType;

        public FrmInvoice(Invoice? invoice = null)
        {
            InitializeComponent();

            Invoice = invoice ?? new Invoice { Items = new BindingList<InvoiceItem>() };

            _frmInvoiceType = invoice == null ? FrmInvoiceType.Add : FrmInvoiceType.Edit;

            IInvoiceService invoiceService = new InvoiceService();
            ICommonService commonService = new CommonService();

            PanelSlider.Controls.Add(new InvoiceStep(invoiceService));
            PanelSlider.Controls.Add(new CompanyStep(commonService));
            PanelSlider.Controls.Add(new CustomerStep(commonService));
            PanelSlider.Controls.Add(new ItemStep(commonService, invoiceService));
            PanelSlider.Controls.Add(new SumStep());
            PanelSlider.Controls.Add(new PayStep(_frmInvoiceType, invoiceService));

            if (_frmInvoiceType == FrmInvoiceType.Edit)
                ChangeModeGroupBoxes();
        }

        #region Events

        private void FrmInvoice_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsApi.ReleaseCapture();
            WindowsApi.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void FrmInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_frmInvoiceType == FrmInvoiceType.Add)
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

        public void ShowOptionalGroupBoxes(bool show)
        {
            foreach (Control step in PanelSlider.Controls)
                ShowOptionalGroupBoxesRecursive(step);

            void ShowOptionalGroupBoxesRecursive(Control step)
            {
                foreach (Control control in step.Controls)
                {
                    ShowOptionalGroupBoxesRecursive(control);

                    if (control is not CustomGroupBox groupBox)
                        continue;

                    groupBox.ShowOptional = show;
                }
            }
        }

        #endregion

        public void ShowSemiRequiredGroupBoxes(bool show)
        {
            foreach (Control step in PanelSlider.Controls)
                ShowSemiRequiredGroupBoxesRecursive(step);

            void ShowSemiRequiredGroupBoxesRecursive(Control step)
            {
                foreach (Control control in step.Controls)
                {
                    ShowSemiRequiredGroupBoxesRecursive(control);

                    if (control is not CustomGroupBox groupBox)
                        continue;

                    groupBox.ShowSemiRequired = show;

                    var newMode = groupBox.Name.GetMode((int)Invoice.Inty, (int)Invoice.Inp);

                    if (newMode is not null)
                        groupBox.Mode = newMode.Value;
                }
            }
        }

        public void ChangeModeGroupBoxes()
        {
            if ((int)Invoice.Inty <= 0 || (int)Invoice.Inp <= 0)
                return;

            foreach (Control step in PanelSlider.Controls)
                ChangeModeGroupBoxesRecursive(step);

            void ChangeModeGroupBoxesRecursive(Control step)
            {
                foreach (Control control in step.Controls)
                {
                    ChangeModeGroupBoxesRecursive(control);

                    if (control is not CustomGroupBox groupBox)
                        continue;

                    var newMode = groupBox.Name.GetMode((int)Invoice.Inty, (int)Invoice.Inp);

                    if (newMode is not null)
                        groupBox.Mode = newMode.Value;
                }
            }
        }
    }

    public enum FrmInvoiceType
    {
        Add = 1,
        Edit = 2
    }
}
