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
    /// Логика взаимодействия для ArendaAddWindow.xaml
    /// </summary>
    public partial class ArendaAddWindow : Window
    {
        private readonly Arenda arenda = new Arenda();
        public ArendaAddWindow()
        {
            InitializeComponent();
            DataContext = arenda;
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            
            var context = ArendaEntities.GetContext();
            context.Arenda.Add(arenda);
            context.SaveChanges();
            MessageBox.Show("Новый пользователь добавлен");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new ArendaShowWindow().Show();
            this.Close();
        }
    }
}
