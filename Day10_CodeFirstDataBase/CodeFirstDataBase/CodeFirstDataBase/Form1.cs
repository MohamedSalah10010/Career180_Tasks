using CodeFirstDataBase.Models;

namespace CodeFirstDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Show_News_Click(object sender, EventArgs e)
        {
            NewsPaper_Context db = new NewsPaper_Context();
            var news = db.News.Select(n => new { n.Name,n.Description,n.Brief,n.Issued_date,n.Author,n.Catalog}).ToList();
            DGV_1.DataSource = news;

        }

        private void Show_Cataolgs_Click(object sender, EventArgs e)
        {
            NewsPaper_Context db = new NewsPaper_Context();
            var catalogs = db.Catalogs.ToList();
            DGV_1.DataSource = catalogs;
        }

        private void Show_Authors_Click(object sender, EventArgs e)
        {
            NewsPaper_Context db = new NewsPaper_Context();
            var authors = db.Authors.Select(a=>new { a.Name,a.age,a.Brief}).ToList();
            DGV_1.DataSource = authors;
        }
    }
}
