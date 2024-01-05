namespace InvoiceManage.App.Forms.InvoicePanel.Controls
{
    partial class ItemStep
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
            BtnNext = new Resources.CustomToolBox.RoundedButton();
            BtnPrevious = new Resources.CustomToolBox.RoundedButton();
            panel1 = new System.Windows.Forms.Panel();
            TabAdd = new Resources.CustomToolBox.RoundedButton();
            TabList = new Resources.CustomToolBox.RoundedButton();
            PanelSlider = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnNext
            // 
            BtnNext.BackColor = System.Drawing.Color.Green;
            BtnNext.BackgroundColor = System.Drawing.Color.Green;
            BtnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            BtnNext.BorderRadius = 10;
            BtnNext.BorderSize = 0;
            BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnNext.FlatAppearance.BorderSize = 0;
            BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnNext.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnNext.ForeColor = System.Drawing.Color.White;
            BtnNext.Location = new System.Drawing.Point(4, 551);
            BtnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new System.Drawing.Size(120, 47);
            BtnNext.TabIndex = 1;
            BtnNext.Text = "بعدی";
            BtnNext.TextColor = System.Drawing.Color.White;
            BtnNext.UseVisualStyleBackColor = false;
            BtnNext.Click += BtnNext_Click;
            // 
            // BtnPrevious
            // 
            BtnPrevious.BackColor = System.Drawing.Color.Gray;
            BtnPrevious.BackgroundColor = System.Drawing.Color.Gray;
            BtnPrevious.BorderColor = System.Drawing.Color.PaleVioletRed;
            BtnPrevious.BorderRadius = 10;
            BtnPrevious.BorderSize = 0;
            BtnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnPrevious.FlatAppearance.BorderSize = 0;
            BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnPrevious.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnPrevious.ForeColor = System.Drawing.Color.White;
            BtnPrevious.Location = new System.Drawing.Point(888, 551);
            BtnPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnPrevious.Name = "BtnPrevious";
            BtnPrevious.Size = new System.Drawing.Size(120, 47);
            BtnPrevious.TabIndex = 3;
            BtnPrevious.Text = "قبلی";
            BtnPrevious.TextColor = System.Drawing.Color.White;
            BtnPrevious.UseVisualStyleBackColor = false;
            BtnPrevious.Click += BtnPrevious_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(TabAdd);
            panel1.Controls.Add(TabList);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1012, 46);
            panel1.TabIndex = 4;
            // 
            // TabAdd
            // 
            TabAdd.BackColor = System.Drawing.Color.PeachPuff;
            TabAdd.BackgroundColor = System.Drawing.Color.PeachPuff;
            TabAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            TabAdd.BorderColor = System.Drawing.Color.FromArgb(224, 224, 224);
            TabAdd.BorderRadius = 5;
            TabAdd.BorderSize = 0;
            TabAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            TabAdd.Dock = System.Windows.Forms.DockStyle.Right;
            TabAdd.FlatAppearance.BorderSize = 0;
            TabAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TabAdd.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TabAdd.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            TabAdd.Location = new System.Drawing.Point(506, 0);
            TabAdd.Name = "TabAdd";
            TabAdd.Size = new System.Drawing.Size(506, 46);
            TabAdd.TabIndex = 1;
            TabAdd.Text = "افزودن اقلام";
            TabAdd.TextColor = System.Drawing.Color.FromArgb(68, 68, 68);
            TabAdd.UseVisualStyleBackColor = false;
            TabAdd.Click += TabAdd_Click;
            // 
            // TabList
            // 
            TabList.BackColor = System.Drawing.Color.LightGray;
            TabList.BackgroundColor = System.Drawing.Color.LightGray;
            TabList.BorderColor = System.Drawing.Color.PaleVioletRed;
            TabList.BorderRadius = 5;
            TabList.BorderSize = 0;
            TabList.Cursor = System.Windows.Forms.Cursors.Hand;
            TabList.Dock = System.Windows.Forms.DockStyle.Left;
            TabList.FlatAppearance.BorderSize = 0;
            TabList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TabList.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TabList.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            TabList.Location = new System.Drawing.Point(0, 0);
            TabList.Name = "TabList";
            TabList.Size = new System.Drawing.Size(506, 46);
            TabList.TabIndex = 0;
            TabList.Text = "لیست اقلام";
            TabList.TextColor = System.Drawing.Color.FromArgb(68, 68, 68);
            TabList.UseVisualStyleBackColor = false;
            TabList.Click += TabList_Click;
            // 
            // PanelSlider
            // 
            PanelSlider.Location = new System.Drawing.Point(0, 47);
            PanelSlider.Name = "PanelSlider";
            PanelSlider.Size = new System.Drawing.Size(1012, 495);
            PanelSlider.TabIndex = 5;
            // 
            // ItemStep
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(PanelSlider);
            Controls.Add(panel1);
            Controls.Add(BtnPrevious);
            Controls.Add(BtnNext);
            Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "ItemStep";
            Size = new System.Drawing.Size(1012, 603);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Resources.CustomToolBox.RoundedButton BtnNext;
        private Resources.CustomToolBox.RoundedButton BtnPrevious;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel PanelSlider;
        private Resources.CustomToolBox.RoundedButton TabList;
        private Resources.CustomToolBox.RoundedButton TabAdd;
    }
}
