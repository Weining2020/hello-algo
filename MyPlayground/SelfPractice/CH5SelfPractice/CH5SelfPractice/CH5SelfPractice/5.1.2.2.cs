using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH5SelfPractice
{
    public class ArrayStack
    {
        List<int> stack;
        public ArrayStack()
        {
            stack = new List<int>();
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }

        public int Size()
        {
            return stack.Count;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new Exception();
            }
            return stack[Size() - 1];
        }

        public void Push(int value)
        {
            stack.Add(value);
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new Exception();
            }
            int res = Peek();
            stack.RemoveAt(Size() - 1);
            return res;
        }

        public int[] ConvertToArray()
        {
            if (IsEmpty())
            {
                throw new Exception();
            }

            return [.. stack];
        }
    }
}
