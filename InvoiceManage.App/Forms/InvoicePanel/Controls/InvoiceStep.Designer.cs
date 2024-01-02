using InvoiceManage.App.Resources.CustomToolBox;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    partial class InvoiceStep
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
            label1 = new System.Windows.Forms.Label();
            Inty = new CustomGroupBox();
            CbInty = new System.Windows.Forms.ComboBox();
            Inp = new CustomGroupBox();
            CbInp = new System.Windows.Forms.ComboBox();
            Tob = new CustomGroupBox();
            CbTob = new System.Windows.Forms.ComboBox();
            Ins = new CustomGroupBox();
            CbIns = new System.Windows.Forms.ComboBox();
            Indatim_1 = new CustomGroupBox();
            MtxtIndatim_1 = new System.Windows.Forms.MaskedTextBox();
            TxtInno = new System.Windows.Forms.TextBox();
            Indatim2m_1 = new CustomGroupBox();
            MtxtIndatim2m_1 = new System.Windows.Forms.MaskedTextBox();
            Indatim_2 = new CustomGroupBox();
            MtxtIndatim_2 = new System.Windows.Forms.MaskedTextBox();
            Indatim2m_2 = new CustomGroupBox();
            MtxtIndatim2m_2 = new System.Windows.Forms.MaskedTextBox();
            Inno = new CustomGroupBox();
            Irtaxid = new CustomGroupBox();
            TxtIrtaxid = new System.Windows.Forms.TextBox();
            TaxId = new CustomGroupBox();
            TxtTaxId = new System.Windows.Forms.TextBox();
            TogSemiRequired = new ToggleButton();
            label2 = new System.Windows.Forms.Label();
            groupBox12 = new CustomGroupBox();
            label3 = new System.Windows.Forms.Label();
            TogOptional = new ToggleButton();
            Inty.SuspendLayout();
            Inp.SuspendLayout();
            Tob.SuspendLayout();
            Ins.SuspendLayout();
            Indatim_1.SuspendLayout();
            Indatim2m_1.SuspendLayout();
            Indatim_2.SuspendLayout();
            Indatim2m_2.SuspendLayout();
            Inno.SuspendLayout();
            Irtaxid.SuspendLayout();
            TaxId.SuspendLayout();
            groupBox12.SuspendLayout();
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
            BtnNext.TabIndex = 0;
            BtnNext.Text = "بعدی";
            BtnNext.TextColor = System.Drawing.Color.White;
            BtnNext.UseVisualStyleBackColor = false;
            BtnNext.Click += BtnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(92, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(769, 32);
            label1.TabIndex = 1;
            label1.Text = "لطفا، ابتدا نوع و الگوی صورتحساب را مشخص کنید. دقت نمایید تمامی ایتم های دو ستاره باید پر شود";
            // 
            // Inty
            // 
            Inty.Controls.Add(CbInty);
            Inty.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Inty.ForeColor = System.Drawing.Color.DimGray;
            Inty.Location = new System.Drawing.Point(754, 86);
            Inty.Mode = Common.Mode.Required;
            Inty.Name = "Inty";
            Inty.ShowOptional = false;
            Inty.ShowSemiRequired = false;
            Inty.Size = new System.Drawing.Size(230, 70);
            Inty.TabIndex = 207;
            Inty.TabStop = false;
            Inty.Text = "نوع فاکتور";
            // 
            // CbInty
            // 
            CbInty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            CbInty.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CbInty.FormattingEnabled = true;
            CbInty.Items.AddRange(new object[] { "نوع اول", "نوع دوم" });
            CbInty.Location = new System.Drawing.Point(11, 25);
            CbInty.Name = "CbInty";
            CbInty.Size = new System.Drawing.Size(208, 36);
            CbInty.TabIndex = 0;
            CbInty.SelectedIndexChanged += CbInty_SelectedIndexChanged;
            // 
            // Inp
            // 
            Inp.Controls.Add(CbInp);
            Inp.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Inp.ForeColor = System.Drawing.Color.DimGray;
            Inp.Location = new System.Drawing.Point(513, 86);
            Inp.Mode = Common.Mode.Required;
            Inp.Name = "Inp";
            Inp.ShowOptional = false;
            Inp.ShowSemiRequired = false;
            Inp.Size = new System.Drawing.Size(230, 70);
            Inp.TabIndex = 208;
            Inp.TabStop = false;
            Inp.Text = "الگوی فاکتور";
            // 
            // CbInp
            // 
            CbInp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            CbInp.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CbInp.FormattingEnabled = true;
            CbInp.Items.AddRange(new object[] { "الگوی اول", "الگوی دوم" });
            CbInp.Location = new System.Drawing.Point(10, 25);
            CbInp.Name = "CbInp";
            CbInp.Size = new System.Drawing.Size(208, 36);
            CbInp.TabIndex = 1;
            CbInp.SelectedIndexChanged += CbInp_SelectedIndexChanged;
            // 
            // Tob
            // 
            Tob.Controls.Add(CbTob);
            Tob.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Tob.ForeColor = System.Drawing.Color.DimGray;
            Tob.Location = new System.Drawing.Point(27, 86);
            Tob.Mode = Common.Mode.Required;
            Tob.Name = "Tob";
            Tob.ShowOptional = false;
            Tob.ShowSemiRequired = false;
            Tob.Size = new System.Drawing.Size(230, 70);
            Tob.TabIndex = 210;
            Tob.TabStop = false;
            Tob.Text = "نوع شخص خریدار";
            // 
            // CbTob
            // 
            CbTob.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            CbTob.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CbTob.FormattingEnabled = true;
            CbTob.Items.AddRange(new object[] { "حقیقی", "حقوقی" });
            CbTob.Location = new System.Drawing.Point(11, 25);
            CbTob.Name = "CbTob";
            CbTob.Size = new System.Drawing.Size(208, 36);
            CbTob.TabIndex = 1;
            // 
            // Ins
            // 
            Ins.Controls.Add(CbIns);
            Ins.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Ins.ForeColor = System.Drawing.Color.DimGray;
            Ins.Location = new System.Drawing.Point(269, 86);
            Ins.Mode = Common.Mode.Required;
            Ins.Name = "Ins";
            Ins.ShowOptional = false;
            Ins.ShowSemiRequired = false;
            Ins.Size = new System.Drawing.Size(230, 70);
            Ins.TabIndex = 209;
            Ins.TabStop = false;
            Ins.Text = "موضوع فاکتور";
            // 
            // CbIns
            // 
            CbIns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            CbIns.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CbIns.FormattingEnabled = true;
            CbIns.Location = new System.Drawing.Point(10, 25);
            CbIns.Name = "CbIns";
            CbIns.Size = new System.Drawing.Size(208, 36);
            CbIns.TabIndex = 0;
            // 
            // Indatim_1
            // 
            Indatim_1.Controls.Add(MtxtIndatim_1);
            Indatim_1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Indatim_1.ForeColor = System.Drawing.Color.DimGray;
            Indatim_1.Location = new System.Drawing.Point(220, 35);
            Indatim_1.Mode = Common.Mode.Required;
            Indatim_1.Name = "Indatim_1";
            Indatim_1.ShowOptional = false;
            Indatim_1.ShowSemiRequired = false;
            Indatim_1.Size = new System.Drawing.Size(226, 70);
            Indatim_1.TabIndex = 211;
            Indatim_1.TabStop = false;
            Indatim_1.Text = "تاریخ صدور";
            // 
            // MtxtIndatim_1
            // 
            MtxtIndatim_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            MtxtIndatim_1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            MtxtIndatim_1.Location = new System.Drawing.Point(6, 29);
            MtxtIndatim_1.Mask = "0000/00/00";
            MtxtIndatim_1.Name = "MtxtIndatim_1";
            MtxtIndatim_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            MtxtIndatim_1.Size = new System.Drawing.Size(214, 29);
            MtxtIndatim_1.TabIndex = 0;
            MtxtIndatim_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtInno
            // 
            TxtInno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtInno.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtInno.Location = new System.Drawing.Point(10, 31);
            TxtInno.Name = "TxtInno";
            TxtInno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtInno.Size = new System.Drawing.Size(450, 29);
            TxtInno.TabIndex = 0;
            // 
            // Indatim2m_1
            // 
            Indatim2m_1.Controls.Add(MtxtIndatim2m_1);
            Indatim2m_1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Indatim2m_1.ForeColor = System.Drawing.Color.DimGray;
            Indatim2m_1.Location = new System.Drawing.Point(220, 120);
            Indatim2m_1.Mode = Common.Mode.Required;
            Indatim2m_1.Name = "Indatim2m_1";
            Indatim2m_1.ShowOptional = false;
            Indatim2m_1.ShowSemiRequired = false;
            Indatim2m_1.Size = new System.Drawing.Size(226, 70);
            Indatim2m_1.TabIndex = 212;
            Indatim2m_1.TabStop = false;
            Indatim2m_1.Text = "تاریخ ایجاد";
            // 
            // MtxtIndatim2m_1
            // 
            MtxtIndatim2m_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            MtxtIndatim2m_1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            MtxtIndatim2m_1.Location = new System.Drawing.Point(6, 29);
            MtxtIndatim2m_1.Mask = "0000/00/00";
            MtxtIndatim2m_1.Name = "MtxtIndatim2m_1";
            MtxtIndatim2m_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            MtxtIndatim2m_1.Size = new System.Drawing.Size(214, 29);
            MtxtIndatim2m_1.TabIndex = 0;
            MtxtIndatim2m_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Indatim_2
            // 
            Indatim_2.Controls.Add(MtxtIndatim_2);
            Indatim_2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Indatim_2.ForeColor = System.Drawing.Color.DimGray;
            Indatim_2.Location = new System.Drawing.Point(25, 35);
            Indatim_2.Mode = Common.Mode.Required;
            Indatim_2.Name = "Indatim_2";
            Indatim_2.ShowOptional = false;
            Indatim_2.ShowSemiRequired = false;
            Indatim_2.Size = new System.Drawing.Size(179, 70);
            Indatim_2.TabIndex = 213;
            Indatim_2.TabStop = false;
            Indatim_2.Text = "ساعت صدور";
            // 
            // MtxtIndatim_2
            // 
            MtxtIndatim_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            MtxtIndatim_2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            MtxtIndatim_2.Location = new System.Drawing.Point(6, 29);
            MtxtIndatim_2.Mask = "00:00";
            MtxtIndatim_2.Name = "MtxtIndatim_2";
            MtxtIndatim_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            MtxtIndatim_2.Size = new System.Drawing.Size(167, 29);
            MtxtIndatim_2.TabIndex = 0;
            MtxtIndatim_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Indatim2m_2
            // 
            Indatim2m_2.Controls.Add(MtxtIndatim2m_2);
            Indatim2m_2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Indatim2m_2.ForeColor = System.Drawing.Color.DimGray;
            Indatim2m_2.Location = new System.Drawing.Point(25, 120);
            Indatim2m_2.Mode = Common.Mode.Required;
            Indatim2m_2.Name = "Indatim2m_2";
            Indatim2m_2.ShowOptional = false;
            Indatim2m_2.ShowSemiRequired = false;
            Indatim2m_2.Size = new System.Drawing.Size(179, 70);
            Indatim2m_2.TabIndex = 214;
            Indatim2m_2.TabStop = false;
            Indatim2m_2.Text = "ساعت ایجاد";
            // 
            // MtxtIndatim2m_2
            // 
            MtxtIndatim2m_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            MtxtIndatim2m_2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            MtxtIndatim2m_2.Location = new System.Drawing.Point(6, 29);
            MtxtIndatim2m_2.Mask = "00:00";
            MtxtIndatim2m_2.Name = "MtxtIndatim2m_2";
            MtxtIndatim2m_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            MtxtIndatim2m_2.Size = new System.Drawing.Size(167, 29);
            MtxtIndatim2m_2.TabIndex = 0;
            MtxtIndatim2m_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Inno
            // 
            Inno.Controls.Add(TxtInno);
            Inno.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Inno.ForeColor = System.Drawing.Color.DimGray;
            Inno.Location = new System.Drawing.Point(513, 184);
            Inno.Mode = Common.Mode.Required;
            Inno.Name = "Inno";
            Inno.ShowOptional = false;
            Inno.ShowSemiRequired = false;
            Inno.Size = new System.Drawing.Size(471, 70);
            Inno.TabIndex = 215;
            Inno.TabStop = false;
            Inno.Text = "سریال داخلی";
            // 
            // Irtaxid
            // 
            Irtaxid.Controls.Add(TxtIrtaxid);
            Irtaxid.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Irtaxid.ForeColor = System.Drawing.Color.DimGray;
            Irtaxid.Location = new System.Drawing.Point(513, 260);
            Irtaxid.Mode = Common.Mode.Required;
            Irtaxid.Name = "Irtaxid";
            Irtaxid.ShowOptional = false;
            Irtaxid.ShowSemiRequired = false;
            Irtaxid.Size = new System.Drawing.Size(471, 70);
            Irtaxid.TabIndex = 216;
            Irtaxid.TabStop = false;
            Irtaxid.Text = "شماره مالیاتی صورتحساب مرجع";
            // 
            // TxtIrtaxid
            // 
            TxtIrtaxid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtIrtaxid.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtIrtaxid.Location = new System.Drawing.Point(10, 31);
            TxtIrtaxid.Name = "TxtIrtaxid";
            TxtIrtaxid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtIrtaxid.Size = new System.Drawing.Size(450, 29);
            TxtIrtaxid.TabIndex = 0;
            // 
            // TaxId
            // 
            TaxId.Controls.Add(TxtTaxId);
            TaxId.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TaxId.ForeColor = System.Drawing.Color.DimGray;
            TaxId.Location = new System.Drawing.Point(513, 336);
            TaxId.Mode = Common.Mode.Required;
            TaxId.Name = "TaxId";
            TaxId.ShowOptional = false;
            TaxId.ShowSemiRequired = false;
            TaxId.Size = new System.Drawing.Size(471, 70);
            TaxId.TabIndex = 216;
            TaxId.TabStop = false;
            TaxId.Text = "شماره مالیاتی صورتحساب ";
            // 
            // TxtTaxId
            // 
            TxtTaxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtTaxId.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtTaxId.Location = new System.Drawing.Point(10, 31);
            TxtTaxId.Name = "TxtTaxId";
            TxtTaxId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtTaxId.Size = new System.Drawing.Size(450, 29);
            TxtTaxId.TabIndex = 0;
            // 
            // TogSemiRequired
            // 
            TogSemiRequired.AutoSize = true;
            TogSemiRequired.Location = new System.Drawing.Point(731, 434);
            TogSemiRequired.MinimumSize = new System.Drawing.Size(45, 22);
            TogSemiRequired.Name = "TogSemiRequired";
            TogSemiRequired.OffBackColor = System.Drawing.Color.Gray;
            TogSemiRequired.OffToggleColor = System.Drawing.Color.Gainsboro;
            TogSemiRequired.OnBackColor = System.Drawing.Color.Green;
            TogSemiRequired.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            TogSemiRequired.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            TogSemiRequired.Size = new System.Drawing.Size(45, 22);
            TogSemiRequired.TabIndex = 217;
            TogSemiRequired.UseVisualStyleBackColor = true;
            TogSemiRequired.CheckedChanged += TogSemiRequired_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(784, 432);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(201, 27);
            label2.TabIndex = 218;
            label2.Text = "نمایش آیتم های اجباری خاص";
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(Indatim_2);
            groupBox12.Controls.Add(Indatim_1);
            groupBox12.Controls.Add(Indatim2m_1);
            groupBox12.Controls.Add(Indatim2m_2);
            groupBox12.ForeColor = System.Drawing.Color.DimGray;
            groupBox12.Location = new System.Drawing.Point(29, 181);
            groupBox12.Mode = Common.Mode.Required;
            groupBox12.Name = "groupBox12";
            groupBox12.ShowOptional = false;
            groupBox12.ShowSemiRequired = false;
            groupBox12.Size = new System.Drawing.Size(470, 225);
            groupBox12.TabIndex = 219;
            groupBox12.TabStop = false;
            groupBox12.Text = "**";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(786, 462);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(199, 27);
            label3.TabIndex = 220;
            label3.Text = "نمایــش آیـــتم های اختیاری";
            // 
            // TogOptional
            // 
            TogOptional.AutoSize = true;
            TogOptional.Location = new System.Drawing.Point(731, 465);
            TogOptional.MinimumSize = new System.Drawing.Size(45, 22);
            TogOptional.Name = "TogOptional";
            TogOptional.OffBackColor = System.Drawing.Color.Gray;
            TogOptional.OffToggleColor = System.Drawing.Color.Gainsboro;
            TogOptional.OnBackColor = System.Drawing.Color.Green;
            TogOptional.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            TogOptional.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            TogOptional.Size = new System.Drawing.Size(45, 22);
            TogOptional.TabIndex = 221;
            TogOptional.UseVisualStyleBackColor = true;
            TogOptional.CheckedChanged += TogOptional_CheckedChanged;
            // 
            // InvoiceStep
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(TogOptional);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TogSemiRequired);
            Controls.Add(TaxId);
            Controls.Add(Irtaxid);
            Controls.Add(Inno);
            Controls.Add(Tob);
            Controls.Add(Ins);
            Controls.Add(Inp);
            Controls.Add(Inty);
            Controls.Add(label1);
            Controls.Add(BtnNext);
            Controls.Add(groupBox12);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "InvoiceStep";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(1012, 603);
            Load += InvoiceStep_Load;
            Inty.ResumeLayout(false);
            Inp.ResumeLayout(false);
            Tob.ResumeLayout(false);
            Ins.ResumeLayout(false);
            Indatim_1.ResumeLayout(false);
            Indatim_1.PerformLayout();
            Indatim2m_1.ResumeLayout(false);
            Indatim2m_1.PerformLayout();
            Indatim_2.ResumeLayout(false);
            Indatim_2.PerformLayout();
            Indatim2m_2.ResumeLayout(false);
            Indatim2m_2.PerformLayout();
            Inno.ResumeLayout(false);
            Inno.PerformLayout();
            Irtaxid.ResumeLayout(false);
            Irtaxid.PerformLayout();
            TaxId.ResumeLayout(false);
            TaxId.PerformLayout();
            groupBox12.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Resources.CustomToolBox.RoundedButton BtnNext;
        private System.Windows.Forms.Label label1;
        private CustomGroupBox Inty;
        private CustomGroupBox Inp;
        private System.Windows.Forms.ComboBox CbInty;
        private System.Windows.Forms.ComboBox CbInp;
        private CustomGroupBox Tob;
        private System.Windows.Forms.ComboBox CbTob;
        private CustomGroupBox Ins;
        private System.Windows.Forms.ComboBox CbIns;
        private CustomGroupBox Indatim_1;
        private System.Windows.Forms.TextBox TxtInno;
        private System.Windows.Forms.MaskedTextBox MtxtIndatim_1;
        private CustomGroupBox Indatim2m_1;
        private System.Windows.Forms.MaskedTextBox MtxtIndatim2m_1;
        private CustomGroupBox Indatim_2;
        private System.Windows.Forms.MaskedTextBox MtxtIndatim_2;
        private CustomGroupBox Indatim2m_2;
        private System.Windows.Forms.MaskedTextBox MtxtIndatim2m_2;
        private CustomGroupBox Inno;
        private CustomGroupBox Irtaxid;
        private System.Windows.Forms.TextBox TxtIrtaxid;
        private CustomGroupBox TaxId;
        private System.Windows.Forms.TextBox TxtTaxId;
        private Resources.CustomToolBox.ToggleButton TogSemiRequired;
        private System.Windows.Forms.Label label2;
        private CustomGroupBox groupBox12;
        private System.Windows.Forms.Label label3;
        private Resources.CustomToolBox.ToggleButton TogOptional;
    }
}
