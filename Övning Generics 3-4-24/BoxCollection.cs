using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_Generics_3_4_24
{
    internal class BoxCollection : ICollection<Box>
    {
        List<Box> innerBoxList;

        public BoxCollection()
        {
            innerBoxList = new List<Box>();
        }
        public int Count
        {
            get { return innerBoxList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public Box this[int index]
        {
            get { return (Box)innerBoxList[index]; }
            set { innerBoxList[index] = value;}
        }

        public void Add(Box item)
        {
            if (!Contains(item))
            {
                innerBoxList.Add(item);
            }
            else
            {
                Console.WriteLine("The box already exists.");
            }
        }

        public void Clear()
        {
            innerBoxList.Clear();
        }

        public bool Contains(Box item)
        {
            bool result = false;
            if (innerBoxList.Contains(item))
            {
                result = true;
            }
            return result;
        }

        public bool Contains(Box item, EqualityComparer<Box> compare)
        {
            bool result = false;
            foreach (Box b in innerBoxList)
            { 
                if(compare.Equals(item, b))
                {
                    result = true;
                }
            }
            return result;

        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            bool removed = false;
            for (int i = 0; i < innerBoxList.Count; i++)
            {
                Box currentBox = innerBoxList[i];
                if (new SameBoxProp().Equals(currentBox, item))
                {
                    innerBoxList.RemoveAt(i);
                    removed = true;
                    break;
                }
            }
            return removed;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BoxEnumerator(this);
        }
    }
}
