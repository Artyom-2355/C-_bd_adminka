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
    /// Interaction logic for Админ.xaml
    /// </summary>
    public partial class Админ : Window
    {
        user84_dbEntities Q = new user84_dbEntities();
        public Админ()
        {
            InitializeComponent();

            ClientListView.ItemsSource = Q.BD10_Покупатель.ToList();
            MenedjrListView.ItemsSource = Q.BD10_Менеджеры.ToList();
            TovarListView.ItemsSource = Q.BD10_Лодка.ToList();

        }

        private void ButtonDobav(object sender, RoutedEventArgs e)
        {
            new Изменения_админа(Персоны.SelectedIndex).Show();
            Close();
        }

        private void ClientListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MenedjrListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TovarListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ap = (BD10_Покупатель)ClientListView.SelectedItem;
            if (Персоны.SelectedIndex == 0)
            {
                if (ap != null)
                {
                    if (MessageBox.Show("Вы уверены что хотите удалить?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes) Q.BD10_Покупатель.Remove(ap);
                }
                else
                {
                    MessageBox.Show("Выберите строчку", "Сообщение");
                }

            }


            var ho = (BD10_Менеджеры)MenedjrListView.SelectedItem;
            if (Персоны.SelectedIndex == 1)
            {
                if (ho != null)
                {
                    if (MessageBox.Show("Вы уверены что хотите удалить?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes) Q.BD10_Менеджеры.Remove(ho);
                }
                else
                {
                    MessageBox.Show("Выберите строчку", "Сообщение");
                }

            }

           

            Q.SaveChanges();
            UpDate();
            Q = new user84_dbEntities();
            ClientListView.ItemsSource = Q.BD10_Покупатель.ToList();
            MenedjrListView.ItemsSource = Q.BD10_Менеджеры.ToList();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = (BD10_Покупатель)ClientListView.SelectedItem;
            var h = (BD10_Менеджеры)MenedjrListView.SelectedItem;

            if (a != null || h != null)
            {
                if (Персоны.SelectedIndex == 0)
                {
                    new Изменения_админа(a).Show();
                    Close();

                }

                if (Персоны.SelectedIndex == 1)
                {
                    new Изменения_админа(h).Show();
                    Close();

                }


                UpDate();
                Q = new user84_dbEntities();
                ClientListView.ItemsSource = Q.BD10_Покупатель.ToList();
                MenedjrListView.ItemsSource = Q.BD10_Менеджеры.ToList();

            }
            else
            {
                MessageBox.Show("Выберите строчку", "Сообщение");
            }
        }

        private void UpDate()
        {
            ClientListView.ItemsSource = App.Context.BD10_Пользователь.ToList();
            MenedjrListView.ItemsSource = App.Context.BD10_Менеджеры.ToList();

        }

        private void Персоны_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
