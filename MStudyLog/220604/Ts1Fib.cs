using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220604
{
    public class Ts1Fib
    {
        public Ts1Fib(int n)
        {
            double dou = Math.Sqrt(5);
            double dou2 = (Math.Pow(((1 + dou) / 2), n)-Math.Pow(((1 - dou) / 2), n));
            Console.WriteLine( Math.Round(dou2/dou));
            
                
        }
    }
}
