using InvoiceManage.App.Forms.Common;
using InvoiceManage.Database.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms.Invoice
{
    public partial class FrmSelect : Form
    {
        readonly List<object> _data;

        public object? SelectedItem;

        public FrmSelect(List<object> data)
        {
            InitializeComponent();
            _data = data;
        }

        private void FrmSelect_Load(object sender, EventArgs e)
        {
            objectsGv.DataSource = _data;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (objectsGv.SelectedRows.Count == 0 || objectsGv.SelectedRows[0].IsNewRow || objectsGv.CurrentRow is null)
            {
                CustomMessageBox.Show("آیتمی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SelectedItem = objectsGv.CurrentRow.DataBoundItem;
            DialogResult = DialogResult.OK;
        }
    }
}
