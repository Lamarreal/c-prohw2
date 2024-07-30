using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace vectors
{
    public struct Vector2
    {
        double X, Y;
        public Vector2(double X, double Y) {
            this.X = X;
            this.Y = Y;
        }
        public Vector2()
        {
            this.X = 0;
            this.Y = 0;
        }

        public static Vector2 One => new Vector2(1, 1);
        public static Vector2 Zero => new Vector2();
        public double Length => (X + Y) * 2; // малось на у вазі периметер? чи просто сумма 

        public static Vector2 operator +(Vector2 a) => a;
        public static Vector2 operator +(Vector2 a, Vector2 b) => new Vector2(a.X + b.X,a.Y + b.Y);
        public static Vector2 operator *(Vector2 a, double m) => new Vector2(a.X * m, a.Y * m);
        public static Vector2 operator -(Vector2 a, Vector2 b) => new Vector2(a.X - b.X, a.Y - b.Y);
        public static Vector2 operator -(Vector2 a) => new Vector2(-a.X,-a.Y);
        public override string ToString() => $"{X},{Y}";

    }
}
