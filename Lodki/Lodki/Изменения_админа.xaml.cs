using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Изменения_админа.xaml
    /// </summary>
    public partial class Изменения_админа : Window
    {
        user84_dbEntities Q = new user84_dbEntities();
        BD10_Покупатель покупатель;
        BD10_Менеджеры менеджер;
        public Изменения_админа(int Q)
        {
            InitializeComponent();

            
            Кнопка.Content = "Добавить";
            Лабел.Content = "Добавление";

            //visibl(Q);
            ComboBox1.SelectedIndex = Q;
        }
        public Изменения_админа(BD10_Покупатель row)
        {
            InitializeComponent();
            покупатель = row;

            var eRow = Q.BD10_Пользователь.Where(n => n.Код_пользователя == row.Код_пользователя).FirstOrDefault();
            TextBox1.Text = eRow.Логин;
            TextBox6.Text = eRow.Пароль;

            TextBox20.Text = row.Имя;
            TextBox70.Text = row.email;
            TextBox50.Text = row.Адресс;
            TextBox60.Text = row.город;
            TextBox30.Text = row.Дата_рождения;
            TextBox100.Text = row.Имя_документа;
            TextBox40.Text = row.Регистрационное_имя;
            TextBox90.Text = row.Серия_паспорта;
            TextBox80.Text = row.Телефон;
            TextBox2.Text = row.Фамилия;
            

            ComboBox1.SelectedIndex = 0;

        }

        public Изменения_админа(BD10_Менеджеры row)
        {
            InitializeComponent();
            менеджер = row;

            var eRow = Q.BD10_Пользователь.Where(n => n.Код_пользователя == row.Код_пользователя).FirstOrDefault();
            TextBox1.Text = eRow.Логин;
            TextBox6.Text = eRow.Пароль;

            TextBox20.Text = row.Имя;
            TextBox2.Text = row.Фамилия;

            ComboBox1.SelectedIndex = 1;

        }


        private void Кнопка_Click(object sender, RoutedEventArgs e)
        {
            if (покупатель != null)
            {
                if (TextBox1.Text == "" || TextBox6.Text == "" || TextBox90.Text == "")
                {
                    MessageBox.Show("Эти поля обязательны к заполнению: Логин, Пароль, Серия пасопрта", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if(TextBox2.Text == "" && TextBox20.Text == "" )
                {
                    MessageBox.Show("заполните одно из полей: Имя или Фамилия", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (Regex.IsMatch(TextBox80.Text, @"\D") && TextBox80.Text != "")
                {
                    MessageBox.Show("В телефоне должны быть только цифры", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else if (Regex.IsMatch(TextBox20.Text, @"\d"))
                {
                    MessageBox.Show("В имени должны быть только буквы", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else if (Regex.IsMatch(TextBox2.Text, @"\d"))
                {
                    MessageBox.Show("В Фамилии должны быть только буквы", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {
                    var Real = Q.BD10_Пользователь.Where(n => n.Код_пользователя == покупатель.Код_пользователя).FirstOrDefault();
                    Real.Логин = TextBox1.Text;
                    Real.Пароль = TextBox6.Text;


                    var ap = Q.BD10_Покупатель.Where(w => w.Код_покупателя == покупатель.Код_покупателя).FirstOrDefault();
                    ap.город = TextBox60.Text;
                    ap.email = TextBox70.Text;
                    ap.Адресс = TextBox50.Text;
                    ap.Дата_рождения = TextBox30.Text;
                    ap.Имя = TextBox20.Text;
                    ap.Имя_документа = TextBox100.Text;
                    ap.Регистрационное_имя = TextBox40.Text;
                    ap.Серия_паспорта = TextBox90.Text;
                    ap.Телефон = TextBox80.Text;
                    ap.Фамилия = TextBox2.Text;


                    Q.SaveChanges();
                    MessageBox.Show("Клиент изменен", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else if (менеджер != null)
            {
                if (TextBox1.Text == "" || TextBox6.Text == "")
                {
                    MessageBox.Show("Эти поля обязательны к заполнению: Логин, Пароль", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (TextBox2.Text == "" && TextBox20.Text == "")
                {
                    MessageBox.Show("Заполните одно из полей: Имя или Фамилия", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (Regex.IsMatch(TextBox20.Text, @"\d"))
                {
                    MessageBox.Show("В имени должны быть только буквы", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else if (Regex.IsMatch(TextBox2.Text, @"\d"))
                {
                    MessageBox.Show("В Фамилии должны быть только буквы", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {
                    var Real = Q.BD10_Пользователь.Where(n => n.Код_пользователя == менеджер.Код_пользователя).FirstOrDefault();
                    Real.Логин = TextBox1.Text;
                    Real.Пароль = TextBox6.Text;

                    var ho = Q.BD10_Менеджеры.Where(w => w.Код_менеджера == менеджер.Код_менеджера).FirstOrDefault();
                    ho.Имя = TextBox20.Text;
                    ho.Фамилия = TextBox2.Text;

                    Q.SaveChanges();
                    MessageBox.Show("Менеджер изменён", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
           
            else
            {
                BD10_Пользователь re = new BD10_Пользователь();
                re.Логин = TextBox1.Text;
                re.Пароль = TextBox6.Text;

                var dRow = Q.BD10_Пользователь.Where(w => w.Логин == re.Логин && w.Пароль == re.Пароль).FirstOrDefault();

                if (dRow == null)
                {
                    Q.BD10_Пользователь.Add(re);
                    Q.SaveChanges();
                }

                dRow = Q.BD10_Пользователь.Where(w => w.Логин == re.Логин && w.Пароль == re.Пароль).FirstOrDefault();

               
               
                if (ComboBox1.SelectedIndex == 0)
                {
                    if (TextBox1.Text == "" || TextBox6.Text == "" || TextBox90.Text == "")
                    {
                        MessageBox.Show("Эти поля обязательны к заполнению: Логин, Пароль, Серия пасопрта", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else if (TextBox2.Text == "" && TextBox20.Text == "")
                    {
                        MessageBox.Show("заполните одно из полей: Имя или Фамилия", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else if (Regex.IsMatch(TextBox80.Text, @"\D") && TextBox80.Text != "")
                    {
                        MessageBox.Show("В телефоне должны быть только цифры", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else if (Regex.IsMatch(TextBox20.Text, @"\d"))
                    {
                        MessageBox.Show("В имени должны быть только буквы", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else if (Regex.IsMatch(TextBox2.Text, @"\d"))
                    {
                        MessageBox.Show("В Фамилии должны быть только буквы", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else
                    {
                        BD10_Покупатель ap = new BD10_Покупатель();
                        ap.Код_пользователя = dRow.Код_пользователя;
                        ap.город = TextBox60.Text;
                        ap.email = TextBox70.Text;
                        ap.Адресс = TextBox50.Text;
                        ap.Дата_рождения = TextBox30.Text;
                        ap.Имя = TextBox20.Text;
                        ap.Имя_документа = TextBox100.Text;
                        ap.Регистрационное_имя = TextBox40.Text;
                        ap.Серия_паспорта = TextBox90.Text;
                        ap.Телефон = TextBox80.Text;
                        ap.Фамилия = TextBox2.Text;

                        Q.BD10_Покупатель.Add(ap);
                        Q.SaveChanges();
                        MessageBox.Show("Покупатель добавлен", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);


                    }
                }

                if (ComboBox1.SelectedIndex == 1)
                {
                    if (TextBox1.Text == "" || TextBox6.Text == "")
                    {
                        MessageBox.Show("Эти поля обязательны к заполнению: Логин, Пароль", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else if (TextBox2.Text == "" && TextBox20.Text == "")
                    {
                        MessageBox.Show("Заполните одно из полей: Имя или Фамилия", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else if (Regex.IsMatch(TextBox20.Text, @"\d"))
                    {
                        MessageBox.Show("В имени должны быть только буквы", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else if (Regex.IsMatch(TextBox2.Text, @"\d"))
                    {
                        MessageBox.Show("В Фамилии должны быть только буквы", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else
                    {
                        BD10_Менеджеры ap = new BD10_Менеджеры();
                        ap.Код_пользователя = dRow.Код_пользователя;
                        ap.Имя = TextBox20.Text;
                        ap.Фамилия = TextBox2.Text;

                        Q.BD10_Менеджеры.Add(ap);
                        Q.SaveChanges();
                        MessageBox.Show("Менеджер добавлен", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                }

               
            }
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (три != null && четыре != null && пять != null && шесть != null)
            {
                if (ComboBox1.SelectedIndex == 0)
                {
                    три.Visibility = Visibility.Visible;
                    четыре.Visibility = Visibility.Visible;
                    пять.Visibility = Visibility.Visible;
                    шесть.Visibility = Visibility.Visible;
                   
                }

                if (ComboBox1.SelectedIndex == 1)
                {
                    три.Visibility = Visibility.Collapsed;
                    четыре.Visibility = Visibility.Collapsed;
                    пять.Visibility = Visibility.Collapsed;
                    шесть.Visibility = Visibility.Collapsed;

                }

              
            }
        }

      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           new Админ().Show();
           Close();
            
        }
    }
}
