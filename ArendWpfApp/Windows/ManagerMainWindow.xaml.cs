using System.Windows;

namespace ArendWpfApp
{
    /// <summary>
    /// Логика взаимодействия для ManagerMainWindow.xaml
    /// </summary>
    public partial class ManagerMainWindow : Window
    {
        public ManagerMainWindow()
        {
            InitializeComponent();
        }

        private void ProfileShowButton_Click(object sender, RoutedEventArgs e)
        {
            new ManagerProfileWindow().Show();
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

        }
    }
}
