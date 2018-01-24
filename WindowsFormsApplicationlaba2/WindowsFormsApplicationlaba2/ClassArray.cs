using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationlaba2
{
    class ClassArray<T> : IEnumerator<T>, IEnumerable<T>, IComparable<ClassArray<T>>
    {
        private Dictionary<int, T> places;
        private int maxCount;
        private T defaultValue;

        public ClassArray(int size, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = size;
        }

        public static int operator +(ClassArray<T> p, T ianimal)
        {
            var isTarantul = ianimal is Tarantul;
            if (p.places.Count == p.maxCount)
            {
                throw new ParkingOverflowException();
            }
            int index = p.places.Count;
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = i;
                }
                if (ianimal.GetType() == p.places[i].GetType())
                {
                    if (isTarantul)
                    {
                        if ((ianimal as Tarantul).Equals(p.places[i]))
                        {
                            throw new ParkingAlreadyHaveException();
                        }
                    }
                    else if ((ianimal as Spiderswolf).Equals(p.places[i]))
                    {
                        throw new ParkingAlreadyHaveException();
                    }
                }
            }
            if (index != p.places.Count)
            {
                p.places.Add(index, ianimal);
            }
            p.places.Add(p.places.Count, ianimal);
            return p.places.Count - 1;
        }

        public static T operator -(ClassArray<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T ianimal = p.places[index];
                p.places.Remove(index);
                return ianimal;
            }
            throw new ParkingIndexOutOfRangeException();
        }

        private bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);
        }

        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defaultValue;
            }
        }

        private int currentIndex;

        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(ClassArray<T> other)
        {
            if (this.Count() > other.Count())
            {
                return -1;
            }
            else if (this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i = 0; i < places.Count; ++i)
                {
                    if (places[thisKeys[i]] is Spiderswolf && other.places[thisKeys[i]] is Tarantul)
                    {
                        return 1;
                    }
                    if (places[thisKeys[i]] is Tarantul && other.places[thisKeys[i]] is Spiderswolf)
                    {
                        return -1;
                    }
                    if (places[thisKeys[i]] is Spiderswolf && other.places[thisKeys[i]] is Spiderswolf)
                    {
                        return (places[thisKeys[i]] is Spiderswolf).CompareTo(other.places[thisKeys[i]] is Spiderswolf);
                    }
                    if (places[thisKeys[i]] is Tarantul && other.places[thisKeys[i]] is Tarantul)
                    {
                        return (places[thisKeys[i]] is Tarantul).CompareTo(other.places[thisKeys[i]] is Tarantul);
                    }
                }
            }
            return 0;
        }
    }
}
