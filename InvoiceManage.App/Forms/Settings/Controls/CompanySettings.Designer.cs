namespace InvoiceManage.App.Forms.Settings.Controls
{
    partial class CompanySettings
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
            TxtName = new System.Windows.Forms.TextBox();
            groupBox9 = new System.Windows.Forms.GroupBox();
            TxtTins = new System.Windows.Forms.TextBox();
            BtnAdd = new Resources.CustomToolBox.RoundedButton();
            GvCompanies = new System.Windows.Forms.DataGridView();
            TxtSbc = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            TxtCrn = new System.Windows.Forms.TextBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            TxtScln = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            BtnEdit = new System.Windows.Forms.PictureBox();
            BtnDelete = new System.Windows.Forms.PictureBox();
            BtnEditCompany = new Resources.CustomToolBox.RoundedButton();
            groupBox11.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GvCompanies).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnDelete).BeginInit();
            SuspendLayout();
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(TxtName);
            groupBox11.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox11.ForeColor = System.Drawing.Color.DimGray;
            groupBox11.Location = new System.Drawing.Point(292, 30);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new System.Drawing.Size(244, 70);
            groupBox11.TabIndex = 219;
            groupBox11.TabStop = false;
            groupBox11.Text = "نام شرکت";
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
            // groupBox9
            // 
            groupBox9.Controls.Add(TxtTins);
            groupBox9.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox9.ForeColor = System.Drawing.Color.DimGray;
            groupBox9.Location = new System.Drawing.Point(553, 30);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new System.Drawing.Size(205, 70);
            groupBox9.TabIndex = 217;
            groupBox9.TabStop = false;
            groupBox9.Text = "شماره اقتصادی";
            // 
            // TxtTins
            // 
            TxtTins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtTins.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtTins.Location = new System.Drawing.Point(10, 28);
            TxtTins.Name = "TxtTins";
            TxtTins.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtTins.Size = new System.Drawing.Size(186, 29);
            TxtTins.TabIndex = 0;
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
            BtnAdd.Location = new System.Drawing.Point(32, 136);
            BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new System.Drawing.Size(120, 47);
            BtnAdd.TabIndex = 1;
            BtnAdd.Text = "افزودن";
            BtnAdd.TextColor = System.Drawing.Color.White;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // GvCompanies
            // 
            GvCompanies.AllowUserToAddRows = false;
            GvCompanies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            GvCompanies.BackgroundColor = System.Drawing.Color.White;
            GvCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GvCompanies.Location = new System.Drawing.Point(32, 289);
            GvCompanies.MultiSelect = false;
            GvCompanies.Name = "GvCompanies";
            GvCompanies.ReadOnly = true;
            GvCompanies.RowTemplate.Height = 25;
            GvCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            GvCompanies.Size = new System.Drawing.Size(727, 408);
            GvCompanies.TabIndex = 220;
            // 
            // TxtSbc
            // 
            TxtSbc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtSbc.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtSbc.Location = new System.Drawing.Point(15, 28);
            TxtSbc.Name = "TxtSbc";
            TxtSbc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtSbc.Size = new System.Drawing.Size(217, 29);
            TxtSbc.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtSbc);
            groupBox1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.ForeColor = System.Drawing.Color.DimGray;
            groupBox1.Location = new System.Drawing.Point(32, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(244, 70);
            groupBox1.TabIndex = 221;
            groupBox1.TabStop = false;
            groupBox1.Text = "کد شعبه";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TxtCrn);
            groupBox3.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox3.ForeColor = System.Drawing.Color.DimGray;
            groupBox3.Location = new System.Drawing.Point(292, 113);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(244, 70);
            groupBox3.TabIndex = 223;
            groupBox3.TabStop = false;
            groupBox3.Text = "شناسه یکتای ثبت قرارداد";
            // 
            // TxtCrn
            // 
            TxtCrn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtCrn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtCrn.Location = new System.Drawing.Point(15, 28);
            TxtCrn.Name = "TxtCrn";
            TxtCrn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtCrn.Size = new System.Drawing.Size(217, 29);
            TxtCrn.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(TxtScln);
            groupBox4.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox4.ForeColor = System.Drawing.Color.DimGray;
            groupBox4.Location = new System.Drawing.Point(553, 113);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(205, 70);
            groupBox4.TabIndex = 222;
            groupBox4.TabStop = false;
            groupBox4.Text = "شماره پروانه گمرکی";
            // 
            // TxtScln
            // 
            TxtScln.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtScln.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtScln.Location = new System.Drawing.Point(10, 28);
            TxtScln.Name = "TxtScln";
            TxtScln.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtScln.Size = new System.Drawing.Size(186, 29);
            TxtScln.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Control;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnEdit);
            panel1.Controls.Add(BtnDelete);
            panel1.Location = new System.Drawing.Point(32, 233);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(727, 55);
            panel1.TabIndex = 227;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            label1.Location = new System.Drawing.Point(586, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(136, 32);
            label1.TabIndex = 7;
            label1.Text = "لیست شرکت ها";
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
            // BtnEditCompany
            // 
            BtnEditCompany.BackColor = System.Drawing.Color.Orange;
            BtnEditCompany.BackgroundColor = System.Drawing.Color.Orange;
            BtnEditCompany.BorderColor = System.Drawing.Color.PaleVioletRed;
            BtnEditCompany.BorderRadius = 10;
            BtnEditCompany.BorderSize = 0;
            BtnEditCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnEditCompany.FlatAppearance.BorderSize = 0;
            BtnEditCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnEditCompany.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnEditCompany.ForeColor = System.Drawing.Color.White;
            BtnEditCompany.Location = new System.Drawing.Point(156, 136);
            BtnEditCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnEditCompany.Name = "BtnEditCompany";
            BtnEditCompany.Size = new System.Drawing.Size(120, 47);
            BtnEditCompany.TabIndex = 228;
            BtnEditCompany.Text = "ویرایش";
            BtnEditCompany.TextColor = System.Drawing.Color.White;
            BtnEditCompany.UseVisualStyleBackColor = false;
            BtnEditCompany.Click += BtnEditCompany_Click;
            // 
            // CompanySettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(BtnEditCompany);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(GvCompanies);
            Controls.Add(BtnAdd);
            Controls.Add(groupBox11);
            Controls.Add(groupBox9);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "CompanySettings";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(793, 730);
            Load += CompanySettings_Load;
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GvCompanies).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnDelete).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox TxtTins;
        private Resources.CustomToolBox.RoundedButton BtnAdd;
        private System.Windows.Forms.DataGridView GvCompanies;
        private System.Windows.Forms.TextBox TxtSbc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtCrn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtScln;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnEdit;
        private System.Windows.Forms.PictureBox BtnDelete;
        private Resources.CustomToolBox.RoundedButton BtnEditCompany;
    }
}
