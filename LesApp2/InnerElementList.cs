using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    /// <summary>
    /// Список внутрішніх елементів
    /// </summary>
    class InnerElementList<T> : IEnumerable<T>, IEnumerator<T>
    {
        /// <summary>
        /// Масив елементів
        /// </summary>
        T[] array = new T[4];

        /// <summary>
        /// Ємність колекції
        /// </summary>
        public int Capacity => array.Length;

        public InnerElementList() { }
        public InnerElementList(T[] array)
        {
            this.array = array;
        }

        /// <summary>
        /// Ітератор/енумератор
        /// </summary>
        private int state = -1;

        /// <summary>
        /// Повернення поточного значення - generic
        /// </summary>
        public T Current => array[state];

        /// <summary>
        /// Повернення поточного значення
        /// </summary>
        object IEnumerator.Current => array[state];

        /// <summary>
        /// Повернення нумератора - generic
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator() 
            => this as IEnumerator<T>;

        /// <summary>
        /// Повернення поточного значення
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
            => this as IEnumerator;

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

        public void Dispose() { }
    }
}
