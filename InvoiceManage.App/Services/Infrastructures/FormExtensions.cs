using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;
using Microsoft.EntityFrameworkCore.Metadata;

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

        public static void SetMode(this GroupBox groupBox, int type, int pattern)
        {
            var mode = groupBox.Name.GetMode(type, pattern);

            switch (mode)
            {
                case Mode.Required:
                    groupBox.Name = groupBox.Name.Replace("*", string.Empty) + "**";

                    break;
                case Mode.SemiRequired:
                    groupBox.Name = groupBox.Name.Replace("*", string.Empty) + "*";
                    break;
                case Mode.Optional:
                    groupBox.Name = groupBox.Name.Replace("*", string.Empty);
                    break;
                case Mode.Ignore:
                    groupBox.Name = groupBox.Name.Replace("*", string.Empty);
                    break;
            }
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

        public static void ResetValue(this GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                switch (control)
                {
                    case TextBoxBase txt:
                        txt.Text = default;
                        break;
                    case ComboBox combo:
                        combo.SelectedItem = -1;
                        break;
                }
            }
        }
    }
}