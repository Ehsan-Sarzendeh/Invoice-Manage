using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.Database.Entities;
using System;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class SumStep : UserControl
    {
        public SumStep(Invoice invoice)
        {
            InitializeComponent();

            SetComboBoxDataSource();
            SetDataBindings(invoice);
        }

        public void SetDataBindings(Invoice invoice)
        {
            TxtCap.DataBindings.Add("Text", invoice, "Cap", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtInsp.DataBindings.Add("Text", invoice, "Insp", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTadis.DataBindings.Add("Text", invoice, "Tadis", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTax17.DataBindings.Add("Text", invoice, "Tax17", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTbill.DataBindings.Add("Text", invoice, "Tbill", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTocv.DataBindings.Add("Text", invoice, "Tocv", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTodam.DataBindings.Add("Text", invoice, "Todam", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTonw.DataBindings.Add("Text", invoice, "Tonw", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTorv.DataBindings.Add("Text", invoice, "Torv", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTprdis.DataBindings.Add("Text", invoice, "Tprdis", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTvam.DataBindings.Add("Text", invoice, "Tvam", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTvop.DataBindings.Add("Text", invoice, "Tvop", true, DataSourceUpdateMode.OnPropertyChanged);
            CbSetm.DataBindings.Add("SelectedValue", invoice, "Setm", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetComboBoxDataSource()
        {
            CbSetm.SetEnumDataSource(typeof(Setm));
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm, "SumStep", "ItemStep", "ItemStep");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            new Step().Next(ParentForm, "SumStep", "PayStep", "PayStep");
        }
    }
}
