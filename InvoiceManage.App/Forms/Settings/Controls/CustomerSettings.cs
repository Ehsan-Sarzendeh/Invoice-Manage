using InvoiceManage.App.Services.CommonService;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using InvoiceManage.Database.Entities;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.Settings.Controls
{
    public partial class CustomerSettings : UserControl
    {
        private readonly ICommonService _commonService;
        private BindingList<Customer> _customers;

        public CustomerSettings(ICommonService commonService)
        {
            _commonService = commonService;
            InitializeComponent();
        }


        private void CustomerSettings_Load(object sender, EventArgs e)
        {
            _customers = new BindingList<Customer>(_commonService.GetCustomers());
            CustomersGv.DataSource = _customers;
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
    }
}
