namespace CRUD_Operations
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Track_duration = new TextBox();
            Track_name = new TextBox();
            Student_name = new TextBox();
            Age = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TrackID = new ComboBox();
            update_track = new Button();
            Add_track = new Button();
            Delete_track = new Button();
            Update_student = new Button();
            Add_student = new Button();
            Delete_student = new Button();
            DataGridView = new DataGridView();
            Track_location = new TextBox();
            label7 = new Label();
            City = new TextBox();
            label8 = new Label();
            ShowTrack = new Button();
            ShowStudents = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "Track Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 90);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 164);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 3;
            label3.Text = "Location";
            // 
            // Track_duration
            // 
            Track_duration.Location = new Point(105, 83);
            Track_duration.Name = "Track_duration";
            Track_duration.Size = new Size(151, 27);
            Track_duration.TabIndex = 4;
            // 
            // Track_name
            // 
            Track_name.Location = new Point(105, 15);
            Track_name.Name = "Track_name";
            Track_name.Size = new Size(151, 27);
            Track_name.TabIndex = 5;
            // 
            // Student_name
            // 
            Student_name.Location = new Point(603, 18);
            Student_name.Name = "Student_name";
            Student_name.Size = new Size(185, 27);
            Student_name.TabIndex = 11;
            // 
            // Age
            // 
            Age.Location = new Point(603, 82);
            Age.MaxLength = 3;
            Age.Name = "Age";
            Age.Size = new Size(185, 27);
            Age.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(487, 22);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 9;
            label4.Text = "Student Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 86);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 8;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 164);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 7;
            label6.Text = "City";
            // 
            // TrackID
            // 
            TrackID.FormattingEnabled = true;
            TrackID.Location = new Point(603, 227);
            TrackID.Name = "TrackID";
            TrackID.Size = new Size(185, 28);
            TrackID.TabIndex = 6;
            // 
            // update_track
            // 
            update_track.Location = new Point(25, 206);
            update_track.Name = "update_track";
            update_track.Size = new Size(94, 29);
            update_track.TabIndex = 12;
            update_track.Text = "Update Track";
            update_track.UseVisualStyleBackColor = true;
            update_track.Click += update_track_Click;
            // 
            // Add_track
            // 
            Add_track.Location = new Point(140, 206);
            Add_track.Name = "Add_track";
            Add_track.Size = new Size(94, 29);
            Add_track.TabIndex = 13;
            Add_track.Text = "Add ";
            Add_track.UseVisualStyleBackColor = true;
            Add_track.Click += Add_track_Click;
            // 
            // Delete_track
            // 
            Delete_track.Location = new Point(251, 206);
            Delete_track.Name = "Delete_track";
            Delete_track.Size = new Size(94, 29);
            Delete_track.TabIndex = 14;
            Delete_track.Text = "Delete";
            Delete_track.UseVisualStyleBackColor = true;
            Delete_track.Click += Delete_track_Click;
            // 
            // Update_student
            // 
            Update_student.Location = new Point(487, 274);
            Update_student.Name = "Update_student";
            Update_student.Size = new Size(94, 29);
            Update_student.TabIndex = 15;
            Update_student.Text = "Update";
            Update_student.UseVisualStyleBackColor = true;
            Update_student.Click += Update_student_Click;
            // 
            // Add_student
            // 
            Add_student.Location = new Point(594, 274);
            Add_student.Name = "Add_student";
            Add_student.Size = new Size(94, 29);
            Add_student.TabIndex = 16;
            Add_student.Text = "Add";
            Add_student.UseVisualStyleBackColor = true;
            Add_student.Click += Add_student_Click;
            // 
            // Delete_student
            // 
            Delete_student.Location = new Point(694, 274);
            Delete_student.Name = "Delete_student";
            Delete_student.Size = new Size(94, 29);
            Delete_student.TabIndex = 17;
            Delete_student.Text = "Delete";
            Delete_student.UseVisualStyleBackColor = true;
            Delete_student.Click += Delete_student_Click;
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(14, 309);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(795, 175);
            DataGridView.TabIndex = 18;
            DataGridView.RowHeaderMouseDoubleClick += DataGridView_RowHeaderMouseDoubleClick;
            // 
            // Track_location
            // 
            Track_location.Location = new Point(105, 152);
            Track_location.Name = "Track_location";
            Track_location.Size = new Size(151, 27);
            Track_location.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(262, 90);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 20;
            label7.Text = "Weeks";
            // 
            // City
            // 
            City.Location = new Point(603, 160);
            City.Name = "City";
            City.Size = new Size(185, 27);
            City.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(487, 232);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 21;
            label8.Text = "Track";
            // 
            // ShowTrack
            // 
            ShowTrack.Location = new Point(25, 274);
            ShowTrack.Name = "ShowTrack";
            ShowTrack.Size = new Size(104, 29);
            ShowTrack.TabIndex = 23;
            ShowTrack.Text = "ShowTrack";
            ShowTrack.UseVisualStyleBackColor = true;
            ShowTrack.Click += ShowTrack_Click;
            // 
            // ShowStudents
            // 
            ShowStudents.Location = new Point(162, 274);
            ShowStudents.Name = "ShowStudents";
            ShowStudents.Size = new Size(110, 29);
            ShowStudents.TabIndex = 24;
            ShowStudents.Text = "ShowStudents";
            ShowStudents.UseVisualStyleBackColor = true;
            ShowStudents.Click += ShowStudents_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 496);
            Controls.Add(ShowStudents);
            Controls.Add(ShowTrack);
            Controls.Add(City);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Track_location);
            Controls.Add(DataGridView);
            Controls.Add(Delete_student);
            Controls.Add(Add_student);
            Controls.Add(Update_student);
            Controls.Add(Delete_track);
            Controls.Add(Add_track);
            Controls.Add(update_track);
            Controls.Add(Student_name);
            Controls.Add(Age);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(TrackID);
            Controls.Add(Track_name);
            Controls.Add(Track_duration);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Track_duration;
        private TextBox Track_name;
        private TextBox Student_name;
        private TextBox Age;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox TrackID;
        private Button update_track;
        private Button Add_track;
        private Button Delete_track;
        private Button Update_student;
        private Button Add_student;
        private Button Delete_student;
        private DataGridView DataGridView;
        private TextBox Track_location;
        private Label label7;
        private TextBox City;
        private Label label8;
        private Button ShowTrack;
        private Button ShowStudents;
    }
}
