using System;

namespace Stringgg
{
    class Program
    {
        Stringcl s1,s2;
        Stringcl string1 = new Stringcl("1");
        String str;
        String str1;
        String query;

        static void Main(string[] args)
        {
            Program st = new Program();
            st.Menu();
        }
        public void Menu()
        {
            Console.WriteLine("Введите: (++)для создания двух первых строк (>)для сравнения, (?)для поиска, length, (+)для добавления строки");
            query = Console.ReadLine();
            if (query == "++")
            {
             
                Console.WriteLine("Введите первую строку");
                str = Convert.ToString(Console.ReadLine());  
                Console.WriteLine("Введите вторую строку");
                str1 = Convert.ToString(Console.ReadLine());
                s1 = new Stringcl(str);
                s2 = new Stringcl(str1);
                Menu();
            }
            if (query == ">")
            {
                if (s1 > s2) Console.WriteLine("Первая строка длинне");
                else Console.WriteLine("Вторая строка длинне");
                Menu();
            }
            if (query == "?")
            {
                string1.Search(s1);
                Menu();
            }
            if (query == "length")
            {
                string1.Length(s1);
                Menu();
            }
            if (query == "+")
            { 
                Console.WriteLine(s1.str + s2.str);
                Menu();
            }
            }
        }
    class Stringcl
    {
        public string str;

        public Stringcl(string text)
        {
            str = text;
        }

        public static bool operator >(Stringcl s1, Stringcl s2)
        {
            return s1.str.Length > s2.str.Length;
        }
        public static bool operator <(Stringcl s1, Stringcl s2)
        {
            return s1.str.Length < s2.str.Length;
        }
        public void Search(Stringcl s1)
        {
            Console.WriteLine("Введите нужный символ");
            char symb = Convert.ToChar(Console.ReadLine());
            String poz = " ";
            for (int i = 0; i < s1.str.Length; i++)
            {
                if (symb == s1.str[i]) poz += i + 1 + " ";
            }
            Console.WriteLine("Символ: " + symb + " стоит на: " + poz + " позицие/ях в строке " + s1.str);
        }
        public void Length(Stringcl s1)
        {
            Console.WriteLine("Длина строки:" + s1.str.Length + " символов");
        }

        public static Stringcl operator +(Stringcl s1, Stringcl s2)
        {
            return new Stringcl("1")
            {
                str = s1.str + s2.str
            };
        }

    }
}
