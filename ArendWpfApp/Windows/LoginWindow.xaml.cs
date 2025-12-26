using ArendWpfApp.Model;
using System;
using System.Linq;
using System.Windows;

namespace ArendWpfApp
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text) || string.IsNullOrEmpty(PassworPasswordBox.Password))
            {
                MessageBox.Show("Введите логин или пароль");
            }
            try
            {
                var context = ArendaEntities.GetContext();
                string login = LoginTextBox.Text;
                string password = PassworPasswordBox.Password;
                var user = context.Polzovateli.Include("Rol").FirstOrDefault(x => x.Login == login && x.Parol == password);
                if (user != null)
                {
                    var usersRole = user.Rol.ToList();
                    CurrentUser.id = user.Id;
                    if (usersRole.Any(r => r.Rol1 == "Менеджер"))
                    {
                        new ManagerMainWindow().Show();
                        this.Close();
                        return;
                    }
                    if (usersRole.Any(r => r.Rol1 == "Директор"))
                    {
                        new DirectorMainWindow().Show();
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Не верный логин или пароль");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
