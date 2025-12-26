using System.Windows;

namespace ArendWpfApp
{
    /// <summary>
    /// Логика взаимодействия для DirectorMainWindow.xaml
    /// </summary>
    public partial class DirectorMainWindow : Window
    {
        public DirectorMainWindow()
        {
            InitializeComponent();
        }

        private void ArendaShowButton_Click(object sender, RoutedEventArgs e)
        {
            new ArendaShowWindow().Show();
            this.Close();
        }

        private void CarsShowButton_Click(object sender, RoutedEventArgs e)
        {
            new CarsShowWindow().Show();
            this.Close();
        }

        private void ClientsShowButton_Click(object sender, RoutedEventArgs e)
        {
            new ClientsShowWindow().Show();
            this.Close();
        }

        private void SkidkiShowButton_Click(object sender, RoutedEventArgs e)
        {
            new SkidkiShowWindow().Show();
            this.Close();
        }
    }
}
