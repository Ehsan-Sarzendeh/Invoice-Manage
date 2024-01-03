﻿using InvoiceManage.App.Forms.Common;
using System;
using System.Windows.Forms;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.App.Services.InvoiceService;
using InvoiceManage.Database.Entities;

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

        public void SetDataBindings()
        {
            var parentForm = ParentForm as FrmInvoice;

            TxtInno_1.DataBindings.Add("Text", parentForm!.Invoice, nameof(parentForm.Invoice.Inno_1), true, DataSourceUpdateMode.OnPropertyChanged);
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

        #region Events

        private void InvoiceStep_Load(object sender, EventArgs e)
        {
            SetDataBindings();
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
            Inno_1.Text = _invoiceService.GenerateInnoCode().ToString();
        }

        #endregion
    }
}
