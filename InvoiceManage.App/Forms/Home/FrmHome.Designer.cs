namespace InvoiceManage.App.Forms.Home
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            AddInvoice = new Resources.CustomToolBox.RoundedButton();
            InvoiceList = new Resources.CustomToolBox.RoundedButton();
            Settings = new Resources.CustomToolBox.RoundedButton();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            BtnMinimize = new System.Windows.Forms.PictureBox();
            BtnClose = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            SuspendLayout();
            // 
            // AddInvoice
            // 
            AddInvoice.BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
            AddInvoice.BackgroundColor = System.Drawing.Color.FromArgb(68, 68, 68);
            AddInvoice.BorderColor = System.Drawing.Color.PaleVioletRed;
            AddInvoice.BorderRadius = 20;
            AddInvoice.BorderSize = 0;
            AddInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            AddInvoice.FlatAppearance.BorderSize = 0;
            AddInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddInvoice.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            AddInvoice.ForeColor = System.Drawing.Color.White;
            AddInvoice.Location = new System.Drawing.Point(43, 42);
            AddInvoice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            AddInvoice.Name = "AddInvoice";
            AddInvoice.Size = new System.Drawing.Size(250, 70);
            AddInvoice.TabIndex = 0;
            AddInvoice.Text = "ثبت فاکتور";
            AddInvoice.TextColor = System.Drawing.Color.White;
            AddInvoice.UseVisualStyleBackColor = false;
            AddInvoice.Click += AddInvoice_Click;
            // 
            // InvoiceList
            // 
            InvoiceList.BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
            InvoiceList.BackgroundColor = System.Drawing.Color.FromArgb(68, 68, 68);
            InvoiceList.BorderColor = System.Drawing.Color.PaleVioletRed;
            InvoiceList.BorderRadius = 20;
            InvoiceList.BorderSize = 0;
            InvoiceList.Cursor = System.Windows.Forms.Cursors.Hand;
            InvoiceList.FlatAppearance.BorderSize = 0;
            InvoiceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            InvoiceList.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            InvoiceList.ForeColor = System.Drawing.Color.White;
            InvoiceList.Location = new System.Drawing.Point(43, 140);
            InvoiceList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            InvoiceList.Name = "InvoiceList";
            InvoiceList.Size = new System.Drawing.Size(250, 70);
            InvoiceList.TabIndex = 1;
            InvoiceList.Text = "لیست فاکتور ها";
            InvoiceList.TextColor = System.Drawing.Color.White;
            InvoiceList.UseVisualStyleBackColor = false;
            InvoiceList.Click += InvoiceList_Click;
            // 
            // Settings
            // 
            Settings.BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
            Settings.BackgroundColor = System.Drawing.Color.FromArgb(68, 68, 68);
            Settings.BorderColor = System.Drawing.Color.PaleVioletRed;
            Settings.BorderRadius = 20;
            Settings.BorderSize = 0;
            Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            Settings.FlatAppearance.BorderSize = 0;
            Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Settings.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Settings.ForeColor = System.Drawing.Color.White;
            Settings.Location = new System.Drawing.Point(43, 238);
            Settings.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Settings.Name = "Settings";
            Settings.Size = new System.Drawing.Size(250, 70);
            Settings.TabIndex = 2;
            Settings.Text = "تنظیمات";
            Settings.TextColor = System.Drawing.Color.White;
            Settings.UseVisualStyleBackColor = false;
            Settings.Click += Settings_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(AddInvoice);
            panel1.Controls.Add(InvoiceList);
            panel1.Controls.Add(Settings);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new System.Drawing.Point(5, 40);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(609, 355);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 16.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            label1.Location = new System.Drawing.Point(351, 254);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(201, 36);
            label1.TabIndex = 4;
            label1.Text = "سامانه مدیریت فاکتور";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(349, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(203, 207);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // BtnMinimize
            // 
            BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnMinimize.Image = Properties.Resources.minimize_w;
            BtnMinimize.Location = new System.Drawing.Point(547, 2);
            BtnMinimize.Name = "BtnMinimize";
            BtnMinimize.Size = new System.Drawing.Size(37, 37);
            BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BtnMinimize.TabIndex = 8;
            BtnMinimize.TabStop = false;
            BtnMinimize.Click += BtnMinimize_Click;
            // 
            // BtnClose
            // 
            BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnClose.Image = Properties.Resources.close_w;
            BtnClose.Location = new System.Drawing.Point(581, 2);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new System.Drawing.Size(37, 37);
            BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BtnClose.TabIndex = 9;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
            ClientSize = new System.Drawing.Size(619, 400);
            Controls.Add(BtnClose);
            Controls.Add(BtnMinimize);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "FrmHome";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmMain";
            MouseDown += FrmHome_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Resources.CustomToolBox.RoundedButton AddInvoice;
        private Resources.CustomToolBox.RoundedButton InvoiceList;
        private Resources.CustomToolBox.RoundedButton Settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BtnMinimize;
        private System.Windows.Forms.PictureBox BtnClose;
    }
}