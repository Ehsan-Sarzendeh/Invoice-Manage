using InvoiceManage.App.Forms.Common;
using InvoiceManage.Database.Entities;
using System;
using System.Windows.Forms;
using InvoiceManage.App.Services.CommonService;
using InvoiceManage.App.Services.Infrastructures;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class CustomerStep : UserControl
    {
        private readonly ICommonService _commonService;

        public CustomerStep(ICommonService commonService)
        {
            _commonService = commonService;

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
            var data = _commonService.GetCustomers();
            var frmSelect = new FrmSelect<Customer>(data);

            if (frmSelect.ShowDialog() == DialogResult.OK)
            {
                var selectItem = frmSelect.SelectedItem!;
            }
        }

        private void BtnInquiry_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
