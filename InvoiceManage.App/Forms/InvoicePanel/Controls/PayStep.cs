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

        public void SetDataBindings()
        {
            var parentForm = ParentForm as FrmInvoice;

            TxtAcn.DataBindings.Add("Text", parentForm!.Invoice, nameof(parentForm.Invoice.Acn), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtIinn.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Iinn), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPcn.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Pcn), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPid.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Pid), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPv.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Pv), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTrmn.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Trmn), true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTrn.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Trn), true, DataSourceUpdateMode.OnPropertyChanged);
            MtxtPdt_1.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Pdt_1), true, DataSourceUpdateMode.OnPropertyChanged);
            MtxtPdt_2.DataBindings.Add("Text", parentForm.Invoice, nameof(parentForm.Invoice.Pdt_2), true, DataSourceUpdateMode.OnPropertyChanged);
            CbPmt.DataBindings.Add("SelectedValue", parentForm.Invoice, nameof(parentForm.Invoice.Pmt), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetComboBoxDataSource()
        {
            CbPmt.SetEnumDataSource(typeof(Pmt));
        }

        #region Events

        private void PayStep_Load(object sender, EventArgs e)
        {
            SetDataBindings();
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
                CustomMessageBox.Show("امکان ویرایش این فاکتور به علت ارسال و نتیجه موفق قابل ویرایش نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
