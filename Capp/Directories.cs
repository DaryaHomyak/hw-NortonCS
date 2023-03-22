using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capp
{
    internal class Directories
    {
        public string curdir { get; set; }
        public string GetDir()
        {
            return Directory.GetCurrentDirectory();
        }

        public void SetDir(string dir)
        {
            curdir = dir;
            if (Directory.Exists(dir))
            {
                Directory.SetCurrentDirectory(dir);
            }
            else { Console.WriteLine("Can't find directory " + dir + "!"); }
        }

        public static string ShortDir(string st)
        {
            string new_str = st;
            string[] strings = st.Split('\\');
            if (st.Length > 30 && new_str.Length > 3)
            {
                new_str = strings[0] + "\\" + strings[1] + "\\" + strings[2] + "\\...\\" + strings[strings.Length - 1];
            }
            else if (st.Length > 30)
            {
                new_str = st.Substring(0, 29) + "~";
            }
            return new_str;

        } 

        public void PrintDir(Directories D)
        {
            string Dir = D.curdir;
            var dir = Directory.GetDirectories(Dir);
            var files = Directory.GetFiles(Dir);
            foreach ( var file in files) { Console.WriteLine(file); }
        }

    }
}
