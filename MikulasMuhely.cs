namespace mikulas
{
   class MikulasMuhely
   {
      private List<Ajandek> ajandekLista;
      private Ajandek[] ajandekTomb;
      private string muhelyVezeto;
      private bool muhelyNyitva;

      public MikulasMuhely(string muhelyVezeto, Ajandek[] ajandekTomb)
      {
         this.ajandekTomb = ajandekTomb;
         Array.Copy(ajandekTomb, this.ajandekTomb, ajandekTomb.Length);
         ajandekLista = this.ajandekTomb.ToList();
         this.muhelyVezeto = muhelyVezeto;
         muhelyNyitva = false;
      }
      public List<Ajandek> AjandekLista
      {
         get { return ajandekLista; }
      }
      public Ajandek[] AjandekTomb
      {
         get { return ajandekTomb; }
      }
      public string MuhelyVezeto
      {
         get { return muhelyVezeto; }
      }
      public bool MuhelyNyitva
      {
         get { return muhelyNyitva; }
      }
      public void AjandekHozzaadasaListahoz(Ajandek ajandek)
      {
         ajandekLista.Add(ajandek);
      }
      public void AjandekHozzaadasaTombhoz(Ajandek ajandek, int index = -1)
      {
         if (index == -1)
         {
            ajandekTomb.ToList().Add(ajandek);
            ajandekTomb.ToArray();
         }
         else if (index > ajandekTomb.Length)
         {
            Console.WriteLine("Sajnos helytelen index került megadásra!");
         } else {
            ajandekTomb[index] = ajandek;
         }
      }
      public void BecsomagoltAjandekokMegjelenitese()
      {
         Console.WriteLine("A becsomagolt ajándékok listája:");
         foreach (Ajandek ajandek in ajandekLista)
         {
            if (ajandek.Becsomagolva)
            {
               Console.WriteLine(ajandek.Nev);
            }
         }
      }
      public void LejartAjandekokEllenorzese()
      {
         Console.WriteLine("A lejárt ajándékok listája:");
         foreach (Ajandek ajandek in ajandekLista)
         {
            if (ajandek.LejaratiDatum < DateTime.Now)
            {
               Console.WriteLine(ajandek.Nev);
            }
         }
      }
      public void TorekenyAjandekokEllenorzese()
      {
         Console.WriteLine("A törékeny játékok listája:");
         foreach (Ajandek ajandek in ajandekLista)
         {
            if (ajandek.Torekeny)
            {
               Console.WriteLine(ajandek.Nev);
            }
         }
      }
      public void EredetiOrszagbeliAjandekokMegjelenitese(string orszag)
      {
         Console.WriteLine($"{orszag} országból származó ajándékok listája:");
         foreach (Ajandek ajandek in ajandekLista)
         {
            if (ajandek.GyartasiOrszag == orszag)
            {
               Console.WriteLine(ajandek.Nev);
            }
         }
      }
      public void MuhelyNyitas()
      {
         if (muhelyNyitva)
         {
            Console.WriteLine("A műhely már nyitva van.");
         }
         else
         {
            muhelyNyitva = true;
            Console.WriteLine("A műhely kinyitott.");
         }
      }
      public void MuhelyBezaras()
      {
         if (!muhelyNyitva)
         {
            Console.WriteLine("A műhely már zárva van.");
         }
         else
         {
            muhelyNyitva = false;
            Console.WriteLine("A műhely bezárt.");
         }
      }
      public void MuhelyVezetoModositas(string ujVezeto)
      {
         muhelyVezeto = ujVezeto;
         Console.WriteLine("A műhely új vezetőjének neve: " + muhelyVezeto);
      }
      public void AjandekTorlese(string nev)
      {
         ajandekLista.RemoveAll(ajandek => ajandek.Nev == nev);
         ajandekTomb.ToList().RemoveAll(ajandek => ajandek.Nev == nev);
         Console.WriteLine($"{nev} törölve lett a listából.");
      }
   }
}