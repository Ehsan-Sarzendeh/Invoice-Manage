namespace InvoiceManage.App.Forms.Settings.Controls
{
    partial class ProductSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProductsGv = new System.Windows.Forms.DataGridView();
            BtnAdd = new Resources.CustomToolBox.RoundedButton();
            gb = new System.Windows.Forms.GroupBox();
            TxtVra = new System.Windows.Forms.TextBox();
            groupBox10 = new System.Windows.Forms.GroupBox();
            TxtSstt = new System.Windows.Forms.TextBox();
            gb2 = new System.Windows.Forms.GroupBox();
            TxtSstid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)ProductsGv).BeginInit();
            gb.SuspendLayout();
            groupBox10.SuspendLayout();
            gb2.SuspendLayout();
            SuspendLayout();
            // 
            // ProductsGv
            // 
            ProductsGv.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            ProductsGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsGv.Location = new System.Drawing.Point(32, 242);
            ProductsGv.Name = "ProductsGv";
            ProductsGv.RowTemplate.Height = 25;
            ProductsGv.Size = new System.Drawing.Size(727, 451);
            ProductsGv.TabIndex = 225;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = System.Drawing.Color.Green;
            BtnAdd.BackgroundColor = System.Drawing.Color.Green;
            BtnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            BtnAdd.BorderRadius = 10;
            BtnAdd.BorderSize = 0;
            BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnAdd.FlatAppearance.BorderSize = 0;
            BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnAdd.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnAdd.ForeColor = System.Drawing.Color.White;
            BtnAdd.Location = new System.Drawing.Point(32, 148);
            BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new System.Drawing.Size(179, 47);
            BtnAdd.TabIndex = 221;
            BtnAdd.Text = "افزودن";
            BtnAdd.TextColor = System.Drawing.Color.White;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // gb
            // 
            gb.Controls.Add(TxtVra);
            gb.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gb.ForeColor = System.Drawing.Color.DimGray;
            gb.Location = new System.Drawing.Point(233, 31);
            gb.Name = "gb";
            gb.Size = new System.Drawing.Size(204, 70);
            gb.TabIndex = 224;
            gb.TabStop = false;
            gb.Text = "نرخ مالیات بر ارزش افزوده";
            // 
            // TxtVra
            // 
            TxtVra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtVra.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtVra.Location = new System.Drawing.Point(17, 30);
            TxtVra.Name = "TxtVra";
            TxtVra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtVra.Size = new System.Drawing.Size(172, 29);
            TxtVra.TabIndex = 0;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(TxtSstt);
            groupBox10.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox10.ForeColor = System.Drawing.Color.DimGray;
            groupBox10.Location = new System.Drawing.Point(233, 107);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new System.Drawing.Size(525, 88);
            groupBox10.TabIndex = 223;
            groupBox10.TabStop = false;
            groupBox10.Text = "شرح کالا";
            // 
            // TxtSstt
            // 
            TxtSstt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtSstt.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtSstt.Location = new System.Drawing.Point(17, 26);
            TxtSstt.Multiline = true;
            TxtSstt.Name = "TxtSstt";
            TxtSstt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtSstt.Size = new System.Drawing.Size(495, 52);
            TxtSstt.TabIndex = 0;
            TxtSstt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gb2
            // 
            gb2.Controls.Add(TxtSstid);
            gb2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gb2.ForeColor = System.Drawing.Color.DimGray;
            gb2.Location = new System.Drawing.Point(455, 31);
            gb2.Name = "gb2";
            gb2.Size = new System.Drawing.Size(303, 70);
            gb2.TabIndex = 222;
            gb2.TabStop = false;
            gb2.Text = "شناسه کالا";
            // 
            // TxtSstid
            // 
            TxtSstid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtSstid.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtSstid.Location = new System.Drawing.Point(13, 29);
            TxtSstid.Name = "TxtSstid";
            TxtSstid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtSstid.Size = new System.Drawing.Size(279, 29);
            TxtSstid.TabIndex = 0;
            // 
            // ProductSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(ProductsGv);
            Controls.Add(BtnAdd);
            Controls.Add(gb);
            Controls.Add(groupBox10);
            Controls.Add(gb2);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Name = "ProductSettings";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(793, 730);
            Load += ProductSettings_Load;
            ((System.ComponentModel.ISupportInitialize)ProductsGv).EndInit();
            gb.ResumeLayout(false);
            gb.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsGv;
        private Resources.CustomToolBox.RoundedButton BtnAdd;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.TextBox TxtVra;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox TxtSstt;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.TextBox TxtSstid;
    }
}
