using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_Generics_3_4_24
{
    internal class BoxEnumerator : IEnumerator<Box>
    {
        private BoxCollection boxes;
        private int currentIndex;
        private Box currentBox;

        public BoxEnumerator(BoxCollection box)
        {
            this.boxes = box;
            currentIndex = -1;
            currentBox = default(Box);
        }
        public Box Current { get { return currentBox; } }

        object IEnumerator.Current { get { return Current; } }

        public int Count
        {
            get { return boxes.Count; }
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if(++currentIndex >= boxes.Count)
            {
                return false;
            }
            else
            {
                currentBox = boxes[currentIndex];
            }
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
