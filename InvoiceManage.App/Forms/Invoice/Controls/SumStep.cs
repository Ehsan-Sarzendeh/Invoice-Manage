using System;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.Invoice.Controls
{
    public partial class SumStep : UserControl
    {
        public SumStep()
        {
            InitializeComponent();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm, "SumStep", "ItemStep", "ItemStep");

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            new Step().Next(ParentForm, "SumStep", "PayStep", "PayStep");
        }
    }
}
