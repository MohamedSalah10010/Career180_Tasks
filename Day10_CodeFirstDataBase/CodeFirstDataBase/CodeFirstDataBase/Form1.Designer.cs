namespace CodeFirstDataBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGV_1 = new DataGridView();
            Show_News = new Button();
            Show_Cataolgs = new Button();
            Show_Authors = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_1).BeginInit();
            SuspendLayout();
            // 
            // DGV_1
            // 
            DGV_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_1.Location = new Point(0, 244);
            DGV_1.Name = "DGV_1";
            DGV_1.RowHeadersWidth = 51;
            DGV_1.Size = new Size(802, 194);
            DGV_1.TabIndex = 0;
            // 
            // Show_News
            // 
            Show_News.Location = new Point(316, 110);
            Show_News.Name = "Show_News";
            Show_News.Size = new Size(123, 29);
            Show_News.TabIndex = 1;
            Show_News.Text = "Show News";
            Show_News.UseVisualStyleBackColor = true;
            Show_News.Click += Show_News_Click;
            // 
            // Show_Cataolgs
            // 
            Show_Cataolgs.Location = new Point(316, 154);
            Show_Cataolgs.Name = "Show_Cataolgs";
            Show_Cataolgs.Size = new Size(123, 29);
            Show_Cataolgs.TabIndex = 2;
            Show_Cataolgs.Text = "Show Cataolgs";
            Show_Cataolgs.UseVisualStyleBackColor = true;
            Show_Cataolgs.Click += Show_Cataolgs_Click;
            // 
            // Show_Authors
            // 
            Show_Authors.Location = new Point(316, 198);
            Show_Authors.Name = "Show_Authors";
            Show_Authors.Size = new Size(123, 29);
            Show_Authors.TabIndex = 3;
            Show_Authors.Text = "Show Authors";
            Show_Authors.UseVisualStyleBackColor = true;
            Show_Authors.Click += Show_Authors_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Show_Authors);
            Controls.Add(Show_Cataolgs);
            Controls.Add(Show_News);
            Controls.Add(DGV_1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGV_1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_1;
        private Button Show_News;
        private Button Show_Cataolgs;
        private Button Show_Authors;
    }
}
