using System.Drawing;
using System.Windows.Forms;

namespace c_sharp_course_project
{
    //наследование от кнопки с некоторыми свойствами
    public class Cell: Button
    {
        private bool _isEmpty;
        private bool _isShip;
        private bool _isShot;
    
        //добавить сюда ещё получение координат по осям икс и игрек
        public string ShipId { get; set; }

        public const int CELLS_SIZE = 30;
        
        public Cell(bool isEmpty=false, bool isShip=false, bool isShot=false,int shipNumber=0,string shipId="-")
        {
            _isEmpty = isEmpty;
            _isShip = isShip;
            _isShot = isShot;
            ShipId = shipId;
            TabStop = false;
        }
        //параметры кнопки задаются для границы
        public void Border(int x=0, int y=0,string text="")
        {
            Location = new Point(x,y);
            Size = new Size(CELLS_SIZE, CELLS_SIZE);
            Enabled = false; //делаем неактивной  
            BackColor = Color.Gray;
            Text = text;
        }
        
        public bool IsEmpty
        {
            get => _isEmpty;
            set
            {
                _isEmpty = value;
                ChangeColor(value,Color.MintCream, Color.MintCream);
            }
        }
            
        public bool IsShip
        {
            get => _isShip;
            set
            {
                _isShip = value;
                if (value)
                {
                    ChangeColor(value,Color.Brown, Color.Brown);
                }
                else
                {
                    ChangeColor(value,Color.MintCream, Color.MintCream);
                }
              
            }
        }

        public bool IsShot
        {
            get => _isShot;
            set
            {
                _isShot = value;
                if (value)
                {
                    ChangeColor(value,Color.Red, Color.MintCream);
                }
               
                else
                {
                    ChangeColor(value,Color.MintCream, Color.Black);
                }
            }
        }

        private void ChangeColor(bool isSelected,Color colorTrue,Color colorFalse)
        {
            if (isSelected)
            {
                BackColor = colorTrue;
            }
            else
            {
                BackColor = colorFalse;
            }
        }

      
    }
}