using CRUD_Operations.Models;
using Microsoft.EntityFrameworkCore;


namespace CRUD_Operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SchoolContext context = new SchoolContext();
            var track = context.Tracks.ToList();
            TrackID.DataSource = track;
            TrackID.DisplayMember = "Name";
            TrackID.ValueMember = "ID";
        }

        private void ShowTrack_Click(object sender, EventArgs e)
        {
            SchoolContext context = new SchoolContext();
            var track = context.Tracks.Select(t=>new { t.ID , t.Name,t.Location, t.Duration}).ToList();
            DataGridView.DataSource = track;
        }

        private void ShowStudents_Click(object sender, EventArgs e)
        {
            SchoolContext db = new SchoolContext();
            var student = db.Students.Include(s => s.Track).Select(s=>new { s.ID,s.Name,s.Age,s.City,TrackName= s.Track != null ? s.Track.Name : "No Track" }).ToList();
            //var student = db.Students.Include(n => n.Track).Select(s => new { s.ID, s.Name, s.Age, s.City, trackname = s.Track.Name }).ToList(); ;//display list on datagrid view
            DataGridView.DataSource = student;
        }

        private void Add_student_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = Student_name.Text,
                Age = int.Parse(Age.Text),
                City = City.Text,
                TrackID = (int)TrackID.SelectedValue,
            };
            SchoolContext db = new SchoolContext();
            db.Students.Add(student);
            db.SaveChanges();
            MessageBox.Show("Added to Student");
            Student_name.Text = Age.Text = City.Text = "";
            TrackID.SelectedIndex = -1;
            ShowStudents_Click(sender, e);
        }

        int id;


        private void Update_student_Click(object sender, EventArgs e)
        {
            SchoolContext db = new SchoolContext();
            Student student = db.Students.Where(n => n.ID == id).SingleOrDefault();

            student.Name = Student_name.Text;
            student.Age = int.Parse(Age.Text);
            student.City = City.Text;
            student.TrackID = (int)TrackID.SelectedValue;

            db.SaveChanges();
            MessageBox.Show("Updated to Student");
            Student_name.Text = Age.Text = City.Text = "";
            TrackID.SelectedIndex = -1;
            ShowStudents_Click(sender, e);
        }



        private void DataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SchoolContext db = new SchoolContext();
            id = (int)DataGridView.SelectedRows[0].Cells["ID"].Value;
            Student student = db.Students.Where(n => n.ID == id).SingleOrDefault();
            Student_name.Text = student.Name;
            Age.Text = student.Age.ToString();
            City.Text = student.City;
            if (student.TrackID.HasValue)
            {
                TrackID.SelectedValue = student.TrackID.Value;
            }
            else
            {
                TrackID.SelectedIndex = -1; // Clear selection if no TrackID
            }
        }

        private void Delete_student_Click(object sender, EventArgs e)
        {
            SchoolContext db = new SchoolContext();
            Student student = db.Students.Where(n => n.ID == id).SingleOrDefault();
            db.Students.Remove(student);
            db.SaveChanges();
            MessageBox.Show("Deleted from Student");
            Student_name.Text = Age.Text = City.Text  = "";
            TrackID.SelectedIndex = -1;
            ShowStudents_Click(sender, e);


        }
    }
}