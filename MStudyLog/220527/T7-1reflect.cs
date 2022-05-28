using System;
using MStudyLogT2;

namespace MStudyLog
{
    public class NewTS1
    {
        public int a;

        public NewTS1()
        {
            a = 100;
        }
    }
    
    public class T7_1reflect
    {
        private T6preprocessing _t6Preprocessing = new T6preprocessing();
        private T7_2reflect _t72Reflect = new T7_2reflect();
        public void A()
        {
            Type _type = typeof(T7_2reflect);
            
            Console.Write(_type);
            _t6Preprocessing.a();
            _t72Reflect.a();
            
        }
    }
}