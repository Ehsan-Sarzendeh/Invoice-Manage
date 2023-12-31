using System;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.Invoice.Controls
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
