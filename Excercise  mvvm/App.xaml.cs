using Excercise__mvvm.Connectors;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Excercise__mvvm
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static DBConnector _conector = new DBConnector();
        public static DBConnector Conector
        {
            get { return App._conector; }

        }


    }
}
