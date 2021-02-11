using System;

namespace Module_9_Delegates
{
    class Program
    {
        public delegate void MyDelegarePointer(int a, int b);
        static void Main(string[] args)
        {
            MyDelegarePointer pointer;

            MyClass newClass = new MyClass();
            pointer = newClass.MyFirstMethod;
            pointer += newClass.MySecondMethod;

            pointer += delegate (int x, int y)
            {
                Console.WriteLine("I have two parameters " + x + "," + y + "]");
            };

            pointer += (int z, int l) =>
            {
                Console.WriteLine(z / l);
            };

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            pointer(20, 5);

            pointer -= newClass.MyFirstMethod;
            pointer -= newClass.MySecondMethod;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Red;
            pointer(20, 5);
        }
    }
}
public class MyClass
{
    public void MyFirstMethod(int a, int b)
    {
        Console.WriteLine(a * a * b);
    }

    public void MySecondMethod(int a, int b)
    {
        Console.WriteLine(a + a + a + b);
    }
}
