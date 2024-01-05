using InvoiceManage.App.Services.CommonService;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using InvoiceManage.Database.Entities;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.Settings.Controls
{
    public partial class CustomerSettings : UserControl, INotifyPropertyChanged
    {
        private readonly ICommonService _commonService;
        private readonly BindingList<Customer> _customers;

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


        public CustomerSettings(ICommonService commonService)
        {
            InitializeComponent();

            _commonService = commonService;
            _customers = new BindingList<Customer>(_commonService.GetCustomers());

            BtnEditCustomer.DataBindings.Add("Visible", this, nameof(IsEdit));
        }

        private void CustomerSettings_Load(object sender, EventArgs e)
        {
            GvCustomers.DataSource = _customers;
            GvCustomers.SetHeaders(typeof(Customer));
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                BId = long.Parse(TxtBId.Text),
                Tinb = TxtTinb.Text,
                Name = TxtName.Text,
                Bpc = TxtBpc.Text,
                Bbc = TxtBbc.Text,
                Bpn = TxtBpn.Text,
                BillId = TxtBillId.Text
            };
            _customers.Add(customer);
            _commonService.AddCustomer(customer);

            this.ClearControls();

            CustomMessageBox.Show("خریدار با موفقیت ثبت شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            var customer = GetSelectedItem();

            customer!.BId = string.IsNullOrEmpty(TxtBId.Text) ? null :long.Parse(TxtBId.Text);
            customer.Tinb = TxtTinb.Text;
            customer.Name = TxtName.Text;
            customer.Bpc = TxtBpc.Text;
            customer.Bbc = TxtBbc.Text;
            customer.Bpn = TxtBpn.Text;
            customer.BillId = TxtBillId.Text;

            _commonService.EditCustomer(customer);

            GvCustomers.Refresh();
            IsEdit = false;
            this.ClearControls();

            CustomMessageBox.Show("خریدار با موفقیت ویرایش شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var customer = GetSelectedItem();
            if (customer is null)
            {
                CustomMessageBox.Show("آیتمی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TxtBId.Text = customer.BId.ToString();
            TxtTinb.Text = customer.Tinb;
            TxtName.Text = customer.Name;
            TxtBpc.Text = customer.Bpc;
            TxtBbc.Text = customer.Bbc;
            TxtBpn.Text = customer.Bpn;
            TxtBillId.Text = customer.BillId;

            IsEdit = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var customer = GetSelectedItem();
            if (customer is null)
            {
                CustomMessageBox.Show("آیتمی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var res = CustomMessageBox.Show("آیا از حذف این خریدار اطمینان دارید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, true);
            if (res != DialogResult.OK) return;

            _customers.Remove(customer);
            _commonService.DeleteCustomer(customer);
        }

        private Customer? GetSelectedItem()
        {
            if (GvCustomers.SelectedRows.Count == 0 || GvCustomers.SelectedRows[0].IsNewRow)
                return null;

            var customer = _customers[GvCustomers.SelectedRows[0].Index];

            return customer;
        }
    }
}