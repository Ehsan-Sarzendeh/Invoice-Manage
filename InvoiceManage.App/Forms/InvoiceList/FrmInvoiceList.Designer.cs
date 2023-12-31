namespace InvoiceManage.App.Forms.InvoiceList
{
    partial class FrmInvoiceList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            PanelHeader = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            BtnMaximize = new System.Windows.Forms.PictureBox();
            BtnMinimize = new System.Windows.Forms.PictureBox();
            BtnClose = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            actionPanel = new System.Windows.Forms.Panel();
            BtnEdit = new System.Windows.Forms.PictureBox();
            BtnPrint = new System.Windows.Forms.PictureBox();
            BtnDelete = new System.Windows.Forms.PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            InvoiceGv = new System.Windows.Forms.DataGridView();
            PanelHeader.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnPrint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceGv).BeginInit();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
            PanelHeader.Controls.Add(panel4);
            PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            PanelHeader.Location = new System.Drawing.Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new System.Drawing.Size(1026, 38);
            PanelHeader.TabIndex = 0;
            PanelHeader.MouseDown += PanelHeader_MouseDown;
            // 
            // panel4
            // 
            panel4.Controls.Add(BtnMaximize);
            panel4.Controls.Add(BtnMinimize);
            panel4.Controls.Add(BtnClose);
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(914, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(112, 38);
            panel4.TabIndex = 19;
            // 
            // BtnMaximize
            // 
            BtnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnMaximize.Image = Properties.Resources.maximize_w;
            BtnMaximize.Location = new System.Drawing.Point(40, 0);
            BtnMaximize.Name = "BtnMaximize";
            BtnMaximize.Size = new System.Drawing.Size(37, 37);
            BtnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BtnMaximize.TabIndex = 18;
            BtnMaximize.TabStop = false;
            BtnMaximize.Click += BtnMaximize_Click;
            // 
            // BtnMinimize
            // 
            BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnMinimize.Image = Properties.Resources.minimize_w;
            BtnMinimize.Location = new System.Drawing.Point(6, 0);
            BtnMinimize.Name = "BtnMinimize";
            BtnMinimize.Size = new System.Drawing.Size(37, 37);
            BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BtnMinimize.TabIndex = 16;
            BtnMinimize.TabStop = false;
            BtnMinimize.Click += BtnMinimize_Click;
            // 
            // BtnClose
            // 
            BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnClose.Image = Properties.Resources.close_w;
            BtnClose.Location = new System.Drawing.Point(74, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new System.Drawing.Size(37, 37);
            BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BtnClose.TabIndex = 17;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(actionPanel);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1026, 95);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(673, 0);
            panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(351, 93);
            panel3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            label1.Location = new System.Drawing.Point(174, 30);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(157, 38);
            label1.TabIndex = 4;
            label1.Text = "لیست فاکتور ها";
            // 
            // actionPanel
            // 
            actionPanel.Controls.Add(BtnEdit);
            actionPanel.Controls.Add(BtnPrint);
            actionPanel.Controls.Add(BtnDelete);
            actionPanel.Dock = System.Windows.Forms.DockStyle.Left;
            actionPanel.Location = new System.Drawing.Point(0, 0);
            actionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            actionPanel.Name = "actionPanel";
            actionPanel.Size = new System.Drawing.Size(379, 93);
            actionPanel.TabIndex = 3;
            // 
            // BtnEdit
            // 
            BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new System.Drawing.Point(79, 18);
            BtnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new System.Drawing.Size(55, 55);
            BtnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BtnEdit.TabIndex = 4;
            BtnEdit.TabStop = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnPrint
            // 
            BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnPrint.Image = Properties.Resources.print;
            BtnPrint.Location = new System.Drawing.Point(142, 18);
            BtnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new System.Drawing.Size(55, 55);
            BtnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BtnPrint.TabIndex = 3;
            BtnPrint.TabStop = false;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new System.Drawing.Point(16, 18);
            BtnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new System.Drawing.Size(55, 55);
            BtnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BtnDelete.TabIndex = 0;
            BtnDelete.TabStop = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // InvoiceGv
            // 
            InvoiceGv.AllowUserToDeleteRows = false;
            InvoiceGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            InvoiceGv.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            InvoiceGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            InvoiceGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            InvoiceGv.DefaultCellStyle = dataGridViewCellStyle2;
            InvoiceGv.Dock = System.Windows.Forms.DockStyle.Fill;
            InvoiceGv.Location = new System.Drawing.Point(0, 133);
            InvoiceGv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            InvoiceGv.Name = "InvoiceGv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            InvoiceGv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            InvoiceGv.RowHeadersWidth = 51;
            InvoiceGv.RowTemplate.Height = 29;
            InvoiceGv.Size = new System.Drawing.Size(1026, 605);
            InvoiceGv.TabIndex = 3;
            // 
            // FrmInvoiceList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1026, 738);
            Controls.Add(InvoiceGv);
            Controls.Add(panel2);
            Controls.Add(PanelHeader);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FrmInvoiceList";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmInvoiceList";
            FormClosing += FrmInvoiceList_FormClosing;
            Load += FrmInvoiceList_Load;
            MouseDown += FrmInvoiceList_MouseDown;
            PanelHeader.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            actionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnPrint).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceGv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView InvoiceGv;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.PictureBox BtnPrint;
        private System.Windows.Forms.PictureBox BtnDelete;
        private System.Windows.Forms.PictureBox BtnMaximize;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.PictureBox BtnMinimize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox BtnEdit;
    }
}