using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vectors;

namespace interfaces
{
    public interface IMovable
    {
        void Move(int deltaX,int deltaY);
        void Move(Vector2 Delta);
    }
}
