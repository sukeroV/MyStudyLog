using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220609
{
    /// <summary>
    /// 内部类
    /// </summary>
    class aa
    {
        class bb
        {
        }
    }

    /// <summary>
    /// 分部类
    /// </summary>
    partial class Study
    {
        public int _id;
    }
    partial class Study
    {
        public int age;
        public Study()
        {
            Console.WriteLine(_id);
        }
    }
    internal class T3Internal
    {
        Study study1 = new Study();
        
    }
}
