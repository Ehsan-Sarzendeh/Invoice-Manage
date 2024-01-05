using InvoiceManage.App.Forms.Common;
using System;
using System.Windows.Forms;
using InvoiceManage.App.Services.CommonService;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class CompanyStep : UserControl
    {
        private readonly ICommonService _commonService;

        public CompanyStep(ICommonService commonService)
        {
            _commonService = commonService;

            InitializeComponent();
            SetComboBoxDataSource();
        }
        
        private void SetComboBoxDataSource() { }

        #region Events

        private void CompanyStep_Load(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            this.SetDataBindings(parentForm!.Invoice);
            this.SetNumberFormat(parentForm!.Invoice);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            var data = _commonService.GetCompanies();
            var frmSelect = new FrmSelect<Company>(data);

            if (frmSelect.ShowDialog() != DialogResult.OK) return;

            var selectItem = frmSelect.SelectedItem;
            if (selectItem is null) return;

            TxtCompanyId.Text = selectItem.Id.ToString();
            TxtTins.Text = selectItem.Tins;
            TxtSbc.Text = selectItem.Sbc;
            TxtCrn.Text = selectItem.Crn;
            TxtScln.Text = selectItem.Scln;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm!, "CompanyStep", "InvoiceStep", "InvoiceStep");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!this.IsValid())
            {
                CustomMessageBox.Show("آیتم اجباری یا اجباری خاصی پر نشده است", "خطا", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            new Step().Next(ParentForm!, "CompanyStep", "CustomerStep", "CustomerStep");
        }

        #endregion
    }
}