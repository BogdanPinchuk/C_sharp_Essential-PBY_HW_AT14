using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    class Program
    {
        static void Main()
        {
            // Join Unicode
            Console.OutputEncoding = Encoding.Unicode;
            // випадкові числа
            Random rnd = new Random();

            // заповення змінних згідно умовам (без додаткової реалізації чогось)
            // трохи хардкоду, але згідно умови
            OuterElementList<int> outlist = new OuterElementList<int>(
                    new InnerElementList<int>[]
                    {
                    new InnerElementList<int>(
                        Enumerable.Range(rnd.Next(0, 10), 4).ToArray()),
                    new InnerElementList<int>(
                        Enumerable.Range(rnd.Next(10, 20), 4).ToArray()),
                    new InnerElementList<int>(
                        Enumerable.Range(rnd.Next(20, 30), 4).ToArray()),
                    new InnerElementList<int>(
                        Enumerable.Range(rnd.Next(30, 40), 4).ToArray()),
                    });

            // виведення даних
            Console.WriteLine("\n\tВиведення значень через вложені цикли foreach:\n");
            foreach (InnerElementList<int> i in outlist)
            {
                foreach (int j in i)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine();
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
