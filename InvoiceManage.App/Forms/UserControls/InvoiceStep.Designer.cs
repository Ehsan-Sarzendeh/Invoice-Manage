namespace InvoiceManage.App.Forms.UserControls
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
            BtnNext = new Resources.CustomToolBox.RoundedButton();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            comboBox3 = new System.Windows.Forms.ComboBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            comboBox4 = new System.Windows.Forms.ComboBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            groupBox6 = new System.Windows.Forms.GroupBox();
            maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            groupBox7 = new System.Windows.Forms.GroupBox();
            maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            groupBox8 = new System.Windows.Forms.GroupBox();
            maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            groupBox9 = new System.Windows.Forms.GroupBox();
            groupBox10 = new System.Windows.Forms.GroupBox();
            textBox2 = new System.Windows.Forms.TextBox();
            groupBox11 = new System.Windows.Forms.GroupBox();
            textBox3 = new System.Windows.Forms.TextBox();
            toggleButton1 = new Resources.CustomToolBox.ToggleButton();
            label2 = new System.Windows.Forms.Label();
            groupBox12 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            toggleButton2 = new Resources.CustomToolBox.ToggleButton();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
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
            BtnNext.Location = new System.Drawing.Point(4, 535);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Font = new System.Drawing.Font("IRANSansWeb", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.ForeColor = System.Drawing.Color.DimGray;
            groupBox2.Location = new System.Drawing.Point(746, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(230, 70);
            groupBox2.TabIndex = 207;
            groupBox2.TabStop = false;
            groupBox2.Text = "نوع فاکتور";
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            comboBox1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "نوع اول", "نوع دوم" });
            comboBox1.Location = new System.Drawing.Point(11, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(208, 36);
            comboBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Font = new System.Drawing.Font("IRANSansWeb", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.ForeColor = System.Drawing.Color.DimGray;
            groupBox1.Location = new System.Drawing.Point(505, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(230, 70);
            groupBox1.TabIndex = 208;
            groupBox1.TabStop = false;
            groupBox1.Text = "الگوی فاکتور";
            // 
            // comboBox2
            // 
            comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            comboBox2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "الگوی اول", "الگوی دوم" });
            comboBox2.Location = new System.Drawing.Point(10, 25);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(208, 36);
            comboBox2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Font = new System.Drawing.Font("IRANSansWeb", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox3.ForeColor = System.Drawing.Color.DimGray;
            groupBox3.Location = new System.Drawing.Point(19, 86);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(230, 70);
            groupBox3.TabIndex = 210;
            groupBox3.TabStop = false;
            groupBox3.Text = "نوع شخص خریدار";
            // 
            // comboBox3
            // 
            comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            comboBox3.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "حقیقی", "حقوقی" });
            comboBox3.Location = new System.Drawing.Point(11, 25);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(208, 36);
            comboBox3.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox4);
            groupBox4.Font = new System.Drawing.Font("IRANSansWeb", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox4.ForeColor = System.Drawing.Color.DimGray;
            groupBox4.Location = new System.Drawing.Point(261, 86);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(230, 70);
            groupBox4.TabIndex = 209;
            groupBox4.TabStop = false;
            groupBox4.Text = "موضوع فاکتور";
            // 
            // comboBox4
            // 
            comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            comboBox4.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new System.Drawing.Point(10, 25);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new System.Drawing.Size(208, 36);
            comboBox4.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(maskedTextBox1);
            groupBox5.Font = new System.Drawing.Font("IRANSansWeb", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox5.ForeColor = System.Drawing.Color.DimGray;
            groupBox5.Location = new System.Drawing.Point(220, 35);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(226, 70);
            groupBox5.TabIndex = 211;
            groupBox5.TabStop = false;
            groupBox5.Text = "تاریخ صدور";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            maskedTextBox1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            maskedTextBox1.Location = new System.Drawing.Point(6, 29);
            maskedTextBox1.Mask = "0000/00/00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            maskedTextBox1.Size = new System.Drawing.Size(214, 29);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(10, 31);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox1.Size = new System.Drawing.Size(450, 29);
            textBox1.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(maskedTextBox2);
            groupBox6.Font = new System.Drawing.Font("IRANSansWeb", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox6.ForeColor = System.Drawing.Color.DimGray;
            groupBox6.Location = new System.Drawing.Point(220, 120);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new System.Drawing.Size(226, 70);
            groupBox6.TabIndex = 212;
            groupBox6.TabStop = false;
            groupBox6.Text = "تاریخ ایجاد";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            maskedTextBox2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            maskedTextBox2.Location = new System.Drawing.Point(6, 29);
            maskedTextBox2.Mask = "0000/00/00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            maskedTextBox2.Size = new System.Drawing.Size(214, 29);
            maskedTextBox2.TabIndex = 0;
            maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(maskedTextBox3);
            groupBox7.Font = new System.Drawing.Font("IRANSansWeb", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox7.ForeColor = System.Drawing.Color.DimGray;
            groupBox7.Location = new System.Drawing.Point(25, 35);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new System.Drawing.Size(179, 70);
            groupBox7.TabIndex = 213;
            groupBox7.TabStop = false;
            groupBox7.Text = "ساعت صدور";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            maskedTextBox3.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            maskedTextBox3.Location = new System.Drawing.Point(6, 29);
            maskedTextBox3.Mask = "00:00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            maskedTextBox3.Size = new System.Drawing.Size(167, 29);
            maskedTextBox3.TabIndex = 0;
            maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(maskedTextBox4);
            groupBox8.Font = new System.Drawing.Font("IRANSansWeb", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox8.ForeColor = System.Drawing.Color.DimGray;
            groupBox8.Location = new System.Drawing.Point(25, 120);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new System.Drawing.Size(179, 70);
            groupBox8.TabIndex = 214;
            groupBox8.TabStop = false;
            groupBox8.Text = "ساعت ایجاد";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            maskedTextBox4.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            maskedTextBox4.Location = new System.Drawing.Point(6, 29);
            maskedTextBox4.Mask = "00:00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            maskedTextBox4.Size = new System.Drawing.Size(167, 29);
            maskedTextBox4.TabIndex = 0;
            maskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(textBox1);
            groupBox9.Font = new System.Drawing.Font("IRANSansWeb", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox9.ForeColor = System.Drawing.Color.DimGray;
            groupBox9.Location = new System.Drawing.Point(505, 184);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new System.Drawing.Size(471, 70);
            groupBox9.TabIndex = 215;
            groupBox9.TabStop = false;
            groupBox9.Text = "سریال داخلی";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(textBox2);
            groupBox10.Font = new System.Drawing.Font("IRANSansWeb", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox10.ForeColor = System.Drawing.Color.DimGray;
            groupBox10.Location = new System.Drawing.Point(505, 260);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new System.Drawing.Size(471, 70);
            groupBox10.TabIndex = 216;
            groupBox10.TabStop = false;
            groupBox10.Text = "شماره مالیاتی صورتحساب مرجع";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox2.Location = new System.Drawing.Point(10, 31);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox2.Size = new System.Drawing.Size(450, 29);
            textBox2.TabIndex = 0;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(textBox3);
            groupBox11.Font = new System.Drawing.Font("IRANSansWeb", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox11.ForeColor = System.Drawing.Color.DimGray;
            groupBox11.Location = new System.Drawing.Point(505, 336);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new System.Drawing.Size(471, 70);
            groupBox11.TabIndex = 216;
            groupBox11.TabStop = false;
            groupBox11.Text = "شماره مالیاتی صورتحساب ";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox3.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox3.Location = new System.Drawing.Point(10, 31);
            textBox3.Name = "textBox3";
            textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox3.Size = new System.Drawing.Size(450, 29);
            textBox3.TabIndex = 0;
            // 
            // toggleButton1
            // 
            toggleButton1.AutoSize = true;
            toggleButton1.Location = new System.Drawing.Point(723, 434);
            toggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            toggleButton1.Name = "toggleButton1";
            toggleButton1.OffBackColor = System.Drawing.Color.Gray;
            toggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            toggleButton1.OnBackColor = System.Drawing.Color.Green;
            toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            toggleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            toggleButton1.Size = new System.Drawing.Size(45, 22);
            toggleButton1.TabIndex = 217;
            toggleButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(776, 432);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(201, 27);
            label2.TabIndex = 218;
            label2.Text = "نمایش آیتم های اجباری خاص";
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(groupBox7);
            groupBox12.Controls.Add(groupBox5);
            groupBox12.Controls.Add(groupBox6);
            groupBox12.Controls.Add(groupBox8);
            groupBox12.Location = new System.Drawing.Point(21, 181);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new System.Drawing.Size(470, 225);
            groupBox12.TabIndex = 219;
            groupBox12.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(778, 462);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(199, 27);
            label3.TabIndex = 220;
            label3.Text = "نمایــش آیـــتم های اختیاری";
            // 
            // toggleButton2
            // 
            toggleButton2.AutoSize = true;
            toggleButton2.Location = new System.Drawing.Point(723, 465);
            toggleButton2.MinimumSize = new System.Drawing.Size(45, 22);
            toggleButton2.Name = "toggleButton2";
            toggleButton2.OffBackColor = System.Drawing.Color.Gray;
            toggleButton2.OffToggleColor = System.Drawing.Color.Gainsboro;
            toggleButton2.OnBackColor = System.Drawing.Color.Green;
            toggleButton2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            toggleButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            toggleButton2.Size = new System.Drawing.Size(45, 22);
            toggleButton2.TabIndex = 221;
            toggleButton2.UseVisualStyleBackColor = true;
            // 
            // InvoiceStep
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(toggleButton2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(toggleButton1);
            Controls.Add(groupBox11);
            Controls.Add(groupBox10);
            Controls.Add(groupBox9);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(BtnNext);
            Controls.Add(groupBox12);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "InvoiceStep";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(996, 587);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox12.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Resources.CustomToolBox.RoundedButton BtnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBox3;
        private Resources.CustomToolBox.ToggleButton toggleButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label3;
        private Resources.CustomToolBox.ToggleButton toggleButton2;
    }
}
