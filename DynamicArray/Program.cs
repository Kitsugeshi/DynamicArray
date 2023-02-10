using System;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[0];
            Console.WriteLine("Доступные действия с массивом array: \n 1. Добавить элемент + \n 2. Удалить элемент - \n 3. Распечатать массив print");
            bool f = true;
            while (f)
            {
                Console.WriteLine("\nВведите операцию: ");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "+":
                        array = AddElement(array);
                        break;
                    case "-":
                        array = RemoveElement(array);
                        break;
                    case "print":
                        Print(array);
                        break;
                    default:
                        f = false; 
                        break;
                }
            }
            
        }

        static int[] AddElement(int[] mas)
        {
            int[] res = new int[mas.Length + 1];
            for (int i = 0; i < mas.Length; i++)
            {
                res[i] = mas[i];
            }
            Console.WriteLine("Введите число, которое хотите записать в новую ячейку массива: ");
            res[mas.Length] = int.Parse(Console.ReadLine());
            int temp;
            if (res.Length >= 2)
            {
                for (int i = 0; i < res.Length; i++)
                {
                    for (int j = i + 1; j < res.Length; j++)
                    {
                        if (res[i] > res[j])
                        {
                            temp = res[i];
                            res[i] = res[j];
                            res[j] = temp;
                        }
                    }
                }   
            }
            return res;
        }

        static int[] RemoveElement(int[] mas)
        {
            int[] res = new int[mas.Length-1];
            Console.WriteLine("Введите число, которое хотите удалить из массива: ");
            int n = int.Parse(Console.ReadLine());
            bool f = false;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == n)
                {
                    f = true;
                }
            }
            if (f)
            {
                for (int i = 0; i < res.Length; i++)
                {
                    if (mas[i] == n)
                    {
                        res[i] = mas[i + 1];
                        continue;
                    }
                    else
                    {
                        if (res[i] == 0 && res[i] == mas[i]) continue;
                        if (res[i-1] == mas[i]) res[i] = mas[i + 1];
                        else res[i] = mas[i];
                    }

                }
                return res;
            }
            else return mas;
        }

        static void Print(int[] mas)
        {
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
