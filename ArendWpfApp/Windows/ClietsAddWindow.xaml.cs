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
using ArendWpfApp.Model;

namespace ArendWpfApp
{
    /// <summary>
    /// Логика взаимодействия для ClietsAddWindow.xaml
    /// </summary>
    public partial class ClietsAddWindow : Window
    {
        private readonly Client currentClient = new Client();
        public ClietsAddWindow()
        {
            InitializeComponent();
            DataContext = currentClient;
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            ArendaEntities.GetContext().Client.Add(currentClient);
            ArendaEntities.GetContext().SaveChanges();
            MessageBox.Show("Клиент добавился");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new ClientsShowWindow().Show();
            this.Close();
        }
    }
}
