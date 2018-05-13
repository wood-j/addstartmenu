using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddStartMenu
{
    public partial class LinkOper : IOper
    {
        #region IOper
        public override string Create(string path)
        {
            var file = Common.DestDir + "\\" + Path.GetFileName(path);
            FileHelper.CopyFile(path, file);
            return file;
        }

        public override bool Support(string path)
        {
            bool result = false;
            if (path.ToLower().EndsWith(".lnk"))
            {
                result = true;
            }
            return result;
        }
        #endregion
    }
}
