using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Base
    {
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
        protected int a,b,c;
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
        public string About()
        {
            return this.GetType().Name;
        }
        public string MoreThan(Figure another)
        {
            if (this.S > another.S) return "true";
            else if(this.S == another.S) { return "same"; }
            else return "false";
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

