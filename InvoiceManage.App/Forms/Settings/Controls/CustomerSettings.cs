using InvoiceManage.App.Services.CommonService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Forms.Settings.Controls
{
    public partial class CustomerSettings : UserControl
    {
        private readonly ICommonService _commonService;

        public CustomerSettings(ICommonService commonService)
        {
            _commonService = commonService;
            InitializeComponent();
        }


        private void CustomerSettings_Load(object sender, EventArgs e)
        {
            // CustomersGv.DataSource = _commonService.GetCustomers();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                
            };
            _commonService.AddCustomer(customer);
        }
    }
}
