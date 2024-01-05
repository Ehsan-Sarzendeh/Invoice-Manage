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
            GvProducts = new System.Windows.Forms.DataGridView();
            BtnAdd = new Resources.CustomToolBox.RoundedButton();
            gb = new System.Windows.Forms.GroupBox();
            TxtVra = new System.Windows.Forms.TextBox();
            groupBox10 = new System.Windows.Forms.GroupBox();
            TxtSstt = new System.Windows.Forms.TextBox();
            gb2 = new System.Windows.Forms.GroupBox();
            TxtSstid = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            BtnEdit = new System.Windows.Forms.PictureBox();
            BtnDelete = new System.Windows.Forms.PictureBox();
            BtnEditProduct = new Resources.CustomToolBox.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)GvProducts).BeginInit();
            gb.SuspendLayout();
            groupBox10.SuspendLayout();
            gb2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnDelete).BeginInit();
            SuspendLayout();
            // 
            // GvProducts
            // 
            GvProducts.AllowUserToAddRows = false;
            GvProducts.AllowUserToDeleteRows = false;
            GvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            GvProducts.BackgroundColor = System.Drawing.Color.White;
            GvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GvProducts.Location = new System.Drawing.Point(33, 292);
            GvProducts.MultiSelect = false;
            GvProducts.Name = "GvProducts";
            GvProducts.ReadOnly = true;
            GvProducts.RowTemplate.Height = 25;
            GvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            GvProducts.Size = new System.Drawing.Size(727, 409);
            GvProducts.TabIndex = 225;
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
            BtnAdd.Location = new System.Drawing.Point(33, 165);
            BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new System.Drawing.Size(159, 47);
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
            gb.Location = new System.Drawing.Point(222, 32);
            gb.Name = "gb";
            gb.Size = new System.Drawing.Size(216, 70);
            gb.TabIndex = 224;
            gb.TabStop = false;
            gb.Text = "نرخ مالیات بر ارزش افزوده";
            // 
            // TxtVra
            // 
            TxtVra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtVra.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtVra.Location = new System.Drawing.Point(16, 30);
            TxtVra.Name = "TxtVra";
            TxtVra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtVra.Size = new System.Drawing.Size(182, 29);
            TxtVra.TabIndex = 0;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(TxtSstt);
            groupBox10.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox10.ForeColor = System.Drawing.Color.DimGray;
            groupBox10.Location = new System.Drawing.Point(222, 108);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new System.Drawing.Size(537, 104);
            groupBox10.TabIndex = 223;
            groupBox10.TabStop = false;
            groupBox10.Text = "شرح کالا";
            // 
            // TxtSstt
            // 
            TxtSstt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtSstt.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtSstt.Location = new System.Drawing.Point(15, 25);
            TxtSstt.Multiline = true;
            TxtSstt.Name = "TxtSstt";
            TxtSstt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtSstt.Size = new System.Drawing.Size(509, 72);
            TxtSstt.TabIndex = 0;
            TxtSstt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gb2
            // 
            gb2.Controls.Add(TxtSstid);
            gb2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gb2.ForeColor = System.Drawing.Color.DimGray;
            gb2.Location = new System.Drawing.Point(456, 32);
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
            TxtSstid.Location = new System.Drawing.Point(12, 29);
            TxtSstid.Name = "TxtSstid";
            TxtSstid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtSstid.Size = new System.Drawing.Size(279, 29);
            TxtSstid.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Control;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnEdit);
            panel1.Controls.Add(BtnDelete);
            panel1.Location = new System.Drawing.Point(33, 236);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(727, 55);
            panel1.TabIndex = 226;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            label1.Location = new System.Drawing.Point(604, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 32);
            label1.TabIndex = 7;
            label1.Text = "لیست کالا ها";
            // 
            // BtnEdit
            // 
            BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new System.Drawing.Point(54, 5);
            BtnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new System.Drawing.Size(45, 45);
            BtnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BtnEdit.TabIndex = 6;
            BtnEdit.TabStop = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new System.Drawing.Point(4, 5);
            BtnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new System.Drawing.Size(45, 45);
            BtnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BtnDelete.TabIndex = 5;
            BtnDelete.TabStop = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnEditProduct
            // 
            BtnEditProduct.BackColor = System.Drawing.Color.Orange;
            BtnEditProduct.BackgroundColor = System.Drawing.Color.Orange;
            BtnEditProduct.BorderColor = System.Drawing.Color.PaleVioletRed;
            BtnEditProduct.BorderRadius = 10;
            BtnEditProduct.BorderSize = 0;
            BtnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnEditProduct.FlatAppearance.BorderSize = 0;
            BtnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnEditProduct.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnEditProduct.ForeColor = System.Drawing.Color.White;
            BtnEditProduct.Location = new System.Drawing.Point(33, 108);
            BtnEditProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnEditProduct.Name = "BtnEditProduct";
            BtnEditProduct.Size = new System.Drawing.Size(159, 47);
            BtnEditProduct.TabIndex = 227;
            BtnEditProduct.Text = "ویرایش";
            BtnEditProduct.TextColor = System.Drawing.Color.White;
            BtnEditProduct.UseVisualStyleBackColor = false;
            BtnEditProduct.Click += BtnEditProduct_Click;
            // 
            // ProductSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(BtnEditProduct);
            Controls.Add(panel1);
            Controls.Add(GvProducts);
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
            ((System.ComponentModel.ISupportInitialize)GvProducts).EndInit();
            gb.ResumeLayout(false);
            gb.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnDelete).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView GvProducts;
        private Resources.CustomToolBox.RoundedButton BtnAdd;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.TextBox TxtVra;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox TxtSstt;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.TextBox TxtSstid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BtnEdit;
        private System.Windows.Forms.PictureBox BtnDelete;
        private System.Windows.Forms.Label label1;
        private Resources.CustomToolBox.RoundedButton BtnEditProduct;
    }
}
