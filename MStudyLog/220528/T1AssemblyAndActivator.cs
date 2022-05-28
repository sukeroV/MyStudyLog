using System;
using System.Reflection;

namespace MStudyLog._220528
{
    public class T1AssemblyAndActivator
    {
        public void a()
        {
            /*
            #region Activator

            Type testType = typeof(Test1);
            Test1 obj = Activator.CreateInstance(testType) as Test1;
            Console.WriteLine(obj.str);
            
            obj = Activator.CreateInstance(testType,99) as Test1;
            Console.WriteLine(obj.j);
            #endregion

            #region Assembly
           
            Assembly assembly = Assembly.LoadFrom(@"C:\Users\hsl\Desktop\ww\Ts1\Ts1\bin\Debug\Ts1.dll");//
            Console.WriteLine(assembly.GetName().Version.ToString());
            Type[] type = assembly.GetTypes();
            foreach (Type t in type)
            {
                Console.WriteLine(t);
            }
            Type type1 = assembly.GetType("Ts1.Class1");//
            MemberInfo[] members = type1.GetMembers();
            foreach (MemberInfo m in members)
            {
                Console.WriteLine(m);
            }
            FieldInfo fieldInfo = type1.GetField("jj");
            object obj2 = Activator.CreateInstance(type1);//
            Console.WriteLine(fieldInfo.GetValue(obj2));

            MethodInfo constructor = type1.GetMethod("a");//
            constructor.Invoke(obj2, null);//
            constructor = type1.GetMethod("b");
            constructor.Invoke(obj2, null);
            //obj2 = Activator.CreateInstance(type1);
            Console.WriteLine(constructor);

            //Console.WriteLine(fieldInfo.GetValue(type1));




            #endregion
            */
            //获取程序集
            Assembly assembly2 = Assembly.LoadFrom(@"C:\Users\hsl\source\repos\AndActivator\AndActivator\bin\Debug\AndActivator.dll");
            //获取type
            Type type5 = assembly2.GetType("AndActivator.class1");  
            //实例化对象
            object obj3 = Activator.CreateInstance(type5,10);
            //获取方法
            MethodInfo constructor = type5.GetMethod("b");
            //调用方法
            constructor.Invoke(obj3, new object[] {10});



        }
    }
}