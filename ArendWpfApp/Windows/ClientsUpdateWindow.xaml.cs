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
using ArendWpfApp.Model;

namespace ArendWpfApp
{
    /// <summary>
    /// Логика взаимодействия для ClientsUpdateWindow.xaml
    /// </summary>
    public partial class ClientsUpdateWindow : Window
    {
        private Client _currentClient = new Client();
        public ClientsUpdateWindow(Client selectedClient)
        {
            InitializeComponent();
            _currentClient = selectedClient;
            DataContext = _currentClient;
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            ArendaEntities.GetContext().SaveChanges();
            MessageBox.Show("Клиент изменился");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new ClientsShowWindow().Show();
            this.Close();
        }
    }
}
