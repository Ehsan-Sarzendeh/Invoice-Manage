namespace InvoiceManage.App.Forms.Settings
{
    partial class FrmSettings
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
            BtnClose = new System.Windows.Forms.PictureBox();
            BtnMinimize = new System.Windows.Forms.PictureBox();
            BtnProduct = new Resources.CustomToolBox.RoundedButton();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            BtnCustomer = new Resources.CustomToolBox.RoundedButton();
            BtnCompany = new Resources.CustomToolBox.RoundedButton();
            label1 = new System.Windows.Forms.Label();
            PanelSlider = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimize).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnClose
            // 
            BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnClose.Image = Properties.Resources.close_w;
            BtnClose.Location = new System.Drawing.Point(190, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new System.Drawing.Size(37, 37);
            BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BtnClose.TabIndex = 11;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnMinimize
            // 
            BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnMinimize.Image = Properties.Resources.minimize_w;
            BtnMinimize.Location = new System.Drawing.Point(156, 0);
            BtnMinimize.Name = "BtnMinimize";
            BtnMinimize.Size = new System.Drawing.Size(37, 37);
            BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BtnMinimize.TabIndex = 10;
            BtnMinimize.TabStop = false;
            BtnMinimize.Click += BtnMinimize_Click;
            // 
            // BtnProduct
            // 
            BtnProduct.BackColor = System.Drawing.Color.White;
            BtnProduct.BackgroundColor = System.Drawing.Color.White;
            BtnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            BtnProduct.BorderColor = System.Drawing.Color.White;
            BtnProduct.BorderRadius = 20;
            BtnProduct.BorderSize = 0;
            BtnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnProduct.FlatAppearance.BorderSize = 0;
            BtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnProduct.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnProduct.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            BtnProduct.Location = new System.Drawing.Point(-35, 235);
            BtnProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            BtnProduct.Name = "BtnProduct";
            BtnProduct.Size = new System.Drawing.Size(224, 60);
            BtnProduct.TabIndex = 12;
            BtnProduct.Text = "کـــــالا    ";
            BtnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            BtnProduct.TextColor = System.Drawing.Color.FromArgb(68, 68, 68);
            BtnProduct.UseVisualStyleBackColor = false;
            BtnProduct.Click += BtnProduct_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BtnCustomer);
            panel1.Controls.Add(BtnCompany);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnProduct);
            panel1.Controls.Add(BtnMinimize);
            panel1.Controls.Add(BtnClose);
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(796, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(230, 738);
            panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.settings;
            pictureBox1.Location = new System.Drawing.Point(67, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(97, 89);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // BtnCustomer
            // 
            BtnCustomer.BackColor = System.Drawing.Color.White;
            BtnCustomer.BackgroundColor = System.Drawing.Color.White;
            BtnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            BtnCustomer.BorderColor = System.Drawing.Color.White;
            BtnCustomer.BorderRadius = 20;
            BtnCustomer.BorderSize = 0;
            BtnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnCustomer.FlatAppearance.BorderSize = 0;
            BtnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnCustomer.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnCustomer.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            BtnCustomer.Location = new System.Drawing.Point(-35, 414);
            BtnCustomer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            BtnCustomer.Name = "BtnCustomer";
            BtnCustomer.Size = new System.Drawing.Size(224, 60);
            BtnCustomer.TabIndex = 16;
            BtnCustomer.Text = "خریــدار    ";
            BtnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            BtnCustomer.TextColor = System.Drawing.Color.FromArgb(68, 68, 68);
            BtnCustomer.UseVisualStyleBackColor = false;
            BtnCustomer.Click += BtnCustomer_Click;
            // 
            // BtnCompany
            // 
            BtnCompany.BackColor = System.Drawing.Color.White;
            BtnCompany.BackgroundColor = System.Drawing.Color.White;
            BtnCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            BtnCompany.BorderColor = System.Drawing.Color.White;
            BtnCompany.BorderRadius = 20;
            BtnCompany.BorderSize = 0;
            BtnCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnCompany.FlatAppearance.BorderSize = 0;
            BtnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnCompany.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnCompany.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            BtnCompany.Location = new System.Drawing.Point(-35, 323);
            BtnCompany.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            BtnCompany.Name = "BtnCompany";
            BtnCompany.Size = new System.Drawing.Size(224, 60);
            BtnCompany.TabIndex = 15;
            BtnCompany.Text = "فروشنده    ";
            BtnCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            BtnCompany.TextColor = System.Drawing.Color.FromArgb(68, 68, 68);
            BtnCompany.UseVisualStyleBackColor = false;
            BtnCompany.Click += BtnCompany_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(67, 156);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 40);
            label1.TabIndex = 14;
            label1.Text = "تنظیمات";
            // 
            // PanelSlider
            // 
            PanelSlider.BackColor = System.Drawing.Color.White;
            PanelSlider.Location = new System.Drawing.Point(4, 4);
            PanelSlider.Name = "PanelSlider";
            PanelSlider.Size = new System.Drawing.Size(793, 730);
            PanelSlider.TabIndex = 14;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
            ClientSize = new System.Drawing.Size(1026, 738);
            Controls.Add(PanelSlider);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FrmSettings";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "تنظیمات";
            FormClosing += FrmSettings_FormClosing;
            Load += FrmSettings_Load;
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimize).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.PictureBox BtnMinimize;
        private Resources.CustomToolBox.RoundedButton BtnProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Resources.CustomToolBox.RoundedButton BtnCompany;
        private Resources.CustomToolBox.RoundedButton BtnCustomer;
        private System.Windows.Forms.Panel PanelSlider;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}