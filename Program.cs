using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.DisplayAllInDB();
            Class2 class2 = new Class2();
            class2.DisplayAllInDB();
        }
    }
}
