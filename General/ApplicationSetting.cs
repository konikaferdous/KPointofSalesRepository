using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace KPointofSales.General
{
    public class ApplicationSetting
    {
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["rbx"].ConnectionString;
        }
    }
}
