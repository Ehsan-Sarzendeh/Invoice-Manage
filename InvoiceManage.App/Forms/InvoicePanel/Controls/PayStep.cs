using System;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class PayStep : UserControl
    {
        public PayStep(FrmInvoiceType type)
        {
            InitializeComponent();

            BtnEdit.Visible = type == FrmInvoiceType.Edit;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            parentForm!.Invoice.Acn = TxtAcn.Text;
            parentForm!.Invoice.Iinn = TxtIinn.Text;
            parentForm!.Invoice.Pcn = TxtPcn.Text;
            parentForm!.Invoice.Pid = TxtPid.Text;
            parentForm!.Invoice.Pv = decimal.Parse(TxtPv.Text);
            parentForm!.Invoice.Trmn = TxtTrmn.Text;
            parentForm!.Invoice.Trn = TxtTrn.Text;
            parentForm!.Invoice.Pdt_1 = MtxtPdt_1.Text;
            parentForm!.Invoice.Pdt_2 = MtxtPdt_2.Text;
            parentForm!.Invoice.Pmt = (int)CbPmt.SelectedValue;

            new Step().Previous(ParentForm, "PayStep", "SumStep", "SumStep");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            ParentForm.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            ParentForm.Close();
        }
    }
}
