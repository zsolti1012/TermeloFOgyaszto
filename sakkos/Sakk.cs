using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sakkos
{
    class Sakk
    {
        public void Kirajzolfelül()
        {
            for (int i = 0; i < 8; i++)
			{
                for (int j = 0; j < 4; j++)
                {
                    
                    
                        if ((i+j)%2!=0)
                        {
                            lock (typeof(Console))
                            {
                                Console.SetCursorPosition(i, j);
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Write(" ");
                                System.Threading.Thread.Sleep(10);
                            }

                        }
                        
                    
                }
			}
        }

        public void Kirajzolalul()
        {
            for (int i = 7; i >=0; i--)
            {
                for (int j = 4; j <8; j++)
                {


                    if ((i + j) % 2 != 0)
                    {
                        lock (typeof(Console))
                        {
                            Console.SetCursorPosition(i, j);
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(" ");
                            System.Threading.Thread.Sleep(10);
                        }

                    }
                   

                }
            }

        }
    }
}
