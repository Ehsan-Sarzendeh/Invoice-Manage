using InvoiceManage.App.Forms.Helper;
using System;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.UserControls
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
