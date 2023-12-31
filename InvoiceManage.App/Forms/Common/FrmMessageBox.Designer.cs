using System.Drawing;
using System.Windows.Forms;
using InvoiceManage.App.Resources.CustomToolBox;

namespace InvoiceManage.App.Forms.Common
{
    partial class FormMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessageBox));
            panelButtons = new Panel();
            button3 = new RoundedButton();
            button2 = new RoundedButton();
            button1 = new RoundedButton();
            panelTitleBar = new Panel();
            btnClose = new PictureBox();
            labelCaption = new Label();
            roundedPanel1 = new Panel();
            panelBody = new Panel();
            labelMessage = new Label();
            pictureBoxIcon = new PictureBox();
            panelButtons.SuspendLayout();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            roundedPanel1.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelButtons.BackColor = Color.FromArgb(235, 235, 235);
            panelButtons.Controls.Add(button3);
            panelButtons.Controls.Add(button2);
            panelButtons.Controls.Add(button1);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 128);
            panelButtons.Margin = new Padding(4);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(396, 67);
            panelButtons.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.BackgroundColor = Color.DimGray;
            button3.BorderColor = Color.PaleVioletRed;
            button3.BorderRadius = 10;
            button3.BorderSize = 0;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("IRANSansWeb", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(258, 13);
            button3.Name = "button3";
            button3.Size = new Size(110, 40);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.TextColor = Color.White;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.BackgroundColor = Color.DimGray;
            button2.BorderColor = Color.PaleVioletRed;
            button2.BorderRadius = 10;
            button2.BorderSize = 0;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("IRANSansWeb", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(142, 13);
            button2.Name = "button2";
            button2.Size = new Size(110, 40);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.TextColor = Color.White;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.BackgroundColor = Color.DimGray;
            button1.BorderColor = Color.PaleVioletRed;
            button1.BorderRadius = 10;
            button1.BorderSize = 0;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("IRANSansWeb", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(26, 13);
            button1.Name = "button1";
            button1.Size = new Size(110, 40);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.TextColor = Color.White;
            button1.UseVisualStyleBackColor = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(64, 64, 64);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(labelCaption);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(396, 28);
            panelTitleBar.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.close_w;
            btnClose.Location = new Point(370, -3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 5;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // labelCaption
            // 
            labelCaption.AutoSize = true;
            labelCaption.Font = new Font("IRANSansWeb", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCaption.ForeColor = Color.White;
            labelCaption.Location = new Point(8, 2);
            labelCaption.Margin = new Padding(4, 0, 4, 0);
            labelCaption.Name = "labelCaption";
            labelCaption.Size = new Size(49, 27);
            labelCaption.TabIndex = 4;
            labelCaption.Text = "عنوان";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.WhiteSmoke;
            roundedPanel1.Controls.Add(panelBody);
            roundedPanel1.Controls.Add(panelButtons);
            roundedPanel1.Controls.Add(panelTitleBar);
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.Location = new Point(5, 5);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(396, 195);
            roundedPanel1.TabIndex = 1;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.WhiteSmoke;
            panelBody.Controls.Add(labelMessage);
            panelBody.Controls.Add(pictureBoxIcon);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 28);
            panelBody.Margin = new Padding(4);
            panelBody.Name = "panelBody";
            panelBody.Padding = new Padding(12, 15, 0, 0);
            panelBody.Size = new Size(396, 100);
            panelBody.TabIndex = 8;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Dock = DockStyle.Right;
            labelMessage.Font = new Font("IRANSansWeb", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.FromArgb(85, 85, 85);
            labelMessage.Location = new Point(293, 15);
            labelMessage.Margin = new Padding(4, 0, 4, 0);
            labelMessage.MaximumSize = new Size(700, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Padding = new Padding(6, 8, 12, 22);
            labelMessage.Size = new Size(103, 61);
            labelMessage.TabIndex = 1;
            labelMessage.Text = "متن خطا";
            labelMessage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(16, 23);
            pictureBoxIcon.Margin = new Padding(4);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(42, 47);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 0;
            pictureBoxIcon.TabStop = false;
            // 
            // FormMessageBox
            // 
            AutoScaleDimensions = new SizeF(9F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(406, 205);
            Controls.Add(roundedPanel1);
            Font = new Font("IRANSansWeb", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4);
            MinimumSize = new Size(406, 201);
            Name = "FormMessageBox";
            Padding = new Padding(5);
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            TopMost = true;
            KeyDown += FormMessageBox_KeyDown;
            panelButtons.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            roundedPanel1.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private RoundedButton button3;
        private RoundedButton button2;
        private RoundedButton button1;
        private Panel panelTitleBar;
        private PictureBox btnClose;
        private Label labelCaption;
        private Panel panelBody;
        private Label labelMessage;
        private PictureBox pictureBoxIcon;
        private Panel roundedPanel1;
    }
}