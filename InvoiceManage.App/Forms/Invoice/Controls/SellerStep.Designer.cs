namespace InvoiceManage.App.Forms.Invoice.Controls
{
    partial class SellerStep
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
            BtnPrevious = new Resources.CustomToolBox.RoundedButton();
            groupBox5 = new System.Windows.Forms.GroupBox();
            maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            groupBox9 = new System.Windows.Forms.GroupBox();
            textBox1 = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            textBox2 = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            textBox3 = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            textBox4 = new System.Windows.Forms.TextBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            textBox5 = new System.Windows.Forms.TextBox();
            groupBox6 = new System.Windows.Forms.GroupBox();
            textBox6 = new System.Windows.Forms.TextBox();
            groupBox7 = new System.Windows.Forms.GroupBox();
            textBox7 = new System.Windows.Forms.TextBox();
            roundedButton1 = new Resources.CustomToolBox.RoundedButton();
            groupBox5.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
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
            BtnPrevious.Location = new System.Drawing.Point(872, 535);
            BtnPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnPrevious.Name = "BtnPrevious";
            BtnPrevious.Size = new System.Drawing.Size(120, 47);
            BtnPrevious.TabIndex = 2;
            BtnPrevious.Text = "قبلی";
            BtnPrevious.TextColor = System.Drawing.Color.White;
            BtnPrevious.UseVisualStyleBackColor = false;
            BtnPrevious.Click += BtnPrevious_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(maskedTextBox1);
            groupBox5.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox5.ForeColor = System.Drawing.Color.DimGray;
            groupBox5.Location = new System.Drawing.Point(752, 306);
            groupBox5.Name = "groupBox5";
            groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox5.Size = new System.Drawing.Size(220, 70);
            groupBox5.TabIndex = 212;
            groupBox5.TabStop = false;
            groupBox5.Text = "تاریخ کوتاژ اظهارنامه گمرکی";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            maskedTextBox1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            maskedTextBox1.Location = new System.Drawing.Point(6, 29);
            maskedTextBox1.Mask = "0000/00/00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            maskedTextBox1.Size = new System.Drawing.Size(205, 29);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(textBox1);
            groupBox9.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox9.ForeColor = System.Drawing.Color.DimGray;
            groupBox9.Location = new System.Drawing.Point(501, 110);
            groupBox9.Name = "groupBox9";
            groupBox9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox9.Size = new System.Drawing.Size(471, 70);
            groupBox9.TabIndex = 216;
            groupBox9.TabStop = false;
            groupBox9.Text = "شماره اقتصادی";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.ForeColor = System.Drawing.Color.DimGray;
            groupBox1.Location = new System.Drawing.Point(24, 306);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox1.Size = new System.Drawing.Size(241, 70);
            groupBox1.TabIndex = 217;
            groupBox1.TabStop = false;
            groupBox1.Text = "شناسه یکتای ثبت قرارداد";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox2.Location = new System.Drawing.Point(10, 31);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox2.Size = new System.Drawing.Size(225, 29);
            textBox2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.ForeColor = System.Drawing.Color.DimGray;
            groupBox2.Location = new System.Drawing.Point(24, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox2.Size = new System.Drawing.Size(471, 70);
            groupBox2.TabIndex = 217;
            groupBox2.TabStop = false;
            groupBox2.Text = "شماره کوتاژ اظهارنامه گمرکی";
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
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox4);
            groupBox3.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox3.ForeColor = System.Drawing.Color.DimGray;
            groupBox3.Location = new System.Drawing.Point(24, 110);
            groupBox3.Name = "groupBox3";
            groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox3.Size = new System.Drawing.Size(471, 70);
            groupBox3.TabIndex = 217;
            groupBox3.TabStop = false;
            groupBox3.Text = "شناسه یکتا فروشنده";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox4.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox4.Location = new System.Drawing.Point(10, 31);
            textBox4.Name = "textBox4";
            textBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox4.Size = new System.Drawing.Size(450, 29);
            textBox4.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox5);
            groupBox4.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox4.ForeColor = System.Drawing.Color.DimGray;
            groupBox4.Location = new System.Drawing.Point(271, 306);
            groupBox4.Name = "groupBox4";
            groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox4.Size = new System.Drawing.Size(224, 70);
            groupBox4.TabIndex = 217;
            groupBox4.TabStop = false;
            groupBox4.Text = "شماره پروانه گمرکی";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox5.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox5.Location = new System.Drawing.Point(10, 31);
            textBox5.Name = "textBox5";
            textBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox5.Size = new System.Drawing.Size(203, 29);
            textBox5.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBox6);
            groupBox6.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox6.ForeColor = System.Drawing.Color.DimGray;
            groupBox6.Location = new System.Drawing.Point(501, 306);
            groupBox6.Name = "groupBox6";
            groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox6.Size = new System.Drawing.Size(245, 70);
            groupBox6.TabIndex = 217;
            groupBox6.TabStop = false;
            groupBox6.Text = "کد شعبه ";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox6.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox6.Location = new System.Drawing.Point(10, 31);
            textBox6.Name = "textBox6";
            textBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox6.Size = new System.Drawing.Size(230, 29);
            textBox6.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(textBox7);
            groupBox7.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox7.ForeColor = System.Drawing.Color.DimGray;
            groupBox7.Location = new System.Drawing.Point(501, 207);
            groupBox7.Name = "groupBox7";
            groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox7.Size = new System.Drawing.Size(471, 70);
            groupBox7.TabIndex = 217;
            groupBox7.TabStop = false;
            groupBox7.Text = "کد گمرکی محل اظهارنامه";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox7.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox7.Location = new System.Drawing.Point(10, 31);
            textBox7.Name = "textBox7";
            textBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox7.Size = new System.Drawing.Size(450, 29);
            textBox7.TabIndex = 0;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = System.Drawing.Color.LightSlateGray;
            roundedButton1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            roundedButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            roundedButton1.BorderRadius = 10;
            roundedButton1.BorderSize = 0;
            roundedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            roundedButton1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            roundedButton1.ForeColor = System.Drawing.Color.White;
            roundedButton1.Location = new System.Drawing.Point(24, 40);
            roundedButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new System.Drawing.Size(220, 47);
            roundedButton1.TabIndex = 218;
            roundedButton1.Text = "انتخاب از لیست شرکت‌های من";
            roundedButton1.TextColor = System.Drawing.Color.White;
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // SellerStep
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(roundedButton1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox6);
            Controls.Add(groupBox7);
            Controls.Add(groupBox1);
            Controls.Add(groupBox9);
            Controls.Add(groupBox5);
            Controls.Add(BtnPrevious);
            Controls.Add(BtnNext);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "SellerStep";
            Size = new System.Drawing.Size(996, 587);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Resources.CustomToolBox.RoundedButton BtnNext;
        private Resources.CustomToolBox.RoundedButton BtnPrevious;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox7;
        private Resources.CustomToolBox.RoundedButton roundedButton1;
    }
}
