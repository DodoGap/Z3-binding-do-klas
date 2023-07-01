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
using System.Xml;

namespace Z3_binding_do_klas
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OtwórzSzczegółyKategorii(object sender, RoutedEventArgs e)
        {
            new SzczegółyKategorii((XmlElement)ListaKategorii.SelectedItem).Show();
        }

        private void DodajNowyElement(object sender, RoutedEventArgs e)
        {
            Dodawanie okno = new Dodawanie();
            okno.Show();
        }
    }
}
