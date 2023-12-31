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
            PrintBtn = new System.Windows.Forms.PictureBox();
            InvoiceItemsBtn = new System.Windows.Forms.PictureBox();
            DeleteInvoiceBtn = new System.Windows.Forms.PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            PanelHeader.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PrintBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceItemsBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoiceBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
            PanelHeader.Controls.Add(panel4);
            PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            PanelHeader.Location = new System.Drawing.Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new System.Drawing.Size(1010, 38);
            PanelHeader.TabIndex = 0;
            PanelHeader.MouseDown += PanelHeader_MouseDown;
            // 
            // panel4
            // 
            panel4.Controls.Add(BtnMaximize);
            panel4.Controls.Add(BtnMinimize);
            panel4.Controls.Add(BtnClose);
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(810, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(200, 38);
            panel4.TabIndex = 19;
            // 
            // BtnMaximize
            // 
            BtnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnMaximize.Image = Properties.Resources.minimize_w;
            BtnMaximize.Location = new System.Drawing.Point(128, 0);
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
            BtnMinimize.Location = new System.Drawing.Point(92, 0);
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
            BtnClose.Location = new System.Drawing.Point(163, 0);
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
            panel2.Size = new System.Drawing.Size(1010, 95);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(657, 0);
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
            actionPanel.Controls.Add(PrintBtn);
            actionPanel.Controls.Add(InvoiceItemsBtn);
            actionPanel.Controls.Add(DeleteInvoiceBtn);
            actionPanel.Dock = System.Windows.Forms.DockStyle.Left;
            actionPanel.Location = new System.Drawing.Point(0, 0);
            actionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            actionPanel.Name = "actionPanel";
            actionPanel.Size = new System.Drawing.Size(379, 93);
            actionPanel.TabIndex = 3;
            // 
            // PrintBtn
            // 
            PrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            PrintBtn.Image = Properties.Resources.print;
            PrintBtn.Location = new System.Drawing.Point(142, 18);
            PrintBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new System.Drawing.Size(55, 55);
            PrintBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PrintBtn.TabIndex = 3;
            PrintBtn.TabStop = false;
            // 
            // InvoiceItemsBtn
            // 
            InvoiceItemsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            InvoiceItemsBtn.Image = Properties.Resources.items;
            InvoiceItemsBtn.Location = new System.Drawing.Point(79, 18);
            InvoiceItemsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            InvoiceItemsBtn.Name = "InvoiceItemsBtn";
            InvoiceItemsBtn.Size = new System.Drawing.Size(55, 55);
            InvoiceItemsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            InvoiceItemsBtn.TabIndex = 2;
            InvoiceItemsBtn.TabStop = false;
            // 
            // DeleteInvoiceBtn
            // 
            DeleteInvoiceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            DeleteInvoiceBtn.Image = Properties.Resources.delete;
            DeleteInvoiceBtn.Location = new System.Drawing.Point(16, 18);
            DeleteInvoiceBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            DeleteInvoiceBtn.Name = "DeleteInvoiceBtn";
            DeleteInvoiceBtn.Size = new System.Drawing.Size(55, 55);
            DeleteInvoiceBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            DeleteInvoiceBtn.TabIndex = 0;
            DeleteInvoiceBtn.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 133);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(1010, 566);
            dataGridView1.TabIndex = 3;
            // 
            // FrmInvoiceList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1010, 699);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(PanelHeader);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FrmInvoiceList";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmInvoiceList";
            FormClosing += FrmInvoiceList_FormClosing;
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
            ((System.ComponentModel.ISupportInitialize)PrintBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceItemsBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoiceBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.PictureBox PrintBtn;
        private System.Windows.Forms.PictureBox InvoiceItemsBtn;
        private System.Windows.Forms.PictureBox DeleteInvoiceBtn;
        private System.Windows.Forms.PictureBox BtnMaximize;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.PictureBox BtnMinimize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
    }
}