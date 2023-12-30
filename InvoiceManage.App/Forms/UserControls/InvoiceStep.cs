using System;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Helper;

namespace InvoiceManage.App.Forms.UserControls
{
    public partial class InvoiceStep : UserControl
    {
        public InvoiceStep()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            new Step().Next(ParentForm, "InvoiceStep", "SellerStep", "SellerStep");
        }
    }
}
