using System;
using System.Collections.Generic;
using System.Text;

namespace Learningcsharpmay26.Csharpfirstproject
{
    public class Basics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello pradeep");
            
            string str;
            str = " pradeepkumar ";
            Console.WriteLine(str.Length);
            str = str.Trim();   
            Console.WriteLine(str.Length);
            Console.WriteLine($"this value is {str}");

        }
    }
}
