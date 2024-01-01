using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.Database.Entities;
using System;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class InvoiceStep : UserControl
    {
        public InvoiceStep()
        {
            InitializeComponent();
            SetComboBoxDataSource();
        }

        public void SetDataBindings()
        {
            var parentForm = ParentForm as FrmInvoice;

            TxtInno.DataBindings.Add("Text", parentForm!.Invoice, nameof(parentForm.Invoice.Inno), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtIrtaxid.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Irtaxid), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTaxId.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.TaxId), true, DataSourceUpdateMode.OnPropertyChanged);
            MtxtIndatim2m_1.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Indatim2m_1), true, DataSourceUpdateMode.OnPropertyChanged);
            MtxtIndatim2m_2.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Indatim2m_2), true, DataSourceUpdateMode.OnPropertyChanged);
            MtxtIndatim_1.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Indatim_1), true, DataSourceUpdateMode.OnPropertyChanged);
            MtxtIndatim_2.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Indatim_2), true, DataSourceUpdateMode.OnPropertyChanged);
            CbInty.DataBindings.Add("SelectedValue", parentForm.Invoice, nameof(parentForm.Invoice.Inty), true, DataSourceUpdateMode.OnPropertyChanged);
            CbInp.DataBindings.Add("SelectedValue", parentForm.Invoice, nameof(parentForm.Invoice.Inp), true, DataSourceUpdateMode.OnPropertyChanged);
            CbIns.DataBindings.Add("SelectedValue", parentForm.Invoice, nameof(parentForm.Invoice.Ins), true, DataSourceUpdateMode.OnPropertyChanged);
            CbTob.DataBindings.Add("SelectedValue", parentForm.Invoice, nameof(parentForm.Invoice.Tob), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetComboBoxDataSource()
        {
            CbInty.SetEnumDataSource(typeof(Inty));
            CbInp.SetEnumDataSource(typeof(Inp));
            CbIns.SetEnumDataSource(typeof(Ins));
            CbTob.SetEnumDataSource(typeof(Tob));
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            new Step().Next(ParentForm!, "InvoiceStep", "SellerStep", "SellerStep");
        }

        private void InvoiceStep_Load(object sender, EventArgs e)
        {
            SetDataBindings();
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

            parentForm!.ShowSemiRequiredGroupBoxes(TogOptional.Checked);
        }

        private void TogOptional_CheckedChanged(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            parentForm!.ShowOptionalGroupBoxes(TogOptional.Checked);
        }
    }
}
