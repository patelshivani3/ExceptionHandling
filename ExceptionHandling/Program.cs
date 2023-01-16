using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Types Of Exception\n");
            //TypesOfException.TestIndexOutOfBoundException();
            //TypesOfException.TestNullReferenceException();
            //TypesOfException.TestInvalidOperationException("Shivani");
            //TypesOfException.TestArgumentNullException();
            TypesOfException.TestArgumentOutOfRangeException();
            Console.ReadLine();
        }
    }
}
