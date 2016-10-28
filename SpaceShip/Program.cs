using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpaceShip
{
    class Program
    {
        static Fill fill = new Fill();
        static bool Stop = false;

        static void Main(string[] args)
        {
            Thread thread = new Thread(Key);
            thread.Start();

            while (Stop != true)
            {
                Console.Clear();
                fill.Visualize();
                Thread.Sleep(100);
            }

            fill.Visualize();
        }

        static void Key()
        {
            while (true)
            {
                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.N)
                {
                    if (Setting.getInstance().GameOver == true)
                    {
                        Stop = true;
                        break;
                    }
                }

                fill.Key(key.Key);
            }
        }
    }
}
