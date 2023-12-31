using System;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.Invoice.Controls
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
            new Step().Next(ParentForm, "BuyerStep", "ItemStep", "ItemStep");
        }
    }
}
