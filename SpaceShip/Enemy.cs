using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class Enemy : ElementFill
    {
        public Enemy(int PositionI, int PositionJ)
        {
            positionI = PositionI;
            positionJ = PositionJ;
            element = '+';
            enemy = '*';
        }

        public override bool Visualize(ref char[,] Fill)
        {
            if (positionI == Setting.getInstance().HeightFill - 2)
            {
                return false;
            }

            if (Chek(ref Fill) == false)
            {
                return false;
            }

            positionI++;

            return true;
        }
    }
}
