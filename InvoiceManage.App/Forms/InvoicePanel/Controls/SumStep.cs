using InvoiceManage.App.Forms.Common;
using InvoiceManage.Database.Entities;
using System;
using System.Globalization;
using System.Windows.Forms;
using InvoiceManage.App.Services.Infrastructures;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class SumStep : UserControl
    {
        public SumStep()
        {
            InitializeComponent();

            SetComboBoxDataSource();
        }
        
        public void SetComputedProperties()
        {
            var parentForm = ParentForm as FrmInvoice;

            TxtTadis.Text = parentForm!.Invoice.Tadis.ToString("N0", CultureInfo.InvariantCulture);
            TxtTbill.Text = parentForm.Invoice.Tbill.ToString("N0", CultureInfo.InvariantCulture);
            TxtTocv.Text = parentForm.Invoice.Tocv.ToString("N0", CultureInfo.InvariantCulture);
            TxtTodam.Text = parentForm.Invoice.Todam.ToString("N0", CultureInfo.InvariantCulture);
            TxtTonw.Text = parentForm.Invoice.Tonw.ToString("N0", CultureInfo.InvariantCulture);
            TxtTorv.Text = parentForm.Invoice.Torv.ToString("N0", CultureInfo.InvariantCulture);
            TxtTprdis.Text = parentForm.Invoice.Tprdis.ToString("N0", CultureInfo.InvariantCulture);
            TxtTvam.Text = parentForm.Invoice.Tvam.ToString("N0", CultureInfo.InvariantCulture);
            TxtTvop.Text = parentForm.Invoice.Tvop.ToString("N0", CultureInfo.InvariantCulture);
        }

        private void SetComboBoxDataSource()
        {
            Cbv.SetEnumDataSource(typeof(Setm));
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            new Step().Previous(ParentForm!, "SumStep", "ItemStep", "ItemStep");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!this.IsValid())
            {
                CustomMessageBox.Show("آیتم اجباری یا اجباری خاصی پر نشده است", "خطا", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            new Step().Next(ParentForm!, "SumStep", "PayStep", "PayStep");
        }

        private void SumStep_Load(object sender, EventArgs e)
        {
            var parentForm = ParentForm as FrmInvoice;

            this.SetDataBindings(parentForm!.Invoice);
            this.SetNumberFormat(parentForm!.Invoice);
        }
    }
}
