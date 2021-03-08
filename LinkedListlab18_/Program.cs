using System;

namespace Lab18LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var list = new List(6);
            list.Insert("one");
            list.Insert("two");
            list.Insert("three");
            list.Insert("four");
            list.Insert("Seven");
            list.Insert("Nine");


            //list.PrintReverse();
            //list.InserAt(3, "Six");
            //Console.WriteLine("\nBefore Removal");
            //list.Print();

            list.RemoveAt(3);
            list.RemoveAt(1);


            //Console.WriteLine("\nAfter Removal");
            list.Print();

            list.Insert("It Worked!");
            list.Print();

            list.PrintReverse();
            Console.ReadKey();
        }

    }

    public class List
    {
        private int _count = 0;
        private readonly string[] _array;

        public List(int maxLength)
        {
            _array = new string[maxLength];
        }

        public int Count()
        {
            return _count;
        }

        public bool IsEmpty()
        {
            //if (_count == 0)
            //{ 
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return _count == 0;
        }


        public bool IsFull()
        {
            return _count == _array.Length;  //Here you can see if the list is full.
        }

        public bool Insert(string value)
        {
            if (IsFull())
            {
                return false;             //Allows you to insert a value at a given index
            }

            _array[_count] = value;
            _count++;
            return true;
        }

        public void Print()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(_array[i]);
            }
        }

        public void PrintReverse()
        {
            for (int i = _array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(_array[i]);
            }
        }

        public bool InserAt(int index, string value)
        {
            if (index > _array.Length && index < 0)
            {
                return false;
            }

            _array[index] = value;

            return true;
        }

        public bool RemoveAt(int index)
        {
            if(index >= _array.Length)
            {
                return false;
            }

            if (index == _array.Length - 1)
            {
                _array[index] = null;
            }
            else
            {
                for (int i = index; i < _count - 1; i++)   // Here you can  to remove an item at a given index 
                {
                    _array[i] = _array[i + 1];
                }

                _array[_count - 1] = null;
            }

            _count--;

            return true;
        }
    }
}
