using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220528
{
    [MyT2_1("he","v1.1","资本家路灯挂件--限定版")]
    internal class T2_2
    {
        
        public T2_2()
        {
            //判断这个类身上有没有特性
            Type t = typeof(T2_2);
            bool result = t.IsDefined(typeof(MyT2_1Attribute), false);
            Console.WriteLine(result);

            //获取所有特性
            object[] args = t.GetCustomAttributes(false);
            foreach (var arg in args)
            {
                //调用字段
                Console.WriteLine(arg.ToString());
                Console.WriteLine((arg as MyT2_1Attribute).version);//这么写有问题的，贪图方便。（加个判断吧）
                Console.WriteLine((arg as MyT2_1Attribute).developer);
                Console.WriteLine((arg as MyT2_1Attribute).description);

                (arg as MyT2_1Attribute).a();
            }
        }
        
        
    }
}
