using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddStartMenu
{
    public abstract class IOper
    {
        public abstract bool Support(string path);
        public abstract string Create(string path);

        protected static List<IOper> All = null;
        public static void Init()
        {
            All = new List<IOper>();
            All.Add(new ExeOper());
            All.Add(new LinkOper());
            All.Add(new DirOper());
        }
        public static IOper GetSupportOper(string file)
        {
            IOper result = null;
            foreach(var item in All)
            {
                if (item.Support(file))
                {
                    return item;
                }
            }
            return result;
        }
    }
}
