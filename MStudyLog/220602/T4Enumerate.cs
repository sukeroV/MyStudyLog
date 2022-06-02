using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220602
{
    public class T4Enumerate
    {
        #region 枚举是什么
        //它是一个被命名的整数常量的集合
        //一般用它来表示状态，类型，状态

        //声明枚举  参见写在namespace中
        enum E_Enum
        {
            age,
            name,
            sex
        }
        #endregion

        public T4Enumerate()
        {
            //使用枚举
            //自定义枚举类型 变量 = 默认值；
            E_Enum e_Enum = E_Enum.age;
            if(e_Enum == E_Enum.age)
            {
                Console.WriteLine(e_Enum);
            }
            //枚举类型转换
            int i = (int)E_Enum.sex;
            Console.WriteLine(i);
        }

    }
}
