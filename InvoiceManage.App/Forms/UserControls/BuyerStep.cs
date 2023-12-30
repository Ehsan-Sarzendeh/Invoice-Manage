using InvoiceManage.App.Forms.Helper;
using System;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.UserControls
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
