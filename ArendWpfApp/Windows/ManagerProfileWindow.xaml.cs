using ArendWpfApp.Model;
using System.Linq;
using System.Windows;

namespace ArendWpfApp
{
    /// <summary>
    /// Логика взаимодействия для ManagerProfileWindow.xaml
    /// </summary>
    public partial class ManagerProfileWindow : Window
    {

        public ManagerProfileWindow()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            var user = ArendaEntities.GetContext().Polzovateli.Where(x => x.Id == CurrentUser.id).ToList();
            DataContext = user;
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            ArendaEntities.GetContext().SaveChanges();
            MessageBox.Show("Данные успешно обновились");
            LoadData();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new ManagerMainWindow().Show();
            this.Close();
        }
    }
}
