using System;

///
///lambad 使用
///
/// 
namespace MStudyLog
{
    public class T3anonymous
    {
        public void a()
        {
            Action action = () =>
            {
               Console.WriteLine("lambad"); 
            };
            action();

            Action<int> action2 = (value) =>
            {
                Console.WriteLine(value);
            };
            action2(1000);
        }

        public Action<int> b(Action<int> bB1)
        {
            bB1(10);
            bB1 = (i) => { Console.WriteLine("change bB1"); };
            return bB1;
        }

        public void M()
        {
            a();
            Action<int> mM1 = b((i) => { Console.WriteLine("bB1"); });
            mM1(100);
        }
        
    }
}