using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class Ship
    {
        private char[,]ship;
        private const int width = 5;
        private const int height = 6;
        private int positionI;
        private int positionJ;
        private Guns guns;

        public Ship()
        {
            ship = new char[height, width]{
            {' ', ' ', '#', ' ', ' '},
            {'|', ' ', '#', ' ', '|'},
            {'#', '#', '#', '#', '#'},
            {' ', '#', '#', '#', ' '},
            {' ', '#', '#', '#', ' '},
            {'#', '#', '#', '#', '#'}};

            positionI = Setting.getInstance().HeightFill - height - 1;
            positionJ = 1;

            guns = new Guns(1, width, Setting.getInstance().HeightFill - height - 1);
        }

        public void StepLeft()
        {
            if (positionJ - 1 > 0)
            {
                positionJ--;
                guns.MoveLeft();
            }
        }

        public void StepRight()
        {
            if (positionJ + width + 1 < Setting.getInstance().WidthFill - Setting.getInstance().WidthMenu + 1)
            {
                positionJ++;
                guns.MoveRight();
            }
        }

        public void Shot()
        {
            guns.Shot();
        }

        public void Visualize(ref char[,] Fill)
        {
            int I = 0;
            int J = 0;

            guns.Visualize(ref Fill);

            for (int i = positionI; i < positionI + height; i++)
            {
                for (int j = positionJ; j < positionJ + width; j++)
                {
                    if (((Fill[i, j] == '+') && (ship[I, J] == '#')) || ((Fill[i, j] == '+') && (ship[I, J] == '|')))
                    {
                        Setting.getInstance().GameOver = true;
                    }

                    if ((Fill[i, j] != ' ') && (ship[I, J] == ' ') && (Fill[i, j] != '*'))
                    {
                        continue;
                    }
                    else
                    {
                        Fill[i, j] = ship[I, J];
                    }

                    J++;
                }

                I++;
                J = 0;
            }
        }
    }
}
