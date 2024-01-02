using System;
using System.Windows.Forms;
using InvoiceManage.App.Services.CommonService;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Forms.Settings.Controls
{
    public partial class ProductSettings : UserControl
    {
        private readonly ICommonService _commonService;

        public ProductSettings(ICommonService commonService)
        {
            _commonService = commonService;
            InitializeComponent();
        }

        private void ProductSettings_Load(object sender, EventArgs e)
        {
            // ProductsGv.DataSource = _commonService.GetProducts();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Sstid = gb2.Text,
                Sstt = gb.Text,
                Vra = double.Parse(TxtSstt.Text),
            };

            _commonService.AddProduct(product);
        }
    }
}
