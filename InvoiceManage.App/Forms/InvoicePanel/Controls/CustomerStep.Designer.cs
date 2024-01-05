using InvoiceManage.App.Resources.CustomToolBox;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    partial class CustomerStep
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
            BtnNext = new RoundedButton();
            BtnPrevious = new RoundedButton();
            Bpn = new CustomGroupBox();
            TxtBpn = new System.Windows.Forms.TextBox();
            groupBox3 = new CustomGroupBox();
            BtnInquiry = new RoundedButton();
            textBox4 = new System.Windows.Forms.TextBox();
            BillId = new CustomGroupBox();
            TxtBillId = new System.Windows.Forms.TextBox();
            BId = new CustomGroupBox();
            TxtBId = new System.Windows.Forms.TextBox();
            Bbc = new CustomGroupBox();
            TxtBbc = new System.Windows.Forms.TextBox();
            Tinb = new CustomGroupBox();
            TxtTinb = new System.Windows.Forms.TextBox();
            BtnSelect = new RoundedButton();
            Ft = new CustomGroupBox();
            CbFt = new System.Windows.Forms.ComboBox();
            Bpc = new CustomGroupBox();
            TxtBpc = new System.Windows.Forms.TextBox();
            Bpn.SuspendLayout();
            groupBox3.SuspendLayout();
            BillId.SuspendLayout();
            BId.SuspendLayout();
            Bbc.SuspendLayout();
            Tinb.SuspendLayout();
            Ft.SuspendLayout();
            Bpc.SuspendLayout();
            SuspendLayout();
            // 
            // BtnNext
            // 
            BtnNext.BackColor = System.Drawing.Color.Green;
            BtnNext.BackgroundColor = System.Drawing.Color.Green;
            BtnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            BtnNext.BorderRadius = 10;
            BtnNext.BorderSize = 0;
            BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnNext.FlatAppearance.BorderSize = 0;
            BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnNext.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnNext.ForeColor = System.Drawing.Color.White;
            BtnNext.Location = new System.Drawing.Point(4, 551);
            BtnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnNext.Name = "BtnNext";
            BtnNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            BtnNext.Size = new System.Drawing.Size(120, 47);
            BtnNext.TabIndex = 1;
            BtnNext.Text = "بعدی";
            BtnNext.TextColor = System.Drawing.Color.White;
            BtnNext.UseVisualStyleBackColor = false;
            BtnNext.Click += BtnNext_Click;
            // 
            // BtnPrevious
            // 
            BtnPrevious.BackColor = System.Drawing.Color.Gray;
            BtnPrevious.BackgroundColor = System.Drawing.Color.Gray;
            BtnPrevious.BorderColor = System.Drawing.Color.PaleVioletRed;
            BtnPrevious.BorderRadius = 10;
            BtnPrevious.BorderSize = 0;
            BtnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnPrevious.FlatAppearance.BorderSize = 0;
            BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnPrevious.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnPrevious.ForeColor = System.Drawing.Color.White;
            BtnPrevious.Location = new System.Drawing.Point(888, 551);
            BtnPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnPrevious.Name = "BtnPrevious";
            BtnPrevious.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            BtnPrevious.Size = new System.Drawing.Size(120, 47);
            BtnPrevious.TabIndex = 3;
            BtnPrevious.Text = "قبلی";
            BtnPrevious.TextColor = System.Drawing.Color.White;
            BtnPrevious.UseVisualStyleBackColor = false;
            BtnPrevious.Click += BtnPrevious_Click;
            // 
            // Bpn
            // 
            Bpn.Controls.Add(TxtBpn);
            Bpn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Bpn.ForeColor = System.Drawing.Color.DimGray;
            Bpn.Location = new System.Drawing.Point(274, 304);
            Bpn.Mode = Common.Mode.Required;
            Bpn.Name = "Bpn";
            Bpn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Bpn.ShowOptional = false;
            Bpn.ShowSemiRequired = false;
            Bpn.Size = new System.Drawing.Size(230, 70);
            Bpn.TabIndex = 221;
            Bpn.TabStop = false;
            Bpn.Text = "شماره گذرنامه خریدار";
            // 
            // TxtBpn
            // 
            TxtBpn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBpn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBpn.Location = new System.Drawing.Point(10, 31);
            TxtBpn.Name = "TxtBpn";
            TxtBpn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtBpn.Size = new System.Drawing.Size(209, 29);
            TxtBpn.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnInquiry);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox3.ForeColor = System.Drawing.Color.DimGray;
            groupBox3.Location = new System.Drawing.Point(33, 109);
            groupBox3.Mode = Common.Mode.Required;
            groupBox3.Name = "groupBox3";
            groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox3.ShowOptional = false;
            groupBox3.ShowSemiRequired = false;
            groupBox3.Size = new System.Drawing.Size(471, 70);
            groupBox3.TabIndex = 222;
            groupBox3.TabStop = false;
            groupBox3.Text = "نتیجه استعلام";
            // 
            // BtnInquiry
            // 
            BtnInquiry.BackColor = System.Drawing.Color.DarkGray;
            BtnInquiry.BackgroundColor = System.Drawing.Color.DarkGray;
            BtnInquiry.BorderColor = System.Drawing.Color.PaleVioletRed;
            BtnInquiry.BorderRadius = 10;
            BtnInquiry.BorderSize = 0;
            BtnInquiry.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnInquiry.FlatAppearance.BorderSize = 0;
            BtnInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnInquiry.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnInquiry.ForeColor = System.Drawing.Color.White;
            BtnInquiry.Location = new System.Drawing.Point(16, 25);
            BtnInquiry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnInquiry.Name = "BtnInquiry";
            BtnInquiry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            BtnInquiry.Size = new System.Drawing.Size(98, 33);
            BtnInquiry.TabIndex = 229;
            BtnInquiry.Text = "استعلام خریدار";
            BtnInquiry.TextColor = System.Drawing.Color.White;
            BtnInquiry.UseVisualStyleBackColor = false;
            BtnInquiry.Click += BtnInquiry_Click;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox4.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox4.Location = new System.Drawing.Point(125, 27);
            textBox4.Name = "textBox4";
            textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            textBox4.Size = new System.Drawing.Size(337, 29);
            textBox4.TabIndex = 0;
            // 
            // BillId
            // 
            BillId.Controls.Add(TxtBillId);
            BillId.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BillId.ForeColor = System.Drawing.Color.DimGray;
            BillId.Location = new System.Drawing.Point(33, 204);
            BillId.Mode = Common.Mode.Required;
            BillId.Name = "BillId";
            BillId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            BillId.ShowOptional = false;
            BillId.ShowSemiRequired = false;
            BillId.Size = new System.Drawing.Size(471, 70);
            BillId.TabIndex = 223;
            BillId.TabStop = false;
            BillId.Text = "شماره اشتراک/ شناسه قبض";
            // 
            // TxtBillId
            // 
            TxtBillId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBillId.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBillId.Location = new System.Drawing.Point(10, 31);
            TxtBillId.Name = "TxtBillId";
            TxtBillId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtBillId.Size = new System.Drawing.Size(450, 29);
            TxtBillId.TabIndex = 0;
            // 
            // BId
            // 
            BId.Controls.Add(TxtBId);
            BId.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BId.ForeColor = System.Drawing.Color.DimGray;
            BId.Location = new System.Drawing.Point(510, 204);
            BId.Mode = Common.Mode.Required;
            BId.Name = "BId";
            BId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            BId.ShowOptional = false;
            BId.ShowSemiRequired = false;
            BId.Size = new System.Drawing.Size(471, 70);
            BId.TabIndex = 225;
            BId.TabStop = false;
            BId.Text = "شناسه ملی";
            // 
            // TxtBId
            // 
            TxtBId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBId.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBId.Location = new System.Drawing.Point(10, 28);
            TxtBId.Name = "TxtBId";
            TxtBId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtBId.Size = new System.Drawing.Size(450, 29);
            TxtBId.TabIndex = 0;
            // 
            // Bbc
            // 
            Bbc.Controls.Add(TxtBbc);
            Bbc.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Bbc.ForeColor = System.Drawing.Color.DimGray;
            Bbc.Location = new System.Drawing.Point(510, 304);
            Bbc.Mode = Common.Mode.Required;
            Bbc.Name = "Bbc";
            Bbc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Bbc.ShowOptional = false;
            Bbc.ShowSemiRequired = false;
            Bbc.Size = new System.Drawing.Size(235, 70);
            Bbc.TabIndex = 226;
            Bbc.TabStop = false;
            Bbc.Text = "کد شعبه ";
            // 
            // TxtBbc
            // 
            TxtBbc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBbc.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBbc.Location = new System.Drawing.Point(10, 31);
            TxtBbc.Name = "TxtBbc";
            TxtBbc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtBbc.Size = new System.Drawing.Size(219, 29);
            TxtBbc.TabIndex = 0;
            // 
            // Tinb
            // 
            Tinb.Controls.Add(TxtTinb);
            Tinb.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Tinb.ForeColor = System.Drawing.Color.DimGray;
            Tinb.Location = new System.Drawing.Point(510, 109);
            Tinb.Mode = Common.Mode.Required;
            Tinb.Name = "Tinb";
            Tinb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Tinb.ShowOptional = false;
            Tinb.ShowSemiRequired = false;
            Tinb.Size = new System.Drawing.Size(471, 70);
            Tinb.TabIndex = 220;
            Tinb.TabStop = false;
            Tinb.Text = "شماره اقتصادی";
            // 
            // TxtTinb
            // 
            TxtTinb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtTinb.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtTinb.Location = new System.Drawing.Point(10, 31);
            TxtTinb.Name = "TxtTinb";
            TxtTinb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtTinb.Size = new System.Drawing.Size(449, 29);
            TxtTinb.TabIndex = 0;
            // 
            // BtnSelect
            // 
            BtnSelect.BackColor = System.Drawing.Color.LightSlateGray;
            BtnSelect.BackgroundColor = System.Drawing.Color.LightSlateGray;
            BtnSelect.BorderColor = System.Drawing.Color.PaleVioletRed;
            BtnSelect.BorderRadius = 10;
            BtnSelect.BorderSize = 0;
            BtnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnSelect.FlatAppearance.BorderSize = 0;
            BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnSelect.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnSelect.ForeColor = System.Drawing.Color.White;
            BtnSelect.Location = new System.Drawing.Point(33, 40);
            BtnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnSelect.Name = "BtnSelect";
            BtnSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            BtnSelect.Size = new System.Drawing.Size(188, 47);
            BtnSelect.TabIndex = 227;
            BtnSelect.Text = "انتخاب از لیست مشتریان";
            BtnSelect.TextColor = System.Drawing.Color.White;
            BtnSelect.UseVisualStyleBackColor = false;
            BtnSelect.Click += BtnSelect_Click;
            // 
            // Ft
            // 
            Ft.Controls.Add(CbFt);
            Ft.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Ft.ForeColor = System.Drawing.Color.DimGray;
            Ft.Location = new System.Drawing.Point(751, 304);
            Ft.Mode = Common.Mode.Required;
            Ft.Name = "Ft";
            Ft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Ft.ShowOptional = false;
            Ft.ShowSemiRequired = false;
            Ft.Size = new System.Drawing.Size(230, 70);
            Ft.TabIndex = 228;
            Ft.TabStop = false;
            Ft.Text = "نوع پرواز";
            // 
            // CbFt
            // 
            CbFt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CbFt.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CbFt.FormattingEnabled = true;
            CbFt.Items.AddRange(new object[] { "الگوی اول", "الگوی دوم" });
            CbFt.Location = new System.Drawing.Point(10, 26);
            CbFt.Name = "CbFt";
            CbFt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            CbFt.Size = new System.Drawing.Size(208, 36);
            CbFt.TabIndex = 1;
            // 
            // Bpc
            // 
            Bpc.Controls.Add(TxtBpc);
            Bpc.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Bpc.ForeColor = System.Drawing.Color.DimGray;
            Bpc.Location = new System.Drawing.Point(33, 304);
            Bpc.Mode = Common.Mode.Required;
            Bpc.Name = "Bpc";
            Bpc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Bpc.ShowOptional = false;
            Bpc.ShowSemiRequired = false;
            Bpc.Size = new System.Drawing.Size(235, 70);
            Bpc.TabIndex = 222;
            Bpc.TabStop = false;
            Bpc.Text = "کدپستی";
            // 
            // TxtBpc
            // 
            TxtBpc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBpc.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBpc.Location = new System.Drawing.Point(7, 30);
            TxtBpc.Name = "TxtBpc";
            TxtBpc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtBpc.Size = new System.Drawing.Size(219, 29);
            TxtBpc.TabIndex = 0;
            // 
            // CustomerStep
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(Bpc);
            Controls.Add(Ft);
            Controls.Add(BtnSelect);
            Controls.Add(Bpn);
            Controls.Add(groupBox3);
            Controls.Add(BillId);
            Controls.Add(BId);
            Controls.Add(Bbc);
            Controls.Add(Tinb);
            Controls.Add(BtnPrevious);
            Controls.Add(BtnNext);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Name = "CustomerStep";
            Size = new System.Drawing.Size(1012, 603);
            Load += CustomerStep_Load;
            Bpn.ResumeLayout(false);
            Bpn.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            BillId.ResumeLayout(false);
            BillId.PerformLayout();
            BId.ResumeLayout(false);
            BId.PerformLayout();
            Bbc.ResumeLayout(false);
            Bbc.PerformLayout();
            Tinb.ResumeLayout(false);
            Tinb.PerformLayout();
            Ft.ResumeLayout(false);
            Bpc.ResumeLayout(false);
            Bpc.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Resources.CustomToolBox.RoundedButton BtnNext;
        private Resources.CustomToolBox.RoundedButton BtnPrevious;
        private CustomGroupBox Bpn;
        private System.Windows.Forms.TextBox TxtBpn;
        private CustomGroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox4;
        private CustomGroupBox BillId;
        private System.Windows.Forms.TextBox TxtBillId;
        private CustomGroupBox BId;
        private System.Windows.Forms.TextBox TxtBId;
        private CustomGroupBox Bbc;
        private System.Windows.Forms.TextBox TxtBbc;
        private CustomGroupBox Tinb;
        private System.Windows.Forms.TextBox TxtTinb;
        private Resources.CustomToolBox.RoundedButton BtnSelect;
        private CustomGroupBox Ft;
        private System.Windows.Forms.ComboBox CbFt;
        private Resources.CustomToolBox.RoundedButton BtnInquiry;
        private CustomGroupBox Bpc;
        private System.Windows.Forms.TextBox TxtBpc;
    }
}
