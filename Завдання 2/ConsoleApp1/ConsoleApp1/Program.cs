using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Heir1 heir1 = new Heir1();
            Heir2 heir2 = new Heir2();
            Heir3 heir3 = new Heir3();
            A a = new A(heir1, heir2, heir3);
            double y = heir1.Math(1, 3);
            Console.WriteLine(y);
        }
    }
    internal class A
    {
        public A(B heir1)
        {
            Console.WriteLine($"It's A class and its accepts class descendant arguments B ");
            Console.WriteLine("B");
            Console.WriteLine($"| -- {heir1}");
        }
        public A(B heir1, B heir2)
        {
            Console.WriteLine($"It's A class and its accepts class descendant arguments B ");
            Console.WriteLine("B");
            Console.WriteLine($"| -- {heir1}");
            Console.WriteLine($"| -- {heir2}");
        }
        public A(B heir1, B heir2, B heir3)
        {
            Console.WriteLine($"It's A class and its accepts class descendant arguments B ");
            Console.WriteLine("B");
            Console.WriteLine($"| -- {heir1}");
            Console.WriteLine($"| -- {heir2}");
            Console.WriteLine($"| -- {heir3}");
        }

    }
    internal abstract class B
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual void MyName(string name)
        {
            _name = name;
            Console.WriteLine(name);
        }

        public virtual int Sum(int a, int b)
        {
            return a + b;
        }

        public abstract double Math(int a, int b);
    }

    internal class Heir1 : B
    {
        public override void MyName(string name)
        {
            base.MyName(name);
        }
        public override int Sum(int a, int b)
        {
            return base.Sum(a, b);
        }
        public override double Math(int a, int b)
        {
            return a - b;
        }
    }
    internal class Heir2 : B
    {
        public override void MyName(string name)
        {
            base.MyName(name);
        }
        public override int Sum(int a, int b)
        {
            return base.Sum(a, b);
        }
        public override double Math(int a, int b)
        {
            return a * b;
        }
    }
    internal class Heir3 : B
    {
        public override void MyName(string name)
        {
            base.MyName(name);
        }
        public override int Sum(int a, int b)
        {
            return base.Sum(a, b);
        }
        public override double Math(int a, int b)
        {
            return a / b;
        }
    }
}
