﻿namespace InvoiceManage.App.Forms.InvoicePanel
{
    partial class FrmSelectAbstract
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
            BtnClose = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            BtnSelect = new Resources.CustomToolBox.RoundedButton();
            GvRecords = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GvRecords).BeginInit();
            SuspendLayout();
            // 
            // BtnClose
            // 
            BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnClose.Image = Properties.Resources.close_w;
            BtnClose.Location = new System.Drawing.Point(692, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new System.Drawing.Size(37, 37);
            BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BtnClose.TabIndex = 16;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnSelect);
            panel1.Controls.Add(GvRecords);
            panel1.Location = new System.Drawing.Point(4, 39);
            panel1.Name = "panel1";
            panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            panel1.Size = new System.Drawing.Size(721, 440);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            label1.Location = new System.Drawing.Point(234, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(260, 32);
            label1.TabIndex = 223;
            label1.Text = "آیتم مورد نظر خود را انتخاب کنید";
            // 
            // BtnSelect
            // 
            BtnSelect.BackColor = System.Drawing.Color.Green;
            BtnSelect.BackgroundColor = System.Drawing.Color.Green;
            BtnSelect.BorderColor = System.Drawing.Color.PaleVioletRed;
            BtnSelect.BorderRadius = 10;
            BtnSelect.BorderSize = 0;
            BtnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnSelect.FlatAppearance.BorderSize = 0;
            BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnSelect.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnSelect.ForeColor = System.Drawing.Color.White;
            BtnSelect.Location = new System.Drawing.Point(24, 371);
            BtnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnSelect.Name = "BtnSelect";
            BtnSelect.Size = new System.Drawing.Size(143, 47);
            BtnSelect.TabIndex = 222;
            BtnSelect.Text = "انتخاب";
            BtnSelect.TextColor = System.Drawing.Color.White;
            BtnSelect.UseVisualStyleBackColor = false;
            BtnSelect.Click += BtnSelect_Click;
            // 
            // GvRecords
            // 
            GvRecords.AllowUserToAddRows = false;
            GvRecords.AllowUserToDeleteRows = false;
            GvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            GvRecords.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            GvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GvRecords.Location = new System.Drawing.Point(24, 68);
            GvRecords.Name = "GvRecords";
            GvRecords.ReadOnly = true;
            GvRecords.RowTemplate.Height = 25;
            GvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            GvRecords.Size = new System.Drawing.Size(676, 287);
            GvRecords.TabIndex = 221;
            // 
            // FrmSelectAbstract
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
            ClientSize = new System.Drawing.Size(729, 484);
            Controls.Add(panel1);
            Controls.Add(BtnClose);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FrmSelectAbstract";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "FrmSelect";
            Load += FrmSelect_Load;
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GvRecords).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.DataGridView GvRecords;
        private Resources.CustomToolBox.RoundedButton BtnSelect;
        private System.Windows.Forms.Label label1;
    }
}