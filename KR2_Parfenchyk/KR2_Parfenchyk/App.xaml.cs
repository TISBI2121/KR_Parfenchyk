using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using KR2_Parfenchyk.models;




namespace KR2_Parfenchyk
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application

    {
        public static KR2_ParfenchykEntities db = new KR2_ParfenchykEntities();
        public static User loggedUser;

    }
}
