using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.Database.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class BuyerStep : UserControl
    {
        public BuyerStep(Invoice invoice)
        {
            InitializeComponent();
            SetComboBoxDataSource();
            SetDataBindings(invoice);
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm, "BuyerStep", "SellerStep", "SellerStep");
        }

        public void SetDataBindings(Invoice invoice)
        {
            TxtTinb.DataBindings.Add("Text", invoice, "Tinb", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtBId.DataBindings.Add("Text", invoice, "Bid", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtBillId.DataBindings.Add("Text", invoice, "BillId", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtBpc.DataBindings.Add("Text", invoice, "Bpc", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtBpn.DataBindings.Add("Text", invoice, "Bpn", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtBbc.DataBindings.Add("Text", invoice, "Bbc", true, DataSourceUpdateMode.OnPropertyChanged);
            CbFt.DataBindings.Add("SelectedValue", invoice, "Ft", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetComboBoxDataSource()
        {
            CbFt.SetEnumDataSource(typeof(Ft));
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            new Step().Next(ParentForm, "BuyerStep", "ItemStep", "ItemStep");
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            List<object> data = null;
            var frmSelect = new FrmSelect(data);

            if (frmSelect.ShowDialog() == DialogResult.OK)
            {
                var selectItem = (Customer)frmSelect.SelectedItem!;
            }
        }
    }
}
