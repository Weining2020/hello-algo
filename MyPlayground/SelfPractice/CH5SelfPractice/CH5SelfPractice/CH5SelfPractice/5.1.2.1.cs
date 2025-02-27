using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH5SelfPractice.utils;

namespace CH5SelfPractice
{
    public class  LinkedListStack
    {
        public ListNode? stackPeek;
        public int stackSize;
        public LinkedListStack()
        {
            stackPeek = null;
        }
        public int Size()
        {
            return stackSize;
        }
        public bool IsEmpty()
        {
            return stackSize == 0;
        }
        public int? Peek()
        {
            if (IsEmpty())
            {
                return null;
            }
            return 
        }
        public void Push(int val)
        {
            ListNode newNode = new ListNode(val);
            stackPeek.next = newNode;
            stackPeek = newNode;
            stackSize++;
        }

    }
}
