using InvoiceManage.App.Forms.Common;
using System;
using System.Windows.Forms;
using InvoiceManage.App.Services.CommonService;
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

        public void SetDataBindings()
        {
            var parentForm = ParentForm as FrmInvoice;

            TxtCdcn.DataBindings.Add("Text", parentForm!.Invoice, nameof(parentForm.Invoice.Cdcn), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCrn.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Crn), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtSbc.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Sbc), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtScc.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Scc), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtScln.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Scln), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTins.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Tins), true, DataSourceUpdateMode.OnPropertyChanged);
            MtxtCdcd_1.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Cdcd_1), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetComboBoxDataSource()
        {

        }

        #region Events

        private void CompanyStep_Load(object sender, EventArgs e)
        {
            SetDataBindings();

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            var data = _commonService.GetCompanies();
            var frmSelect = new FrmSelect<Company>(data);

            if (frmSelect.ShowDialog() == DialogResult.OK)
            {
                var selectItem = frmSelect.SelectedItem;
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm!, "CompanyStep", "InvoiceStep", "InvoiceStep");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            new Step().Next(ParentForm!, "CompanyStep", "CustomerStep", "CustomerStep");
        }

        #endregion
    }
}