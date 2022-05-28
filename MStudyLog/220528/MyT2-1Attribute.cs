using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220528
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal sealed class MyT2_1Attribute : Attribute
    {
        public string developer;
        public string version;
        public string description;


        public MyT2_1Attribute(string developer, string version, string description)
        {
            this.developer = developer;
            this.version = version;
            this.description = description;
        }

        public void a()
        {
            Console.WriteLine("MyT2_1Attribute --a() in 26. \t" + "特性调用方法");
        }
    }
}
