using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    /// <summary>
    /// Елемент
    /// </summary>
    class Element
    {
        /// <summary>
        /// Для випадкових чисел
        /// </summary>
        internal static Random rnd = new Random();

        /// <summary>
        /// Координата X
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Координата Y
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Координата Z
        /// </summary>
        public int Z { get; set; }

        /// <summary>
        /// Конструктор користувача
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Element(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Element()
            : this(rnd.Next(sbyte.MinValue, sbyte.MaxValue),
                    rnd.Next(sbyte.MinValue, sbyte.MaxValue),
                    rnd.Next(sbyte.MinValue, sbyte.MaxValue))
        { }

        /// <summary>
        /// Вивід в консольь
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            => $"Координати: ({X}, {Y}, {Z});";

    }
}
