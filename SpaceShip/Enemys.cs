using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class Enemys : Container
    {
        private Random rand;

        public Enemys()
        {
            rand = new Random();
            elements = new List<ElementFill>();
            deleteElements = new List<ElementFill>();
        }

        public void GenerateEnemys()
        {
            int rd = 0;
            int size = Setting.getInstance().WidthFill - Setting.getInstance().WidthMenu - 1;

            for (int i = 0; i < size; i++)
            {
                rd = rand.Next(0, 20);

                if (rd == 5)
                {
                    elements.Add(new Enemy(1, i + 1));
                }
            }
        }
    }
}
