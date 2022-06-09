using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//概念
//给现有的非静态 变量类型 添加方法
//作用
//1、提升程序拓展性
//2、不需要在类中重写方法
//3、不需要继承来添加方法
//4、为别人写的封装类写额外方法
//特点
//1、一定写在静态类当中
//2、一定是个静态函数
//3、第一个参数为拓展目标
//4、第一个参数用this修饰

namespace MStudyLog._220609
{
    public static class a
    {
        public static void A_a()
        {
            Console.WriteLine("静态方法调用：A_a");
        } 
        public static void SpeakValue(this int value)
        {
            Console.WriteLine(value + "拓展方法");
        }
    }
    public class T2Fc
    {
        public T2Fc()
        {
            a.A_a();
            int i = 10;
            i.SpeakValue();
            a.SpeakValue(1);

        }

    }
}
