using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class Fill
    {

        private char[,] fill;
        private Menu menu = new Menu();
        private Ship ship;
        private Enemys enemys;

        public Fill()
        {
            fill = new char[Setting.getInstance().HeightFill, Setting.getInstance().WidthFill];

            ClearFill();
        }

        public void Visualize()
        {
            OutputFill();
        }

        private void OutputFill()
        {
            if (Setting.getInstance().GameOver == true)
            {
                menu.Visualize(ref fill);
            }
            else
            {
                enemys.Visualize(ref fill);
                ship.Visualize(ref fill);
                enemys.Chek(ref fill);

                enemys.GenerateEnemys();
            }

            ClearFill();
        }

        private void InitializeNewGame()
        {
            ship = new Ship();
            enemys = new Enemys();

            ClearFill();
        }

        private void ClearFill()
        {
            Console.Clear();

            ///////////Привожу поле в начальное положение///////////////////////////////////
            for (int i = 0; i < Setting.getInstance().HeightFill; i++)
            {
                for (int j = 0; j < Setting.getInstance().WidthFill; j++)
                {
                    Console.Write(fill[i, j]);

                    if ((j == 0) || ((i == 0) && (j < Setting.getInstance().WidthFill - Setting.getInstance().WidthMenu)))
                    {
                        fill[i, j] = '#';
                        continue;
                    }

                    if ((j == Setting.getInstance().WidthFill - Setting.getInstance().WidthMenu) || ((i == Setting.getInstance().HeightFill - 1) && (j < Setting.getInstance().WidthFill - Setting.getInstance().WidthMenu)))
                    {
                        fill[i, j] = '#';
                        continue;
                    }

                    fill[i, j] = ' ';
                }

                Console.WriteLine();
            }
            //////////////////////////////////////////////////////////////////////////////////////
        }

        public void Key(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.RightArrow:

                    if (Setting.getInstance().GameOver == false)
                    {
                        ship.StepRight();
                    }

                    break;

                case ConsoleKey.LeftArrow:

                    if (Setting.getInstance().GameOver == false)
                    {
                        ship.StepLeft();
                    }

                    break;

                case ConsoleKey.Y:

                    if (Setting.getInstance().GameOver == true)
                    {
                        Setting.getInstance().GameOver = false;
                        InitializeNewGame();
                    }

                    break;

                case ConsoleKey.Spacebar:

                    if (Setting.getInstance().GameOver == false)
                    {
                        ship.Shot();
                    }

                    break;
            }
        }
    }
}
