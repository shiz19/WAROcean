using System;
using System.Windows.Forms;
using c_sharp_course_project.resources;

namespace c_sharp_course_project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        

        private void MainMenu_Load(object sender, EventArgs e)
        {
          //  throw new System.NotImplementedException();
        }
        
        private void StartGameBtn_Click(object sender, EventArgs e)
        { 
           Game game = new Game();
           game.gamePlayerName.Text = menuPlayerName.Text;
           game.Show();
           Hide();
        }

        private void RecordsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Records records = new Records();
            records.recordsPlayerName.Text= menuPlayerName.Text;
            records.Show();
        }
        

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}