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

namespace practice02
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            tbLogin.Focus();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == "student1" && pbPassword.Password == "111")
            {
                Users.userRole = "student1";
                this.Close();
            }
            else if (tbLogin.Text == "student2" && pbPassword.Password == "222")
            {
                Users.userRole = "student2";
                this.Close();
            }
            else if (tbLogin.Text == "student3" && pbPassword.Password == "333")
            {
                Users.userRole = "student3";
                this.Close();
            }
            else if (tbLogin.Text == "teacher" && pbPassword.Password == "1234")
            {
                Users.userRole = "teacher";
                this.Close();
            }
            else
            {
                MessageBox.Show("Логин или пароль введены неверно. Повторите попытку", 
                    "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                tbLogin.Clear();
                tbLogin.Focus();
                pbPassword.Clear();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
