#define IsShowMessage

using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

#region 总结
/*Obsolete  弃用
 * Conditional  调不调用
 * [CallerLineNumber] 调用者信息  第几行调用
 * [CallerFilePath]  调用者信息
 * [CallerMemberName]  调用者名字
 * DebuggerStepThrough  debug跳过
 * 
 */

#endregion
namespace MStudyLog._220528
{
    public class T2Attribute
    {
        public T2Attribute()
        {
            Console.WriteLine("特性");
            Myclass myclass = new Myclass();
            myclass.TestFun(1);
            myclass.c();
        }

    }
    class Myclass
    {

        public string name;
        //Obsolete  弃用
        [Obsolete("使用别的函数，你猜用什么")]
        public void TestFun(int i)
        {
        }

        //Conditional  宏被定义的时候就调用
        [Conditional("IsShowMessage")]
        public void b()
        {
        }

        public void c([CallerLineNumber]int i = 0, [CallerFilePath]string filePath = "",[CallerMemberName]string Name="")
        {
            Console.WriteLine(i);
            Console.WriteLine(filePath);
            Console.WriteLine(Name);
        }

        [DebuggerStepThrough]
        public void d()
        {

        }

    }
}
