using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Tema5.Controller
{
    class ConnectionString
    {
        public static string ConnStr
        {
            get 
            {
                return ConfigurationManager.ConnectionStrings["Tema5.Properties.Settings.ConnStr"].ConnectionString;
            }
        }
    }
}
