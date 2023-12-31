using System;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Forms.Invoice.Controls
{
    public partial class PayStep : UserControl
    {
        public PayStep(FrmInvoiceType type)
        {
            InitializeComponent();

            BtnEdit.Visible = type == FrmInvoiceType.Edit;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm, "PayStep", "SumStep", "SumStep");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            ParentForm.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            ParentForm.Close();
        }
    }
}
