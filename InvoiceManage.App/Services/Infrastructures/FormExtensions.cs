﻿using InvoiceManage.Database.Infrastructures;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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

        public static void SetNumberFormat(this Control control, object obj)
        {
            control.SetNumberFormat(obj.GetType().GetProperties());
        }
        private static void SetNumberFormat(this Control control, params PropertyInfo[] properties)
        {
            switch (control)
            {
                case TextBoxBase textBoxBase:
                    var name = textBoxBase.Name
                        .Replace("mtxt", "", StringComparison.OrdinalIgnoreCase)
                        .Replace("txt", "", StringComparison.OrdinalIgnoreCase);

                    var property = properties.FirstOrDefault(x => x.Name.Equals(name));

                    if (property is not null && (property.PropertyType == typeof(byte) ||
                                                 property.PropertyType == typeof(short) ||
                                                 property.PropertyType == typeof(int) ||
                                                 property.PropertyType == typeof(long)))
                        textBoxBase.KeyPress += IntegerControl_KeyPress!;
                    else if (property is not null && (property.PropertyType == typeof(float) ||
                                                      property.PropertyType == typeof(decimal)))
                        textBoxBase.KeyPress += DecimalControl_KeyPress!;

                    break;
            }

            foreach (Control c in control.Controls)
                SetNumberFormat(c, properties);
        }

        public static void SetDataBindings(this Control control, object obj)
        {
            control.SetDataBindings(obj, obj.GetType().GetProperties());
        } 
        private static void SetDataBindings(this Control control, object obj, params PropertyInfo[] properties)
        {
            switch (control)
            {
                case TextBox textBox:
                    var name = textBox.Name.Replace("txt", "", StringComparison.OrdinalIgnoreCase);
                    
                    var property = properties.FirstOrDefault(x => x.Name.Equals(name));

                    if (property is not null && (property.GetCustomAttribute<BindableAttribute>() is null || (bool)property.GetCustomAttribute<BindableAttribute>()?.Bindable))
                        textBox.DataBindings.Add("Text", obj, property.Name, true, DataSourceUpdateMode.OnPropertyChanged);

                    break;

                case MaskedTextBox maskTextBox:
                    name = maskTextBox.Name.Replace("mtxt", "", StringComparison.OrdinalIgnoreCase);

                    property = properties.FirstOrDefault(x => x.Name.Equals(name));

                    if (property is not null && (property.GetCustomAttribute<BindableAttribute>() is null || (bool)property.GetCustomAttribute<BindableAttribute>()?.Bindable))
                        maskTextBox.DataBindings.Add("Text", obj, property.Name, true, DataSourceUpdateMode.OnPropertyChanged);

                    break;

                case ComboBox comboBox:
                    name = comboBox.Name.Replace("Cb", "", StringComparison.OrdinalIgnoreCase);

                    property = properties.FirstOrDefault(x => x.Name.Equals(name));

                    if (property is not null && (property.GetCustomAttribute<BindableAttribute>() is null || (bool)property.GetCustomAttribute<BindableAttribute>()?.Bindable))
                        comboBox.DataBindings.Add("SelectedValue", obj, property.Name, true, DataSourceUpdateMode.OnPropertyChanged);

                    break;
            }

            foreach (Control c in control.Controls)
                SetDataBindings(c, obj, properties);
        }

        private static void DecimalControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            
            if (e.KeyChar == '.' && (sender as TextBoxBase)!.Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private static void IntegerControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}