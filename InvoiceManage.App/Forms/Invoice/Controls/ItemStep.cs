using System;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.Invoice.Controls
{
    public partial class ItemStep : UserControl
    {
        public ItemStep()
        {
            InitializeComponent();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm, "ItemStep", "BuyerStep", "BuyerStep");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            new Step().Next(ParentForm, "ItemStep", "SumStep", "SumStep");
        }
    }
}
