﻿using InvoiceManage.Database.Entities;
using System;
using System.Globalization;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.CommonService;
using InvoiceManage.App.Services.Infrastructures;
using System.ComponentModel;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class ItemStepAdd : UserControl, INotifyPropertyChanged
    {
        private readonly ICommonService _commonService;


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


        public ItemStepAdd(ICommonService commonService)
        {
            _commonService = commonService;

            InitializeComponent();
            SetComboBoxDataSource();

            BtnEdit.DataBindings.Add("Visible", this, nameof(IsEdit));
        }

        private void SetComboBoxDataSource()
        {
            CbMu.SetEnumDataSource(typeof(Mu));
        }

        #region Events

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!this.IsValid())
            {
                CustomMessageBox.Show("آیتم اجباری یا اجباری خاصی پر نشده است", "خطا", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var parentForm = ParentForm as FrmInvoice;

            var newItem = new InvoiceItem
            {
                Invoice = parentForm!.Invoice,
                SstId = TxtSstid.Text,
                Sstt = TxtSstt.Text,
                Mu = (Mu)CbMu.SelectedValue,
                Am = decimal.TryParse(TxtAm.Text, out var am)
                    ? am : default,
                // Mu = CbMu.SelectedItem,
                Nw = decimal.TryParse(TxtNw.Text, out var nw)
                    ? nw : default,
                Fee = decimal.TryParse(TxtFee.Text, out var fee)
                    ? fee : default,
                CFee = decimal.TryParse(TxtCFee.Text, out var cfee)
                    ? cfee : default,
                Cut = TxtCut.Text,
                Exr = decimal.TryParse(TxtExr.Text, out var exr)
                    ? exr : default,
                Ssrv = decimal.TryParse(TxtSsrv.Text, out var ssrv)
                    ? ssrv : default,
                Sscv = decimal.TryParse(TxtSscv.Text, out var sscv)
                    ? sscv : default,
                Dis = decimal.TryParse(TxtDis.Text, out var dis)
                    ? dis : default,
                Vra = double.TryParse(TxtVra.Text, out var vra)
                    ? vra : default,
                Odt = TxtOdt.Text,
                Odr = double.TryParse(TxtOdr.Text, out var odr)
                    ? odr : default,
                Odam = decimal.TryParse(TxtOdam.Text, out var odam)
                    ? odam : default,
                Olt = TxtOlt.Text,
                Olr = double.TryParse(TxtOlr.Text, out var olr)
                    ? olr : default,
                Olam = decimal.TryParse(TxtOlam.Text, out var olam)
                    ? olam : default,
                Consfee = decimal.TryParse(TxtConsfee.Text, out var consfee)
                    ? consfee : default,
                Spro = decimal.TryParse(TxtSpro.Text, out var spro)
                    ? spro : default,
                Bros = decimal.TryParse(TxtBros.Text, out var bros)
                    ? bros : default
            };

            parentForm!.Invoice.Items.Add(newItem);

            this.ClearControls();
            IsEdit = false;

            CustomMessageBox.Show("کالا با موفقیت ثبت شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PicAdd_Click(object sender, EventArgs e)
        {
            BtnAdd_Click(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;




            this.ClearControls();
            IsEdit = false;

            CustomMessageBox.Show("کالا با موفقیت ویرایش شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PicEdit_Click(object sender, EventArgs e)
        {
            BtnEdit_Click(sender, e);
        }


        private void BtnSelect_Click(object sender, EventArgs e)
        {
            var data = _commonService.GetProducts();
            var frmSelect = new FrmSelect<Product>(data);

            if (frmSelect.ShowDialog() != DialogResult.OK) return;

            var selectItem = frmSelect.SelectedItem;
            if (selectItem is null) return;

            TxtSstid.Text = selectItem.Sstid;
            TxtSstt.Text = selectItem.Sstt;
            TxtVra.Text = selectItem.Vra.ToString(CultureInfo.InvariantCulture);
        }

        #endregion

    }
}