using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace mikulas
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Ajandek csoki = new Ajandek("csoki", 0.1, 450, "Ferenc", "Édesség", false, "Mondelez", 1000, "Csokoládé", new DateTime(2024,09,16), false, "Bludenz", "Határ út 38");
         Ajandek iPhone = new Ajandek("iPhone", 0.2, 350000, "Ádám", "Telefon", true, "Apple", 100, "Titánium", new DateTime(2026,01,31), true, "Canada", "Isaszegi út 40");
         Ajandek billentyűzet = new Ajandek("Apex Pro", 0.95, 80000, "Máté", "Billentyűzet", true, "SteelSeries", 200, "Fém", new DateTime(2026,06,18), false, "Dánia", "Mexikói út 22");

         csoki.Becsomagolas();
         Console.WriteLine("Termék becsomagolva!");
         csoki.Szallitas("Tompa Utca 19");
         Console.WriteLine("Szállitási cim megváltoztatva!");
         csoki.Kiszallitas();
         csoki.Ellenorzes();
         csoki.ArModositas(500);
         Console.WriteLine("A termék ára megváltozott!");

         MikulasMuhely eszakiSarkMuhely = new MikulasMuhely("Gábor", new Ajandek[3] {csoki, iPhone, billentyűzet});

         csoki.Cimzett = "Levente";
         csoki.Szallitas("Gubacsi út 77");
         eszakiSarkMuhely.AjandekHozzaadasaListahoz(csoki);
         Console.WriteLine("\n\n\nEgy új ajándék került a listába!");
         eszakiSarkMuhely.AjandekHozzaadasaTombhoz(iPhone);
         Console.WriteLine("Egy új ajándék került a tömbbe!\n");
         eszakiSarkMuhely.BecsomagoltAjandekokMegjelenitese();
         Console.WriteLine();
         eszakiSarkMuhely.LejartAjandekokEllenorzese();
         Console.WriteLine();
         eszakiSarkMuhely.TorekenyAjandekokEllenorzese();
         Console.WriteLine();
         eszakiSarkMuhely.EredetiOrszagbeliAjandekokMegjelenitese("Dánia");
         Console.WriteLine();
         eszakiSarkMuhely.MuhelyNyitas();
         eszakiSarkMuhely.MuhelyBezaras();
         eszakiSarkMuhely.MuhelyVezetoModositas("Mihály");
         eszakiSarkMuhely.AjandekTorlese("iPhone");
         Console.ReadKey();
      }
   }
}