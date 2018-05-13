using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddStartMenu
{
    public class FileHelper
    {
        public static void CopyFile(string src, string dest)
        {
            if(!File.Exists(src))
            {
                throw new Exception("Source file not found.");
            }
            var dir =  GetDirOfFile(dest);
            if(!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            File.Copy(src, dest, true);
        }
        public static string GetDirOfFile(string file)
        {
            string result = string.Empty;
            var index = file.LastIndexOf("\\");
            if (index != -1)
            {
                result = file.Substring(0, index);
            }
            return result;
        }
        //public static string GetFileNameOfFile(string file)
        //{
        //    string result = string.Empty;
        //    if (!file.EndsWith("\\"))
        //    {
        //        var index = file.LastIndexOf("\\");
        //        if (index != -1)
        //        {
        //            result = file.Substring(index + 1);
        //        }
        //    }
        //    return result;
        //}
    }
}
