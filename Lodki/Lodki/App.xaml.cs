using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Lodki
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static user84_dbEntities Context
        { get; } = new user84_dbEntities();

        public static BD10_Пользователь пользователь = null;
    }
}
