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
    /// Логика взаимодействия для SkidkiEditWindow.xaml
    /// </summary>
    public partial class SkidkiEditWindow : Window
    {
        private Skidka _currentSkidka = new Skidka();
        public SkidkiEditWindow(Skidka selectedSkidka)
        {
            InitializeComponent();
            _currentSkidka = selectedSkidka;
            DataContext = _currentSkidka;
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            ArendaEntities.GetContext().SaveChanges();
            MessageBox.Show("Скидка изменилась");

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new SkidkiShowWindow().Show();
            this.Close();
        }
    }
}
