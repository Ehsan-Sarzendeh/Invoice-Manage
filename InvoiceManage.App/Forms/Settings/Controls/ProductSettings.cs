using System;
using System.ComponentModel;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.CommonService;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Forms.Settings.Controls
{
    public partial class ProductSettings : UserControl, INotifyPropertyChanged
    {
        private readonly ICommonService _commonService;
        private readonly BindingList<Product> _products;

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

        public ProductSettings(ICommonService commonService)
        {
            InitializeComponent();

            _commonService = commonService;
            _products = new BindingList<Product>(_commonService.GetProducts());

            BtnEditProduct.DataBindings.Add("Visible", this, nameof(IsEdit));
        }

        private void ProductSettings_Load(object sender, EventArgs e)
        {
            GvProducts.DataSource = _products;
            GvProducts.SetHeaders(typeof(Product));
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
            IsEdit = false;

            CustomMessageBox.Show("کالا با موفقیت ثبت شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            var product = GetSelectedItem();

            product!.Sstid = TxtSstid.Text;
            product.Sstt = TxtSstt.Text;
            product.Vra = double.Parse(TxtVra.Text);

            _commonService.EditProduct(product);

            GvProducts.Refresh();
            IsEdit = false;
            this.ClearControls();

            CustomMessageBox.Show("کالا با موفقیت ویرایش شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var product = GetSelectedItem();
            if (product is null)
            {
                CustomMessageBox.Show("آیتمی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TxtSstid.Text = product.Sstid;
            TxtSstt.Text = product.Sstt;
            TxtVra.Text = product.Vra.ToString();

            IsEdit = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var product = GetSelectedItem();
            if (product is null)
            {
                CustomMessageBox.Show("آیتمی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var res = CustomMessageBox.Show("آیا از حذف این کالا اطمینان دارید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, true);
            if (res != DialogResult.OK) return;

            _products.Remove(product);
            _commonService.DeleteProduct(product);
        }

        private Product? GetSelectedItem()
        {
            if (GvProducts.SelectedRows.Count == 0 || GvProducts.SelectedRows[0].IsNewRow)
                return null;

            var product = _products[GvProducts.SelectedRows[0].Index];

            return product;
        }
    }
}