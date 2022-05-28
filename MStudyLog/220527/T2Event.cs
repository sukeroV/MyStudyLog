
///
///26课 事件
///https://www.bilibili.com/video/BV1Ar4y1K7AK?p=14&spm_id_from=pageDriver
/// 

using System;
namespace MStudyLog
{
    #region 知识点 事件是什么
    //事件是基于委托的存在
    //事件是委托的安全包裹
    //让委托的使用更具有安全性
    //事件是一种特殊的变量类型
    #endregion

    #region 知识点 事件的使用
    //申明语法：
    //访问修饰符 event 委托类型 事件名
    //时间的使用：
    //1.事件是作为  成员变量存在于类中
    //2.委托怎么用  事件就怎么用
    //事件相对于委托的区别
    //1.不能在类的外部赋值
    //2.不能在类外部  调用
    //注意：
    //它只能作为成员在于类和接口中及结构体中
    
    
    class MyClass
    {
        //委托
        public Action myFun;
        //事件
        public event Action myEvent;

        public void Test()
        {
            myFun = TestFun;
            myFun += TestFun;
            // Console.Write(11);
            //myEvent = TestFun;
            // myEvent += TestFun;
            // myEvent -= TestFun;
            //myEvent();
        }

        public void TestFun()
        {
            Console.WriteLine("TestFun");
        }

        public void diaoyongEvent()
        {
            myEvent();
        }

        public void addEvent(Action amyFun)
        {
            myEvent = amyFun;
        }

    }
    
    

    #endregion

    public class T2Event
    {
        private MyClass _myClass = new MyClass();

        public void a(int Temp)
        {
            _myClass.myEvent += _myClass.TestFun;
            _myClass.myEvent += _myClass.TestFun;
            _myClass.Test();
            _myClass.diaoyongEvent();
            _myClass.addEvent(b);
            _myClass.diaoyongEvent();
           
        }

        public void b()
        {
            Console.Write("b");
        }
    }
}