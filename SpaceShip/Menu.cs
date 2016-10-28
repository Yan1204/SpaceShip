using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class Menu
    {
        private char[,] menu;

        public Menu()
        {
            menu = new char[3, 9] {{'N','e','w',' ','g','a','m','e', '?'},
            {' ',' ','Y','-','Y','e','s',' ',' '},
            {' ',' ',' ','N','-','N','o',' ',' '}};
        }

        public void Visualize(ref char[,] Fill)
        {
            int I = 0;
            int J = 0;
            int begin_i = Setting.getInstance().HeightFill - Setting.getInstance().PositionMenuI;
            int begin_j = Setting.getInstance().WidthFill - Setting.getInstance().PositionMenuJ;

            for (int i = begin_i; i < begin_i + 3; i++)
            {
                for (int j = begin_j; j < begin_j + 9; j++)
                {
                    Fill[i, j] = menu[I, J];
                    J++;
                }

                I++;
                J = 0;
            }
        }
    }
}
