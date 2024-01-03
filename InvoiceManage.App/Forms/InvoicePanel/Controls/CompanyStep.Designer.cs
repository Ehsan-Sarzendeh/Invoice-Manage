using InvoiceManage.App.Resources.CustomToolBox;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    partial class CompanyStep
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
            Cdcd_1 = new CustomGroupBox();
            MtxtCdcd_1 = new System.Windows.Forms.MaskedTextBox();
            Tins = new CustomGroupBox();
            TxtTins = new System.Windows.Forms.TextBox();
            Crn = new CustomGroupBox();
            TxtCrn = new System.Windows.Forms.TextBox();
            Cdcn = new CustomGroupBox();
            TxtCdcn = new System.Windows.Forms.TextBox();
            CompanyId = new CustomGroupBox();
            TxtCompanyId = new System.Windows.Forms.TextBox();
            Scln = new CustomGroupBox();
            TxtScln = new System.Windows.Forms.TextBox();
            Sbc = new CustomGroupBox();
            TxtSbc = new System.Windows.Forms.TextBox();
            Scc = new CustomGroupBox();
            TxtScc = new System.Windows.Forms.TextBox();
            BtnSelect = new RoundedButton();
            Cdcd_1.SuspendLayout();
            Tins.SuspendLayout();
            Crn.SuspendLayout();
            Cdcn.SuspendLayout();
            CompanyId.SuspendLayout();
            Scln.SuspendLayout();
            Sbc.SuspendLayout();
            Scc.SuspendLayout();
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
            BtnPrevious.Size = new System.Drawing.Size(120, 47);
            BtnPrevious.TabIndex = 2;
            BtnPrevious.Text = "قبلی";
            BtnPrevious.TextColor = System.Drawing.Color.White;
            BtnPrevious.UseVisualStyleBackColor = false;
            BtnPrevious.Click += BtnPrevious_Click;
            // 
            // Cdcd_1
            // 
            Cdcd_1.Controls.Add(MtxtCdcd_1);
            Cdcd_1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Cdcd_1.ForeColor = System.Drawing.Color.DimGray;
            Cdcd_1.Location = new System.Drawing.Point(761, 306);
            Cdcd_1.Mode = Common.Mode.Required;
            Cdcd_1.Name = "Cdcd_1";
            Cdcd_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Cdcd_1.ShowOptional = false;
            Cdcd_1.ShowSemiRequired = false;
            Cdcd_1.Size = new System.Drawing.Size(220, 70);
            Cdcd_1.TabIndex = 212;
            Cdcd_1.TabStop = false;
            Cdcd_1.Text = "تاریخ کوتاژ اظهارنامه گمرکی";
            // 
            // MtxtCdcd_1
            // 
            MtxtCdcd_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            MtxtCdcd_1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            MtxtCdcd_1.Location = new System.Drawing.Point(6, 29);
            MtxtCdcd_1.Mask = "0000/00/00";
            MtxtCdcd_1.Name = "MtxtCdcd_1";
            MtxtCdcd_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            MtxtCdcd_1.Size = new System.Drawing.Size(205, 29);
            MtxtCdcd_1.TabIndex = 0;
            MtxtCdcd_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tins
            // 
            Tins.Controls.Add(TxtTins);
            Tins.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Tins.ForeColor = System.Drawing.Color.DimGray;
            Tins.Location = new System.Drawing.Point(510, 110);
            Tins.Mode = Common.Mode.Required;
            Tins.Name = "Tins";
            Tins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Tins.ShowOptional = false;
            Tins.ShowSemiRequired = false;
            Tins.Size = new System.Drawing.Size(471, 70);
            Tins.TabIndex = 216;
            Tins.TabStop = false;
            Tins.Text = "شماره اقتصادی";
            // 
            // TxtTins
            // 
            TxtTins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtTins.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtTins.Location = new System.Drawing.Point(10, 31);
            TxtTins.Name = "TxtTins";
            TxtTins.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtTins.Size = new System.Drawing.Size(450, 29);
            TxtTins.TabIndex = 0;
            // 
            // Crn
            // 
            Crn.Controls.Add(TxtCrn);
            Crn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Crn.ForeColor = System.Drawing.Color.DimGray;
            Crn.Location = new System.Drawing.Point(33, 306);
            Crn.Mode = Common.Mode.Required;
            Crn.Name = "Crn";
            Crn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Crn.ShowOptional = false;
            Crn.ShowSemiRequired = false;
            Crn.Size = new System.Drawing.Size(241, 70);
            Crn.TabIndex = 217;
            Crn.TabStop = false;
            Crn.Text = "شناسه یکتای ثبت قرارداد";
            // 
            // TxtCrn
            // 
            TxtCrn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtCrn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtCrn.Location = new System.Drawing.Point(10, 31);
            TxtCrn.Name = "TxtCrn";
            TxtCrn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtCrn.Size = new System.Drawing.Size(225, 29);
            TxtCrn.TabIndex = 0;
            // 
            // Cdcn
            // 
            Cdcn.Controls.Add(TxtCdcn);
            Cdcn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Cdcn.ForeColor = System.Drawing.Color.DimGray;
            Cdcn.Location = new System.Drawing.Point(33, 207);
            Cdcn.Mode = Common.Mode.Required;
            Cdcn.Name = "Cdcn";
            Cdcn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Cdcn.ShowOptional = false;
            Cdcn.ShowSemiRequired = false;
            Cdcn.Size = new System.Drawing.Size(471, 70);
            Cdcn.TabIndex = 217;
            Cdcn.TabStop = false;
            Cdcn.Text = "شماره کوتاژ اظهارنامه گمرکی";
            // 
            // TxtCdcn
            // 
            TxtCdcn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtCdcn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtCdcn.Location = new System.Drawing.Point(10, 31);
            TxtCdcn.Name = "TxtCdcn";
            TxtCdcn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtCdcn.Size = new System.Drawing.Size(450, 29);
            TxtCdcn.TabIndex = 0;
            // 
            // CompanyId
            // 
            CompanyId.Controls.Add(TxtCompanyId);
            CompanyId.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CompanyId.ForeColor = System.Drawing.Color.DimGray;
            CompanyId.Location = new System.Drawing.Point(33, 110);
            CompanyId.Mode = Common.Mode.Required;
            CompanyId.Name = "CompanyId";
            CompanyId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            CompanyId.ShowOptional = false;
            CompanyId.ShowSemiRequired = false;
            CompanyId.Size = new System.Drawing.Size(471, 70);
            CompanyId.TabIndex = 217;
            CompanyId.TabStop = false;
            CompanyId.Text = "شناسه یکتا فروشنده";
            // 
            // TxtCompanyId
            // 
            TxtCompanyId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtCompanyId.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtCompanyId.Location = new System.Drawing.Point(10, 31);
            TxtCompanyId.Name = "TxtCompanyId";
            TxtCompanyId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtCompanyId.Size = new System.Drawing.Size(450, 29);
            TxtCompanyId.TabIndex = 0;
            // 
            // Scln
            // 
            Scln.Controls.Add(TxtScln);
            Scln.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Scln.ForeColor = System.Drawing.Color.DimGray;
            Scln.Location = new System.Drawing.Point(280, 306);
            Scln.Mode = Common.Mode.Required;
            Scln.Name = "Scln";
            Scln.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Scln.ShowOptional = false;
            Scln.ShowSemiRequired = false;
            Scln.Size = new System.Drawing.Size(224, 70);
            Scln.TabIndex = 217;
            Scln.TabStop = false;
            Scln.Text = "شماره پروانه گمرکی";
            // 
            // TxtScln
            // 
            TxtScln.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtScln.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtScln.Location = new System.Drawing.Point(10, 31);
            TxtScln.Name = "TxtScln";
            TxtScln.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtScln.Size = new System.Drawing.Size(203, 29);
            TxtScln.TabIndex = 0;
            // 
            // Sbc
            // 
            Sbc.Controls.Add(TxtSbc);
            Sbc.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Sbc.ForeColor = System.Drawing.Color.DimGray;
            Sbc.Location = new System.Drawing.Point(510, 306);
            Sbc.Mode = Common.Mode.Required;
            Sbc.Name = "Sbc";
            Sbc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Sbc.ShowOptional = false;
            Sbc.ShowSemiRequired = false;
            Sbc.Size = new System.Drawing.Size(245, 70);
            Sbc.TabIndex = 217;
            Sbc.TabStop = false;
            Sbc.Text = "کد شعبه ";
            // 
            // TxtSbc
            // 
            TxtSbc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtSbc.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtSbc.Location = new System.Drawing.Point(10, 31);
            TxtSbc.Name = "TxtSbc";
            TxtSbc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtSbc.Size = new System.Drawing.Size(230, 29);
            TxtSbc.TabIndex = 0;
            // 
            // Scc
            // 
            Scc.Controls.Add(TxtScc);
            Scc.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Scc.ForeColor = System.Drawing.Color.DimGray;
            Scc.Location = new System.Drawing.Point(510, 207);
            Scc.Mode = Common.Mode.Required;
            Scc.Name = "Scc";
            Scc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Scc.ShowOptional = false;
            Scc.ShowSemiRequired = false;
            Scc.Size = new System.Drawing.Size(471, 70);
            Scc.TabIndex = 217;
            Scc.TabStop = false;
            Scc.Text = "کد گمرکی محل اظهارنامه";
            // 
            // TxtScc
            // 
            TxtScc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtScc.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtScc.Location = new System.Drawing.Point(10, 31);
            TxtScc.Name = "TxtScc";
            TxtScc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtScc.Size = new System.Drawing.Size(450, 29);
            TxtScc.TabIndex = 0;
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
            BtnSelect.Location = new System.Drawing.Point(33, 38);
            BtnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnSelect.Name = "BtnSelect";
            BtnSelect.Size = new System.Drawing.Size(188, 47);
            BtnSelect.TabIndex = 218;
            BtnSelect.Text = "انتخاب از لیست شرکت‌ها";
            BtnSelect.TextColor = System.Drawing.Color.White;
            BtnSelect.UseVisualStyleBackColor = false;
            BtnSelect.Click += BtnSelect_Click;
            // 
            // CompanyStep
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(BtnSelect);
            Controls.Add(Cdcn);
            Controls.Add(CompanyId);
            Controls.Add(Scln);
            Controls.Add(Sbc);
            Controls.Add(Scc);
            Controls.Add(Crn);
            Controls.Add(Tins);
            Controls.Add(Cdcd_1);
            Controls.Add(BtnPrevious);
            Controls.Add(BtnNext);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "CompanyStep";
            Size = new System.Drawing.Size(1012, 603);
            Load += CompanyStep_Load;
            Cdcd_1.ResumeLayout(false);
            Cdcd_1.PerformLayout();
            Tins.ResumeLayout(false);
            Tins.PerformLayout();
            Crn.ResumeLayout(false);
            Crn.PerformLayout();
            Cdcn.ResumeLayout(false);
            Cdcn.PerformLayout();
            CompanyId.ResumeLayout(false);
            CompanyId.PerformLayout();
            Scln.ResumeLayout(false);
            Scln.PerformLayout();
            Sbc.ResumeLayout(false);
            Sbc.PerformLayout();
            Scc.ResumeLayout(false);
            Scc.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Resources.CustomToolBox.RoundedButton BtnNext;
        private Resources.CustomToolBox.RoundedButton BtnPrevious;
        private CustomGroupBox Cdcd_1;
        private System.Windows.Forms.MaskedTextBox MtxtCdcd_1;
        private CustomGroupBox Tins;
        private System.Windows.Forms.TextBox TxtTins;
        private CustomGroupBox Crn;
        private System.Windows.Forms.TextBox TxtCrn;
        private CustomGroupBox Cdcn;
        private System.Windows.Forms.TextBox TxtCdcn;
        private CustomGroupBox CompanyId;
        private System.Windows.Forms.TextBox TxtCompanyId;
        private CustomGroupBox Scln;
        private System.Windows.Forms.TextBox TxtScln;
        private CustomGroupBox Sbc;
        private System.Windows.Forms.TextBox TxtSbc;
        private CustomGroupBox Scc;
        private Resources.CustomToolBox.RoundedButton BtnSelect;
        private System.Windows.Forms.TextBox TxtScc;
    }
}
