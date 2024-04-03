using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_Generics_3_4_24
{
    internal class Box : IEquatable<Box>
    {
        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public Box(int height, int length, int width)
        {
            this.Height = height;
            this.Length = length;
            this.Width = width;
        }
        public bool Equals(Box? other)
        {
            if(new SameBoxProp().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Box with dimensions: Höjd: {Height} Längd: {Length} Bredd: {Width}";
        }
    }
}
