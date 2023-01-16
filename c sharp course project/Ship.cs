using System;
using System.Linq;
using c_sharp_course_project.resources;

namespace c_sharp_course_project
{
    public class Ship : Cell
    {
        private int _x;
        private int _y;
        private bool _isVertical; //повернут ли корабль
        private int _shipLenght; //длина корабля

        public Ship(int x = 0, int y = 0, bool isVertical = false, int shipLenght = 0)
        {
            _x = x;
            _y = y;
            _isVertical = isVertical;
            _shipLenght = shipLenght;
        }

        public int X
        {
            get => _x;
            set
            {
                if (value < 0)
                {
                    _x = 0;
                }
            }
        }

        public int Y
        {
            get => _y;
            set
            {
                if (value < 0)
                {
                    _y = 0;
                }
            }
        }

        public bool IsVertical
        {
            get => _isVertical;
            set => _isVertical = value;
        }

        public int ShipLenght
        {
            get => _shipLenght;
            set => _shipLenght = value;
        }


        public override string ToString()
        {
            return $"ID: {ShipId}\nx: {_x}\ny: {_y}\nisVertical: {_isVertical}\nshipLenght: {_shipLenght}\n";
        }


        
        //проверка на то, что корабль подбит
        //если так и есть, то ячейки вокруг корабля уже как бы обстреляны и отмечаются соответствующим цветом
        public bool CheckLostShip(CellsArray cellsArray)
        {
            //проверка на то, чтобы нельзя было установить корабль за границами массива
            int maxShipX = _x + _shipLenght;
            int maxShipY = _y + _shipLenght; //определяем, до какоко момента выполняется цикл


            if (_isVertical)
            {
                int countShot = 0;
                if (maxShipX < Game.CELLS_COUNT)
                {
                    for (int i = _x; i < maxShipX; i++)
                    {
                        if ( cellsArray.GetCellByIndex(i,_y).IsShot)
                        {
                            countShot++;
                        }
                    }

                    if (countShot.Equals(_shipLenght))
                    {
                        for (int i = _x; i < maxShipX; i++)
                        {
                            cellsArray.GetCellByIndex(i+1,_y).IsShot = false;
                            cellsArray.GetCellByIndex(i-1,_y).IsShot = false;
                            cellsArray.GetCellByIndex(i,_y-1).IsShot = false;
                            cellsArray.GetCellByIndex(i,_y+1).IsShot = false;
                            cellsArray.GetCellByIndex(i+1,_y+1).IsShot = false;
                            cellsArray.GetCellByIndex(i-1,_y+1).IsShot = false;
                            cellsArray.GetCellByIndex(i+1,_y-1).IsShot = false;
                            cellsArray.GetCellByIndex(i-1,_y-1).IsShot = false;

                            //блокирока ячеек, неудобно, но как есть
                            cellsArray.GetCellByIndex(i+1,_y).Enabled = false;
                            cellsArray.GetCellByIndex(i-1,_y).Enabled = false;
                            cellsArray.GetCellByIndex(i,_y-1).Enabled = false;
                            cellsArray.GetCellByIndex(i,_y+1).Enabled = false;
                            cellsArray.GetCellByIndex(i+1,_y+1).Enabled = false;
                            cellsArray.GetCellByIndex(i-1,_y+1).Enabled = false;
                            cellsArray.GetCellByIndex(i+1,_y-1).Enabled = false;
                            cellsArray.GetCellByIndex(i-1,_y-1).Enabled = false;
                        }

                        for (int i = _x; i < maxShipX; i++)
                        {
                            cellsArray.GetCellByIndex(i,_y).IsShot = true;
                        }

                        return true;
                    }
                }

                return false;
            }

            else
            {
                int countShot = 0;
                if (maxShipY < Game.CELLS_COUNT)
                {
                    for (int i = _y; i < maxShipY; i++)
                    {
                        if (cellsArray.GetCellByIndex(_x, i).IsShot)
                        {
                            countShot++;
                        }
                    }

                    if (countShot.Equals(_shipLenght))
                    {
                        for (int i = _y; i < maxShipY; i++)
                        {
                            cellsArray.GetCellByIndex(_x+1, i).IsShot = false; //сразу над кораблем
                            cellsArray.GetCellByIndex(_x-1, i).IsShot = false; //сразу под кораблем
                            cellsArray.GetCellByIndex(_x, i-1).IsShot = false; //боковые
                            cellsArray.GetCellByIndex(_x, i+1).IsShot = false;
                            cellsArray.GetCellByIndex(_x+1, i+1).IsShot = false; //левый верхний и нижние углы
                            cellsArray.GetCellByIndex(_x-1, i+1).IsShot  = false;
                            cellsArray.GetCellByIndex(_x + 1, i - 1).IsShot = false;  //правый верхний и нижние углы
                            cellsArray.GetCellByIndex(_x-1, i-1).IsShot = false;

                            //блокирока ячеек, неудобно, но как есть
                            cellsArray.GetCellByIndex(_x+1, i).Enabled = false; //сразу над кораблем
                            cellsArray.GetCellByIndex(_x-1, i).Enabled = false; //сразу под кораблем
                            cellsArray.GetCellByIndex(_x, i-1).Enabled = false; //боковые
                            cellsArray.GetCellByIndex(_x, i+1).Enabled = false;
                            cellsArray.GetCellByIndex(_x+1, i+1).Enabled = false; //левый верхний и нижние углы
                            cellsArray.GetCellByIndex(_x-1, i+1).Enabled  = false;
                            cellsArray.GetCellByIndex(_x + 1, i - 1).Enabled = false;  //правый верхний и нижние углы
                            cellsArray.GetCellByIndex(_x-1, i-1).Enabled = false;
                        }

                        for (int i = _y; i < maxShipY; i++)
                        {
                            cellsArray.GetCellByIndex(_x, i).IsShot = true;
                        }

                        return true;
                    }
                }

                return false;
            }
        }


