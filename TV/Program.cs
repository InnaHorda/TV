using System;
using System.IO;

namespace TV
{
     class TV
        {
            public int[] canals = new int[10];
            public int nomer;

            public TV()
            {
                TWOn(nomer);
                Switch();
                Print();
            }
            public void Print()
            {
                Console.WriteLine("Canal " + nomer);
            }
            public int TWOn(int a)
            {
try
                {   
                    Console.WriteLine("Введите канал от 1 о 10");
                a = Convert.ToInt32(Console.ReadLine());
                    if (a >= 0 && a <= 10)
                    {
                        nomer = a;
                    }
                    else
                    {
                        canals[0] = 0;
                        a = canals[0];
                        Console.WriteLine("Такого канала нету:");
                    }               
                }
                catch(Exception)
                {
                    Console.WriteLine("Такого канала нету?. Вы переходити на канал №{0}", canals[nomer]);
                }
        return nomer;
            }

            public void Switch()
            {
            string h = "N";
                ConsoleKeyInfo btn;
                canals[nomer] = nomer;
                Console.WriteLine("+ albo -");
            do
            {
                 //btn = Console.ReadKey(true);
               
                try
                { string a = Convert.ToString(Console.ReadLine());

                    if (a == "+")
                    {
                        canals[nomer]++;
                        
                    }
                    if (a == "-")
                    {
                        canals[nomer]--;
                    }
                    if (canals[nomer] < 0)
                    {
                        canals[nomer] = 9;
                    }
                    if (canals[nomer] > 9)
                    {
                        canals[nomer] = 0;
                    }
                    else
                    {
                        canals[nomer] = Convert.ToInt32(a);
                        Console.WriteLine(" dfdf" + canals[nomer]);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine(" Вы переходити на канал №{0}", canals[nomer]);
                    
                }
               // Console.WriteLine(" Вы переходити на каналddd №{0}", canals[nomer]);

            }// while (h != "y");
                while (Console.ReadKey(true).Key != ConsoleKey.Escape);
               // while  (btn.Key != ConsoleKey.Escape)  ;
                                       
            }
        }
    class Program
    {
       

        static void Main(string[] args)
        {
            TV Telewizor = new TV();
            Console.WriteLine();
        }
    }
}
