using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InvoiceManage.App.Forms
{
    public partial class FormMessageBox : Form
    {
        //Fields
        private Color _primaryColor = Color.FromArgb(64, 64, 64);
        // private Color _primaryColor = Color.DarkOrange;
        private const int BorderSize = 5;

        private bool _closeWithEsc;

        //Properties
        public Color PrimaryColor
        {
            get => _primaryColor;
            set
            {
                _primaryColor = value;
                this.BackColor = _primaryColor;//Form Border Color
                this.panelTitleBar.BackColor = PrimaryColor;//Title Bar Back Color
            }
        }

        //Constructors
        public FormMessageBox(string text, bool closeWithEsc = false)
        {
            _closeWithEsc = closeWithEsc;
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = _primaryColor;
            this.labelMessage.Text = text;
            this.labelCaption.Text = "";
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public FormMessageBox(string text, string caption, bool closeWithEsc = false)
        {
            _closeWithEsc = closeWithEsc;
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = _primaryColor;
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public FormMessageBox(string text, string caption, MessageBoxButtons buttons, bool closeWithEsc = false)
        {
            _closeWithEsc = closeWithEsc;
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = _primaryColor;
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
        }
        public FormMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, bool closeWithEsc = false)
        {
            _closeWithEsc = closeWithEsc;
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = _primaryColor;
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
            SetIcon(icon);
        }
        public FormMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, bool closeWithEsc = false)
        {
            _closeWithEsc = closeWithEsc;
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = _primaryColor;
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, defaultButton);
            SetIcon(icon);
        }

        //-> Private Methods
        private void InitializeItems()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(BorderSize);//Set border size
            this.labelMessage.MaximumSize = new Size(550, 0);
            // this.btnClose.DialogResult = DialogResult.Cancel;
            this.button1.DialogResult = DialogResult.OK;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
        }
        private void SetFormSize()
        {
            var widht = this.labelMessage.Width + this.pictureBoxIcon.Width + this.panelBody.Padding.Left;
            var height = this.panelTitleBar.Height + this.labelMessage.Height + this.panelButtons.Height + this.panelBody.Padding.Top - 20;
            this.Size = new Size(widht, height);
        }
        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            var xCenter = (this.panelButtons.Width - button1.Width) / 2;
            var yCenter = (this.panelButtons.Height - button1.Height) / 2;

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    //OK Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter, yCenter);
                    button1.Text = "تایید";
                    button1.DialogResult = DialogResult.OK;//Set DialogResult

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
                case MessageBoxButtons.OKCancel:
                    //OK Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                    button1.Text = "تایید";
                    button1.DialogResult = DialogResult.OK;//Set DialogResult

                    //Cancel Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = "لغو";
                    button2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button2.BackColor = Color.DimGray;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.RetryCancel:
                    //Retry Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                    button1.Text = "تلاش دوباره";
                    button1.DialogResult = DialogResult.Retry;//Set DialogResult

                    //Cancel Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = "لغو";
                    button2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button2.BackColor = Color.DimGray;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.YesNo:
                    //Yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                    button1.Text = "بله";
                    button1.DialogResult = DialogResult.Yes;//Set DialogResult

                    //No Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = "خیر";
                    button2.DialogResult = DialogResult.No;//Set DialogResult
                    button2.BackColor = Color.IndianRed;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    //Yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                    button1.Text = "بله";
                    button1.DialogResult = DialogResult.Yes;//Set DialogResult

                    //No Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "خیر";
                    button2.DialogResult = DialogResult.No;//Set DialogResult
                    button2.BackColor = Color.IndianRed;

                    //Cancel Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = "لغو";
                    button3.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button3.BackColor = Color.DimGray;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;

                case MessageBoxButtons.AbortRetryIgnore:
                    //Abort Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                    button1.Text = "Abort";
                    button1.DialogResult = DialogResult.Abort;//Set DialogResult
                    button1.BackColor = Color.Goldenrod;

                    //Retry Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "Retry";
                    button2.DialogResult = DialogResult.Retry;//Set DialogResult                    

                    //Ignore Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = "Ignore";
                    button3.DialogResult = DialogResult.Ignore;//Set DialogResult
                    button3.BackColor = Color.IndianRed;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
            }
        }
        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1://Focus button 1
                    button1.Select();
                    button1.ForeColor = Color.White;
                    break;
                case MessageBoxDefaultButton.Button2://Focus button 2
                    button2.Select();
                    button2.ForeColor = Color.White;
                    break;
                case MessageBoxDefaultButton.Button3://Focus button 3
                    button3.Select();
                    button3.ForeColor = Color.White;
                    break;
            }
        }
        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.pictureBoxIcon.Image = Properties.Resources.error;
                    // PrimaryColor = Color.FromArgb(255, 58, 23);
                    // this.btnClose.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    break;
                case MessageBoxIcon.Information: //Information
                    this.pictureBoxIcon.Image = Properties.Resources.information;
                    // PrimaryColor = Color.FromArgb(38, 191, 166);
                    break;
                case MessageBoxIcon.Question://Question
                    this.pictureBoxIcon.Image = Properties.Resources.question;  
                    // PrimaryColor = Color.FromArgb(10, 119, 232);
                    break;
                case MessageBoxIcon.Exclamation://Exclamation
                    this.pictureBoxIcon.Image = Properties.Resources.exclamation;
                    // PrimaryColor = Color.FromArgb(255, 140, 0);
                    break;
                case MessageBoxIcon.None: //None
                    this.pictureBoxIcon.Image = Properties.Resources.chat;
                    // PrimaryColor = Color.CornflowerBlue;
                    break;
            }
        }

        //-> Events Methods
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region -> Drag Form
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void FormMessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape || !_closeWithEsc) return;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    public abstract class CustomMessageBox
    {
        public static DialogResult Show(string text, bool closeWithEsc = false)
        {
            using var msgForm = new FormMessageBox(text, closeWithEsc);
            var result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption, bool closeWithEsc = false)
        {
            using var msgForm = new FormMessageBox(text, caption, closeWithEsc);
            var result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, bool closeWithEsc = false)
        {
            using var msgForm = new FormMessageBox(text, caption, buttons, closeWithEsc);
            var result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, bool closeWithEsc = false)
        {
            using var msgForm = new FormMessageBox(text, caption, buttons, icon, closeWithEsc);
            var result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, bool closeWithEsc = false)
        {
            using var msgForm = new FormMessageBox(text, caption, buttons, icon, defaultButton, closeWithEsc);
            var result = msgForm.ShowDialog();
            return result;
        }

        /*-> IWin32Window Owner:
            *      Displays a message box in front of the specified object and with the other specified parameters.
            *      An implementation of IWin32Window that will own the modal dialog box.*/
        public static DialogResult Show(IWin32Window owner, string text)
        {
            using var msgForm = new FormMessageBox(text);
            var result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption)
        {
            using var msgForm = new FormMessageBox(text, caption);
            var result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
        {
            using var msgForm = new FormMessageBox(text, caption, buttons);
            var result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            using var msgForm = new FormMessageBox(text, caption, buttons, icon);
            var result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            using var msgForm = new FormMessageBox(text, caption, buttons, icon, defaultButton);
            var result = msgForm.ShowDialog(owner);
            return result;
        }
    }

}
