using System;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class SumStep : UserControl
    {
        public SumStep()
        {
            InitializeComponent();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm, "SumStep", "ItemStep", "ItemStep");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            parentForm!.Invoice.Cap = decimal.Parse(TxtCap.Text);
            parentForm.Invoice.Insp = decimal.Parse(TxtInsp.Text);
            parentForm.Invoice.Tadis = decimal.Parse(TxtTadis.Text);
            parentForm.Invoice.Tax17 = decimal.Parse(TxtTax17.Text);
            parentForm.Invoice.Tbill = decimal.Parse(TxtTbill.Text);
            parentForm.Invoice.Tocv = decimal.Parse(TxtTocv.Text);
            parentForm.Invoice.Todam = decimal.Parse(TxtTodam.Text);
            parentForm.Invoice.Tonw = decimal.Parse(TxtTonw.Text);
            parentForm.Invoice.Torv = decimal.Parse(TxtTorv.Text);
            parentForm.Invoice.Tprdis = decimal.Parse(TxtTprdis.Text);
            parentForm.Invoice.Tvam = decimal.Parse(TxtTvam.Text);
            parentForm.Invoice.Tvop = decimal.Parse(TxtTvop.Text);
            parentForm.Invoice.Setm = (int)CbSetm.SelectedValue;

            new Step().Next(ParentForm, "SumStep", "PayStep", "PayStep");
        }
    }
}
