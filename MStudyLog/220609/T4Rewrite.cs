using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220609
{
    class Parents1
    {

        public Parents1()
        {
            Console.WriteLine("父");
        }
        public virtual void P_1()
        {
            Console.WriteLine("P_1");
        }
        public void P_2()
        {
            Console.WriteLine("P_2");
        }
        public virtual void P_3()
        {
            Console.WriteLine("P_3");
        }
    }

    class Child : Parents1
    {
        public Child()
        {
            Console.WriteLine("子");
        }
        // 不写override\new 就会默认隐藏父类中的同名方法
        /*
        public void P_1()
        {
            Console.WriteLine("P_2");
        }
        //同理
        public void P_2()
        {
            Console.WriteLine("P_2_2");
        }
        */
        public override void P_1()
        {
            base.P_1();//调用父类
            Console.WriteLine("P_1_1");
        }
        public new void P_3()
        {
            Console.WriteLine("P_3_3");  
            base.P_3();
        }
        
    }
    internal class T4Rewrite
    {
        public T4Rewrite()
        {
            Child child = new Child();

            child.P_1();
            child.P_2();
            child.P_3();
            Console.Read();
        }
    }
}
