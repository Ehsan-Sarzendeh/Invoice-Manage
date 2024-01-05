using System;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.App.Services.InvoiceService;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class PayStep : UserControl
    {
        private readonly IInvoiceService _invoiceService;

        public PayStep(FrmInvoiceType type, IInvoiceService invoiceService)
        {
            InitializeComponent();
            SetComboBoxDataSource();

            _invoiceService = invoiceService;
            BtnEdit.Visible = type == FrmInvoiceType.Edit;
        }
        
        private void SetComboBoxDataSource()
        {
            CbPmt.SetEnumDataSource(typeof(Pmt));
        }

        #region Events

        private void PayStep_Load(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            this.SetDataBindings(parentForm!.Invoice);
            this.SetNumberFormat(parentForm!.Invoice);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            _invoiceService.AddInvoice(parentForm!.Invoice);

            CustomMessageBox.Show("فاکتور با موفقیت ثبت شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ParentForm!.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            if (parentForm!.Invoice.SendStatus == "Success" && parentForm!.Invoice.ResultStatus == "Success")
            {
                CustomMessageBox.Show("امکان ویرایش این فاکتور به علت ارسال و نتیجه موفق وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _invoiceService.EditInvoice(parentForm.Invoice);

            CustomMessageBox.Show("فاکتور با موفقیت ویرایش شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ParentForm!.Close();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm!, "PayStep", "SumStep", "SumStep");
        }

        #endregion
    }
}
