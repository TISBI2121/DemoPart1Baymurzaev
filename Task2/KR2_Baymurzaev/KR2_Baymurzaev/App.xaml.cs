using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using KR2_Baymurzaev.Models;

namespace KR2_Baymurzaev
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static KR2BaymurzaevEntities db = new KR2BaymurzaevEntities();
        public static User loginedUser;
    }
}
