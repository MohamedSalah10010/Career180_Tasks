using CodeFirstDataBase.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace CodeFirstDataBase
{
    public enum dataBase { 
    
       
        Author,
        News,
        Catalog
    
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            form_clean();

        }
        public void form_clean() {

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";


        }

        dataBase flag;
        int id;
        private void Show_News_Click(object sender, EventArgs e)
        {
            form_clean();

            NewsPaper_Context db = new NewsPaper_Context();
            var news = db.News.Select(n => new { n.News_ID, n.Name, n.Description, n.Brief, n.Issued_date, n.Author, n.Catalog }).ToList();
            DGV_1.DataSource = news;
            flag = dataBase.News;

            label1.Text = "News Name";
            label2.Text = "News Description";
            label3.Text = "News Brief";
            label4.Text = "Catalog";
            label5.Text = "Author";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = false;

        }

        private void Show_Cataolgs_Click(object sender, EventArgs e)
        {
            form_clean();

            NewsPaper_Context db = new NewsPaper_Context();
            var catalogs = db.Catalogs.ToList();
            DGV_1.DataSource = catalogs;
            flag = dataBase.Catalog;
            label1.Text = "Catalog Name";
            label2.Text = "Catalog Description";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;


        }

        private void Show_Authors_Click(object sender, EventArgs e)
        {
            form_clean();

            NewsPaper_Context db = new NewsPaper_Context();
            var authors = db.Authors.Select(a => new { a.Auth_ID, a.Name, a.age,a.Brief }).ToList();
            DGV_1.DataSource = authors;
            flag = dataBase.Author;
            label1.Text = "Author Name";
            label2.Text = "Author Age";
            label3.Text = "Brief";
            label4.Text = "Username";
            label5.Text = "Password";
            label6.Text = "Confirm Password";
            
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
           
            NewsPaper_Context db = new NewsPaper_Context();

            if (flag == dataBase.Author)
            {
                              
                Author author = db.Authors.Where(n => n.Auth_ID == id).SingleOrDefault();
                author.Name  = textBox1.Text;
                author.age   = int.Parse(textBox2.Text);
                author.Brief = textBox3.Text ;

                if ((textBox5.Text == "" && textBox6.Text == "") && textBox4.Text == "")
                {
                   
                    db.SaveChanges();
                    MessageBox.Show("Updated to Authors");
                    Show_Authors_Click(sender, e);
                }
                else
                {
                    if (textBox5.Text == textBox6.Text && !(db.Authors.Any(t => t.UserName == textBox4.Text)))
                    {
                        author.Password = textBox5.Text;
                        author.UserName = textBox4.Text;
                        db.SaveChanges();
                        MessageBox.Show("Updated to Authors");
                        Show_Authors_Click(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("Invalid Password or Username!!");

                    }
                }
                


            }
            else if (flag == dataBase.Catalog)
            {

                Catalog catalog = db.Catalogs.Where(n => n.Cata_ID == id).SingleOrDefault();
                
                catalog.Description = textBox2.Text;
                if (db.Catalogs.Any(t => t.Name == textBox1.Text))
                {
                   
                    MessageBox.Show("Invalid Name, try another one!!");
                }
                else
                {

                    catalog.Name = textBox1.Text;
                    db.SaveChanges();
                    MessageBox.Show("Updated to Catalogs");
                    Show_Cataolgs_Click(sender, e);
                }


            }
            else if (flag == dataBase.News)
            {
                News news = db.News.Where(n => n.News_ID == id).SingleOrDefault();
                news.Name = textBox1.Text;
                news.Description = textBox2.Text;
                news.Brief = textBox3.Text;

                Catalog catalog = db.Catalogs.SingleOrDefault(n => n.Name.ToUpper() == textBox4.Text.ToUpper());
                Author author = db.Authors.SingleOrDefault(n => n.Name.ToUpper() == textBox5.Text.ToUpper());

                if (author == null || catalog == null )
                {
                    
                    MessageBox.Show("Author or Catalog doesn't exist, try to add them!!");

                }
                else
                {
                    news.Catalog = catalog;
                    news.Author = author ;
                    db.SaveChanges();
                    MessageBox.Show("Updated to News");
                    Show_News_Click(sender, e);

                }

            }
            else
            {
                form_clean();
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            NewsPaper_Context db = new NewsPaper_Context();

            if (flag == dataBase.Author)
            {

                Author author = new Author(); 
              
                if (textBox5.Text == textBox6.Text && !(db.Authors.Any(t => t.UserName == textBox4.Text)) || textBox4.Text == "")
                {
                    author.Password = textBox5.Text;
                    author.UserName = textBox4.Text;
                    author.Name = textBox1.Text;
                    author.age = int.Parse(textBox2.Text);
                    author.Brief = textBox3.Text;
                    author.Join_date= DateTime.Today;
                    db.Authors.Add(author);
                    db.SaveChanges();
                    MessageBox.Show("Added to Authors");
                    Show_Authors_Click(sender, e);

                }
                else
                {
                    MessageBox.Show("Invalid Password or Username!!");

                }



            }
            else if (flag == dataBase.Catalog)
            {

                Catalog catalog = new Catalog();

                
                if (db.Catalogs.Any(t => t.Name == textBox1.Text))
                {

                    MessageBox.Show("Invalid Name, Try another one!!");
                }
                else
                {

                    catalog.Name = textBox1.Text;
                    catalog.Description = textBox2.Text;
                    db.Catalogs.Add(catalog);
                    db.SaveChanges();
                    MessageBox.Show("Added to Catalogs");
                    Show_Cataolgs_Click(sender, e);
                }


            }
            else if (flag == dataBase.News)
            {
                News news = new News();
               

                Catalog catalog = db.Catalogs.SingleOrDefault(n => n.Name.ToUpper() == textBox4.Text.ToUpper());
                Author author = db.Authors.SingleOrDefault(n => n.Name.ToUpper() == textBox5.Text.ToUpper());

                if (author == null || catalog == null)
                {

                    MessageBox.Show("Author or Catalog doesn't exist, try to add them!!");

                }
                else
                {
                    news.Catalog = catalog;
                    news.Author = author;
                    news.Name = textBox1.Text;
                    news.Description = textBox2.Text;
                    news.Brief = textBox3.Text;
                    news.Issued_date = DateTime.Today;
                    db.News.Add(news);
                    db.SaveChanges();
                    MessageBox.Show("Added to News");
                    Show_News_Click(sender, e);

                }

            }
            else
            {
                form_clean();
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            NewsPaper_Context db = new NewsPaper_Context();

            if (flag == dataBase.Author)
            {

                Author author = db.Authors.Where(n => n.Auth_ID == id).SingleOrDefault();

                db.Authors.Remove(author);
                db.SaveChanges();
                MessageBox.Show("Removed from Authors");
                Show_Authors_Click(sender, e);

            }

            else if (flag == dataBase.Catalog)
            {

                Catalog catalog = db.Catalogs.Where(n => n.Cata_ID == id).SingleOrDefault();
                db.Catalogs.Remove(catalog);
                db.SaveChanges();
                MessageBox.Show("Removed from Catalogs");
                Show_Cataolgs_Click(sender, e);
            }

            else if (flag == dataBase.News)
            {
                News news = db.News.Where(n => n.News_ID == id).SingleOrDefault();


                     db.News.Remove(news);
                    db.SaveChanges();
                    MessageBox.Show("Removed from News");
                    Show_News_Click(sender, e);

                

            }
            else
            {
                form_clean();
            }


        }

        private void DGV_1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NewsPaper_Context db = new NewsPaper_Context();

            if (flag == dataBase.Author)
            {
                
                id = (int)DGV_1.SelectedRows[0].Cells["Auth_ID"].Value;
                Author author = db.Authors.Where(n => n.Auth_ID == id).SingleOrDefault();
                textBox1.Text = author.Name;
                textBox2.Text = author.age.ToString();
                textBox3.Text = author.Brief;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;   



            }
            else if (flag == dataBase.Catalog)
            {
                
                id = (int)DGV_1.SelectedRows[0].Cells["Cata_ID"].Value;
                Catalog catalog = db.Catalogs.Where(n => n.Cata_ID == id).SingleOrDefault();
                textBox1.Text = catalog.Name;
                textBox2.Text = catalog.Description;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;

            }
            else if (flag == dataBase.News)
            {
                id = (int)DGV_1.SelectedRows[0].Cells["News_ID"].Value;
                News news = db.News.Where(n => n.News_ID == id).SingleOrDefault();
                textBox1.Text = news.Name;
                textBox2.Text = news.Description;
                textBox3.Text = news.Brief;
                textBox4.Text = news.Catalog.Name;
                textBox5.Text = news.Author.Name;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = false;


            }
            else
            {
                form_clean();
            }
        }


    }
}
