using InvoiceManage.App.Services.CommonService;
using InvoiceManage.Database.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.Settings.Controls
{
    public partial class CompanySettings : UserControl, INotifyPropertyChanged
    {
        private readonly ICommonService _commonService;
        private readonly BindingList<Company> _companies;


        private bool _isEdit;
        public bool IsEdit
        {
            get => _isEdit;
            set
            {
                _isEdit = value;
                OnPropertyChanged(nameof(IsEdit));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }


        public CompanySettings(ICommonService commonService)
        {
            InitializeComponent();

            _commonService = commonService;
            _companies = new BindingList<Company>(_commonService.GetCompanies());

            BtnEditCompany.DataBindings.Add("Visible", this, nameof(IsEdit));
        }

        private void CompanySettings_Load(object sender, EventArgs e)
        {
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

        private void BtnEditCompany_Click(object sender, EventArgs e)
        {
            var company = GetSelectedItem();

            company!.Tins = TxtTins.Text;
            company.Name = TxtName.Text;
            company.Sbc = TxtSbc.Text;
            company.Scln = TxtScln.Text;
            company.Crn = TxtCrn.Text;

            _commonService.EditCompany(company);

            GvCompanies.Refresh();
            IsEdit = false;
            this.ClearControls();

            CustomMessageBox.Show("شرکت با موفقیت ویرایش شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var company = GetSelectedItem();
            if (company is null)
            {
                CustomMessageBox.Show("آیتمی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TxtTins.Text = company!.Tins;
            TxtName.Text = company.Name;
            TxtSbc.Text = company.Sbc;
            TxtScln.Text = company.Scln;
            TxtCrn.Text = company.Crn;

            IsEdit = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var company = GetSelectedItem();
            if (company is null)
            {
                CustomMessageBox.Show("آیتمی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var res = CustomMessageBox.Show("آیا از حذف این شرکت اطمینان دارید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, true);
            if (res != DialogResult.OK) return;

            _companies.Remove(company);
            _commonService.DeleteCompany(company);
        }

        private Company? GetSelectedItem()
        {
            if (GvCompanies.SelectedRows.Count == 0 || GvCompanies.SelectedRows[0].IsNewRow)
                return null;

            var company = _companies[GvCompanies.SelectedRows[0].Index];

            return company;
        }

    }
}