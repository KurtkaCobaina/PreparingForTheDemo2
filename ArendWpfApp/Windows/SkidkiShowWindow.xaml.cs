using ArendWpfApp.Model;
using System.Linq;
using System.Windows;

namespace ArendWpfApp
{
    /// <summary>
    /// Логика взаимодействия для SkidkiShowWindow.xaml
    /// </summary>
    public partial class SkidkiShowWindow : Window
    {
        public SkidkiShowWindow()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            ShowDataGrid.ItemsSource = ArendaEntities.GetContext().Skidka.OrderBy(x => x.Id).ToList();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            new SkidkiAddWindow().Show();
            this.Close();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var item = (Skidka)ShowDataGrid.SelectedItem;
            new SkidkiEditWindow(item).Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var removingObject = ShowDataGrid.SelectedItems.Cast<Skidka>().ToList();
                ArendaEntities.GetContext().Skidka.RemoveRange(removingObject);
                MessageBox.Show("Скидка удалилась");
                LoadData();
            }
            catch
            {
                MessageBox.Show("Нельзя удалить этот объект");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new DirectorMainWindow().Show();
            this.Close();
        }
       
    }
}
