using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    /// <summary>
    /// Тестовий клас
    /// </summary>
    class TestClass : IEnumerable, IEnumerator
    {
        /// <summary>
        /// Масив на 5 елементів
        /// </summary>
        private Element[] array = new Element[5];

        /// <summary>
        /// Для випадкових чисел
        /// </summary>
        private Random rnd = new Random();

        /// <summary>
        /// Конструктор
        /// </summary>
        public TestClass()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Element(
                    rnd.Next(sbyte.MinValue, sbyte.MaxValue),
                    rnd.Next(sbyte.MinValue, sbyte.MaxValue),
                    rnd.Next(sbyte.MinValue, sbyte.MaxValue));
            }
        }

        /// <summary>
        /// Ітератор/енумератор
        /// </summary>
        private int state = -1;

        /// <summary>
        /// Повернення поточного значення
        /// </summary>
        object IEnumerator.Current { get { return array[state]; } }

        /// <summary>
        /// Повернення нумератора
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator() => this as IEnumerator;

        /// <summary>
        /// Крокування по масиву
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if (state < array.Length - 1)
            {
                state++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        /// <summary>
        /// Скидання (лічильника) ітератора
        /// </summary>
        public void Reset() => state = -1;
    }
}
