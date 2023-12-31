using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class BuyerStep : UserControl
    {
        public BuyerStep()
        {
            InitializeComponent();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm, "BuyerStep", "SellerStep", "SellerStep");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            parentForm!.Invoice.Tins = TxtTins.Text;
            parentForm.Invoice.Bid = TxtBId.Text;
            parentForm.Invoice.BillId = TxtBillId.Text;
            parentForm.Invoice.Bpc = TxtBpc.Text;
            parentForm.Invoice.Bpn = TxtBpn.Text;
            parentForm.Invoice.Sbc = TxtSbc.Text;
            parentForm.Invoice.Ft = (int)CbFt.SelectedValue;

            new Step().Next(ParentForm, "BuyerStep", "ItemStep", "ItemStep");
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
