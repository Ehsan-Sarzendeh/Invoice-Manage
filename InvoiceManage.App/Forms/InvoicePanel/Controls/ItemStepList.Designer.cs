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
            CustomersGv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)CustomersGv).BeginInit();
            SuspendLayout();
            // 
            // CustomersGv
            // 
            CustomersGv.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            CustomersGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGv.Location = new System.Drawing.Point(24, 32);
            CustomersGv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            CustomersGv.Name = "CustomersGv";
            CustomersGv.RowTemplate.Height = 25;
            CustomersGv.Size = new System.Drawing.Size(945, 424);
            CustomersGv.TabIndex = 228;
            // 
            // ItemStepList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(CustomersGv);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "ItemStepList";
            Size = new System.Drawing.Size(997, 475);
            ((System.ComponentModel.ISupportInitialize)CustomersGv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersGv;
    }
}
