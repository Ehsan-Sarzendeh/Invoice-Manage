using InvoiceManage.App.Forms.Helper;
using System;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.UserControls
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
            new Step().Next(ParentForm, "SellerStep", "BuyerStep", "BuyerStep");
        }
    }
}