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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            BtnAdd = new Resources.CustomToolBox.RoundedButton();
            groupBox11 = new System.Windows.Forms.GroupBox();
            textBox3 = new System.Windows.Forms.TextBox();
            groupBox10 = new System.Windows.Forms.GroupBox();
            textBox2 = new System.Windows.Forms.TextBox();
            groupBox9 = new System.Windows.Forms.GroupBox();
            textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox11.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(25, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(727, 418);
            dataGridView1.TabIndex = 225;
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
            BtnAdd.Location = new System.Drawing.Point(25, 148);
            BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new System.Drawing.Size(179, 47);
            BtnAdd.TabIndex = 221;
            BtnAdd.Text = "افزودن";
            BtnAdd.TextColor = System.Drawing.Color.White;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(textBox3);
            groupBox11.Font = new System.Drawing.Font("IRANSansWeb", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox11.ForeColor = System.Drawing.Color.DimGray;
            groupBox11.Location = new System.Drawing.Point(226, 31);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new System.Drawing.Size(204, 70);
            groupBox11.TabIndex = 224;
            groupBox11.TabStop = false;
            groupBox11.Text = "نرخ مالیات بر ارزش افزوده";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox3.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox3.Location = new System.Drawing.Point(17, 30);
            textBox3.Name = "textBox3";
            textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox3.Size = new System.Drawing.Size(172, 29);
            textBox3.TabIndex = 0;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(textBox2);
            groupBox10.Font = new System.Drawing.Font("IRANSansWeb", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox10.ForeColor = System.Drawing.Color.DimGray;
            groupBox10.Location = new System.Drawing.Point(226, 107);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new System.Drawing.Size(525, 88);
            groupBox10.TabIndex = 223;
            groupBox10.TabStop = false;
            groupBox10.Text = "شرح کالا";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox2.Location = new System.Drawing.Point(17, 26);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox2.Size = new System.Drawing.Size(495, 52);
            textBox2.TabIndex = 0;
            textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(textBox1);
            groupBox9.Font = new System.Drawing.Font("IRANSansWeb", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox9.ForeColor = System.Drawing.Color.DimGray;
            groupBox9.Location = new System.Drawing.Point(448, 31);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new System.Drawing.Size(303, 70);
            groupBox9.TabIndex = 222;
            groupBox9.TabStop = false;
            groupBox9.Text = "شناسه کالا";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(13, 29);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox1.Size = new System.Drawing.Size(279, 29);
            textBox1.TabIndex = 0;
            // 
            // ProductSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(BtnAdd);
            Controls.Add(groupBox11);
            Controls.Add(groupBox10);
            Controls.Add(groupBox9);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Name = "ProductSettings";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(777, 691);
            Load += ProductSettings_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Resources.CustomToolBox.RoundedButton BtnAdd;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBox1;
    }
}
