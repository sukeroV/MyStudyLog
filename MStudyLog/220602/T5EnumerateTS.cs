using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220602
{
    enum E_QQType
    {
        Online,
        Leave,
        Busy,
        Invisible
    }
    public class T5EnumerateTS
    {
        public T5EnumerateTS()
        {
            Console.WriteLine("枚举练习题");
            /////////////////////////////////////////////练习题1
            //定义qq状态的枚举，并提示一个在线状态，我们接受数字，并转换成枚举类型
            try
            {
                Console.WriteLine("请输入QQ状态，（0在线，1离开，2忙，3隐身）");
                int type = int.Parse(Console.ReadLine());
                E_QQType qqType = (E_QQType)type;
                Console.WriteLine(qqType);
            }
            catch
            {
                Console.WriteLine("输入字段非法，请输入数字");
            }
            /////////////////////////////////////////////练习题2
            //


        }
    }
}
