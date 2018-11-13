using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec
{
    class Program
    {
        static int Main(string[] args)
        {
            MyLog("Hello, Application d'échec");
            MyLog("End, Application d'échec");
            MyPrint("Appuyez sur une touche pour continuer");
            Console.ReadKey();
            return 0;
        }

        static void MyLog(string s)
        {
            Console.WriteLine("##### " + s);
        }

        static void MyPrint(string s)
        {
            Console.WriteLine(s);
        }
    }
}
