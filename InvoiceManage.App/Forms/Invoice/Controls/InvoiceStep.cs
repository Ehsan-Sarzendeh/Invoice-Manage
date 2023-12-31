using System;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.Invoice.Controls
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
