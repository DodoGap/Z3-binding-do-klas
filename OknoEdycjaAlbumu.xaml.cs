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

        private void OK(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
