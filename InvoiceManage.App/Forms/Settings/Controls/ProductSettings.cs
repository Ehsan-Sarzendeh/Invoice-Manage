using System;
using System.ComponentModel;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.CommonService;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Forms.Settings.Controls
{
    public partial class ProductSettings : UserControl
    {
        private readonly ICommonService _commonService;
        private BindingList<Product> _products;

        public ProductSettings(ICommonService commonService)
        {
            _commonService = commonService;
            InitializeComponent();
        }

        private void ProductSettings_Load(object sender, EventArgs e)
        {
            _products = new BindingList<Product>(_commonService.GetProducts());
            ProductsGv.DataSource = _products;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Sstid = TxtSstid.Text,
                Sstt = TxtSstt.Text,
                Vra = double.Parse(TxtVra.Text),
            };
            _products.Add(product);
            _commonService.AddProduct(product);

            this.ClearControls();

            CustomMessageBox.Show("کالا با موفقیت ثبت شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
