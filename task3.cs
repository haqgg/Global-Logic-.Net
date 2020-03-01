using System;
using System.Linq;

namespace coding
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numofex = Console.Read();
            //ex1(25);
            //ex2(14);
            //ex4();
            //ex5();

            switch (numofex)
            {
                case 1:
                    ex1();
                    break;
                case 2:
                    int intfor2 = Console.Read();
                    ex2(intfor2);
                    break;
                case 3:
                    int intfor3 = Console.Read();
                    ex3(intfor3);
                    break;
                case 4:
                    
                    ex4();
                    break;
                case 5:
                    ex5();
                    break;
                case 6:
                    ex6('o');
                    break;
            }

            static void ex1()
            {
                DateTime day = DateTime.Now;
                Console.Write("Ура сегодня " + day.DayOfWeek);
            }

            static void ex2(int num)
            {
                Random rnd = new Random();
                int[] mas = new int[num];
                long arg = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rnd.Next();
                    Console.Write(mas[i] + " ");
                }

                int min = mas[0];
                int max = mas[0];
                //отдельно вывести в метод
                for (int i = 0; i < mas.Length; i++)
                {
                    arg += mas[i];
                    if (min > mas[i])
                    {
                        min = mas[i];
                    }

                    if (max < mas[i])
                    {
                        max = mas[i];
                    }
                }

                Console.Write("\nMin: " + min + "\nMax: " + max + "\nAverage: " + arg / (mas.Length - 1));

            }

            static void ex3(int num)
            {
                int howMuch = 0;
                int[] mas = new int[1000];
                Random rnd = new Random();
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rnd.Next(-25, 25);
                    if (mas[i] == num)
                    {
                        howMuch++;
                    }
                }

                Console.Write(howMuch);
            }

            static void ex4()
            {
                DateTime dateTime = DateTime.Now;
                DateTime dateTime1 = new DateTime(2021, 7, 20);
                Console.Write("Days: " + (dateTime1 - dateTime).Days + "\nHours: " + (dateTime1 - dateTime).Hours +
                              "\nMinutes: " + (dateTime1 - dateTime).Minutes);
            }

            static void ex5()
            {
                Random rnd = new Random();
                DateTime dateTime = DateTime.Now;
                int daysToAdd = rnd.Next(72, 1000);
                Console.Write("\nDate: " + dateTime.AddDays(daysToAdd).Date + "\nDay of week: " +
                              dateTime.AddDays(daysToAdd).DayOfWeek);
            }

            static void ex6(char sym)
            {
                string str1 = "Hello to everyone";
                int k = 0;
                for (int i = 0; i < str1.Length; i++)
                    if (sym == str1[i])
                    {
                        k++;
                    }
                Console.Write(sym + " появляется " + k + "раз");
            }

        }
    }
}
