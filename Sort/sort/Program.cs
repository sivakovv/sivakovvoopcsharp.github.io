using System;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort1.Buble();
            Sort2.Selection();

        }
    }

    class Sort1
    {
        public static int[] Buble()
        {
            int z;
            int[] array = new int[10];
            Random rnd = new Random();
            Console.Write("Числа(до сортировки)");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next() / 100000000;
                Console.Write("Число: ", i + 1);
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Сортировка пузырьком: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[i] > array[j])
                    {
                        z = array[i];
                        array[i] = array[j];
                        array[j] = z;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++) Console.WriteLine(array[i]);

            return array;
        } }


    class Sort2
    {
        public static int[] Selection()
        {
            int i;
            int[] array = new int[10];
            Random rnd = new Random();
            Console.Write("Числа(до сортировки)");
            for (i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next() / 100000000;
                Console.Write("Число: ", i + 1);
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Сортировка выбором: ");
            for (i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int dummy = array[i];
                array[i] = array[min];
                array[min] = dummy;

                for (i = 0; i < array.Length; i++) Console.WriteLine(array[i]);
            }
            return array;
        }
    }
    
    }
class Sort3
{

}
