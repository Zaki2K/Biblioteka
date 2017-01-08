using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Biblioteka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool czy_ksiazka = false;
        bool czy_czasopismo = false;
        Katalog biblioteka = new Katalog();
        
        public MainWindow()
        {
            InitializeComponent();
            biblioteka.Test();

            LImie.Visibility = Visibility.Hidden;
            LNazwisko.Visibility = Visibility.Hidden;
            LLiczbaStron.Visibility = Visibility.Hidden;
            LRokWydania.Visibility = Visibility.Hidden;
            LNumer.Visibility = Visibility.Hidden;
            LId.Visibility = Visibility.Hidden;
            LTytul.Visibility = Visibility.Hidden;
            LWydawnictwo.Visibility = Visibility.Hidden;

            TImie.Visibility = Visibility.Hidden;
            TNazwisko.Visibility = Visibility.Hidden;
            TLiczbaStron.Visibility = Visibility.Hidden;
            TRokWydania.Visibility = Visibility.Hidden;
            TNumer.Visibility = Visibility.Hidden;
            TId.Visibility = Visibility.Hidden;
            TTytul.Visibility = Visibility.Hidden;
            TWydawnictwo.Visibility = Visibility.Hidden;

        }

        

        private void DKsiazke_Click(object sender, RoutedEventArgs e)
        {
            LImie.Visibility = Visibility.Visible;
            LNazwisko.Visibility = Visibility.Visible;
            LLiczbaStron.Visibility = Visibility.Visible;
            LRokWydania.Visibility = Visibility.Visible;
            LNumer.Visibility = Visibility.Hidden;
            LId.Visibility = Visibility.Visible;
            LTytul.Visibility = Visibility.Visible;
            LWydawnictwo.Visibility = Visibility.Visible;

            TImie.Visibility = Visibility.Visible;
            TNazwisko.Visibility = Visibility.Visible;
            TLiczbaStron.Visibility = Visibility.Visible;
            TRokWydania.Visibility = Visibility.Visible;
            TNumer.Visibility = Visibility.Hidden;
            TId.Visibility = Visibility.Visible;
            TTytul.Visibility = Visibility.Visible;
            TWydawnictwo.Visibility = Visibility.Visible;

            TImie.Text = "";
            TNazwisko.Text = "";
            TLiczbaStron.Text = "";
            TRokWydania.Text = "";
            TNumer.Text = "";
            TId.Text = "";
            TTytul.Text = "";
            TWydawnictwo.Text = "";

            czy_ksiazka = true;
            czy_czasopismo = false;
        }

        private void DCzasopismo_Click(object sender, RoutedEventArgs e)
        {
            LImie.Visibility = Visibility.Hidden;
            LNazwisko.Visibility = Visibility.Hidden;
            LLiczbaStron.Visibility = Visibility.Hidden;
            LRokWydania.Visibility = Visibility.Visible;
            LNumer.Visibility = Visibility.Visible;
            LId.Visibility = Visibility.Visible;
            LTytul.Visibility = Visibility.Visible;
            LWydawnictwo.Visibility = Visibility.Visible;

            TImie.Visibility = Visibility.Hidden;
            TNazwisko.Visibility = Visibility.Hidden;
            TLiczbaStron.Visibility = Visibility.Hidden;
            TRokWydania.Visibility = Visibility.Visible;
            TNumer.Visibility = Visibility.Visible;
            TId.Visibility = Visibility.Visible;
            TTytul.Visibility = Visibility.Visible;
            TWydawnictwo.Visibility = Visibility.Visible;

            TImie.Text="";
            TNazwisko.Text="";
            TLiczbaStron.Text = "";
            TRokWydania.Text = "";
            TNumer.Text = "";
            TId.Text = "";
            TTytul.Text = "";
            TWydawnictwo.Text = "";

            czy_ksiazka = false;
            czy_czasopismo = true;
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            if (czy_ksiazka == true)
            {
                biblioteka.DodajPozycje(TImie.Text, TNazwisko.Text, TTytul.Text, int.Parse(TId.Text), TWydawnictwo.Text, int.Parse(TRokWydania.Text), int.Parse(TLiczbaStron.Text));
            }

            if (czy_czasopismo == true)
            {
                biblioteka.DodajPozycje(TTytul.Text, TWydawnictwo.Text, int.Parse(TRokWydania.Text), int.Parse(TId.Text), int.Parse(TNumer.Text));
            }
        }

        private void WPoId_Click(object sender, RoutedEventArgs e)
        {
            string opis = "";
            int id = int.Parse(TPodajId.Text);

            opis += biblioteka.WyszukajPoId(id);

            TOpis.Text = opis;

        }

        private void WPoTytule_Click(object sender, RoutedEventArgs e)
        {
            string opis = "";
            string tytul = TPodajTytul.Text;

            opis += biblioteka.WyszukajPoTytule(tytul);

            TOpis.Text = opis;
        }

        


    }
}
