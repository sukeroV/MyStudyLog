using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220609
{
    public class T1Fc
    {
        public T1Fc()
        {
            Console.WriteLine("构造函数");
        }

        public T1Fc(string name)
        {
            Console.WriteLine("name 重写构造");
            Console.WriteLine(name);
        }

        public T1Fc(int age,string name) : this(name)
        {
            Console.WriteLine("特殊构造函数");
            Console.WriteLine(age);
            Console.WriteLine(name);
            //GC.Collect();
            
        }

        //析构函数 回收时调用
        ~T1Fc()
        {
            Console.WriteLine("析构函数");
        }

        //垃圾回收
        //GC类

        
    }
}
