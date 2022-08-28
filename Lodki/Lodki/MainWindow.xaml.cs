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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lodki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        user84_dbEntities Q = new user84_dbEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Role = Q.BD10_Пользователь.Where(a => a.Логин == TxtBks1.Text && a.Пароль == TxtBks2.Password).FirstOrDefault();
       
            if (Role is null)
            {
                MessageBox.Show("Проверьте данные");
            }
            else if(TxtBks1.Text == "" && TxtBks2.Password == "")
            {
                MessageBox.Show("Оба поля обязательны к заполнению");
            }

           
            else
            {

                if (Role.Роль == "Админ")
                {
                    new Админ().Show();
                    Close();
                }
                if (Role.Роль == "Клиент")
                {
                    new Клиент().Show();
                    Close();
                }
                if (Role.Роль == "Менеджер")
                {
                    new Менеджер().Show();
                    Close();
                }
           
            }
             
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Регистрация().Show();
            Close();
        }
    }
}
