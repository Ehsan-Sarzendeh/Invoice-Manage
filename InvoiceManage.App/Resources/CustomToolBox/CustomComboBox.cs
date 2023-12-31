﻿using System.Windows.Forms;

namespace InvoiceManage.App.Resources.CustomToolBox
{
    public class CustomComboBox : ComboBox
    {
        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData & (Keys.Alt | Keys.KeyCode))
            {
                case Keys.Enter:
                case Keys.Escape:
                    if (DroppedDown)
                    {
                        DroppedDown = false;
                        return false;
                    }
                    break;
            }
            return base.IsInputKey(keyData);
        }
    }
}