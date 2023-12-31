using System;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class InvoiceStep : UserControl
    {
        public InvoiceStep()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            parentForm!.Invoice.Inno = TxtInno.Text;
            parentForm!.Invoice.Irtaxid = TxtIrtaxid.Text;
            parentForm!.Invoice.TaxId = TxtTaxId.Text;
            parentForm!.Invoice.Indatim2m_1 = MtxtIndatim2m_1.Text;
            parentForm!.Invoice.Indatim2m_2 = MtxtIndatim2m_2.Text;
            parentForm!.Invoice.Indatim_1 = MtxtIndatim_1.Text;
            parentForm!.Invoice.Indatim_2 = MtxtIndatim_2.Text;
            parentForm!.Invoice.Inp = (int)CbInp.SelectedValue;
            parentForm!.Invoice.Ins = (int)CbIns.SelectedValue;
            parentForm!.Invoice.Inty = (int)CbInty.SelectedValue;
            parentForm!.Invoice.Tob = (int)CbTob.SelectedValue;
            
            parentForm!.ShowOptional = TogOptional.Checked;
            parentForm!.ShowSemiRequired = TogSemiRequired.Checked;

            new Step().Next(ParentForm, "InvoiceStep", "SellerStep", "SellerStep");
        }
    }
}
