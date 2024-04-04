using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsCMS
{
    public class StringUtil
    {
        public static string ConvertToPermalink(string title)
        {
            string permalink = title.ToLower();
            permalink = Regex.Replace(permalink, @"\s+", "-");
            permalink = Regex.Replace(permalink, @"[^a-z0-9\-]", "");
            return permalink;
        }
    }
}
