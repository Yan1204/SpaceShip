using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    abstract class ElementFill
    {
        protected char element;
        protected char enemy;
        protected int positionI;
        protected int positionJ;

        public bool Chek(ref char[,] Fill)
        {
            if (Fill[positionI, positionJ] == enemy)
            {
                //Fill[positionI, positionJ] = ' ';

                 return false;
            }

            Fill[positionI, positionJ] = element;

            return true;
        }

        public abstract bool Visualize(ref char[,] Fill);
    }
}
