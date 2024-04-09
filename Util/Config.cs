using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCMS
{
    public class Config
    {
        public static String LocalDomainName = ConfigurationManager.AppSettings["LocalDomainName"];
        public static String LocalFolder = ConfigurationManager.AppSettings["LocalFolder"];
        public static String ThemeFile = ConfigurationManager.AppSettings["ThemeFile"];
    }
}
