using System.Drawing;

namespace c_sharp_course_project
{
    //массив ячеек
    public class CellsArray : Cell
    {
        private Cell[,] insideCellsfield = new Cell[CELLS_SIZE, CELLS_SIZE];


        public const int CELLS_COUNT = 12;
        private int _offsetX;

        public int OffsetX
        {
            get => _offsetX;
            set => _offsetX = value;
        }

        public Cell[,] InsideCellsfield
        {
            get => insideCellsfield;
            set => insideCellsfield = value;
        }

        public Cell GetCellByIndex(int x, int y)
        {
            return  insideCellsfield[x,y];
        }


        public CellsArray(int offsetX)
        {
            _offsetX = offsetX;
            Cell[,] insideCellsfield = new Cell[CELLS_SIZE, CELLS_SIZE];
            for (int i = 0; i < CELLS_COUNT; i++)
            {
                for (int j = 0; j < CELLS_COUNT; j++)
                {
                    insideCellsfield[i, j] = new Cell();
                }
            }
        }

        //перезаливка граничных серых ячеек
        public void FixingBordersColor()
        {
            for (int i = 0; i < CELLS_COUNT; i++)
            {
                for (int j = 0; j < CELLS_COUNT; j++)
                {
                    if (i < 1 || j < 1)
                    {
                        insideCellsfield[i, j].BackColor = Color.Gray;
                    }

                    if (i > 10 || j > 10)
                    {
                        insideCellsfield[i, j].Border(j * CELLS_SIZE + _offsetX, i * CELLS_SIZE + CELLS_SIZE);
                    }
                }
            }
        }


        //сокрытие ячеек кораблей противника
        public void HideShipsCells()
        {
            for (int i = 0; i < CELLS_COUNT; i++)
            {
                for (int j = 0; j < CELLS_COUNT; j++)
                {
                    if (insideCellsfield[i, j].IsShip)
                    {
                        insideCellsfield[i, j].IsEmpty = true;
                    }
                }
            }
        }


        //отображение поля игрока и поля противника из массива ячеек с учетом сдвига
        //Также отображаются ячейки с буквами, цифрами и ячейки границ
        public void PrintField()
        {
            const int LETTERS_COUNT = 10;
            const int NUMBERS_COUNT = 11;

            string letterArray = "АБВГДЕЖЗИК";

            Cell firstCell = new Cell();
            firstCell.Location = new Point(0, 10);
            firstCell.Size = new Size(CELLS_SIZE, CELLS_SIZE);

            insideCellsfield[0, 0] = firstCell;
            insideCellsfield[0, 0].IsEmpty = true;

            for (int i = 0; i < CELLS_COUNT; i++)
            {
                for (int j = 0; j < CELLS_COUNT; j++)
                {
                    if (i == 0 && j < LETTERS_COUNT)
                    {
                        Cell numberCell = new Cell();
                        numberCell.Border(j * CELLS_SIZE + _offsetX + CELLS_SIZE, CELLS_SIZE,
                            letterArray[j].ToString());
                        insideCellsfield[i, j] = numberCell;
                        continue;
                    }

                    if (j == 0 && i < NUMBERS_COUNT)
                    {
                        Cell letterCell = new Cell();
                        letterCell.Border(j * CELLS_SIZE + _offsetX, i * CELLS_SIZE + CELLS_SIZE, i.ToString());
                        insideCellsfield[i, j] = letterCell;
                        continue;
                    }


                    if (i > 10 || j > 10)
                    {
                        Cell emptyCell = new Cell();
                        emptyCell.Border(j * CELLS_SIZE + _offsetX, i * CELLS_SIZE + CELLS_SIZE);

                        insideCellsfield[i, j] = emptyCell;
                    }
                    else
                    {
                        Cell fieldCell = new Cell();
                        fieldCell.Location = new Point(j * CELLS_SIZE + _offsetX, i * CELLS_SIZE + CELLS_SIZE);
                        fieldCell.Size = new Size(CELLS_SIZE, CELLS_SIZE);

                        insideCellsfield[i, j] = fieldCell;
                        insideCellsfield[i, j].IsEmpty = true;
                    }
                }
            }
        }
    }
}