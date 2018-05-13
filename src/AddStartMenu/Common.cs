using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddStartMenu
{
    public partial class Common
    {
        private static string destDir = string.Empty;
        public static string DestDir
        {
            get
            {
                if (string.IsNullOrWhiteSpace(destDir))
                {
                    destDir = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    destDir += "\\Microsoft\\Windows\\Start Menu\\AddStartMenu";
                }
                return destDir;
            }
        }
    }
}
