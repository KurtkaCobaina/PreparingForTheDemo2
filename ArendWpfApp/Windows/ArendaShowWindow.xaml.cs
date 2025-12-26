using ArendWpfApp.Model;
using System.Linq;
using System.Windows;

namespace ArendWpfApp
{
    /// <summary>
    /// Логика взаимодействия для ArendaShowWindow.xaml
    /// </summary>
    public partial class ArendaShowWindow : Window
    {
        public ArendaShowWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new DirectorMainWindow().Show();
            this.Close();
        }
        private void LoadData()
        {
            ShowDataGrid.ItemsSource = ArendaEntities.GetContext().Arenda.OrderBy(x => x.Id).ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            new ArendaAddWindow().Show();
            this.Close();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var item = (Arenda)ShowDataGrid.SelectedItem;
            new ArendUpdateWindow(item).Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var removingObject = ShowDataGrid.SelectedItems.Cast<Arenda>().ToList();
                ArendaEntities.GetContext().Arenda.RemoveRange(removingObject);
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
