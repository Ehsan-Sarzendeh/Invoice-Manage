using InvoiceManage.App.Services.CommonService;
using InvoiceManage.Database.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.Settings.Controls
{
    public partial class CompanySettings : UserControl
    {
        private readonly ICommonService _commonService;
        private BindingList<Company> _companies;

        public CompanySettings(ICommonService commonService)
        {
            _commonService = commonService;
            InitializeComponent();
        }

        private void CompanySettings_Load(object sender, EventArgs e)
        {
            _companies = new BindingList<Company>(_commonService.GetCompanies());
            GvCompanies.DataSource = _companies;
            GvCompanies.SetHeaders(typeof(Company));
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var company = new Company()
            {
                Tins = TxtTins.Text,
                Name = TxtName.Text,
                Sbc = TxtSbc.Text,
                Scln = TxtScln.Text,
                Crn = TxtCrn.Text,
            };
            _companies.Add(company);
            _commonService.AddCompany(company);

            this.ClearControls();

            CustomMessageBox.Show("شرکت با موفقیت ثبت شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}