using InvoiceManage.Database.Infrastructures;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Windows.Forms;

namespace InvoiceManage.App.Services.Infrastructures
{
    public static class FormExtensions
    {
        public static void SetEnumDataSource(this ComboBox combo, Type targerEnum)
        {
            combo.DataSource = EnumExtensions.GetValues(targerEnum);
            combo.DisplayMember = "Display";
            combo.ValueMember = "Value";
        }

        public static void SetHeaders(this DataGridView dataGrid, Type target)
        {
            foreach (var property in target.GetProperties())
                if (dataGrid.Columns.Contains(property.Name))
                    dataGrid.Columns[property.Name]!.HeaderText = property.GetCustomAttribute<DisplayAttribute>(false)?.Name ?? property.Name;
        }

        public static void ChangeReadOnly(this GroupBox groupBox, bool disable)
        {
            foreach (Control control in groupBox.Controls)
            {
                switch (control)
                {
                    case TextBoxBase txt:
                        txt.ReadOnly = disable;
                        txt.Visible = !disable;
                        break;
                    case ListControl combo:
                        combo.Enabled = !disable;
                        combo.Visible = !disable;
                        break;
                }
            }
        }

        public static void ClearControls(this Control control)
        {
            switch (control)
            {
                case TextBoxBase textBox:
                    textBox.Clear();
                    break;

                case ComboBox comboBox:
                    comboBox.SelectedItem = null;
                    break;
            }

            foreach (Control c in control.Controls)
                ClearControls(c);
        }
    }
}