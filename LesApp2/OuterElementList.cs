using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    /// <summary>
    /// Список зовнішніх елементів
    /// </summary>
    class OuterElementList<T> : 
        IEnumerable<InnerElementList<T>>, 
        IEnumerator<InnerElementList<T>>
    {
        /// <summary>
        /// Масив елементів
        /// </summary>
        InnerElementList<T>[] array = new InnerElementList<T>[4];

        /// <summary>
        /// Ємність колекції
        /// </summary>
        public int Capacity => array.Length;

        public OuterElementList() { }

        public OuterElementList(InnerElementList<T>[] array)
        {
            this.array = array;
        }

        /// <summary>
        /// Ітератор/енумератор
        /// </summary>
        private int state = -1;

        /// <summary>
        /// Повернення поточного значення
        /// </summary>
        object IEnumerator.Current => array[state];

        /// <summary>
        /// Повернення поточного значення - generic
        /// </summary>
        InnerElementList<T> IEnumerator<InnerElementList<T>>.Current 
            => array[state];

        /// <summary>
        /// Повернення нумератора - generic
        /// </summary>
        /// <returns></returns>
        public IEnumerator<InnerElementList<T>> GetEnumerator()
            => this as IEnumerator<InnerElementList<T>>;

        /// <summary>
        /// Повернення поточного значення
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
            => this as IEnumerator;

        /// <summary>
        /// Повернення нумератора - generic
        /// </summary>
        /// <returns></returns>
        IEnumerator<InnerElementList<T>> IEnumerable<InnerElementList<T>>.GetEnumerator()
            => this as IEnumerator<InnerElementList<T>>;

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