        public bool FieldAdd(CellsArray cellsArray)
        {
            //проверка на то, чтобы нельзя было установить корабль за границами массива
            int maxShipX = _x + _shipLenght;
            int maxShipY = _y + _shipLenght; //определяем, до какоко момента выполняется цикл


            if (_x > 0 && _y > 0) //проверка на выход за границы массива
            {
                if (_isVertical)
                {
                    if (maxShipX < Game.CELLS_COUNT)
                    {
                        for (int i = _x; i < maxShipX; i++)
                        {
                            //odo при размещении вертикального и горизонтального кораблей в углу не происходит проверка
                            if (cellsArray.GetCellByIndex(i+1, _y).IsShip //сразу над кораблем
                                || cellsArray.GetCellByIndex(i-1, _y).IsShip //сразу под кораблем
                                ||cellsArray.GetCellByIndex(i, _y-1).IsShip //боковые
                                || cellsArray.GetCellByIndex(i, _y+1).IsShip
                                || cellsArray.GetCellByIndex(i+1, _y+1).IsShip//левый верхний и нижние углы
                                || cellsArray.GetCellByIndex(i-1, _y+1).IsShip
                                || cellsArray.GetCellByIndex(i+1, _y-1).IsShip //правый верхний и нижние углы
                                || cellsArray.GetCellByIndex(i-1, _y-1).IsShip)
                            {
                                return false;
                            }
                        }

                        Guid generateShipId = Guid.NewGuid(); //создаем ID корабля и помещаем его в кнопку
                        ShipId = generateShipId.ToString();
                        //размещение кораблей после полной проверки
                        for (int i = _x; i < maxShipX; i++)
                        {
                            cellsArray.GetCellByIndex(i, _y).IsShip = true;
                            cellsArray.GetCellByIndex(i, _y).ShipId = generateShipId.ToString();
                        }

                        //сравниваем, чтобы выбранная длинна корабля в радиобаттоне для удаления
                        //соответстовала удаляемому кораблю, чтобы нельзя было удлаить корабль длины 2 с кнопкой на длину 4

                        return true;
                    }
                }
                else
                {
                    if (maxShipY < Game.CELLS_COUNT)
                    {
                        for (int i = _y; i < maxShipY; i++)
                        {
                            if (cellsArray.GetCellByIndex(_x+1, i).IsShip //сразу над кораблем
                                 || cellsArray.GetCellByIndex(_x-1, i).IsShip //сразу под кораблем
                                 ||cellsArray.GetCellByIndex(_x, i-1).IsShip //боковые
                                 || cellsArray.GetCellByIndex(_x, i+1).IsShip
                                 || cellsArray.GetCellByIndex(_x+1, i+1).IsShip//левый верхний и нижние углы
                                 || cellsArray.GetCellByIndex(_x-1, i+1).IsShip
                                 || cellsArray.GetCellByIndex(_x+1, i-1).IsShip //правый верхний и нижние углы
                                 || cellsArray.GetCellByIndex(_x-1, i-1).IsShip)
                            {
                                return false;
                            }
                        }

                        Guid generateShipId = Guid.NewGuid(); //создаем ID корабля и помещаем его в кнопку
                        ShipId = generateShipId.ToString();
                        for (int i = _y; i < maxShipY; i++)
                        {
                            cellsArray.GetCellByIndex(_x, i).IsShip = true;
                            cellsArray.GetCellByIndex(_x, i).ShipId = generateShipId.ToString();
                        }

                        return true;
                    }
                }
            }

            return false;
        }

        
        //удаление корабля
        public void FieldDelete(CellsArray myArray)
        {
            if (_isVertical)
            {
                for (int i = _x; i < _x + _shipLenght; i++)
                {
                    myArray.GetCellByIndex(i, _y).IsShip = false;
                    myArray.GetCellByIndex(i, _y).ShipId = "-";
                }
            }
            else
            {
                for (int i = _y; i < _y + _shipLenght; i++)
                {
                    myArray.GetCellByIndex(_x, i).IsShip = false;
                    myArray.GetCellByIndex(_x, i).ShipId = "-";
                }
            }
        }
    }
}