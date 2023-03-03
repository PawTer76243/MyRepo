using System;

namespace Program
{
    class Program
    {
        

    static void ekran()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    static void Dodaj()
        {
            Console.WriteLine("Dodanie liczb");
        }

        static void Dodaj(int a, int b)
        {
            Console.WriteLine("suma = " + (a + b));
        }

        static void Dodaj(int a, int b, int c)
        {
            Console.WriteLine("suma = " + (a + b + c));
        }

        static void Dodaj(int a, int b, int c=5000, int d=0)
        {
            for (int i = 0; i < 20; i++)
                Console.Write("=");
            Console.WriteLine();
            Console.WriteLine("suma = " + (a + b + c + d));
            int wynik = a + b + c + d;
            Console.WriteLine("suma 2 = " + wynik);

        }

        static double Dodaj_1(double a, double b, double c = 0, double d = 0)
        {
            return (a + b + c + d);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ekran();

            Dodaj(50, 923);

            Dodaj(124, 531, 76);

            Dodaj(10, 20);

            Dodaj(10, 20, d: 12334, c: 1);

            Dodaj_1(1.1, 2.2);

            Console.WriteLine();
            Console.WriteLine("suma = " + Dodaj_1(2.3, 3.5) + Dodaj_1(11.7, 3.3, 123.3));

            Console.ReadKey();
        }
    }
}
