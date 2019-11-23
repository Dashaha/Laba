using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aga();
            Aga2();
            Aga3();
            Aga4();
            static void Aga()
            {
                Console.WriteLine("Задание массива 1.5: Дан массив размера N и целые числа K и L (1< K < L < N). Найти сумму всех элементов массива, кроме элементов с номерами от K до L включительно.");
                Console.WriteLine("Введите К и L:");
                double K = double.Parse(Console.ReadLine());
                double L = double.Parse(Console.ReadLine());
                double sum = 0;
                double[] mass = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                for (int i = 0; i < mass.Length; i++)
                {
                    if (i < K  || i > L)
                    {
                        sum = sum + mass[i];

                    }                    

                }
                Console.WriteLine(sum);
            }
            static void Aga2()
            {
                Console.WriteLine("Дан целочисленный массив размера N (> 2). Удалить из массива все элементы с нечетными номерами (1, 3, …). Условный оператор не использовать.");
                double[] mass = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                for (int i =1;i< mass.Length; i ++)
                {
                    mass[i] = mass[i - 1];
                    i++;
                    Console.WriteLine(mass[i - 1]);
                }
                
            }
            static void Aga3()
            {
                Console.WriteLine("В одномерном массиве, состоящем из n вещественных элементов, вычислить cумму элементов массива, расположенных между первым и вторым отрица­тельными элементами.");
                double[] mass = new double[] { 1,-2.23, 5, 6, 7, 8,-9, 10 };
                double sum = 0;
                double one = 0;
                for (int i = 1; i < mass.Length; i++)
                {
                    if (mass[i] < 0)
                    {
                        one = one + 1;
                    }
                    else
                    {
                        if (one == 1)
                        {
                            sum = sum + mass[i];
                        }
                        if (one >1)
                        {
                          break;
                        }
                    }
                    
                }
                Console.WriteLine(sum);
            }
            static void Aga4()
            {
                Console.WriteLine("Дан целочисленный массив A размера N (< 15). Переписать в новый целочисленный массив B все элементы с порядковыми номерами, кратными трем (3, 6, …)," +
                    " и вывести размер полученного массива B и его содержимое. Условный оператор не использовать.");

                int r=0;
                double[] mass = new double[11] { 12, 2, 3, 4, 15, 7, 6, 8, 9, 10, 13 };
                int num;
                num = 11 / 3;
                double[] mass2 = new double[num];
                for (int i = 3; i < mass.Length; i=i+3)
                {
                    mass[r] = mass[i];
                    
                    Console.WriteLine(mass[r]);
                }

                Console.WriteLine(num);
            }
        }
    }
}
