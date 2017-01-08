using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        public Autor autor = new Autor();

        public Ksiazka() { }
        public Ksiazka(string imie,string nazwisko, string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron)
            : base(tytul, id, wydawnictwo, rokWydania)
        {
            autor.UstawImie(imie);
            autor.UstawNazwisko(nazwisko);
            this.liczbaStron = liczbaStron;
        }


        public override string ToString()
        {
            return "Książka:\nTytuł: " + tytul + "; Autor: " + autor.Info() + "; id: " + id + "; Wydawnictwo: " + wydawnictwo + "; rokWydania: " + rokWydania+"; Liczba Stron: "+liczbaStron;
        }
    }
}
