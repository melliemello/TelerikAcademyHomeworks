using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GenericClass
{
    public class GenericList<T> where T : IComparable, new()
    {
        private T[] list;
        private int defaultLength = 5;
        private int count = 0;

        public GenericList(int length)             
        {
            this.defaultLength = length;
            this.list = new T[length];
        }

        public T this[int index]
        {
            get 
            {
                if (!IsValidIndex(index, this.list))
                {
                    throw new IndexOutOfRangeException(String.Format("The index {0} is not correct for the array with length {1}", index, this.list.Length));
                }
                return this.list[index]; 
            }
        }

        public void Add(T element)
        {
            if(this.count >= this.list.Length)
            {
                this.list = DoubleLength(this.list);
            }
            this.list[this.count] = element;
            this.count++;
        } 

        public void InsertAt(int index, T element)
        {
            try
            {
                
                if(this.count + 1 >= this.list.Length)
                {
                    this.list = DoubleLength(this.list);
                }

                this.count++;

                for (int i = this.count; i > index; i-- )
                {
                    this.list[i] = this.list[i - 1];
                }
                this.list[index] = element;
                
            }
            catch
            {
                throw new IndexOutOfRangeException(String.Format("The index {0} is not correct for the array with length {1}", index, this.list.Length));
            }            
        }

        public void Clear()
        {
            this.list = new T[this.defaultLength];
            this.count = 0;
        }

        public void RemoveAt(int index)
        {
            if ( this.count <= index || !IsValidIndex(index, this.list))
            {
                throw new IndexOutOfRangeException("There's no such element to remove");
            }
            for (int i = index; i < this.list.Length-1; i++ )
            {
                this.list[index] = this.list[index + 1];
            }
            this.list[this.count] = new T();
            this.count--;
        }

        public int IndexOf( T value)
        {
            int indexFound = Array.IndexOf(this.list, value);
            return indexFound;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.list.Length; i++ )
            {
                result.Append(this.list[i]);
                result.Append(" ");
            }
            return result.ToString();
        }

        public T[] All
        {
            get { return this.list; }
        }

        public T Min()
        {
            if(this.count > 0)
            {
                T min = this.list[0];
                for (int i = 1; i < this.count; i++ )
                {
                    if(this.list[i].CompareTo(min) < 0)
                    {
                        min = this.list[i];
                    }
                }
                return min;
            }
            else
            {
                throw new IndexOutOfRangeException("The list is empty");
                
            }           
        }

        public T Max()
        {
            if (this.count > 0)
            {
                T max = this.list[0];
                for (int i = 1; i < this.count; i++)
                {
                    if (this.list[i].CompareTo(max) > 0)
                    {
                        max = this.list[i];
                    }
                }
                return max;
            }
            else
            {
                throw new IndexOutOfRangeException("The list is empty");

            }
        }

        private T[] DoubleLength(T[] list)
        {
            T[] temp = this.list;
            list = new T[list.Length * 2];
            Array.Copy(temp, list, temp.Length);
            return list;
        }

        private bool IsValidIndex(int i, T[] list)
        {
            if(i < 0 || i >= list.Length)
            {
                return false;
            }
            return true;
        }  


        

    }
}
