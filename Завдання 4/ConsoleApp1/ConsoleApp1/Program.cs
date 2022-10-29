
using System;
using System.Security.Cryptography;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
namespace ApplicationLicense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int code;
            Console.WriteLine("Enter your code to determine access to the program");
            code = Convert.ToInt32(Console.ReadLine());
            Application application = new Application(code);
            Console.WriteLine($"Your code : {code}");
            application.DoWork(10, 2);
        }
    }
}
namespace ApplicationLicense
{
    internal class Application : IWorkable
    {
        private readonly int _code;
        public Application(int code)
        {
            this._code = code;
        }

        private ApplicationLicense applicationLicense = new ApplicationLicense();
        public void DoWork(int a, int b)
        {
            if (_code > 0)
            {
                if (_code % 3 == 0)
                {
                    applicationLicense.AllowPro();
                    Console.WriteLine(a + b);
                    applicationLicense.AllowPro();
                    Console.WriteLine(a * b);
                    applicationLicense.AllowPro();
                    Console.WriteLine(a - b);
                    applicationLicense.AllowPro();
                    Console.WriteLine(a / b);
                    applicationLicense.AllowPro();
                }
                if (_code % 3 == 1)
                {
                    applicationLicense.AllowTrial();
                    Console.WriteLine(a + b);
                    applicationLicense.AllowTrial();
                    Console.WriteLine(a * b);
                    applicationLicense.AllowTrial();
                    Console.WriteLine(a - b);
                    applicationLicense.AllowTrial();
                    Console.WriteLine(a / b);
                    applicationLicense.AllowTrial();
                }
                else if (_code % 3 == 2)
                {
                    applicationLicense.AllowCommon();
                    Console.WriteLine(a + b);
                    applicationLicense.AllowCommon();
                    Console.WriteLine(a - b);
                    applicationLicense.AllowCommon();
                }
            }
        }
    }
}
namespace ApplicationLicense
{
    internal class ApplicationLicense
    {
        public void AllowTrial()
        {
            Console.WriteLine("You have chosen Trial version");
        }

        public void AllowCommon()
        {
            Console.WriteLine("You have chosen the Free version");
        }

        public void AllowPro()
        {
            Console.WriteLine("You have chosen the Professional version");
        }
    }
}
namespace ApplicationLicense
{
    internal interface IWorkable
    {
        void DoWork(int a, int b);
    }
}