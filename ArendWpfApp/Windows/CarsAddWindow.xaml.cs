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
    /// Логика взаимодействия для CarsAddWindow.xaml
    /// </summary>
    public partial class CarsAddWindow : Window
    {
        private readonly TransportnoeSredstvo transportnoeSredstvo = new TransportnoeSredstvo();
        public CarsAddWindow()
        {
            InitializeComponent();
            DataContext = transportnoeSredstvo;
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            var context = ArendaEntities.GetContext();
            context.TransportnoeSredstvo.Add(transportnoeSredstvo);
            context.SaveChanges();
            MessageBox.Show("Добавилось ТС");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new CarsShowWindow().Show();
            this.Close();
        }
    }
}
