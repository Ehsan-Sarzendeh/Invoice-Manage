using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.Infrastructures;

namespace InvoiceManage.App.Forms.InvoicePanel
{
    public partial class FrmSelect<T> : FrmSelectAbstract
    {
        private readonly List<T> _data;

        public T? SelectedItem;

        public FrmSelect(List<T> data)
        {
            _data = data;
        }

        protected override void FrmSelect_Load(object sender, EventArgs e)
        {
            GvRecords.DataSource = _data;
            GvRecords.SetHeaders(typeof(T));
        }

        protected override void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override void BtnSelect_Click(object sender, EventArgs e)
        {
            if (GvRecords.SelectedRows.Count == 0 || GvRecords.SelectedRows[0].IsNewRow || GvRecords.CurrentRow is null)
            {
                CustomMessageBox.Show("آیتمی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SelectedItem = (T?)GvRecords.CurrentRow.DataBoundItem;
            DialogResult = DialogResult.OK;
        }
    }
}
