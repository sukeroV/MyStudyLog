using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace MStudyLog._220605
{
    class TS
    {
        public void a()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
        public void b()
        {
            for (int i = 100; i < 200; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
    }
    internal class Async
    {
        public Async()
        {
            TS tS = new TS();
            Thread thread = new Thread(tS.a);
            Thread thread2 = new Thread(tS.b);
            Console.WriteLine( char.IsUpper('C') );
            
            thread.Start();
            thread2.Start();                                                        
        }        
    }
}
