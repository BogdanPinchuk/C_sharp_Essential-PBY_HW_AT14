using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3
{
    /// <summary>
    /// Тестовий клас
    /// </summary>
    class TestClass
    {
        /// <summary>
        /// Дані для виведення
        /// </summary>
        private string s = "Hello World";

        /// <summary>
        /// Кількість ітерацій
        /// </summary>
        public int Iteration { get; set; } = 10;

        /// <summary>
        /// Повернення рядка певну кількість разів
        /// </summary>
        /// <returns></returns>
        public IEnumerable GetString()
        {
            for (int i = 0; i < Iteration; i++)
            {
                yield return s;
            }
        }

    }
}
