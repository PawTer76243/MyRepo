using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

namespace Program
{
    class Program
    {
        //static void ekran()
        //{
        //    Console.BackgroundColor = ConsoleColor.Red;
        //    Console.ForegroundColor = ConsoleColor.Blue;
        //}
        //static void Dodaj()
        //{
        //    Console.WriteLine("Dodanie liczb");
        //}

        //static void Dodaj(int a, int b)
        //{
        //    Console.WriteLine("suma = " + (a + b));
        //}

        //static void Dodaj(int a, int b, int c)
        //{
        //    Console.WriteLine("suma = " + (a + b + c));
        //}

        //static void Dodaj(int a, int b, int c = 5000, int d = 0)
        //{
        //    for (int i = 0; i < 20; i++)
        //        Console.Write("=");
        //    Console.WriteLine();
        //    Console.WriteLine("suma = " + (a + b + c + d));
        //    int wynik = a + b + c + d;
        //    Console.WriteLine("suma 2 = " + wynik);

        //}

        //static double Dodaj_1(double a, double b, double c = 0, double d = 0)
        //{
        //    return (a + b + c + d);
        //}

        private static BigInteger Silnia(int x)
        {
            BigInteger wynik = 1;
            for (int i = 2; i <= x; i++)
                wynik *= i;
            return wynik;
        }

        private static BigInteger Silnia_Rekurencja(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
                return Silnia_Rekurencja(x - 1) * x;
        }

        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter,
            Wiosna,
        }



