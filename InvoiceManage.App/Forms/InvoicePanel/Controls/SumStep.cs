using InvoiceManage.App.Forms.Common;
using InvoiceManage.Database.Entities;
using System;
using System.Windows.Forms;
using InvoiceManage.App.Services.Infrastructures;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class SumStep : UserControl
    {
        public SumStep()
        {
            InitializeComponent();

            SetComboBoxDataSource();
        }

        public void SetDataBindings()
        {
            var parentForm = ParentForm as FrmInvoice;

            TxtCap.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Cap), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtInsp.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Insp), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTadis.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Tadis), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTax17.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Tax17), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTbill.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Tbill), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTocv.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Tocv), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTodam.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Todam), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTonw.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Tonw), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTorv.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Torv), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTprdis.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Tprdis), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTvam.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Tvam), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTvop.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Tvop), true, DataSourceUpdateMode.OnPropertyChanged);
            Cbv.DataBindings.Add("SelectedValue", parentForm.Invoice, nameof(parentForm.Invoice.Setm), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetComboBoxDataSource()
        {
            Cbv.SetEnumDataSource(typeof(Setm));
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm!, "SumStep", "ItemStep", "ItemStep");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            new Step().Next(ParentForm!, "SumStep", "PayStep", "PayStep");
        }

        private void SumStep_Load(object sender, EventArgs e)
        {
            SetDataBindings();
        }
    }
}
