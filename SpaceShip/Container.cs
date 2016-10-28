using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class Container
    {
        protected List<ElementFill> elements;
        protected List<ElementFill> deleteElements;

        public void Visualize(ref char[,] Fill)
        {
            foreach (ElementFill a in elements)
            {
                if (a.Visualize(ref Fill) == false)
                {
                    deleteElements.Add(a);
                }
            }

            if (deleteElements.Count > 0)
            {
                foreach (ElementFill a in deleteElements)
                {
                    elements.Remove(a);
                }

                deleteElements.Clear();
            }
        }

        public void Chek(ref char[,] Fill)
        {
            foreach (ElementFill a in elements)
            {
                if (a.Chek(ref Fill) == false)
                {
                    deleteElements.Add(a);
                }
            }

            if (deleteElements.Count > 0)
            {
                foreach (ElementFill a in deleteElements)
                {
                    elements.Remove(a);
                }

                deleteElements.Clear();
            }
        }
    }
}
