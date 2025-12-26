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
    /// Логика взаимодействия для CarUpdateWindow.xaml
    /// </summary>
    public partial class CarUpdateWindow : Window
    {
        private TransportnoeSredstvo _currentTS = new TransportnoeSredstvo();
        public CarUpdateWindow( TransportnoeSredstvo selectedTS)
        {
            InitializeComponent();
            _currentTS = selectedTS;
            DataContext = _currentTS;
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            ArendaEntities.GetContext().SaveChanges();
            MessageBox.Show("Данные обновились");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new CarsShowWindow().Show();
            this.Close();
        }
    }
}
