using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Крейзи_тест
{
    internal class Program
    {

        static void Main(string[] args)
        {

            // Задание #1
            //while (true)
            //{
            //    try // Запускаем проверку на ошибки
            //    {
            //        double a, b, S; // Вводим переменные
            //        Console.WriteLine("Введите сторону a пж:");
            //        a = Convert.ToDouble(Console.ReadLine()); // Вводим сторону a

            //        if (a <= 0) // Если сторона а меньше или равна нулю
            //        {
            //            Console.WriteLine("Такое значение не подходит");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Введите сторону b пж:");
            //            b = Convert.ToDouble(Console.ReadLine()); // Вводим сторону b
            //            if (b <= 0) // Если сторона b меньше или равна нулю
            //            {
            //                Console.WriteLine("Ну нормально же начали...а закончили за упокой");
            //            }
            //            else
            //            {
            //                S = a * b; // Ищем площадь
            //                Console.WriteLine("Площадь равна: " + S);
            //                Console.ReadKey(); // Пауза
            //            }

            //        }
            //    }
            //    catch { Console.WriteLine("Try ещё раз =3"); }
            //}




            // Задание #2
            /*
            while (true) // Задаём цикл для проверки на ошибки
            {
                try
                {
                    int i, N; // Вводим переменную для создания строчек
                    Console.WriteLine("Ку! Задайте число N для вывода строк:");
                    N = Convert.ToInt32(Console.ReadLine()); // Прописываем N, к-ая является кол-ом строк из звёздочек
                    if (N <= 0) // Проверка на вшивость
                    {
                        Console.WriteLine("Боюсь такого кол-ва невозможно создать...=(");
                    }
                    else
                    {
                        string alplhacentavra = "*"; // Задаём переменную вывода символа - *
                        for (i = 1; i <= N; i++)
                        {
                            Console.WriteLine(alplhacentavra.PadRight(i, '*')); // Используем PadRight для добавления справа
                        }
                        Console.ReadKey(); // Пауза
                    }
                }
                catch
                {
                    Console.WriteLine("Try ещё раз =3");
                }
            }
            */


            /*
            //Задание #3
            while (true) // Задаём цикл для проверки на ошибки
            {
                try
                {
                    int i, N; // Вводим переменную для создания строчек
                    Console.WriteLine("Ку! Задайте число N для вывода ёлки:");
                    N = Convert.ToInt32(Console.ReadLine()); // Прописываем N, к-ая является кол-ом строк из звёздочек
                    if (N <= 0) // Проверка на вшивость
                    {
                        Console.WriteLine("Боюсь такого кол-ва невозможно создать...=(");
                    }
                    else
                    {
                        string alplhacentavra = "*"; // Задаём переменную вывода символа - *
                        Console.Write(alplhacentavra.PadLeft(N + 1, ' ')); // Добавляем звезду для начала ёлки
                        Console.WriteLine(" "); // Создаём пустое пространтсво, иначе вторая строчка не будет под первой звездой
                        for (i = 1; i <= N; i++)
                        {
                            Console.Write(alplhacentavra.PadLeft(N+1-1*i, ' ')); 
                            Console.Write(alplhacentavra.PadRight(i, '*')); // Добавляем звезду справа
                            Console.Write(alplhacentavra.PadLeft(i, '*')); // Добавляем звезду слева
                            Console.WriteLine();
                        }
                        
                        Console.ReadKey(); // Пауза
                    }
                }

                catch
                {
                    Console.WriteLine("Try ещё раз =3");
                }
            }
            */


            /*
            //Задание #4:
            while (true) // Задаём цикл для проверки на ошибки
            {
                try
                {
                    int i, N, p; // Вводим переменную для создания строчек
                    Console.WriteLine("Ку! Задайте число N для вывода ёлок:");
                    N = Convert.ToInt32(Console.ReadLine()); // Прописываем N, к-ая является кол-ом строк из звёздочек
                    if (N <= 0) // Проверка на вшивость
                    {
                        Console.WriteLine("Боюсь такого кол-ва невозможно создать...=(");
                    }
                    else
                    {
                        string alplhacentavra = "*"; // Задаём переменную вывода символа - *
                        

                        for (i = 0; i <= N; i++) 
                        {
                            int iter; // Количество итераций
                            Console.Write(alplhacentavra.PadLeft(N + 1, ' '));
                            Console.WriteLine(' '); 
                            iter = i;

                            for (p = 1; p <= iter; p++)
                            {
                                Console.Write(alplhacentavra.PadLeft(N + 1 - 1 * p, ' '));
                                Console.Write(alplhacentavra.PadRight(p, '*'));
                                Console.Write(alplhacentavra.PadLeft(p, '*'));
                                Console.WriteLine();
                            }

                        }

                        Console.ReadKey(); // Пауза
                    }
                }

                catch
                {
                    Console.WriteLine("Try ещё раз =3");
                }
            }
            */


            /*
            // Задание #5
            while (true) // Задаём цикл для проверки на ошибки
            {
                try
                {
                    int kosar = 1000, kratno3 = 0, kratno5 = 0; // Вводим переменные
                    for (int i = 1; i < kosar; i++)
                    {
                        if (i % 3 == 0) // Проверка на кратность трём
                        {
                            kratno3 = kratno3 + i;
                        }
                    }

                    for (int i = 1; i < kosar; i++)
                    {
                        if (i % 5 == 0) // Проверка на кратность пяти
                        {
                            kratno5 = kratno5 + i;
                        }
                    }

                    // Вывод
                    Console.WriteLine("Сумма чисел кратных трём равняется: " + kratno3); 
                    Console.WriteLine("Сумма чисел кратных пяти равняется: " + kratno5);
                    Console.ReadKey(); // Пауза
                }

                catch
                {
                    Console.WriteLine("Try ещё раз =3");
                }
            }
            */
        }
    }
}
