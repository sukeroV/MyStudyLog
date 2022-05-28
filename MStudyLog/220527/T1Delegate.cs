using System;

///
/// 25课  委托---
/// https://www.bilibili.com/video/BV1Ar4y1K7AK?p=13
/// 
namespace MStudyLog
{
    delegate void Myfun();
    delegate int Myfun2(int a);
    delegate void Myfun3();
    class Test
    {
        public Myfun fun;
        public Myfun2 fun2;
        public void TestFun(Myfun fun,Myfun2 fun2)
        {
            int i = 1;
            i *= 2;
            i += 2;
            this.fun = fun;
            this.fun2 = fun2;
            this.fun();
            this.fun2(10);
        }
    }
    public class T1Delegate
    {
        public void a(int Temp)
        {
            if (Temp == 1)
            {
                Console.WriteLine(Temp);
                Myfun f = new Myfun(Fun);
                f.Invoke();
            }
            if (Temp == 2)
            {
                Console.WriteLine(Temp);
                Myfun f = Fun;
                f();
            }
            if (Temp == 3)
            {
                Console.WriteLine(Temp);
                Test test = new Test();
                test.TestFun(Fun,Fun2);
            }
            
            if (Temp == 4)
            {
                Console.WriteLine(Temp);
                //怎么存储多个函数
                Myfun ff = null;
                ff += Fun3;
                ff += Fun;
                ff();
                ff -= Fun;
                ff -= Fun;
                ff();
            }
            if (Temp == 5)
            {
                Console.WriteLine(Temp);
                //可以传参
                Action action = Fun;
                action();
                Action<int, string, bool> action2;
                
                //可以返回
                Func<string> func = Func4;
                func();
                Func<string, float, int, bool> func2;
            }
        }
        void Fun()
        {
            Console.WriteLine("123321");
        }
        int Fun2(int T)
        {
            Console.WriteLine(456654);
            return T;
        }
        void Fun3()
        {
            Console.WriteLine(567765);
        }
        string Func4()
        {
            Console.WriteLine("Func4");
            return null;
        }
    }
}