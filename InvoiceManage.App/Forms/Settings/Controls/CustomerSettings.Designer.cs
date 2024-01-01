namespace InvoiceManage.App.Forms.Settings.Controls
{
    partial class CustomerSettings
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
            groupBox11 = new System.Windows.Forms.GroupBox();
            TxtBId = new System.Windows.Forms.TextBox();
            groupBox9 = new System.Windows.Forms.GroupBox();
            TxtTinb = new System.Windows.Forms.TextBox();
            CustomersGv = new System.Windows.Forms.DataGridView();
            BtnAdd = new Resources.CustomToolBox.RoundedButton();
            TxtName = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            TxtBbc = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            TxtBpc = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            TxtBpn = new System.Windows.Forms.TextBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            TxtBillId = new System.Windows.Forms.TextBox();
            groupBox11.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGv).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(TxtBId);
            groupBox11.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox11.ForeColor = System.Drawing.Color.DimGray;
            groupBox11.Location = new System.Drawing.Point(292, 31);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new System.Drawing.Size(244, 70);
            groupBox11.TabIndex = 226;
            groupBox11.TabStop = false;
            groupBox11.Text = "شناسه ملی";
            // 
            // TxtBId
            // 
            TxtBId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBId.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBId.Location = new System.Drawing.Point(15, 28);
            TxtBId.Name = "TxtBId";
            TxtBId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtBId.Size = new System.Drawing.Size(217, 29);
            TxtBId.TabIndex = 0;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(TxtTinb);
            groupBox9.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox9.ForeColor = System.Drawing.Color.DimGray;
            groupBox9.Location = new System.Drawing.Point(553, 31);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new System.Drawing.Size(205, 70);
            groupBox9.TabIndex = 225;
            groupBox9.TabStop = false;
            groupBox9.Text = "شماره اقتصادی";
            // 
            // TxtTinb
            // 
            TxtTinb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtTinb.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtTinb.Location = new System.Drawing.Point(10, 28);
            TxtTinb.Name = "TxtTinb";
            TxtTinb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtTinb.Size = new System.Drawing.Size(186, 29);
            TxtTinb.TabIndex = 0;
            // 
            // CustomersGv
            // 
            CustomersGv.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            CustomersGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGv.Location = new System.Drawing.Point(32, 316);
            CustomersGv.Name = "CustomersGv";
            CustomersGv.RowTemplate.Height = 25;
            CustomersGv.Size = new System.Drawing.Size(727, 382);
            CustomersGv.TabIndex = 227;
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
            BtnAdd.Location = new System.Drawing.Point(32, 230);
            BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new System.Drawing.Size(179, 47);
            BtnAdd.TabIndex = 224;
            BtnAdd.Text = "افزودن";
            BtnAdd.TextColor = System.Drawing.Color.White;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // TxtName
            // 
            TxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtName.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtName.Location = new System.Drawing.Point(15, 28);
            TxtName.Name = "TxtName";
            TxtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtName.Size = new System.Drawing.Size(217, 29);
            TxtName.TabIndex = 0;
            TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TxtBbc);
            groupBox3.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox3.ForeColor = System.Drawing.Color.DimGray;
            groupBox3.Location = new System.Drawing.Point(292, 114);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(244, 70);
            groupBox3.TabIndex = 230;
            groupBox3.TabStop = false;
            groupBox3.Text = "کد شعبه";
            // 
            // TxtBbc
            // 
            TxtBbc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBbc.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBbc.Location = new System.Drawing.Point(15, 28);
            TxtBbc.Name = "TxtBbc";
            TxtBbc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtBbc.Size = new System.Drawing.Size(217, 29);
            TxtBbc.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtName);
            groupBox1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.ForeColor = System.Drawing.Color.DimGray;
            groupBox1.Location = new System.Drawing.Point(32, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(244, 70);
            groupBox1.TabIndex = 228;
            groupBox1.TabStop = false;
            groupBox1.Text = "نام";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(TxtBpc);
            groupBox4.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox4.ForeColor = System.Drawing.Color.DimGray;
            groupBox4.Location = new System.Drawing.Point(553, 114);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(205, 70);
            groupBox4.TabIndex = 229;
            groupBox4.TabStop = false;
            groupBox4.Text = "کدپستی";
            // 
            // TxtBpc
            // 
            TxtBpc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBpc.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBpc.Location = new System.Drawing.Point(10, 28);
            TxtBpc.Name = "TxtBpc";
            TxtBpc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtBpc.Size = new System.Drawing.Size(186, 29);
            TxtBpc.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtBpn);
            groupBox2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.ForeColor = System.Drawing.Color.DimGray;
            groupBox2.Location = new System.Drawing.Point(32, 114);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(244, 70);
            groupBox2.TabIndex = 231;
            groupBox2.TabStop = false;
            groupBox2.Text = "شماره گذرنامه";
            // 
            // TxtBpn
            // 
            TxtBpn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBpn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBpn.Location = new System.Drawing.Point(15, 28);
            TxtBpn.Name = "TxtBpn";
            TxtBpn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtBpn.Size = new System.Drawing.Size(217, 29);
            TxtBpn.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(TxtBillId);
            groupBox5.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox5.ForeColor = System.Drawing.Color.DimGray;
            groupBox5.Location = new System.Drawing.Point(292, 207);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(466, 70);
            groupBox5.TabIndex = 232;
            groupBox5.TabStop = false;
            groupBox5.Text = "شماره اشتراک/ شناسه قبض بهربرداری";
            // 
            // TxtBillId
            // 
            TxtBillId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBillId.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBillId.Location = new System.Drawing.Point(10, 28);
            TxtBillId.Name = "TxtBillId";
            TxtBillId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtBillId.Size = new System.Drawing.Size(447, 29);
            TxtBillId.TabIndex = 0;
            // 
            // CustomerSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox11);
            Controls.Add(groupBox9);
            Controls.Add(CustomersGv);
            Controls.Add(BtnAdd);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "CustomerSettings";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(793, 730);
            Load += CustomerSettings_Load;
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGv).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox TxtBId;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox TxtTinb;
        private System.Windows.Forms.DataGridView CustomersGv;
        private Resources.CustomToolBox.RoundedButton BtnAdd;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtBbc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtBpc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtBpn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TxtBillId;
    }
}
