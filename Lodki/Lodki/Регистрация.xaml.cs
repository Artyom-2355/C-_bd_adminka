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

namespace Lodki
{
    /// <summary>
    /// Interaction logic for Регистрация.xaml
    /// </summary>
    public partial class Регистрация : Window
    {
        user84_dbEntities Q = new user84_dbEntities();
        public Регистрация()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBks1.Text != null || TxtBks2.Password != null)
            {
                MessageBox.Show("Оба поля обязательны к заполнению");
            }
            
            else
            {
                BD10_Пользователь P = new BD10_Пользователь();
                P.Логин = TxtBks1.Text;
                P.Пароль = TxtBks2.Password;
                P.Роль = "Клиент";

                Q.BD10_Пользователь.Add(P);
                Q.SaveChanges();
                MessageBox.Show("Пользователь добавлен");
            }
        
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }
    }
}
