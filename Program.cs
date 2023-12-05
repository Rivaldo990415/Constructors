using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("harry Potter","Jk Rowling", 400);

            Console.WriteLine(book1);
            Console.ReadLine();
        }
    }
}
