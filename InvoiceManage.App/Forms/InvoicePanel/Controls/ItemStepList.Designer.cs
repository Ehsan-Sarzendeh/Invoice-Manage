namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    partial class ItemStepList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            GvItems = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            BtnEdit = new System.Windows.Forms.PictureBox();
            BtnDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)GvItems).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnDelete).BeginInit();
            SuspendLayout();
            // 
            // GvItems
            // 
            GvItems.AllowUserToAddRows = false;
            GvItems.AllowUserToDeleteRows = false;
            GvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            GvItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            GvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            GvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GvItems.Location = new System.Drawing.Point(19, 69);
            GvItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            GvItems.MultiSelect = false;
            GvItems.Name = "GvItems";
            GvItems.ReadOnly = true;
            GvItems.RowTemplate.Height = 25;
            GvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            GvItems.Size = new System.Drawing.Size(975, 413);
            GvItems.TabIndex = 228;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Control;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(BtnEdit);
            panel1.Controls.Add(BtnDelete);
            panel1.Location = new System.Drawing.Point(19, 10);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(975, 55);
            panel1.TabIndex = 229;
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
            // ItemStepList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel1);
            Controls.Add(GvItems);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "ItemStepList";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(1012, 495);
            Load += ItemStepList_Load;
            ((System.ComponentModel.ISupportInitialize)GvItems).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnDelete).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView GvItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BtnEdit;
        private System.Windows.Forms.PictureBox BtnDelete;
    }
}
