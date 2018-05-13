using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddStartMenu
{
    public class ExeOper : IOper
    {
        #region IOper
        public override string Create(string path)
        {
            var lnk = ShortcutHelper.CreateShortcut(path);
            var file = Common.DestDir + "\\" + Path.GetFileName(lnk);
            FileHelper.CopyFile(lnk, file);
            return file;
        }

        public override bool Support(string path)
        {
            bool result = false;
            if (path.ToLower().EndsWith(".exe"))
            {
                result = true;
            }
            return result;
        }
        #endregion
    }
}
