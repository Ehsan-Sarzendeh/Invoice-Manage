using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.Database.Entities;
using System;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class PayStep : UserControl
    {
        public PayStep(FrmInvoiceType type, Invoice invoice)
        {
            InitializeComponent();

            BtnEdit.Visible = type == FrmInvoiceType.Edit;

            SetComboBoxDataSource();
            SetDataBindings(invoice);
        }

        public void SetDataBindings(Invoice invoice)
        {
            TxtAcn.DataBindings.Add("Text", invoice, "Acn", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtIinn.DataBindings.Add("Text", invoice, "Iinn", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPcn.DataBindings.Add("Text", invoice, "Pcn", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPid.DataBindings.Add("Text", invoice, "Pid", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPv.DataBindings.Add("Text", invoice, "Pv", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTrmn.DataBindings.Add("Text", invoice, "Trmn", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTrn.DataBindings.Add("Text", invoice, "Trn", true, DataSourceUpdateMode.OnPropertyChanged);
            MtxtPdt_1.DataBindings.Add("Text", invoice, "Pdt_1", true, DataSourceUpdateMode.OnPropertyChanged);
            MtxtPdt_2.DataBindings.Add("Text", invoice, "Pdt_2", true, DataSourceUpdateMode.OnPropertyChanged);
            CbPmt.DataBindings.Add("SelectedValue", invoice, "Pmt", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetComboBoxDataSource()
        {
            CbPmt.SetEnumDataSource(typeof(Pmt));
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm, "PayStep", "SumStep", "SumStep");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var a = ParentForm as FrmInvoice;

            var b= a.Invoice;

            ParentForm.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            ParentForm.Close();
        }
    }
}
