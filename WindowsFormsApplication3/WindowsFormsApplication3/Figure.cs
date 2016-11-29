using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Base
    {
        /// <summary>
        /// Метод создания фигуры
        /// </summary>
        /// <param name="a">сторона</param>
        /// <param name="b">сторона</param>
        /// <param name="c">сторона(0 по умл.)</param>
        /// <returns></returns>
        public static Figure CreateFigure(int a, int b, int c = 0)
        {
            Figure F;
            if (c > 0)
            { F = new Parallelepiped(a, b, c); }
            else
            { F = new Rectangle(a, b); }
            return F;
        }
    }
    abstract class Figure
    {
        protected int a, b, c;//стороны
        /// <summary>
        /// Перегрузка операторов
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <returns></returns>
        public static bool operator >(Figure f1,Figure f2)
        {
            if (f1.S > f2.S) return true;
            else return false;
        }
        public static bool operator <(Figure f1, Figure f2)
        {
            if (f1.S < f2.S) return true;
            else return false;
        }
        public int A
        {
            get { return a; }
        }
        public int B
        {
            get { return b; }
        }
        public int C
        {
            get { return c; }
        }
        public Figure(int a,int b,int c = 0)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public abstract int S { get; }
        public abstract int V { get; }
        public abstract int P { get; }
        /// <summary>
        /// Информация о типе фигуры
        /// </summary>
        /// <returns> Имя фигуры </returns>
        public string About()
        {
            return "A:" + this.A + " B:" + this.B + " C:" + this.C + " Figure:"+this.GetType().Name;
        }
        /// <summary>
        /// Проверка размера фигуры
        /// </summary>
        /// <param name="another">Фигура с которой сверяем</param>
        /// <returns> ответ верно ли </returns>
        public string MoreThan(Figure another)
        {
            if (this > another)
            {
                return "true";
            }
            else
            {
                if(another > this)
                {
                    return "false";
                }
                else { return "same"; }
            }
        }
    }
    class Parallelepiped : Figure
    {
        public Parallelepiped(int a,int b,int c):base(a,b,c)
        {}
        public override int S
        {
            get { return 2*(A*B+B*C+C*A); }
        }
        public override int V
        {
            get
            {
                return a * b * c;
            }
        }
        public double d
        {
            get
            {
                return Math.Sqrt(A * A + B * B + C * C);
            }
        }
        public override int P
        {
            get
            {
                return 4 * (A + B + C);
            }
        }
    }
    class Rectangle : Figure
    {
        public Rectangle(int a, int b):base(a,b)
        {}
        public override int S 
        {
            get { return (A * B); }
        }
        public override int V
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override int P
        {
            get
            {
                return 2*(A + B);
            }
        }
    }
}

