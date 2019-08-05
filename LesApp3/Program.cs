using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3
{
    class Program
    {
        static void Main()
        {
            // Join Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // виведення даних
            Console.WriteLine("\n\tВиведення рядка 10 раз через foreach:\n");

            int j = 0;
            foreach (string i in new TestClass().GetString())
            {
                Console.WriteLine(++j + ". " + i);
            }

            // delay
            Console.ReadKey(true);
        }
    }
}
