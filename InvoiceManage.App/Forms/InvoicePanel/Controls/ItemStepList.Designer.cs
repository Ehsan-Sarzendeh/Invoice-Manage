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
            GvItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)GvItems).BeginInit();
            SuspendLayout();
            // 
            // GvItems
            // 
            GvItems.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            GvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GvItems.Location = new System.Drawing.Point(21, 17);
            GvItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            GvItems.Name = "GvItems";
            GvItems.RowTemplate.Height = 25;
            GvItems.Size = new System.Drawing.Size(975, 458);
            GvItems.TabIndex = 228;
            // 
            // ItemStepList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(GvItems);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "ItemStepList";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(1012, 495);
            Load += ItemStepList_Load;
            ((System.ComponentModel.ISupportInitialize)GvItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView GvItems;
    }
}
