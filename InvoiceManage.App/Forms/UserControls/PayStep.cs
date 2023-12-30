using InvoiceManage.App.Forms.Helper;
using System;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.UserControls
{
    public partial class PayStep : UserControl
    {
        public PayStep()
        {
            InitializeComponent();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm, "PayStep", "SumStep", "SumStep");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {


            ParentForm.Close();
        }
    }
}
