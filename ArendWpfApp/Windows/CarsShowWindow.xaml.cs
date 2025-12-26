using ArendWpfApp.Model;
using System.Linq;
using System.Windows;

namespace ArendWpfApp
{
    /// <summary>
    /// Логика взаимодействия для CarsShowWindow.xaml
    /// </summary>
    public partial class CarsShowWindow : Window
    {
        public CarsShowWindow()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            ShowDataGrid.ItemsSource = ArendaEntities.GetContext().TransportnoeSredstvo.OrderBy(x => x.Id).ToList();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new DirectorMainWindow().Show();
            this.Close();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
           new CarsAddWindow().Show();
            this.Close();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var item = (TransportnoeSredstvo)ShowDataGrid.SelectedItem;
            new CarUpdateWindow(item).Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var removingObject = ShowDataGrid.SelectedItems.Cast<TransportnoeSredstvo>().ToList();
                ArendaEntities.GetContext().TransportnoeSredstvo.RemoveRange(removingObject);
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
