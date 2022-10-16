using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DebugOne
{
    internal class Task1<T>
    {
        public void GetInDebugMethod(T first, T second)
        {           
            Debug.WriteLine(first);
            Debug.WriteLine(second);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Type for first parameter is : {first.GetType()} and value :  ");
            Console.WriteLine(first);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"Type for second parameter is : {second.GetType()} and value :  ");
            Console.WriteLine(second);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}