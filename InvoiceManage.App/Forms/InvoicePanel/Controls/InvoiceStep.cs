using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.App.Services.InvoiceService;
using InvoiceManage.Database.Entities;
using System;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class InvoiceStep : UserControl
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceStep(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
            InitializeComponent();
            SetComboBoxDataSource();
        }
        
        private void SetComboBoxDataSource()
        {
            CbInty.SetEnumDataSource(typeof(Inty));
            CbInp.SetEnumDataSource(typeof(Inp));
            CbIns.SetEnumDataSource(typeof(Ins));
            CbTob.SetEnumDataSource(typeof(Tob));
        }

        #region Events

        private void InvoiceStep_Load(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            this.SetDataBindings(parentForm!.Invoice);
            this.SetNumberFormat(parentForm.Invoice);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            new Step().Next(ParentForm!, "InvoiceStep", "CompanyStep", "CompanyStep");
        }

        private void CbInty_SelectedIndexChanged(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            parentForm?.ChangeModeGroupBoxes();
        }

        private void CbInp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            parentForm?.ChangeModeGroupBoxes();
        }

        private void TogSemiRequired_CheckedChanged(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            parentForm!.ShowSemiRequiredGroupBoxes(TogSemiRequired.Checked);
        }

        private void TogOptional_CheckedChanged(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            parentForm!.ShowOptionalGroupBoxes(TogOptional.Checked);
        }

        private void BtnGenerateCode_Click(object sender, EventArgs e)
        {
            TxtInno_1.Text = _invoiceService.GenerateInnoCode().ToString();

            var parentForm = ParentForm as FrmInvoice;
            parentForm!.Invoice.GenerateInno = true;
        }

        #endregion
    }
}
