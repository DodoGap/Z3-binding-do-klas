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
using System.Windows.Shapes;

namespace Z3_binding_do_klas
{
    /// <summary>
    /// Logika interakcji dla klasy Dodawanie.xaml
    /// </summary>
    public partial class Dodawanie : Window
    {
        public Dodawanie()
        {
            InitializeComponent();
        }

        private void Anuluj(object sender, RoutedEventArgs e)
        {
            Close(); // Zamknięcie aktualnego okna
        }

        private void Dodaj(object sender, RoutedEventArgs e)
        {
            Close(); // Zamknięcie aktualnego okna
        }
    }
}
