using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddStartMenu
{
    public class DirOper : IOper
    {
        #region IOper
        public override string Create(string path)
        {
            List<string> results = new List<string>();
            //
            var files = Directory.GetFiles(path);
            foreach(var file in files)
            {
                var oper = IOper.GetSupportOper(file);
                if(null != oper)
                {
                    var r = oper.Create(file);
                    results.Add(r);
                }
            }
            var dirs = Directory.GetDirectories(path);
            foreach (var dir in dirs)
            {
                var oper = IOper.GetSupportOper(dir);
                if (null != oper)
                {
                    var r = oper.Create(dir);
                    results.Add(r);
                }
            }
            //
            return string.Join("\n", results.ToArray());
        }

        public override bool Support(string path)
        {
            bool result = false;
            if (Directory.Exists(path))
            {
                result = true;
            }
            return result;
        }
        #endregion
    }
}
