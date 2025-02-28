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
        public int stackSize = 0;
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
            return Size() == 0;
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new Exception();
            }
            return stackPeek!.val;
        }
        public void Push(int val)
        {
            ListNode newNode = new ListNode(val);
            newNode.next = stackPeek;
            stackPeek = newNode;
            stackSize++;
        }

        public int Pop()
        {
            int res = Peek();
            stackPeek = stackPeek!.next;
            stackSize--;
            return res;
        }

        //把栈转化为数组。
        public int[] ConvertToArray()
        {
            if (IsEmpty())
            {
                return Array.Empty<int>();
            }

            ListNode node = stackPeek;
            int[] resArray = new int[Size()];
            for (int i = Size() - 1; i >= 0; i--)
            {
                resArray[i] = node.val;
                node = node.next;
            }

            return resArray;
        }

    }
}
