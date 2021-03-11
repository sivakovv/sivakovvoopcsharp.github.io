using System;

namespace arrayy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { }; 
            Arrayy Arr = new Arrayy();
            Arr.Menu(arr);
        }
    }
    class Arrayy
    {
        public string[] str { get; set; }
        static String[] ResizeArr(String[] arr)
        {
            Array.Resize(ref arr, arr.Length + 1);
            Console.WriteLine("Введите значение");
            arr[arr.Length - 1] = Console.ReadLine();
            return arr;
        }
        static String[] DeleteElement(String[] arr)
        {
            arr[arr.Length-1]="";
            return arr;
        }
        static String[] DeleteAll (String[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            arr[arr.Length - 1] = "";
            return arr;
        }
        public void ShowArr(String[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[" + i + "]=" + arr[i]);
            }
        }

        public String this[int i]
        {
            get
            {
                String[] arr = { };
                return arr[i];
            }
        }

        public static String operator +(Arrayy dArr, int a)
        {
            return dArr.str[0] + a;
        }

        public static Arrayy operator ++(Arrayy dArr)
        {
            dArr.str = ResizeArr(dArr.str);
            return dArr;
        }
        public static Arrayy operator --(Arrayy dArr)
        {
            dArr.str = DeleteElement(dArr.str);
            return dArr;
        }

        public void Menu(String[] arr)
        {
            string choose;
            Console.WriteLine("Введите команду: ++, ==, +, -, -- ");
            choose = Convert.ToString(Console.ReadLine());
            if (choose == "++")
            {
                arr = ResizeArr(arr);
                Console.WriteLine("Масив создан");
                Menu(arr);
            }
            if (choose == "-")
            {
                arr = DeleteElement(arr);
                Console.WriteLine("Удален последний ел масива");
                Menu(arr);
            }
            if (choose == "--")
            {
                arr = DeleteAll(arr);
                Console.WriteLine("Масив удален");
                Menu(arr);
            }
            if (choose == "==")
            {
                Console.WriteLine("Масив: ");
                ShowArr(arr);
                Menu(arr);
            }
            if (choose == "+")
            {
                Console.WriteLine("Добавить елемент");
                int n = Convert.ToInt32(Console.ReadLine());        
                arr[0] = arr[0] +" "+ n; 
                Menu(arr);
            }

        }
    }
}
  
    
