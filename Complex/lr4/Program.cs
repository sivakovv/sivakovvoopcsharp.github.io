using System;

namespace lr4
{
    class Program
    {
        static void Main(string[] args)
        {
            Massiv mass = new Massiv();
            var mas = mass.Input();
            Massiv c1 = new Massiv { A = mas[0], B = mas[1] };
            Massiv c2 = new Massiv { A = mas[2], B = mas[3] };
            Console.WriteLine("Выберите действие (+,-,*,/): ");
            String math = (Console.ReadLine());
            if (math == "+")
            {
                Massiv c3 = c1 + c2;
                Console.WriteLine(c1.A + "(" + c1.B + "i) + " + c2.A + "(" + c2.B + "i) = " + c3.A + "(" + c3.B + "i)");
            }
            else if (math == "-")
            {
                Massiv c4 = c1 - c2;
                Console.WriteLine(c1.A + "(" + c1.B + "i) - " + c2.A + "(" + c2.B + "i) = " + c4.A + "(" + c4.B + "i)");
            }
            else if (math == "*")
            {
                Massiv c5 = c1 * c2;
                Console.WriteLine( c1.A + "(" + c1.B + "i) * " + c2.A + "(" + c2.B + "i) = " + c5.A + "(" + c5.B + "i)");
            }
            else if (math == "/")
            {
                Massiv c6 = c1 / c2;
                Console.WriteLine(c1.A + "(" + c1.B + "i) / " + c2.A + "(" + c2.B + "i) = " + c6.A + "(" + c6.B + "i)");
                }
                else
                    Console.WriteLine("Неверное действие");
         }
    }
    class Massiv
    {
        public Double[] Input()
        {
            Double[] arr = new Double[4];
            Console.WriteLine("Введите первое число");
            Console.WriteLine("Введите действительную часть: ");
            arr[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть: ");
            arr[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Второе число");
            Console.WriteLine("Введите действительную часть: ");
            arr[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть: ");
            arr[3] = Convert.ToDouble(Console.ReadLine());
            return arr;
        }
        public Double A { get; set; }
        public Double B { get; set; }

        public static Massiv operator - (Massiv cont1, Massiv cont2)
        {
            return new Massiv
            {
                A = cont1.A - cont2.A,
                B = cont1.B - cont2.B
            };
        }
        public static Massiv operator + (Massiv cont1, Massiv cont2)
        {
            return new Massiv
            {
                A = cont1.A + cont2.A,
                B = cont1.B + cont2.B
            };
        }
        public static Massiv operator / (Massiv cont1, Massiv cont2)
        {
            return new Massiv
            {
                A = cont1.A / cont2.A,
                B = cont1.B / cont2.B
              
            };
        }
        public static Massiv operator * (Massiv cont1, Massiv cont2)
        {
            return new Massiv
            {
                A = cont1.A * cont2.A,
                B = cont1.B * cont2.B
            };
        }        
    }
}

