using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.Database.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InvoiceManage.App.Services.CommonService;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class CustomerStep : UserControl
    {
        public CustomerStep()
        {
            InitializeComponent();
            SetComboBoxDataSource();
        }

        public void SetDataBindings()
        {
            var parentForm = ParentForm as FrmInvoice;

            TxtTinb.DataBindings.Add("Text", parentForm!.Invoice, nameof(parentForm.Invoice.Tinb), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtBId.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Bid), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtBillId.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.BillId), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtBpc.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Bpc), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtBpn.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Bpn), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtBbc.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Bbc), true, DataSourceUpdateMode.OnPropertyChanged);
            CbFt.DataBindings.Add("SelectedValue", parentForm.Invoice, nameof(parentForm.Invoice.Ft), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetComboBoxDataSource()
        {
            CbFt.SetEnumDataSource(typeof(Ft));
        }

        #region Events
        private void CustomerStep_Load(object sender, EventArgs e)
        {
            SetDataBindings();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm!, "CustomerStep", "CompanyStep", "CompanyStep");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            new Step().Next(ParentForm!, "CustomerStep", "ItemStep", "ItemStep");
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            using var commonService = new CommonService();

            List<Customer> data = commonService.GetCustomers();
            var frmSelect = new FrmSelect(null);

            if (frmSelect.ShowDialog() == DialogResult.OK)
            {
                var selectItem = (Customer)frmSelect.SelectedItem!;
            }
        }

        private void BtnInquiry_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
