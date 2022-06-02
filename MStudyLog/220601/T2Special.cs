using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220601
{
    class cla2
    {
        public int age;
        public string name;
        public int sex
        {
            get;
            set;
        }
        /// <summary>
        /// ///////////////////////////////////////2
        /// </summary>
        public void Test1()
        {
            Console.WriteLine("设置对象初始化:{0}\n", age);
            Console.WriteLine("设置对象初始化:{0}\n", name);
            Console.WriteLine("设置对象初始化:{0}\n", sex);
        }

    }
    public class T2Special
    {
        public T2Special()
        { 
            Console.WriteLine("特殊语法\n");
            /////////////////////////////////////////1
            #region var cla1
            var a = 10;
            #endregion
            /////////////////////////////////////////2
            #region 设置对象初始化 cal2
            cla2 cla2 = new cla2 { sex = 1,age = 100,name = "wang"};
            cla2.Test1();
            #endregion
            /////////////////////////////////////////3
            #region 设置集合初始化值
            int[] ints = { 1,2,3,4,5,6};
            List<int> list = new List<int>() { 1,2,3,4,5};
            //List<int> list2 = new { 1, 2, 3, 4, 5 }; 错误写法
            #endregion
            /////////////////////////////////////////4
            #region 匿名类型
            var v = new { age = 10, name = "小米" };
            Console.WriteLine("匿名类型:{0},{1}\n", v.age, v.name);
            #endregion
            /////////////////////////////////////////5
            #region 可空类型
            //类型不能赋空
            //int c1 = null;
            //加？可以赋空
            int? c = null;
            c = 100;
            if (c.HasValue)
            {
                Console.WriteLine("可控类型:{0}\n", c.Value);
            }
            //
            object obj = null;
            //如果这样调用会出错
            //obj.ToString();
            //解决上面的问题用if
            //if (obj != null) obj.ToString();
            //或者用这个  同效果同上  语法糖
            obj?.ToString();
            //举例
            int[] ints1 = null;
            Console.WriteLine(ints1?[0]);
            //举例
            Action action = null;
            action?.Invoke();
            #endregion
            /////////////////////////////////////////6
            #region 空合并操作符
            Console.WriteLine("空合并操作符:");
            int? c1 = null;
            int c2 = c1 == null? 1 : c1.Value;
            Console.WriteLine(c2);
            //如果左边值不为空则使用其值，否则使用后面的
            int c3 = c1 ?? 100;
            Console.WriteLine(c3);
            c1 = 120;
            c3 = c1 ?? 100;
            Console.WriteLine(c3);
            Console.WriteLine();
            #endregion
            /////////////////////////////////////////7
            #region 内插字符串
            //关键符合：$
            //$拼接string变量
            string name = "小何";
            int age = 22;
            Console.WriteLine($"\"内插字符串\":好好学习，{name},{age}\n");
            #endregion
            /////////////////////////////////////////8
            #region 单句语句简略写法
            for (int i = 0; i < list.Count; i++) Console.WriteLine("单句语句简略写法:{0}", i);
            Console.WriteLine();
            #endregion

            //////////end
        }
    }
}
