using InvoiceManage.App.Services.CommonService;
using InvoiceManage.Database.Entities;
using System;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.Settings.Controls
{
    public partial class CompanySettings : UserControl
    {
        private readonly ICommonService _commonService;

        public CompanySettings(ICommonService commonService)
        {
            _commonService = commonService;
            InitializeComponent();
        }

        private void CompanySettings_Load(object sender, EventArgs e)
        {
            // CompaniesGv.DataSource = _commonService.GetCompanies();
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
            _commonService.AddCompany(company);
        }
    }
}
