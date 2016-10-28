using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class Guns : Container
    {
        private int positionLeft;
        private int positionRight;
        private int positionI;

        public Guns(int PositionLeft, int PositionRight, int PositionI)
        {
            positionI = PositionI;
            positionLeft = PositionLeft;
            positionRight = PositionRight;

            elements = new List<ElementFill>();
            deleteElements = new List<ElementFill>();
        }

        public void MoveLeft()
        {
            positionLeft--;
            positionRight--;
        }

        public void MoveRight()
        {
            positionLeft++;
            positionRight++;
        }

        public void Shot()
        {
            elements.Add(new Bullet(positionI, positionLeft));
            elements.Add(new Bullet(positionI, positionRight));
        }
    }
}
