using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix3 m3a = new Matrix3();
            m3a.SetRotateX(3.98f);
            m3a.PrintMatrixToConsole();

            Matrix3 m3c = new Matrix3();
            m3c.SetRotateZ(9.62f);
            m3c.PrintMatrixToConsole();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        
    }
}
