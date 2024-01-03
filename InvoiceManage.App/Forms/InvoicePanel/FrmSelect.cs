using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;

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
            objectsGv.DataSource = _data;
        }

        protected override void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override void BtnSelect_Click(object sender, EventArgs e)
        {
            if (objectsGv.SelectedRows.Count == 0 || objectsGv.SelectedRows[0].IsNewRow || objectsGv.CurrentRow is null)
            {
                CustomMessageBox.Show("آیتمی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SelectedItem = (T?)objectsGv.CurrentRow.DataBoundItem;
            DialogResult = DialogResult.OK;
        }
    }
}
