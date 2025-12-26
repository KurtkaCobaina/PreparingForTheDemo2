using ArendWpfApp.Model;
using System.Linq;
using System.Windows;

namespace ArendWpfApp
{
    /// <summary>
    /// Логика взаимодействия для ClientsShowWindow.xaml
    /// </summary>
    public partial class ClientsShowWindow : Window
    {
        public ClientsShowWindow()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            ShowDataGrid.ItemsSource = ArendaEntities.GetContext().Client.OrderBy(x => x.Id).ToList();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new DirectorMainWindow().Show();
            this.Close();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            new ClietsAddWindow().Show();
            this.Close();

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var item = (Client)ShowDataGrid.SelectedItem;
            new ClientsUpdateWindow(item).Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var removingObject = ShowDataGrid.SelectedItems.Cast<Client>().ToList();
                ArendaEntities.GetContext().Client.RemoveRange(removingObject);
                MessageBox.Show("Скидка удалилась");
                LoadData();
            }
            catch
            {
                MessageBox.Show("Нельзя удалить этот объект");
            }
        }
    }
}
