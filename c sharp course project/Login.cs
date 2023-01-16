using System;

using System.Windows.Forms;
using c_sharp_course_project.resources;


namespace c_sharp_course_project
{
    
    public partial class Login : Form
    {
        public Player player = new Player();
        
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // throw new System.NotImplementedException();
        }
        

        //при нажитии на кнопку входа происходит проверка имени пользователя, после чего открывается форма с меню
        private void enterBtn_Click(object sender, EventArgs e)
        {
            string checkPlayerName = nickname.Text;
            if (checkPlayerName!=""&&checkPlayerName.Length<=20)
            {
                player.Name = checkPlayerName;
                MainMenu mainMenu = new MainMenu();
                mainMenu.menuPlayerName.Text=checkPlayerName;
                mainMenu.Show();
                Hide();
            }
            else
            {
                Game game = new Game();
                game.Message("Поле имени игрока не должно быть пустым и содержать более 20 символов","Внимание",MessageBoxIcon.Warning);
                nickname.Clear();
            }
        }
    }
}