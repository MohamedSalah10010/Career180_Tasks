namespace NotePad
{
    public partial class Notepad : Form
    {

        public string Path { get; set; }
        public Notepad()
        {
            InitializeComponent();
            Path = null;
        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Path != null)
            {
                Notepad_txt.SaveFile(Path);

            }

            else
            {
                
                    if (saveFile.ShowDialog() == DialogResult.OK)
                        Notepad_txt.SaveFile(saveFile.FileName);

                    Path = saveFile.FileName;
            }
            Notepad_txt.Modified = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (Notepad_txt.Text != "")
                {
                    if (MessageBox.Show("Do you want to save?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        saveToolStripMenuItem_Click(null, null);

                    }
                }
                Notepad_txt.LoadFile(openFile.FileName);
                Path = openFile.FileName;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Notepad_txt.Text != "")
            {

                if (MessageBox.Show("Do you want to save?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);

                }
            }
            Notepad_txt.Clear();
            Path = null;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
                Notepad_txt.SaveFile(saveFile.FileName);

            Path = saveFile.FileName;
            Notepad_txt.Modified = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Notepad_txt.Modified)
            {
                if (MessageBox.Show("Do you want to save?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);

                }
            }

            e.Cancel = false;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontFile.ShowDialog() == DialogResult.OK)
            {

                if (Notepad_txt.SelectedText != "")
                {

                    Notepad_txt.SelectionFont = fontFile.Font;
                }
                else
                    Notepad_txt.Font = fontFile.Font;
            }

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorFile.ShowDialog() == DialogResult.OK)
            {

                if (Notepad_txt.SelectedText != "")
                {

                    Notepad_txt.SelectionColor = colorFile.Color;
                }
                else
                    Notepad_txt.ForeColor = colorFile.Color;
            }

        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorFile.ShowDialog() == DialogResult.OK)
            {

                if (Notepad_txt.SelectedText != "")
                {

                    Notepad_txt.SelectionBackColor = colorFile.Color;
                }
                else
                    Notepad_txt.BackColor = colorFile.Color;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This a notepad application designed and developed by Mohamed Salah.\nFor more information you can visit https://github.com/MohamedSalah10010", "About", MessageBoxButtons.OK);
        }
    }
}
