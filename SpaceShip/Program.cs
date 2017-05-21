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
            //Console.SetBufferSize(150, 50);
            //Console.SetWindowSize(150, 50);

            Thread thread = new Thread(Key);
            thread.Start();

            TimerCallback tm = new TimerCallback(Visualize);
            // создаем таймер
            Timer timer = new Timer(tm, 0, 0, 200);

            //fill.Visualize();
        }

        private static void Visualize(object obj)
        {
            Console.Clear();
            fill.Visualize();
        }

        private static void Key()
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