        static void Main(string[] args)
        {

            Season a = Season.Spring;
            Console.WriteLine(a);
            Console.WriteLine($"Integral value of {a} is {(int)a}");
            Console.WriteLine("Integral value of " + a + " is " + (int)a);
            Console.WriteLine("Integral value of {0} is {1}", a, (int)a);

            var b = (Season)1;
            Console.WriteLine(b);


            //Stopwatch czas = new Stopwatch();
            //czas.Start();

            //int koniec = 100000000;
            //czas.Start();
            //int suma = 0;
            //for (int i = 1; i <= suma; i++)
            //    suma = suma + i;

            //Console.WriteLine("Suma od 0 do " + koniec + " to ");
            //Console.WriteLine(koniec);
            //Console.WriteLine(suma);
            //czas.Stop();
            //Console.WriteLine("czas: ");
            //Console.WriteLine(czas.ElapsedTicks);
            //Console.WriteLine();


            //int koniec1 = 444;
            //czas.Start();
            ////long silnia = 1;
            //BigInteger silnia = 1;
            //for (int i = 1; i <= koniec1; i++)
            //{
            //    //silnia = silnia * i;
            //    silnia = BigInteger.Multiply(silnia, i);
            //    //Console.WriteLine("dla: " + i + " silnia jest rowna: " + silnia);
            //}

            //Console.WriteLine("Suma od 0 do " + koniec1 + " to ");
            //Console.WriteLine(koniec1);
            //Console.WriteLine(silnia);
            //czas.Stop();
            //Console.WriteLine("czas: ");
            //Console.WriteLine(czas.ElapsedTicks);


            //const int liczba_suma = 5555;
            //Stopwatch czas = new Stopwatch();
            //const int liczba = 77;
            //czas.Reset();
            //czas.Start();
            //Console.WriteLine("Silnia dla " + liczba + " rowna się: " + Silnia(liczba));
            //czas.Stop();
            //Console.WriteLine("czas " + czas.ElapsedTicks);
            //Console.WriteLine();
            //czas.Reset();
            //czas.Start();
            //Console.WriteLine("zasosowanie rekurencji - silnia dla: " + liczba + " rowna sie " + Silnia_Rekurencja(liczba));
            //czas.Stop();
            //Console.WriteLine("czas " + czas.ElapsedTicks);
            //Console.WriteLine();
            //czas.Reset();







            //var kolekcja_string = new List<string> { "aaa" };
            //var kolekcja_string = new List<String>();
            //var kolekcja_string = new List<string>(100);
            //foreach (var item in kolekcja_string)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            ////Console.WriteLine("Liczba elementow, Które ArrayList moze zawierac: {0} ", kolekcja_string.Capacity);
            //Console.WriteLine();
            ////Console.WriteLine("LIczba elementow: {0}", kolekcja_string.Count);
            //Console.WriteLine();
            //kolekcja_string.Add("bbb");
            //kolekcja_string.Add("ccc");
            //kolekcja_string.Add("ddd");
            //kolekcja_string.Add("eee");
            //kolekcja_string.Add("fff");
            //kolekcja_string.Add("ggg");
            //foreach (var item in kolekcja_string)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Liczba elementow ktore Arraylist moze zawierac: {0}", kolekcja_string.Capacity);
            //Console.WriteLine("Liczbe elementow: {0} ", kolekcja_string.Count);
            //Console.WriteLine();
            //kolekcja_string[0] = "AAA";
            //foreach (var item in kolekcja_string)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Element 3 list to: " + kolekcja_string[2]);
            //Console.WriteLine();

            //kolekcja_string.Insert(3, "wtorek");
            //foreach (var item in kolekcja_string)
            //    Console.Write(item + " ");
            //Console.WriteLine();
            ////kolekcja_string.Insert(30, "wwwwtorek");
            ////foreach (var item in kolekcja_string)
            ////    Console.Write(item + " ");
            ////Console.WriteLine();
            //kolekcja_string.Remove("ccc");
            //foreach (var item in kolekcja_string)
            //    Console.Write(item + " ");
            //Console.WriteLine();

            //kolekcja_string.RemoveAt(4);
            //foreach (var item in kolekcja_string)
            //    Console.Write(item + " ");
            //Console.WriteLine();

            //var kolekcja_int = new List<int> { 111 };
            //foreach (var item in kolekcja_int)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //kolekcja_int.Add(222);
            //kolekcja_int.Add(555);
            //kolekcja_int.Add(444);
            //kolekcja_int.Add(333);
            //kolekcja_int.Add(666);
            
            //Console.WriteLine("666 jest na pozycji: " + (kolekcja_int.IndexOf(666) + 1 ));
            //Console.WriteLine("333 jest na pozycji: " + (kolekcja_int.IndexOf(333) + 1));
            //Console.WriteLine("333 jest na pozycji: " + (kolekcja_int.LastIndexOf(333) + 1));
            //Console.WriteLine("567 jest na pozycji: " + (kolekcja_int.IndexOf(567) + 1));

            //kolekcja_int.Sort();
            //foreach (var item in kolekcja_int)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //ArrayList array = new ArrayList();
            //Console.WriteLine("Liczba elementow ktore ArrayList moze zawirac: {0}", array.Capacity);
            //Console.WriteLine("Liczba elementow: {0}", array.Count);
            //array.Add("wtorek");
            //array.Add(false);
            //array.Add("sroda");
            //array.Add(true);
            //Console.WriteLine();
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //array.Add(100);
            //array.Add(200);
            //array.Add(300);
            //array.Add("qqq");
            //array.Add(123);
            //array.Add(500);
            //array.Add(100);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Liczba elementow ktore Arraylist moze zawierac: {0} ", array.Capacity);
            //Console.WriteLine("Liczba eleemntow: {0} ", array.Count);
            //Console.WriteLine();
            //int licznik = 0;
            //Console.WriteLine("Pozycja dla 100: ");
            //for (int i = 0; i < array.Count; i++)
            //    if (array[i].Equals(100))
            //    {
            //        Console.WriteLine((i + 1) + ", ");
            //        licznik++;
            //    }
            //Console.WriteLine("Wynik " + licznik);


            //licznik = 0;
            //foreach (var item in array)
            //    if (item.Equals(100))
            //        licznik++;
            //Console.WriteLine("wynik" + licznik);
            //Console.WriteLine("Wynik" + array.Contains(100));

            //array.RemoveRange(4, 3);
            //Console.WriteLine();
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //array.Reverse();
            //Console.WriteLine();
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //array.Reverse(1, 5);
            //Console.WriteLine();
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            ////array.Sort();
            ////foreach (var item in array)
            ////{
            ////    Console.Write(item + " ");
            ////}

            //array.Clear();
            //Console.WriteLine();
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Liczba elementow ktore Arraylist moze posaidac: {0}", array.Capacity);
            //Console.WriteLine("Liczba elementow: {0}", array.Count);

            //array.TrimToSize();



            //string s1, s2;
            //s1 = "Wtorek";
            //s2 = "wtorek";
            //Console.WriteLine("Wynik porównania 1");
            //if (s1 != s2)
            //    Console.WriteLine("Podane lancuchy {0}, {1} sa rozne", s1, s2);
            //else
            //    Console.WriteLine("Podane lancuchy {0}, {1} sa take same", s1, s2);
            //Console.WriteLine();

            //Console.WriteLine("Wynik porownania 2");
            //if (s1 == s2)
            //    Console.WriteLine("Podane lancuchy {0}, {1] sa takie same", s1, s2);
            //else
            //    Console.WriteLine("Podane lancuchy {0}, {1} sa rozne", s1, s2);
            //Console.WriteLine();

            //Console.WriteLine("Wynik porownania 3");
            //if (s1.Equals(s2))
            //    Console.WriteLine("Podane lancuchy {0}, {1} sa takie same", s1, s2);
            //else
            //    Console.WriteLine("Podane lancuchy {0}, {1} sa rozne", s1, s2);
            //Console.WriteLine();

            //Console.WriteLine("Wynik porownania 4 - Compare");
            //if (string.Compare(s1, s2, true) == 0)
            //    Console.WriteLine("Podane lancuchy {0}, {1} sa takie same", s1, s2);
            //else
            //    Console.WriteLine("Podane lancuchy {0}, {1}sa rozne", s1, s2);
            //Console.WriteLine();

            //Console.WriteLine("Wynik porownania 5");
            //if (string.Compare(s1, s2, false) == 0)
            //    Console.WriteLine("Podane lancuchy {0}, {1} sa takie same", s1, s2);
            //else
            //    Console.WriteLine("Podane lancuchy {0}, {1} sa rozne", s1, s2);
            //Console.WriteLine();

            //Console.WriteLine("Wynik porownania 6");
            //if (string.Compare(s1, s2) == 0)
            //    Console.WriteLine("Podane lancuchy {0}, {1} sa takie same", s1, s2);
            //else
            //    Console.WriteLine("Podane lancuchy {0}, {1} sa rozne", s1, s2);


            //// laczenie znakow

            //Console.WriteLine("Polaczone {0} z {1} = {2}", s1, s2, s1 + s2);
            //Console.WriteLine("Polaczone {0} z {1} = {2}", s1, s2, string.Concat(s1, s2, "dowolny"));

            //string s3 = "Dzisiaj jest wtorek";
            //if (s3.Contains("jest"))
            //    Console.WriteLine("W lancuchu {0} wystepuje dany wyraz", s3);
            //else
            //    Console.WriteLine("W lancuchu {0} nie wystepuje dany wyraz", s3);

            ////dlugosc ciagu znakow
            //Console.WriteLine("lancuch {0} a {1} znakow", s3, s3.Length);


            ////wstawianie znakow
            //string s4;
            //s4 = "Zajecia z C#";
            //Console.WriteLine(s4);
            //Console.WriteLine(s4.Insert(9, "jezyka programowania"));

            ////laczenie znakow z tablicy
            //string[] tablica_znakow = { "Wyzsza", "Szkola", "Biznesu" };
            //Console.WriteLine(tablica_znakow[0]);
            //Console.WriteLine(tablica_znakow[1]);
            //Console.WriteLine(tablica_znakow[2]);
            //Console.WriteLine(String.Join("-", tablica_znakow));

            ////dzielenie ciagu znakow
            //string s5;
            //s5 = "Wroclaw ulica Fabryczna";
            //string[] tablica_wynik = s5.Split(new char[] { ' ' });
            //foreach (string wyraz in tablica_wynik)
            //    Console.WriteLine(wyraz);
            //for (int i = 0; i < tablica_wynik.Length; i++)
            //    Console.WriteLine("Pozycja - " + tablica_wynik);

            ////zamiana znakow
            //string s6;
            //s6 = "We wroclawiu jest slaba pogoda";
            //Console.WriteLine(s6);
            //string s6a = s6.Replace("We wroclawiu", "W warszawie");
            //Console.WriteLine(s6a);
            //Console.WriteLine(s6a.Replace("slaba", "dobra"));

            ////usuwanie znakow
            //string s7 = "Seminarium dyplomowe i magisterskie";
            //Console.WriteLine(s7.Remove(11, 12));

            ////wycinanie znakow
            //Console.WriteLine("wyciete znaki to" + s3.Substring(2, 4));

            ////zamiana na wielkeie 
            //Console.WriteLine("wielkie znaki to " + s3.ToUpper());

            ////zamiana na male
            //Console.WriteLine("male znaki to " + s3.ToLower());

            //string s8 = "    Tymon    ";
            //Console.WriteLine("|" + s8 + "|");
            //Console.WriteLine("|" + s8.Trim() + "|");
            //Console.WriteLine("|" + s8.TrimStart() + "|");
            //Console.WriteLine("|" + s8.TrimEnd() + "|");

            //string s9;
            //s9 = "Od 1 lipca zaczynaja sie wakacje. Bedzie impreza.";
            //Console.WriteLine("Wprowadzony tekst to: " + s9);
            //Console.WriteLine();
            //for (int i = 0; i < s9.Length; i++)
            //    Console.Write(s9.Substring(i, 1));
            //Console.WriteLine();

            //string s10;
            //s10 = "Jest calkiem w porzadku";
            //for (int i = s10.Length - 1; i >= 0; i--)
            //    Console.Write(s10.Substring(i, 1));

            //int liczba_a = 0;
            //for (int i = 0; i < s9.Length; i++)
            //    if (s9.Substring(i, 1).Equals("a"))
            //        liczba_a++;
            //Console.WriteLine();
            //Console.WriteLine("Liczba 'a' w tekscie --> " + liczba_a);
            //Console.WriteLine();

            //int liczba_zdan = 0;
            //for (int i = 0; i < s9.Length; i++)
            //    if (s9.Substring(i, 1).Equals("."))
            //        liczba_zdan++;
            //Console.WriteLine("Liczba zdan w tekscie --> " + liczba_zdan);

            //ekran();

            //Dodaj(50, 923);

            //Dodaj(124, 531, 76);

            //Dodaj(10, 20);

            //Dodaj(10, 20, d: 12334, c: 1);

            //Dodaj_1(1.1, 2.2);

            //Console.WriteLine();
            //Console.WriteLine("suma = " + Dodaj_1(2.3, 3.5) + Dodaj_1(11.7, 3.3, 123.3));

            Console.ReadKey();
        }
    }
}