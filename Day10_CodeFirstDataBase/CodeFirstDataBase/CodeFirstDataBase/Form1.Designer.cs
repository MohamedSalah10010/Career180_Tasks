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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DGV_1 = new DataGridView();
            Show_News = new Button();
            Show_Catalogs = new Button();
            Show_Authors = new Button();
            btn_Add = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_1).BeginInit();
            SuspendLayout();
            // 
            // DGV_1
            // 
            DGV_1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_1.Dock = DockStyle.Bottom;
            DGV_1.Location = new Point(0, 311);
            DGV_1.Name = "DGV_1";
            DGV_1.RowHeadersWidth = 51;
            DGV_1.Size = new Size(927, 227);
            DGV_1.TabIndex = 0;
            DGV_1.RowHeaderMouseDoubleClick += DGV_1_RowHeaderMouseDoubleClick;
            // 
            // Show_News
            // 
            Show_News.Location = new Point(316, 134);
            Show_News.Name = "Show_News";
            Show_News.Size = new Size(123, 29);
            Show_News.TabIndex = 1;
            Show_News.Text = "Show News";
            Show_News.UseVisualStyleBackColor = true;
            Show_News.Click += Show_News_Click;
            // 
            // Show_Catalogs
            // 
            Show_Catalogs.Location = new Point(316, 178);
            Show_Catalogs.Name = "Show_Catalogs";
            Show_Catalogs.Size = new Size(123, 29);
            Show_Catalogs.TabIndex = 2;
            Show_Catalogs.Text = "Show Catalogs";
            Show_Catalogs.UseVisualStyleBackColor = true;
            Show_Catalogs.Click += Show_Cataolgs_Click;
            // 
            // Show_Authors
            // 
            Show_Authors.Location = new Point(316, 222);
            Show_Authors.Name = "Show_Authors";
            Show_Authors.Size = new Size(123, 29);
            Show_Authors.TabIndex = 3;
            Show_Authors.Text = "Show Authors";
            Show_Authors.UseVisualStyleBackColor = true;
            Show_Authors.Click += Show_Authors_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(156, 178);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 29);
            btn_Add.TabIndex = 4;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(12, 178);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(94, 29);
            btn_Update.TabIndex = 5;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(83, 222);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 29);
            btn_Delete.TabIndex = 6;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(530, 40);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(530, 79);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 122);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(530, 162);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(530, 203);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "label5";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(673, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(673, 200);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(190, 27);
            textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(673, 162);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(190, 27);
            textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(673, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 27);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(673, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 27);
            textBox2.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(530, 243);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 18;
            label6.Text = "label6";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(673, 240);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(190, 27);
            textBox6.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(927, 538);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Add);
            Controls.Add(Show_Authors);
            Controls.Add(Show_Catalogs);
            Controls.Add(Show_News);
            Controls.Add(DGV_1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "CRUD ON NewsPaper DataBase";
            ((System.ComponentModel.ISupportInitialize)DGV_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_1;
        private Button Show_News;
        private Button Show_Catalogs;
        private Button Show_Authors;
        private Button btn_Add;
        private Button btn_Update;
        private Button btn_Delete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox6;
    }
}
