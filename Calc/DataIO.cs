using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class DataIO
    {
        public static void Calc()
        {
            bool end = false;
            while (!end)
            {
                try
                {

                   
                    Console.WriteLine("Введите первое число:");
                    float operator1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    float operator2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Выберите операцию:\n1.Сложение\n2.Вычитание\n3.Умножение\n4.Деление\n5.Выход");
                    int с = int.Parse(System.Console.ReadLine());


                    switch (с)
                    {
                        case 1:
                            Console.Write("Сумма чисел:");
                            Console.WriteLine(Class1.Sum(operator1, operator2));
                            break;

                        case 2:
                            Console.Write("Разность чисел:");
                            Console.WriteLine(Class1.Res(operator1, operator2));
                            break;
                        case 3:
                            Console.Write("Произведение чисел:");
                            Console.WriteLine(Class1.Mul(operator1, operator2));
                            break;

                        case 4:
                            if (operator2 == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            Console.Write("Частное чисел:");
                            Console.WriteLine(Class1.Div(operator1, operator2));
                            break;

                        case 5:
                            end = true;
                            break;
                    }

                }

                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Calc();
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}