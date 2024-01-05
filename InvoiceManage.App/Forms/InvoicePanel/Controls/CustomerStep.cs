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
        
        private void SetComboBoxDataSource()
        {
            CbFt.SetEnumDataSource(typeof(Ft));
        }

        #region Events
        private void CustomerStep_Load(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            this.SetDataBindings(parentForm!.Invoice);
            this.SetNumberFormat(parentForm!.Invoice);
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm!, "CustomerStep", "CompanyStep", "CompanyStep");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!this.IsValid())
            {
                CustomMessageBox.Show("آیتم اجباری یا اجباری خاصی پر نشده است", "خطا", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            new Step().Next(ParentForm!, "CustomerStep", "ItemStep", "ItemStep");
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            var data = _commonService.GetCustomers();
            var frmSelect = new FrmSelect<Customer>(data);

            if (frmSelect.ShowDialog() != DialogResult.OK) return;

            var selectItem = frmSelect.SelectedItem;
            if (selectItem is null) return;

            TxtBId.Text = selectItem.BId.ToString();
            TxtTinb.Text = selectItem.Tinb;
            TxtBpc.Text = selectItem.Bpc;
            TxtBbc.Text = selectItem.Bbc;
            TxtBpn.Text = selectItem.Bpn;
            TxtBillId.Text = selectItem.BillId;
        }

        private void BtnInquiry_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
