using System;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace veepegmeprogramek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Osoba osoba = new Osoba("Karp", "Wielki", 'm', new DateTime(1452, 03, 30));
            //Console.WriteLine(osoba.ToString());
            //Uczen uczen = new Uczen("Karp", "Mały", 'm', new DateTime(1999, 01, 11), "2C");
            //Console.WriteLine(uczen.ToString());
            //Miasto miasto = new Miasto("Warszawa", "Polska", 186000000, 517200000);
            //Stolica stolica = new Stolica("Warszawa", "Polska", 186000000, 517200000, new DateTime(1596, 03, 18), new DateTime(2025, 03, 30));
            //Console.WriteLine(miasto.ToString());
            //Console.WriteLine(stolica.ToString());
            //Prostokat prostokat = new Prostokat(2, 3);
            //Console.WriteLine(prostokat.ToString());
            //Kwadrat kwadrat = new Kwadrat(2);
            //Console.WriteLine(kwadrat.ToString());
            //Dodatek dodatek = new Dodatek("Świadczenie pieniężne", 20);
            //Dodatek dodatek1 = new Dodatek("Nagroda jubileuszowa", 100);
            //Dodatek dodatek2 = new Dodatek("Dodatek stażowy", 10);
            //Stanowisko stanowisko = new Stanowisko("Programista", 5000, new List<Dodatek> { dodatek, dodatek1, dodatek2 });
            //Console.WriteLine(stanowisko.ToString());
            //Pracownik pracownik = new Pracownik("Programista", 5000, new List<Dodatek> { dodatek, dodatek1, dodatek2 }, "Karp", new DateTime(2010, 5, 10));
            //Console.WriteLine(pracownik.ToString());
            //Console.WriteLine("Przychód: " + pracownik.Przychod());
            //Publikacja publikacja = new Publikacja("69", "Wiedźmin 6", 1000);
            //Ksiazka ksiazka = new Ksiazka("69", "Wiedźmin 6", 1000, "Karp", "Nie wiem");
            //Console.WriteLine("Cena: " + publikacja.PrzeliczCene(1001));
            //Console.WriteLine("Cena: " + ksiazka.PrzeliczCene(1001));
            //Console.WriteLine("Cena: " + ksiazka.PrzeliczCene(999));
            //bool palindrom = Tekstowa.Palindrom("kot");
            //if (palindrom == true) {
            //    Console.WriteLine("OK");
            //}
            //else { Console.WriteLine("NO OK"); }
            //Tekstowa.Anagramy("pies", "pies");
            //Tekstowa.Anagramy("burza", "arbuz");
            //Tekstowa.Anagramy("Moew", "Meow");
            //Tekstowa.Anagramy("Ala", "Abe");
            //for (int i = 0; i < 10; i++)
            //{
            //    string slowo1 = Console.ReadLine();
            //    string slowo2 = Console.ReadLine();
            //    Tekstowa.Anagramy(slowo1, slowo2);
            //}
            //ZadanieTekstowe zadanieTekstowe = new ZadanieTekstowe(new List<string> {});
            //zadanieTekstowe.PobierzDoTablicy("Anagramy.txt");
            //Console.WriteLine("Liczba samogłosek: " + zadanieTekstowe.PoliczSamogloski());
            //Console.WriteLine("Liczba spółgłosek: " + zadanieTekstowe.PoliczSpolgloski());
            //foreach (string slowo in zadanieTekstowe.Slowa)
            //{
            //    Console.WriteLine(slowo);
            //}
            Stozek s1 = new Stozek(2, 15);
            Stozek s2 = new Stozek(20, 53);
            Czworoscian c1 = new Czworoscian(5);
            Czworoscian c2 = new Czworoscian(32);
            Czworoscian c3 = new Czworoscian(10);
            List<Bryla> bryly = new List<Bryla> { s1, s2, c1, c2, c3 };
            foreach (Bryla bryla in bryly)
            {
                Console.WriteLine("Pole podstawy: " + bryla.PolePodstawy());
                Console.WriteLine("Pole boczne: " + bryla.PoleBoczne());
                Console.WriteLine("Pole całkowite: " + bryla.PoleCalkowite());
                Console.WriteLine("Objętość: " + bryla.Objetosc());
            }
            Grafik grafik = new Grafik(new DateTime(2015, 4, 20), 5);
            Console.WriteLine("Premia:" + grafik.ObliczPremie());
            Console.WriteLine("Wynagrodzenie:" + grafik.ObliczWynagrodzenie());
            

        }
    }










    


}