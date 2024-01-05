using InvoiceManage.App.Forms.Common;
using System;
using System.Drawing;
using System.Windows.Forms;
using InvoiceManage.App.Forms.InvoicePanel;
using InvoiceManage.App.Services.Infrastructures;
using InvoiceManage.App.Services.InvoiceService;
using InvoiceManage.Database.Entities;
using System.ComponentModel;

namespace InvoiceManage.App.Forms.InvoiceList
{
    public partial class FrmInvoiceList : Form
    {
        private readonly IInvoiceService _invoiceService;
        private BindingList<Invoice> _invoices;

        public FrmInvoiceList()
        {
            InitializeComponent();
            _invoiceService = new InvoiceService();
        }

        private void FrmInvoiceList_Load(object sender, EventArgs e)
        {
            LoadData();
            GvInvoices.SetHeaders(typeof(Invoice));
        }

        private void FrmInvoiceList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FrmHome.Show();
        }

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsApi.ReleaseCapture();
            WindowsApi.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void FrmInvoiceList_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsApi.ReleaseCapture();
            WindowsApi.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            // WindowState = WindowState == FormWindowState.Maximized
            //     ? FormWindowState.Normal
            //     : FormWindowState.Maximized;

            if (Width == Screen.PrimaryScreen.WorkingArea.Width)
            {
                Size = new Size(1026, 738);
                CenterToScreen();

            }
            else
            {
                Top = Left = 0;
                Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var invoice = GetSelectedItem();
            if (invoice is null)
            {
                CustomMessageBox.Show("آیتمی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var res = CustomMessageBox.Show("آیا از حذف این فاکتور اطمینان دارید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, true);
            if (res != DialogResult.OK) return;

            if (invoice.Id > 0)
                _invoiceService.DeleteInvoice(invoice);

            _invoices.Remove(invoice);
            GvInvoices.Rows.RemoveAt(GvInvoices.SelectedRows[0].Index);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var invoice = GetSelectedItem();
            if (invoice is null)
            {
                CustomMessageBox.Show("آیتمی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var frmInvoice = new FrmInvoice(invoice);
            frmInvoice.ShowDialog();

            LoadData();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (GetSelectedItem() is null)
            {
                CustomMessageBox.Show("آیتمی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var printForm = new FrmPrePrintInvoice(GetSelectedItem()!);
            printForm.ShowDialog();
        }

        private Invoice? GetSelectedItem()
        {
            if (GvInvoices.SelectedRows.Count == 0 || GvInvoices.SelectedRows[0].IsNewRow)
                return null;

            int.TryParse(GvInvoices.SelectedRows[0].Cells["Id"].Value.ToString(), out var invoiceId);

            var invoice = _invoiceService.GetInvoice(invoiceId);

            return invoice;
        }

        private void LoadData()
        {
            _invoices = new BindingList<Invoice>(_invoiceService.GetInvoices());
            GvInvoices.DataSource = _invoices;
        }

        private void MakeReadonlyProperties(params string[] properties)
        {
            foreach (var property in properties)
                if (GvInvoices.Columns[property] is not null)
                    GvInvoices.Columns[property]!.ReadOnly = true;
        }

        private void HideProperties(params string[] properties)
        {
            foreach (var property in properties)
                if (GvInvoices.Columns[property] is not null)
                    GvInvoices.Columns[property]!.Visible = false;
        }

        private void SetDisplayColumnName(params (string name, string text)[] properties)
        {
            foreach (var property in properties)
                if (GvInvoices.Columns[property.name] is not null)
                    GvInvoices.Columns[property.name]!.HeaderText = property.text;
        }
    }
}
