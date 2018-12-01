using System;



namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Napisz program pytający klienta o jego dane i wyświetl w konsoli z dodatkowym opisem.

            #region Witaj świecie 
            //Console.WriteLine("Hello World");
            //int liczba = 10;
            //Console.WriteLine(liczba);
            #endregion

            #region Dane osobowe 

            Console.WriteLine("Podaj imię");
            string imie = Console.ReadLine();
            //Console.WriteLine("mam na imie" + " " + imie);
            Console.WriteLine($"Witaj { imie}. Podaj swoje nazwisko");
            string nazwisko = Console.ReadLine();
            Console.WriteLine($"{imie} {nazwisko} , świetne imię :). Podaj swój adres.");
            string adres = Console.ReadLine();
            Console.WriteLine("Ile masz lat?");
            int wiek = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Czy jesteś zamężna/żonaty: T/N");
            //string slub = Console.ReadLine().ToUpperInvariant();

         
            var dzis = DateTime.Now;
            //Funkcje klasaKlasa = new Funkcje();
            bool malzenstwo=Funkcje.StanCywilny();
           
            Funkcje.Wyswietl(imie, nazwisko, adres, wiek, dzis);

            #endregion

            #region Funkcja StanCywilny

            /* typ funkcji (typ jaką wartośc nam zwraca)   NAZWA(argumenty tzn typ tego argumentu i nazwa)
             * {
             * (warunki)
             * 
             * return
             * }*/

            //bool StanCywilny(string doSprawdzenia)
            //{
            //    if (doSprawdzenia == "T" || doSprawdzenia == "1") ;
            //    {
            //        return true;

            //    }
            //    return false;
            //}
            #endregion




            #region Data i podsumowanie


            Console.WriteLine($"Dziś jest {dzis}");
            /*var godzina = DateTime.Now.ToShortDateString();
            Console.WriteLine($"Dziś jest {godzina}");
            var a = DateTime.Now.ToLocalTime();
            Console.WriteLine($"Dziś jest {a}");*/

            Console.WriteLine("------------------");
            Console.WriteLine("Twoje dane");
            Console.WriteLine($"Imię i nazwisko: {imie} {nazwisko}");
            Console.WriteLine($"Adres: {adres}");
            Console.WriteLine($"Wiek: {wiek}");
            Console.ReadLine();


            #endregion

        }
    }
}
