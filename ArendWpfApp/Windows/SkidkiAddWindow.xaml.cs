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
    /// Логика взаимодействия для SkidkiAddWindow.xaml
    /// </summary>
    public partial class SkidkiAddWindow : Window
    {
        private readonly Skidka skidka = new Skidka();
        public SkidkiAddWindow()
        {
            InitializeComponent();
            DataContext = skidka;
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            ArendaEntities.GetContext().Skidka.Add(skidka);
            ArendaEntities.GetContext().SaveChanges();
            MessageBox.Show("Скидка добавилась");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new SkidkiShowWindow().Show();
            this.Close();
        }
    }
}
