using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            bool menu = true;
            while (menu == true)
            {
                Console.WriteLine("1.+");
                Console.WriteLine("2.-");
                Console.WriteLine("3.*");
                Console.WriteLine("4./");

                switch (Console.ReadLine())
                {

                    case "1"://+
                        ReadParams();
                        c = a + b;
                        Console.WriteLine(a + "+" + b + "=" + c);
                        break;

                    case "2"://-
                        ReadParams();
                        c = a - b;
                        Console.WriteLine(a + "-" + b + "=" + c);

                        break;

                    case "3"://*
                        ReadParams();
                        c = a * b;
                        Console.WriteLine(a + "*" + b + "=" + c);

                        break; 

                    case "4"://\
                        ReadParams();

                        c = a / b;
                        Console.WriteLine(a + "/" + b + "=" + c);

                        break;




                    default:
                        Console.WriteLine("Нет такой операции!");
                        Console.WriteLine();
                        break;

                }

                void ReadParams()
                {
                    Console.WriteLine("a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("b:vdvfed");
                    b = Convert.ToDouble(Console.ReadLine());
                }


            }
        }
    }
}
