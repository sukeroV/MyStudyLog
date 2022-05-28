using System;
using System.Reflection;

namespace MStudyLog
{
    #region 知识点一 什么是程序集
    //程序集是经由编译器编译得到的，供进一步编译执行的那个中间产物
    //在wINDOWS系统中，它一般表现为后缀为·d11（库文件）或者是·exe（可执行文件）的格式
    //说人话：
    //程序集就是我们写的一个代码集合，我们现在写的所有代码
    //最终都会被编译器翻译为一个程序集供别人使用
    //比如一个代码库文件（d11）或者一个可执行文件（exe）
    #endregion
    #region 知识点二元数据
    //元数据就是用来描述数据的数据
    //这个概念不仅仅用于程序上，在别的领域也有元数据
    //说人话：
    //程序中的类，类中的函数、变量等等信息就是程序的元数据
    //有关程序以及类型的数据被称为元数据，它们保存在程序集中
    #endregion
    #region 知识点三反射的慌念
    //程序正在运行时，可以查看其它程序集或者自身的元数据。
    //一个运行的程序查看本身或者其它程序的元数据的行为就叫做反射
    //说人话：
    //在程序运行时，通过反射可以得到其它程序集者自己程序集代码的各种信息
    //类，函数，变量，对象等等，实例化它们，执行它们，操作它们
    #endregion
    public  class T7Reflection
    {
        

        public void M()
        {
            int a = 42;
            Type _type = a.GetType();
            Console.WriteLine(_type);

            Type _type2 = typeof(int);
            Console.WriteLine(_type2);
            
            Type _type3 = Type.GetType("System.Int32");
            Console.WriteLine(_type3);
            
            Console.WriteLine(_type.Assembly);
            
            //通过反射  获取公共成员
            Type _type4 = typeof(Test1);
            MemberInfo[] infos = _type4.GetMembers();
            foreach (var VARIABLE in infos)
            {
                Console.WriteLine(VARIABLE);
            }
            
            //所有的构造函数
            ConstructorInfo[] constructorInfos = _type4.GetConstructors();
            foreach (var VARIABLE in constructorInfos)
            {
                Console.WriteLine(VARIABLE);
                
            }

            constructorInfos[0].Invoke(new object[0]);

            //得到构造函数传入 Type数组
            //执行构造函数传入 object数组
            //反射获取  然后执行函数
            ConstructorInfo constructorInfo = _type4.GetConstructor(new Type[0]);
            constructorInfo.Invoke(null);
            
            //有参数//获取参数
            ConstructorInfo constructorInfo2 = _type4.GetConstructor(new Type[] {typeof(int)});
            Test1 obj = constructorInfo2.Invoke(new object[] {10}) as Test1;
            Console.WriteLine(obj.str + obj.j);
            Console.WriteLine("constructorInfo2 : "+constructorInfo2);
            //有参数
            ConstructorInfo constructorInfo3 = _type4.GetConstructor(new Type[] {typeof(int), typeof(string)});
            obj = constructorInfo3.Invoke(new object[] {1234, "helang"}) as Test1;
            Console.WriteLine(obj.str + "\n" + "////////////////////////////////////////////////////////////////////////////////////////////////////////");
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            //所有的公共变量
            FieldInfo[] fieldInfos = _type4.GetFields();
            foreach (var VARIABLE in fieldInfos)
            {
                Console.WriteLine(VARIABLE);
            }

            //获取单个
            FieldInfo fieldInfo = _type4.GetField("j");
            Console.WriteLine(fieldInfo);
            //通过反射  获取、设置值
            Test1 test1 = new Test1();////////////////////////////////////？？？？？？？？
            Console.WriteLine(fieldInfo.GetValue(test1));
            fieldInfo.SetValue(test1,100);
            Console.WriteLine(fieldInfo.GetValue(test1));

            //获取类 公共方法
            Type strType = typeof(string);
            MethodInfo[] methodInfos = strType.GetMethods();
            foreach (var VARIABLE in methodInfos)
            {
                //Console.WriteLine(VARIABLE);
            }

            MethodInfo methodInfo = strType.GetMethod("Substring",new Type[]{typeof(int),typeof(int)});
            string str = "Hello World";
            object result = methodInfo.Invoke(str, new object[] {3, 4});
            Console.WriteLine(result);
            
            //静态调用传null即可
            


        }

    }
    
}

class Test1
{
    private int i = 1;
    public int j = 0;
    public string str = "123";
    public Test1()
    {
        Console.WriteLine("Test1()");
    }
    public Test1(int i)
    {
        Console.WriteLine(i);
        this.i = i;
    }
    public Test1(int i,string str):this(i)
    {
        this.str = str;
    }

    public void Speek()
    {
        Console.WriteLine(i);
    }
    
}