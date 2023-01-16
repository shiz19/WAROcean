using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using c_sharp_course_project.resources;

namespace c_sharp_course_project
{
    public partial class Records : Form
    {
        private bool canRead = true;
        public Records()
        {
            InitializeComponent();
            
            if (canRead)
            {
               // string filename =@"C:\Users\Asus\RiderProjects\c sharp course project\c sharp course project\records.dat";
               string filename = "records.dat";
                ShowRecords(filename);
            }
        }


       //считывание информации об игроке из бинарного файла и вывод информации в таблицу
        private void ShowRecords(string filename)
        {
         
            if (File.Exists(filename))
            {
                using (BinaryReader binaryReader = new BinaryReader(File.Open(filename, FileMode.OpenOrCreate)))
                {
                    while (binaryReader.PeekChar()!= -1)
                    {
                        Player player = new Player();
                        player.Name = binaryReader.ReadString();
                        player.Record =  binaryReader.ReadInt32();

                        RecordsTable.Rows.Add(player.Name, player.Record);
                        Controls.Add(RecordsTable);
                     
                    }
                 
                    canRead = false;
                    binaryReader.Close();
                }

            }
            else
            {
                Game game = new Game();
                game.Message("Файл рекордов не существует", "Ошибка", MessageBoxIcon.Error);
            }
            
            
          
        }
        
        private void ToMainMenuBtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.menuPlayerName.Text = recordsPlayerName.Text;
            mainMenu.Show();
        }
        
    }
}