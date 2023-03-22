using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Capp
{
    internal class Commands
    {

        public static void makeDir(Directories D, string NameDir)
        {
            var st = D.curdir + "\\" + NameDir;
            if (Directory.Exists(st))
            {
                Console.WriteLine("Directory" + st + "alredy exists!");
            }
            else if(NameDir == "")
            {
                Console.WriteLine("Uncorrect name");
            }
            else {
                Directory.CreateDirectory(st);
            }

        }
        public static void makeFile(Directories D, string NameFile)
        {
            var st = D.curdir + "\\" + NameFile;
            if (Directory.Exists(st) && NameFile != "")
            {
                Console.WriteLine("Directory" + st + "alredy exists!");
            }
            else if (NameFile == "")
            {
                Console.WriteLine("Uncorrect name");
            }
            else
            {
                var newFile = File.Create(st);
                newFile.Close();
            }

        }

    }
}
