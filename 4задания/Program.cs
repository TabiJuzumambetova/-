using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4задания
{
    class Class
    {
        static int[] Input()
        {
            Console.WriteLine("введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; ++i) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }

        static void RemoveElements(int[] a)
        {
            

            bool deleted = false;

            do
            {
                deleted = false;

                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] == a[i + 1])
                    {
                        a = RemoveElement(a, i + 1);
                        deleted = true;
                    }
                }

            } while (deleted);

            if (a.Length == 0)
            {
                Console.WriteLine("Удаление элементов невозможно");
            }
            else
            {
                Console.WriteLine("Массив после удаления:");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + " ");
                }
            }
        }

        static int[] RemoveElement(int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            Array.Copy(array, 0, newArray, 0, index);
            Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);

            return newArray;
        }


       

        static void AddElements(int[] a)
        {
            
            int valueToInsert = 10; // Значение для вставки

            int maxIndex = FindMaxIndex(a);
            int minIndex = FindMinnIndex(a);

            if (maxIndex == -1 || minIndex == -1)
            {
                Console.WriteLine("Вставка элементов невозможна");
                return;
            }

            a = InsertElement(a, maxIndex + 1, valueToInsert);
            a = InsertElement(a, minIndex + 2, valueToInsert);

            Console.WriteLine("Массив после вставки:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static int FindMaxIndex(int[] array)
        {
            if (array.Length == 0)
                return -1;

            int maxIndex = 0;
            int maxValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        static int FindMinnIndex(int[] array)
        {
            if (array.Length == 0)
                return -1;

            int minIndex = 0;
            int minValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        static int[] InsertElement(int[] array, int index, int value)
        {
            int[] newArray = new int[array.Length + 1];

            if (index > array.Length)
            {
                Console.WriteLine("Вставка элемента невозможна");
                return array;
            }

            Array.Copy(array, 0, newArray, 0, index);
            newArray[index] = value;
            Array.Copy(array, index, newArray, index + 1, array.Length - index);

            return newArray;
        }

        
        

        

        static void CheckArr(int[] a)
        {
            int minIndex = FindMinIndex(a);
            int centerIndex = a.Length / 2;

            if (minIndex == -1 || centerIndex == -1)
            {
                Console.WriteLine("Невозможно вычислить среднее арифметическое");
                return;
            }

            int startIndex = Math.Min(minIndex, centerIndex) + 1;
            int endIndex = Math.Max(minIndex, centerIndex);

            int sum = 0;
            int count = 0;

            for (int i = startIndex; i < endIndex; i++)
            {
                sum += a[i];
                count++;
            }

            if (count == 0)
            {
                Console.WriteLine("Невозможно вычислить среднее арифметическое");
                return;
            }

            double average = (double)sum / count;
            Console.WriteLine("Среднее арифметическое: " + average);
        }

        static int FindMinIndex(int[] array)
        {
            if (array.Length == 0)
                return -1;

            int minIndex = 0;
            int minValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    minIndex = i;
                }

            }
            return minIndex;
        }
        static void CheckSumm(int[] a)
        {
           

            bool containsConsecutiveNegatives = CheckConsecutiveNegatives(a);

            if (containsConsecutiveNegatives)
            {
                Console.WriteLine("Массив содержит два подряд идущих отрицательных элемента.");
            }
            else
            {
                Console.WriteLine("Массив не содержит двух подряд идущих отрицательных элементов.");
            }
        }

        static bool CheckConsecutiveNegatives(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < 0 && array[i + 1] < 0)
                {
                    return true;
                }
            }

            return false;
        }



        static void Main()
        {
            int[] myArray = Input();
            Console.Write("Исходный массив: ");
            Print(myArray);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Выбери задание: ");
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1: CheckArr(myArray); ; break;
                    case 2: RemoveElements(myArray); break;
                    case 3: AddElements(myArray); ; break;
                    case 4: CheckSumm(myArray); ; break;

                }
            }

        }
    }

}
