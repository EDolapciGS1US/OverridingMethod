using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingMethod
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }

    }
}
