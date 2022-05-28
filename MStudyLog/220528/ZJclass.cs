using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220528
{
    public class ZJclass
    {
        public ZJclass()
        {
            //
            Assembly assembly = Assembly.LoadFrom(@"C:\Users\hsl\source\repos\AndActivator\AndActivator\bin\Debug\AndActivator.dll");
            Type type1 = assembly.GetType("AndActivator.class1");// 
            object obj = Activator.CreateInstance(type1);
            Console.WriteLine(obj);
            MemberInfo memberInfo = type1.GetMethod("a");
            Console.WriteLine(memberInfo);
            

            //FieldInfo fieldInfo = type1.GetField("ss");
            //Console.WriteLine(fieldInfo.GetValue(obj));
        }        
        
    }
}
