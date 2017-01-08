using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Katalog : IZarzadzenieKatalogiem
    {
        private List<Pozycja> listaPozycji = new List<Pozycja>();

        public Katalog() { }

        public void DodajPozycje(){ }

        public void DodajPozycje(string imie, string nazwisko, string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron)
        {
            listaPozycji.Add(new Ksiazka(imie, nazwisko, tytul, id, wydawnictwo, rokWydania, liczbaStron));
        }

        public void DodajPozycje(string tytul, string wydawnictwo, int rokWydania, int id, int numer)
        {
            listaPozycji.Add(new Czasopismo(tytul, id, wydawnictwo, rokWydania, numer));
        }

        public string WyszukajPoTytule(string tytul)
        {
            string opis = "";
            foreach (var element in listaPozycji)
            {
                if (element.ReturnTytul() == tytul)
                {
                    opis += element.ToString();
                    opis += "\n";
                }
            }
            return opis;
        }

        public string WyszukajPoId(int id)
        {
            string opis = "";
            foreach (var element in listaPozycji)
            {
                if (element.ReturnId() == id)
                {
                    opis += element.ToString();
                }
            }
            return opis;
        }

        public void Test()
        {
            DodajPozycje("Gazeta Olsztyńska", "Edytor", 1992, 7, 200);
            DodajPozycje("Gazeta Wyborcza", "Agora", 2010, 2, 123);
            DodajPozycje("Henryk", "Sienkiewicz", "Krzyżacy", 23, "Znak", 2010, 220);
            DodajPozycje("Henryk", "Sienkiewicz", "Krzyżacy", 24, "Znak", 2011, 220); 
        }
    }
}
