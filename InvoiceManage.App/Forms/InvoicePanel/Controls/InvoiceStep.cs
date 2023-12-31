using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.Database.Entities;
using System;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class InvoiceStep : UserControl
    {
        public InvoiceStep(Invoice invoice)
        {
            InitializeComponent();
            SetComboBoxDataSource();
            SetDataBindings(invoice);
        }

        public void SetDataBindings(Invoice invoice)
        {
            TxtInno.DataBindings.Add("Text", invoice, "Inno", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtIrtaxid.DataBindings.Add("Text", invoice, "Irtaxid", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTaxId.DataBindings.Add("Text", invoice, "TaxId", true, DataSourceUpdateMode.OnPropertyChanged);
            MtxtIndatim2m_1.DataBindings.Add("Text", invoice, "Indatim2m_1", true, DataSourceUpdateMode.OnPropertyChanged);
            MtxtIndatim2m_2.DataBindings.Add("Text", invoice, "Indatim2m_2", true, DataSourceUpdateMode.OnPropertyChanged);
            MtxtIndatim_1.DataBindings.Add("Text", invoice, "Indatim_1", true, DataSourceUpdateMode.OnPropertyChanged);
            MtxtIndatim_2.DataBindings.Add("Text", invoice, "Indatim_2", true, DataSourceUpdateMode.OnPropertyChanged);
            CbInty.DataBindings.Add("SelectedValue", invoice, "Inty", true, DataSourceUpdateMode.OnPropertyChanged);
            CbInp.DataBindings.Add("SelectedValue", invoice, "Inp", true, DataSourceUpdateMode.OnPropertyChanged);
            CbIns.DataBindings.Add("SelectedValue", invoice, "Ins", true, DataSourceUpdateMode.OnPropertyChanged);
            CbTob.DataBindings.Add("SelectedValue", invoice, "Tob", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetComboBoxDataSource()
        {
            CbInty.SetEnumDataSource(typeof(Inty));
            CbInp.SetEnumDataSource(typeof(Inp));
            CbIns.SetEnumDataSource(typeof(Ins));
            CbTob.SetEnumDataSource(typeof(Tob));
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            new Step().Next(ParentForm, "InvoiceStep", "SellerStep", "SellerStep");
        }
    }
}
