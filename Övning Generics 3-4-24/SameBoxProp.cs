using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_Generics_3_4_24
{
    internal class SameBoxProp : EqualityComparer<Box>
    {
        public override bool Equals(Box B1, Box B2)
        {
            if(B1.Height == B2.Height && B1.Length == B2.Length && B1.Width == B2.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Box b) 
        {
            return b.GetHashCode();       
        }
    }
}
