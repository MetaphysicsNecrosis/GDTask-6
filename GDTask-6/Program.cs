using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GDTask_6
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            
            String s = Console.ReadLine();
            String s1 = Regex.Replace(s, "(?i)[aeiouyауоыиэяюёе]", "");
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}
