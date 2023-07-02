using System.Windows;

namespace Z3_binding_do_klas
{
    public partial class OknoEdycjaAlbumu : Window
    {
        public OknoEdycjaAlbumu(Album album)
        {
            InitializeComponent();
            DataContext = album;
        }

        private void Zapisz(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Anuluj(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
