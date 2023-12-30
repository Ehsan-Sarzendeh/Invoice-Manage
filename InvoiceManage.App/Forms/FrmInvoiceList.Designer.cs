namespace InvoiceManage.App.Forms
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
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            actionPanel = new System.Windows.Forms.Panel();
            PrintBtn = new System.Windows.Forms.PictureBox();
            InvoiceItemsBtn = new System.Windows.Forms.PictureBox();
            DeleteInvoiceBtn = new System.Windows.Forms.PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PrintBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceItemsBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoiceBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(actionPanel);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1008, 91);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("IRANSansWeb", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(838, 28);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(157, 36);
            label1.TabIndex = 3;
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
            actionPanel.Size = new System.Drawing.Size(351, 91);
            actionPanel.TabIndex = 2;
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
            PrintBtn.Click += PrintBtn_Click;
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
            InvoiceItemsBtn.Click += InvoiceItemsBtn_Click;
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
            DeleteInvoiceBtn.Click += DeleteInvoiceBtn_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
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
            dataGridView1.Location = new System.Drawing.Point(0, 91);
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
            dataGridView1.Size = new System.Drawing.Size(1008, 570);
            dataGridView1.TabIndex = 2;
            // 
            // FrmInvoiceList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 31F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1008, 661);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("IRANSansWeb", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FrmInvoiceList";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "لیست فاکتور ها";
            FormClosing += FrmInvoiceList_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            actionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PrintBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceItemsBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoiceBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.PictureBox PrintBtn;
        private System.Windows.Forms.PictureBox InvoiceItemsBtn;
        private System.Windows.Forms.PictureBox DeleteInvoiceBtn;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}