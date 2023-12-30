using InvoiceManage.App.Forms.Helper;
using System;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.UserControls
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
