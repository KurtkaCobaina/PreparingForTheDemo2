using ArendWpfApp.Model;
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

namespace ArendWpfApp
{
    /// <summary>
    /// Логика взаимодействия для ArendUpdateWindow.xaml
    /// </summary>
    public partial class ArendUpdateWindow : Window
    {
        private  Arenda _currentArenda = new Arenda();
        public ArendUpdateWindow(Arenda selectedArenda)
        {
            InitializeComponent();
            _currentArenda = selectedArenda;
            DataContext = _currentArenda;
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            var context = ArendaEntities.GetContext();
            context.SaveChanges();
            MessageBox.Show("Аренда изменилась");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new ArendaShowWindow().Show();
            this.Close();
        }
    }
}
