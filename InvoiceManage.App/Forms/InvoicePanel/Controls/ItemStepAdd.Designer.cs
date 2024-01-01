using InvoiceManage.App.Resources.CustomToolBox;

namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    partial class ItemStepAdd
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
            gb2 = new CustomGroupBox();
            TxtSstid = new System.Windows.Forms.TextBox();
            groupBox10 = new CustomGroupBox();
            TxtVra = new System.Windows.Forms.TextBox();
            BtnAdd = new Resources.CustomToolBox.RoundedButton();
            gb2.SuspendLayout();
            groupBox10.SuspendLayout();
            SuspendLayout();
            // 
            // gb2
            // 
            gb2.Controls.Add(TxtSstid);
            gb2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gb2.ForeColor = System.Drawing.Color.DimGray;
            gb2.Location = new System.Drawing.Point(758, 10);
            gb2.Name = "gb2";
            gb2.Size = new System.Drawing.Size(224, 70);
            gb2.TabIndex = 224;
            gb2.TabStop = false;
            gb2.Text = "شناسه کالا";
            // 
            // TxtSstid
            // 
            TxtSstid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtSstid.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtSstid.Location = new System.Drawing.Point(13, 28);
            TxtSstid.Name = "TxtSstid";
            TxtSstid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtSstid.Size = new System.Drawing.Size(200, 29);
            TxtSstid.TabIndex = 0;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(TxtVra);
            groupBox10.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox10.ForeColor = System.Drawing.Color.DimGray;
            groupBox10.Location = new System.Drawing.Point(275, 10);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new System.Drawing.Size(477, 70);
            groupBox10.TabIndex = 225;
            groupBox10.TabStop = false;
            groupBox10.Text = "شرح کالا";
            // 
            // TxtVra
            // 
            TxtVra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtVra.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtVra.Location = new System.Drawing.Point(9, 27);
            TxtVra.Name = "TxtVra";
            TxtVra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtVra.Size = new System.Drawing.Size(456, 29);
            TxtVra.TabIndex = 0;
            TxtVra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            BtnAdd.Location = new System.Drawing.Point(16, 412);
            BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new System.Drawing.Size(156, 47);
            BtnAdd.TabIndex = 226;
            BtnAdd.Text = "افزودن";
            BtnAdd.TextColor = System.Drawing.Color.White;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // ItemStepAdd
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(BtnAdd);
            Controls.Add(gb2);
            Controls.Add(groupBox10);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "ItemStepAdd";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(997, 475);
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomGroupBox gb2;
        private System.Windows.Forms.TextBox TxtSstid;
        private CustomGroupBox groupBox10;
        private System.Windows.Forms.TextBox TxtVra;
        private Resources.CustomToolBox.RoundedButton BtnAdd;
    }
}
