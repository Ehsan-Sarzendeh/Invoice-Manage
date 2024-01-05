using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.App.Services.InvoiceService;
using InvoiceManage.Database.Entities;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    public partial class ItemStepList : UserControl
    {
        private readonly IInvoiceService _invoiceService;

        public ItemStepList(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
            InitializeComponent();
        }

        private void ItemStepList_Load(object sender, System.EventArgs e)
        {
            SetDataBindings();
        }

        public void SetDataBindings()
        {
            var parentForm = ParentForm! as FrmInvoice;
            GvItems.DataSource = parentForm!.Invoice.Items;
            GvItems.SetHeaders(typeof(InvoiceItem));
        }

        private void BtnEdit_Click(object sender, System.EventArgs e)
        {
            var company = GetSelectedItem();
            if (company is null)
            {
                CustomMessageBox.Show("آیتمی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var itemStep = Parent.Parent as ItemStep;
            itemStep!.TabAdd_Click(sender, e);

            // TxtTins.Text = company!.Tins;
            // TxtName.Text = company.Name;
            // TxtSbc.Text = company.Sbc;
            // TxtScln.Text = company.Scln;
            // TxtCrn.Text = company.Crn;
            //
            // IsEdit = true;
        }

        private void BtnDelete_Click(object sender, System.EventArgs e)
        {
            var item = GetSelectedItem();
            if (item is null)
            {
                CustomMessageBox.Show("آیتمی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var res = CustomMessageBox.Show("آیا از حذف این کالا اطمینان دارید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, true);
            if (res != DialogResult.OK) return;

            var parentForm = ParentForm! as FrmInvoice;

            parentForm!.Invoice.Items.Remove(item);
            _invoiceService.DeleteInvoiceItem(item);
        }

        private InvoiceItem? GetSelectedItem()
        {
            if (GvItems.SelectedRows.Count == 0 || GvItems.SelectedRows[0].IsNewRow)
                return null;

            var parentForm = ParentForm! as FrmInvoice;

            var item = parentForm!.Invoice.Items[GvItems.SelectedRows[0].Index];

            return item;
        }
    }
}