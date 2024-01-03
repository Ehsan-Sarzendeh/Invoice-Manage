using System;
using System.Windows.Forms;
using InvoiceManage.App.Resources.CustomToolBox;
using InvoiceManage.Database.Entities;
using InvoiceManage.Database.Infrastructures;

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