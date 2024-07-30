using interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vectors;

namespace shapes
{
    public abstract class Shape : IMovable
    {
        public Vector2 Position;
        public Vector2 Size = Vector2.One;

        public void Move(int deltaX, int deltaY)
        {
            Position += new Vector2(deltaX, deltaY);
        }

        public void Move(Vector2 delta)
        {
            Position += delta;
        }
    }

    public class Rectangle : Shape
    {
        public void ChangeSize(Vector2 size) => this.Size = size;
    }

    public class Circle : Shape
    {

    }
}
