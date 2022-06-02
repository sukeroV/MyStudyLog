using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//泛型限制  规定传进来的类型必须符合条件
//关键字 where
//6种
//where 泛型字母:struct  值类型
//where 泛型字母:class   引用类型
//where 泛型字母:new()   存在无参公共构造函数
//where 泛型字母:类名    有某个类本身或者其派生
//where 泛型字母:接口名   某个接口的派生
//where 泛型字母:另一个泛型字母  另外一个泛型本身或者其派生类型

namespace MStudyLog._220601
{
    public class GenericsConstraint<T> where T : new()
    {
        //public void a<K>(K k) where K : new(){}
        public GenericsConstraint(int int1)
        {
            Console.WriteLine("New():");
        }

    }
}
