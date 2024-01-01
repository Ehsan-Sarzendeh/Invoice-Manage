using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using InvoiceManage.App.Forms.Common;
using InvoiceManage.App.Services.Infrastructures;

namespace InvoiceManage.App.Resources.CustomToolBox
{
    public class CustomGroupBox : GroupBox
    {
        private Mode mode;
        private bool showOptional;
        private bool showSemiRequired;

        public bool ShowOptional
        {
            get => showOptional;
            set
            {
                showOptional = value;

                ChangeReadOnly();
            }
        }

        public bool ShowSemiRequired
        {
            get => showSemiRequired;
            set
            {
                showSemiRequired = value;

                ChangeReadOnly();
            }
        }
        
        [Browsable(true)]
        [DefaultValue(Mode.Optional)]
        [Localizable(true)]
        public Mode Mode
        {
            get => mode;
            set
            {
                mode = value;

                Text = mode switch
                {
                    Mode.Required => Text.Replace(@"*", string.Empty) + @"**",
                    Mode.SemiRequired => Text.Replace(@"*", string.Empty) + @"*",
                    Mode.Optional => Text.Replace(@"*", string.Empty),
                    Mode.Ignore => Text.Replace(@"*", string.Empty),
                    _ => Text
                };

                ChangeReadOnly();
            }
        }

        private void ChangeReadOnly()
        {
            switch (mode)
            {
                case Mode.Required:
                    ForeColor = Color.DimGray;
                    this.ChangeReadOnly(false);
                    break;
                case Mode.SemiRequired:
                    if (showSemiRequired)
                    {
                        ForeColor = Color.DimGray;
                        this.ChangeReadOnly(false);
                        break;
                    }

                    ForeColor = Color.DarkGray;
                    this.ChangeReadOnly(true);

                    break;
                case Mode.Optional:
                    if (showOptional)
                    {
                        ForeColor = Color.DimGray;
                        this.ChangeReadOnly(false);
                        break;
                    }

                    ForeColor = Color.DarkGray;
                    this.ChangeReadOnly(true);

                    break;
                case Mode.Ignore:
                    ForeColor = Color.DarkGray;
                    this.ChangeReadOnly(true);
                    this.ResetValue();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}