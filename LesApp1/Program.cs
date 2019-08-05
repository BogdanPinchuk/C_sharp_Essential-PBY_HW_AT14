using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // Join Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // створення колекції з випадковими даними
            TestClass test = new TestClass();

            // виведення даних
            Console.WriteLine("\n\tВиведення значень через foreach:\n");
            foreach (Element i in test)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("\n\tДодавання 10 значень:");
            Console.WriteLine("\n\tВиведення значень через foreach:\n");
            for (int i = 0; i < 10; i++)
            {
                test.Add(new Element());
            }

            // в MVS 2015 - не підтримуються Nested методи
            foreach (Element i in test)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("\n\tВидалення 7 перших значень:");
            Console.WriteLine("\n\tВиведення значень через foreach:\n");
            for (int i = 0; i < 7; i++)
            {
                test.RemoveAt(0);
            }

            foreach (Element i in test)
            {
                Console.WriteLine(i.ToString());
            }

            // repeat
            DoExitOrRepeat();
        }

        /// <summary>
        /// Метод виходу або повторення методу Main()
        /// </summary>
        static void DoExitOrRepeat()
        {
            Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey(true);

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
                // без використання рекурсії
                //Process.Start(Assembly.GetExecutingAssembly().Location);
                //Environment.Exit(0);
            }
            else
            {
                // закриває консоль
                Environment.Exit(0);
            }
        }
    }
}
