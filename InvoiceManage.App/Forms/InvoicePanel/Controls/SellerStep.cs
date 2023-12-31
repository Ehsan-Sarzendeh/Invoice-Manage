using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class SellerStep : UserControl
    {
        public SellerStep()
        {
            InitializeComponent();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm, "SellerStep", "InvoiceStep", "InvoiceStep");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            parentForm!.Invoice.Cdcn = TxtCdcn.Text;
            parentForm!.Invoice.Crn = TxtCrn.Text;
            parentForm!.Invoice.Sbc = TxtSbc.Text;
            parentForm!.Invoice.Scc = TxtScc.Text;
            parentForm!.Invoice.Scln = TxtScln.Text;
            parentForm!.Invoice.Tins = TxtTins.Text;
            parentForm!.Invoice.Cdcd_1 = MtxtCdcd_1.Text;
            // parentForm!.Invoice.کدیکتا فروشنده = textBox4.Text;

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