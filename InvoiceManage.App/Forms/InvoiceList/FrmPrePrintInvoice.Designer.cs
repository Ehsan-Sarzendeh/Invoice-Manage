namespace InvoiceManage.App.Forms.InvoiceList
{
    partial class FrmPrePrintInvoice
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
            panel1 = new System.Windows.Forms.Panel();
            BtnClose = new System.Windows.Forms.PictureBox();
            BtnPrint = new Resources.CustomToolBox.RoundedButton();
            BtnCancel = new Resources.CustomToolBox.RoundedButton();
            groupBox5 = new System.Windows.Forms.GroupBox();
            TxtBillId = new System.Windows.Forms.TextBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            TxtBpc = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(BtnCancel);
            panel1.Controls.Add(BtnPrint);
            panel1.Location = new System.Drawing.Point(3, 36);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(477, 342);
            panel1.TabIndex = 0;
            // 
            // BtnClose
            // 
            BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnClose.Image = Properties.Resources.close_w;
            BtnClose.Location = new System.Drawing.Point(447, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new System.Drawing.Size(37, 37);
            BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BtnClose.TabIndex = 10;
            BtnClose.TabStop = false;
            // 
            // BtnPrint
            // 
            BtnPrint.BackColor = System.Drawing.Color.Green;
            BtnPrint.BackgroundColor = System.Drawing.Color.Green;
            BtnPrint.BorderColor = System.Drawing.Color.PaleVioletRed;
            BtnPrint.BorderRadius = 10;
            BtnPrint.BorderSize = 0;
            BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnPrint.FlatAppearance.BorderSize = 0;
            BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnPrint.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnPrint.ForeColor = System.Drawing.Color.White;
            BtnPrint.Location = new System.Drawing.Point(30, 266);
            BtnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new System.Drawing.Size(163, 47);
            BtnPrint.TabIndex = 225;
            BtnPrint.Text = "چاپ";
            BtnPrint.TextColor = System.Drawing.Color.White;
            BtnPrint.UseVisualStyleBackColor = false;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            BtnCancel.BackgroundColor = System.Drawing.Color.FromArgb(192, 0, 0);
            BtnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            BtnCancel.BorderRadius = 10;
            BtnCancel.BorderSize = 0;
            BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnCancel.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnCancel.ForeColor = System.Drawing.Color.White;
            BtnCancel.Location = new System.Drawing.Point(201, 266);
            BtnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new System.Drawing.Size(88, 47);
            BtnCancel.TabIndex = 226;
            BtnCancel.Text = "انصراف";
            BtnCancel.TextColor = System.Drawing.Color.White;
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(TxtBillId);
            groupBox5.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox5.ForeColor = System.Drawing.Color.DimGray;
            groupBox5.Location = new System.Drawing.Point(30, 98);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(414, 141);
            groupBox5.TabIndex = 234;
            groupBox5.TabStop = false;
            groupBox5.Text = "نشانی";
            // 
            // TxtBillId
            // 
            TxtBillId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBillId.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBillId.Location = new System.Drawing.Point(10, 24);
            TxtBillId.Multiline = true;
            TxtBillId.Name = "TxtBillId";
            TxtBillId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtBillId.Size = new System.Drawing.Size(395, 107);
            TxtBillId.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(TxtBpc);
            groupBox4.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox4.ForeColor = System.Drawing.Color.DimGray;
            groupBox4.Location = new System.Drawing.Point(239, 20);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(205, 70);
            groupBox4.TabIndex = 233;
            groupBox4.TabStop = false;
            groupBox4.Text = "شماره تماس";
            // 
            // TxtBpc
            // 
            TxtBpc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBpc.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBpc.Location = new System.Drawing.Point(10, 26);
            TxtBpc.Name = "TxtBpc";
            TxtBpc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtBpc.Size = new System.Drawing.Size(186, 29);
            TxtBpc.TabIndex = 0;
            // 
            // FrmPrePrintInvoice
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
            ClientSize = new System.Drawing.Size(485, 381);
            Controls.Add(BtnClose);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FrmPrePrintInvoice";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Text = "FrmPrePrintInvoice";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BtnClose;
        private Resources.CustomToolBox.RoundedButton BtnCancel;
        private Resources.CustomToolBox.RoundedButton BtnPrint;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TxtBillId;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtBpc;
    }
}