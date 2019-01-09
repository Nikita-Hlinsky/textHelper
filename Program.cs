using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{   public class StringHelper
    {
        public static string TurnOn(string s, int max)
        {
            if(s == null)
            {
                return string.Empty;
            }
            if(s.Length <= max)
            {
                return s;
            }
            return s.Substring(0, max) + "...";
        }       
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Очень длинная строка коротая резко закончится в любом месте";
            Console.WriteLine(StringHelper.TurnOn(s, 20));
            
        }
    }
}
