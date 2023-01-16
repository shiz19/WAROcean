using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace c_sharp_course_project.resources
{
    public partial class Game : Form
    {
        private const int BOT_OFFSET = 650;
        private const int PLAYER_OFFSET = 0;
        private int currentScore = 0;
        public const int CELLS_COUNT = 12; //длинна ячеек в строке 
        private const int CELLS_SIZE = 30;

        private List<Ship> playerShipsList = new List<Ship>();
        private List<Ship> botShipsList = new List<Ship>();

        CellsArray playerCellsArray = new CellsArray(PLAYER_OFFSET);
        CellsArray botCellsArray = new CellsArray(BOT_OFFSET);


        //первое значение словаря - длина корабля, второе - количество размещенных кораблей соответствующей длинны
        public Dictionary<int, int> playerShipDictionary = new Dictionary<int, int>()
        {
            {2, 0},
            {3, 0},
            {4, 0}
        };


        public Dictionary<int, int> botShipDictionary = new Dictionary<int, int>()
        {
            {2, 0},
            {3, 0},
            {4, 0}
        };


        public bool IsGameStart = false;

        public Game()
        {
            InitializeComponent();
            StartGame();
        }


        public void StartGame()
        {
            Vertical.Checked = true;
            two.Checked = true;
            CreateField();
            ChangeShipPosition(playerCellsArray);
        }

        //если началась игра, то меняем событие с расстановки кораблей на
        //выстрел и блокируем кнопки изменения кораблей и кнопку начала игры
        public void StartBattle()
        {
            if (IsGameStart)
            {
                for (int i = 0; i < CELLS_COUNT; i++)
                {
                    for (int j = 0; j < CELLS_COUNT; j++)
                    {
                        botCellsArray.GetCellByIndex(i, j).Click += MakeShot;
                        playerCellsArray.GetCellByIndex(i, j).Click -= UpdateField;
                    }
                }

                SelectShipDirection.Enabled = false;
                SelectShip.Enabled = false;
                StartGameBtn.Enabled = false;
                ClearFieldBtn.Enabled = false;
                SetRandomShips.Enabled = false;
            }
        }

        //проверка на выстрел в корабль
        //Если сделан выстрел и корабль убит, то он удаляется из списка
        public void CheckShipShooting(Cell pressedButton, CellsArray cellsArray,
            List<Ship> ships)
        {
            if (pressedButton.IsShip && pressedButton.Enabled) //проверка на то, чтобы не считать лишние клики
            {
                Ship foundedShip =
                    ships.FirstOrDefault(ship1 => ship1.ShipId.Equals(pressedButton.ShipId));
                if (foundedShip != null)
                {
                    pressedButton.Enabled = false;
                    pressedButton.IsShot = true;
                    if (foundedShip.CheckLostShip(cellsArray))
                    {

                        cellsArray.FixingBordersColor();
                        ships.Remove(foundedShip); //удаляем корабль из списка
                        IsPlayerWin(playerShipsList, botShipsList);//проверка вот тут
                    }
                }
            }

            else if (pressedButton.Enabled)
            {
                pressedButton.IsShot = false;
                pressedButton.Enabled = false;
            }
        }


        //функция выстрела, ячейка меняет цвет и проверяется, попал ли игрок в корабль или нет, после чего компьютер совершает выстрел по полю игрока
        private void MakeShot(object sender, EventArgs e)
        {
            //todo проверить, что во все корабли попали и игрок выиграл, в классе игрока добавить isWin
            Cell pressedButton = sender as Cell;

            CheckShipShooting(pressedButton, botCellsArray, botShipsList);

           // IsPlayerWin(playerShipsList, botShipsList);

            //если нажатая клетка не является кораблем, компьютер делает выстрел
            if (pressedButton.IsShip == false)
            {
                MakeRandomAIShot(playerCellsArray, playerShipsList);
            }

            currentScore++;
            playerScoreLabel.Text = currentScore.ToString();
        }

        //проверка, что все корабли в правильном количестве
        public bool CheckShipRightCount(Dictionary<int, int> shipDictionary)
        {
            if (shipDictionary[2] == 4 && shipDictionary[3] == 2 && shipDictionary[4] == 1)
            {
                return true;
            }
            return false;
        }

        //ко всем кнопкам игрока добавляется событие обновления поля для расстановки кораблей
        public void ChangeShipPosition(CellsArray cells)
        {
            for (int i = 0; i < CELLS_COUNT; i++)
            {
                for (int j = 0; j < CELLS_COUNT; j++)
                {
                    cells.GetCellByIndex(i, j).Click += UpdateField;
                }
            }
        }

        //вывод в заголовок количество кораблей с проверкой того, чтобы не было отрицателбных значений
        private bool CheckShipCount(Dictionary<int, int> shipDictionary)
        {
            if (shipDictionary[2] > 4 || shipDictionary[3] > 2 || shipDictionary[4] > 1)
            {
                return false;
            }

            return true;
        }

        //проверка на количество кораблей
        private int GetLimitShipLenght(Dictionary<int, int> shipDictionary)
        {
            int shipLenght = 0;
            if (shipDictionary[2] > 4)
            {
                shipLenght = 1;
            }
            else if (shipDictionary[3] > 2)
            {
                shipLenght = 2;
            }
            else if (shipDictionary[4] > 1)
            {
                shipLenght = 3;
            }

            return shipLenght;
        }


        //в лейблах пишется текст количества установленных кораблей из словаря
        private void SetLeftShipText(Dictionary<int, int> shipDictionary)
        {
            for (int i = 2; i <= 4; i++)
            {
                if (shipDictionary[i] < 0)
                {
                    shipDictionary[i] = 0;
                }
            }

            twoShipsLabel.Text = shipDictionary[2].ToString();
            threeShipslabel.Text = shipDictionary[3].ToString();
            fourShipsLabel.Text = shipDictionary[4].ToString();
        }

        //возвращается длина выбранного корабля
        private int SelectShipRadios()
        {
            int shipLenght = 2;
            if (two.Checked)
            {
                shipLenght = 2;
            }
            else if (three.Checked)
            {
                shipLenght = 3;
            }
            else if (four.Checked)
            {
                shipLenght = 4;
            }

            return shipLenght;
        }

        //открываем главное меню
        private void OpenMainMenu()
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.menuPlayerName.Text = gamePlayerName.Text;
            mainMenu.Show();
            Hide();
        }
        //если выиграл игрок, то записываем его рекорд в файл рекордов
        public void IsPlayerWin(List<Ship> playerList, List<Ship> botList)
        {
            if (botList.Count == 0)
            {
                Message("Вы выиграли.\nВаш счёт:" + currentScore, "Победа", MessageBoxIcon.Information);

                if (!WriteRecords())
                {
                    Message("Файл рекордов не существует", "Ошибка", MessageBoxIcon.Error);
                }
                OpenMainMenu();

            }
            else if (playerList.Count == 0)
            {
                Message("Компьютер уничтожил все ваши корабли", "Поражение", MessageBoxIcon.Stop);
                OpenMainMenu();
            }
           
        }
        //При нажатии на кнопку,если лимит кораблей не превышается, то вычисляется нажатая клетка
        //и создается корабль в указанной позиции или удалется

        //функция создания или удаления корабля
        //при выбранных параметрах создается корабль определеннной длинны, после чего он добавляется в список и словарь кораблей
        //при удалении, соответственно, он удаляется из списка и словаря
        private void CreateOrDeleteShip(Cell pressedButton, CellsArray cellsArray, List<Ship> ships,
            Dictionary<int, int> shipDictionary)
        {
            bool isVertical = !Horizontal.Checked;

            int shipLenght = SelectShipRadios();
            int xCoord = pressedButton.Location.Y / CELLS_SIZE - 1; //при нажатии тут надо делать смещение почему-то
            int yCoord = (pressedButton.Location.X - cellsArray.OffsetX) / CELLS_SIZE;
            Ship ship = new Ship(xCoord, yCoord, isVertical, shipLenght);

            if (!cellsArray.GetCellByIndex(xCoord, yCoord).IsShip)
            {
                if (shipLenght == 2 && shipDictionary[2] < 4) //|| shipDictionary[3] < 2 || shipDictionary[4] < 1)
                {
                    if (ship.FieldAdd(cellsArray))
                    {
                        ships.Add(ship);
                        shipDictionary[shipLenght] += 1;
                        SetLeftShipText(shipDictionary);
                    }
                    else
                    {
                        Message("Невозможно разместить корабль в этой позиции", "Внимание", MessageBoxIcon.Warning);
                    }
                }
                else if (shipLenght == 3 && shipDictionary[3] < 2)
                {
                    if (ship.FieldAdd(cellsArray))
                    {
                        ships.Add(ship);
                        shipDictionary[shipLenght] += 1;
                        SetLeftShipText(shipDictionary);
                    }
                    else
                    {
                        Message("Невозможно разместить корабль в этой позиции", "Внимание", MessageBoxIcon.Warning);
                    }
                }
                else if (shipLenght == 4 && shipDictionary[4] < 1)
                {
                    if (ship.FieldAdd(cellsArray))
                    {
                        ships.Add(ship);
                        shipDictionary[shipLenght] += 1;
                        SetLeftShipText(shipDictionary);
                    }
                    else
                    {
                        Message("Невозможно разместить корабль в этой позиции", "Внимание", MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    Message($"Лимит кораблей превышен.\n ",
                        "Внимание",
                        MessageBoxIcon.Warning);
                }
            }

            else if (cellsArray.GetCellByIndex(xCoord, yCoord).IsShip)
            {
                Ship foundedShip =
                    ships.FirstOrDefault(ship1 => ship1.ShipId.Equals(cellsArray.GetCellByIndex(xCoord, yCoord).ShipId));
                if (foundedShip != null)
                {
                    foundedShip.FieldDelete(cellsArray);
                    {
                        shipDictionary[foundedShip.ShipLenght] -= 1;
                        SetLeftShipText(shipDictionary);
                        ships.RemoveAt(ships.IndexOf(foundedShip)); //удаляем корабль из списка
                    }
                }

                else
                {
                    Message("Данный корабль не найден", "Внимание", MessageBoxIcon.Warning);
                }
            }
        }

        //обновление поля игрока
        private void UpdateField(object sender, EventArgs e)
        {
            Cell pressedButton = sender as Cell;
            CreateOrDeleteShip(pressedButton, playerCellsArray, playerShipsList, playerShipDictionary);
        }

        //создание двух полей кораблей с подсказками
        public void CreateField()
        {
            //подсказки, информирующие о цвете клеток и их значениях
            Cell shotTipsCell = new Cell();
            shotTipsCell.Border(ShotTipsLabel.Location.X + 3 * CELLS_SIZE + 30,
                ShotTipsLabel.Location.Y - CELLS_SIZE / 3);
            shotTipsCell.IsShot = true;
            Controls.Add(shotTipsCell);


            Cell missTipsCell = new Cell();
            missTipsCell.Border(MissTipsLabel.Location.X + 3 * CELLS_SIZE + 30,
                MissTipsLabel.Location.Y - CELLS_SIZE / 3);
            missTipsCell.IsShot = false;
            Controls.Add(missTipsCell);

            playerCellsArray.PrintField();

            ShowCells(playerCellsArray);
            botCellsArray.PrintField();


            ShowCells(botCellsArray);

            RandomShipPositions(botShipDictionary, botCellsArray, botShipsList);
            botCellsArray.HideShipsCells();

        }
        //запись рекорда игрока в файл
        private bool WriteRecords()
        {
            // string filename =@"C:\Users\Asus\RiderProjects\c sharp course project\c sharp course project\records.dat";
            string filename = "records.dat";
            if (File.Exists(filename))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(filename, FileMode.Append)))
                {
                    binaryWriter.Write(gamePlayerName.Text);
                    binaryWriter.Write(Convert.ToInt32(playerScoreLabel.Text));
                    binaryWriter.Close();
                }

                return true;
            }

            return false;
        }

        //отображение полей ячеек
        private void ShowCells(CellsArray cellsArray)
        {
            for (int i = 0; i < CELLS_COUNT; i++)
            {
                for (int j = 0; j < CELLS_COUNT; j++)
                {
                    Controls.Add(cellsArray.GetCellByIndex(i, j));
                }
            }
        }


        private void Game_Load(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }


        //при нажатии на кнопку появляется отладочная информация по полю, начата ли игра и размещенных корабля
        public void Message(string text, string caption, MessageBoxIcon icon)
        {
            DialogResult warning = MessageBox.Show(text, caption, MessageBoxButtons.OK, icon);
        }


        //при нажатии на кнопку проверяется, что все корабли размещены
        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            if (CheckShipRightCount(playerShipDictionary))
            {
                IsGameStart = true;
                StartBattle();
            }
            else
            {
                Message("Расставьте все корабли, чтобы начать игру", "Внимание", MessageBoxIcon.Warning);
            }
        }

        //рандомная установка кораблей на поле
        private void SetRandomShips_Click(object sender, EventArgs e)
        {
            twoShipsLabel.Text = "4";
            threeShipslabel.Text = "2";
            fourShipsLabel.Text = "1";
            //при рандомной расстановке сначала очищаем, потом рандомим
            ClearCellfield(playerShipDictionary, playerShipsList, playerCellsArray);
            RandomShipPositions(playerShipDictionary, playerCellsArray, playerShipsList);
        }

        //рандомное размещение кораблей для компютера и для игрока при нажатии на кнопку
        //сначала размещаются корабли наименьшей длинны 2, потом 3 и 4
        //если поле занято, пытаемся создать корабль в другом месте и в другом направлении
        void RandomShipPositions(Dictionary<int, int> shipDictionary, CellsArray cellsArray, List<Ship> ships)
        {
            Random random = new Random();
            int startShipLenght = 2;
            while (shipDictionary[2] != 4 || shipDictionary[3] != 2 || shipDictionary[4] != 1)

            {
                if (shipDictionary[2] == 4)
                {
                    startShipLenght = 3;
                }

                if (shipDictionary[3] == 2)
                {
                    startShipLenght = 4;
                }

                int randomX = random.Next(0, 10);
                int randomY = random.Next(0, 10);
                int randomIntegerVal = random.Next(0, 2);
                bool randomVertical;
                if (randomIntegerVal == 1)
                {
                    randomVertical = true;
                }
                else
                {
                    randomVertical = false;
                }
                int randomLenght = startShipLenght;


                Ship ship = new Ship(randomX, randomY, randomVertical, randomLenght);
                if (!cellsArray.GetCellByIndex(randomX, randomY).IsShip)
                {
                    if (CheckShipCount(shipDictionary))
                    {
                        if (ship.FieldAdd(cellsArray))
                        {
                            ships.Add(ship);
                            shipDictionary[randomLenght] += 1;
                        }
                    }
                }
            }
        }

        //очистка поля игрока от всех кораблей
        private void ClearFieldBtn_Click(object sender, EventArgs e)
        {
            if (!IsGameStart)
            {
                twoShipsLabel.Text = "0";
                threeShipslabel.Text = "0";
                fourShipsLabel.Text = "0";
                ClearCellfield(playerShipDictionary, playerShipsList, playerCellsArray);
            }
        }


        void ClearCellfield(Dictionary<int, int> shipDictionary, List<Ship> ships, CellsArray cellsArray)
        {
            for (int i = 2; i <= 4; i++)
            {
                shipDictionary[i] = 0;
            }

            ships.Clear();
            for (int i = 1; i < CELLS_COUNT - 1; i++)
            {
                for (int j = 1; j < CELLS_COUNT - 1; j++)
                {
                    cellsArray.GetCellByIndex(i, j).IsEmpty = true;
                    cellsArray.GetCellByIndex(i, j).ShipId = "-";
                    cellsArray.GetCellByIndex(i, j).IsShip = false;
                }
            }
        }


        void MakeRandomAIShot(CellsArray cellsArray, List<Ship> shipsList)
        {
            int randomX = 0, randomY = 0;

            int maxGenerateValue = CELLS_COUNT - 1;
            int minGenerateValue = 1;
            Random random = new Random();
            Cell aiCell = new Cell();


            bool isBurnShipFound = false;
            Ship burnShip = new Ship();
            for (int i = 0; i < CELLS_COUNT; i++)
            {
                for (int j = 0; j < CELLS_COUNT; j++)
                {
                    //если есть корабль, в который мы попали и при этом он не считается убитым, то начинаем стрелять с клетки подбитого корабля
                    if (cellsArray.GetCellByIndex(i, j).IsShot && cellsArray.GetCellByIndex(i, j).IsShip &&
                        cellsArray.GetCellByIndex(i, j).ShipId != "-")
                    {
                        burnShip =
                            playerShipsList.FirstOrDefault(ship1 =>
                                ship1.ShipId.Equals(cellsArray.GetCellByIndex(i, j).ShipId) &&
                                cellsArray.GetCellByIndex(i, j).ShipId != "-");
                        if (burnShip != null)
                        {
                            // Message("Найден раненый корабль\n " + burnShip, "1", MessageBoxIcon.Asterisk);
                            isBurnShipFound = true;
                            randomX = i;
                            randomY = j;
                            break;
                        }
                    }
                }
            }


            if (!isBurnShipFound) //если раненый корабль не найден, то стреляем туда, куда это можно сделать
            {
                bool rightGenerationFlag = true;
                randomX = random.Next(minGenerateValue, maxGenerateValue);
                randomY = random.Next(minGenerateValue, maxGenerateValue);
                while (rightGenerationFlag)
                {
                    if (cellsArray.GetCellByIndex(randomX, randomY).Enabled == false)
                    {
                        randomX = random.Next(minGenerateValue, maxGenerateValue);
                        randomY = random.Next(minGenerateValue, maxGenerateValue);
                    }
                    else
                    {
                        rightGenerationFlag = false;
                    }
                }

                aiCell = cellsArray.GetCellByIndex(randomX, randomY);
                CheckShipShooting(aiCell, cellsArray, shipsList);
            }

            //если найден раненый корабль, проверяем соседние с ним ячейки
            if (isBurnShipFound)
            {
                for (int i = 0; i < CELLS_COUNT; i++)
                {
                    for (int j = 0; j < CELLS_COUNT; j++)
                    {
                        if (cellsArray.GetCellByIndex(i, j).ShipId.Equals(cellsArray.GetCellByIndex(randomX, randomY).ShipId))
                        {
                            CheckShipShooting(cellsArray.GetCellByIndex(i, j), cellsArray, playerShipsList);
                        }

                    }
                }
            }
        }

        private void ToMainMenuBtn_Click(object sender, EventArgs e)
        {
            DialogResult exitOrNot = MessageBox.Show(
                "Вы уверены, что хотите перейти в главное меню?\nТекущая игра будет завершена" +
                "", "Выход в главное меню", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitOrNot == DialogResult.Yes)
            {
                OpenMainMenu();
            }

        }

        private void twoShipsLabel_Click(object sender, EventArgs e)
        {

        }

        private void fourShipsLabel_Click(object sender, EventArgs e)
        {

        }

        private void MissTipsLabel_Click(object sender, EventArgs e)
        {

        }

        private void ShotTipsLabel_Click(object sender, EventArgs e)
        {

        }

        private void gamePlayerName_Click(object sender, EventArgs e)
        {

        }
    }
}