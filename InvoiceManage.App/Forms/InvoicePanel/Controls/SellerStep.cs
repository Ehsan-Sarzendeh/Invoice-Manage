using InvoiceManage.App.Forms.Common;
using InvoiceManage.Database.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class SellerStep : UserControl
    {
        public SellerStep(Invoice invoice)
        {
            InitializeComponent();
            SetComboBoxDataSource();
            SetDataBindings(invoice);
        }

        public void SetDataBindings(Invoice invoice)
        {
            TxtCdcn.DataBindings.Add("Text", invoice, "Cdcn", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCrn.DataBindings.Add("Text", invoice, "Crn", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtSbc.DataBindings.Add("Text", invoice, "Sbc", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtScc.DataBindings.Add("Text", invoice, "Scc", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtScln.DataBindings.Add("Text", invoice, "Scln", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTins.DataBindings.Add("Text", invoice, "Tins", true, DataSourceUpdateMode.OnPropertyChanged);
            MtxtCdcd_1.DataBindings.Add("Text", invoice, "Cdcd_1", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetComboBoxDataSource()
        {
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm, "SellerStep", "InvoiceStep", "InvoiceStep");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            new Step().Next(ParentForm, "SellerStep", "BuyerStep", "BuyerStep");
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            List<object> data = null;
            var frmSelect = new FrmSelect(data);

            if (frmSelect.ShowDialog() == DialogResult.OK)
            {
                var selectItem = frmSelect.SelectedItem;
            }
        }
    }
}