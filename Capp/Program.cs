using System;
namespace Capp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Directories D = new Directories();
            Console.WriteLine(Directories.ShortDir(D.GetDir()));
            string s = Console.ReadLine();
            D.SetDir(s);
            Commands.makeFile(D, "Mice");
        }

    }
}