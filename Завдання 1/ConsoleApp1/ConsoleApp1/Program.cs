using System;
namespace DebugOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1<int> task1 = new Task1<int>();
            task1.GetInDebugMethod(10, 10);
        }
    }
}