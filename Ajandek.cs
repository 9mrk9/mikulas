namespace mikulas
{
   class Ajandek
   {
      public string Nev { get; set;}
      public double Suly { get; set;}
      public int Ar { get; set;}
      public string Cimzett { get; set;}
      public string Kategoria { get; set;}
      public bool Becsomagolva { get; set;}
      public string Gyarto { get; set;}
      public int RaktaronMennyiseg { get; set;}
      public string Anyag { get; set;}
      public DateTime LejaratiDatum { get; set;}
      public bool Torekeny { get; set;}
      public string GyartasiOrszag { get; set;}
      public string SzallitasiCim { get; set;}
      public bool Kiszallitva { get; set;}

      public Ajandek(string nev, double suly, int ar, string cimzett, string kategoria, bool becsomagolva, string gyarto, int raktaronMennyiseg, string anyag, DateTime lejaratiDatum, bool torekeny, string gyartasiOrszag, string szallitasiCim = "")
      {
         Nev = nev;
         Suly = suly;
         Ar = ar;
         Cimzett = cimzett;
         Kategoria = kategoria;
         Becsomagolva = becsomagolva;
         Gyarto = gyarto;
         RaktaronMennyiseg = raktaronMennyiseg;
         Anyag = anyag;
         LejaratiDatum = lejaratiDatum;
         Torekeny = torekeny;
         GyartasiOrszag = gyartasiOrszag;
         SzallitasiCim = szallitasiCim;
         Kiszallitva = false;
      }
      public void Becsomagolas()
      {
         Becsomagolva = true;
      }
      public void Szallitas(string cel = "")
      {
         if (cel != "")
         {
            SzallitasiCim = cel;
         }
      }
      public void Kiszallitas()
      {
         Kiszallitva = true;
         Console.WriteLine($"Az ajándékot ({Nev}) sikeresen kiszállitotta a Mikulás!");
      }
      public void Ellenorzes() 
      {
         if (Kiszallitva) 
         {
            Console.WriteLine("Az ajándék már ki lett szállitva!");
         } else {
            Console.WriteLine("Az ajándék még nem lett kiszállitva!");
         }
         if (LejaratiDatum > DateTime.Now) {
            Console.WriteLine("Még nem járt le a termék!");
         } else {
            Console.WriteLine("A termék sajnálatos módon már lejárt!");
         }
      }
      public void ArModositas(int ujAr)
      {
         Ar = ujAr;
      }
   }
}