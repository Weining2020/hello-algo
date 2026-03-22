using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH5
{
    internal class _5221
    {
        /*
        //基于链表实现的队列
        using hello_algo.utils;

        public class LinkedListQueue
        {
            ListNode? front, rear;  // 头节点 front ，尾节点 rear //这个设计是核心。
            int queSize = 0;

            public LinkedListQueue()
            {
                front = null;
                rear = null;
            }
            //获取队列的长度
            public int Size()
            {
                return queSize;
            }
            //判断队列是否为空
            public bool IsEmpty()
            {
                return Size() == 0;
            }

            public int Peek() //逻辑是从队首开始遍历这个Queue，添加到数组中，再返回。
            {
                if (IsEmpty())
                {
                    throw new Exception();
                }

                return front!.val;
            }
            //入队
            public void Push(int num)
            {
                ListNode node = new(num);
                if (front == null) //可以将 if (front == null) 修改为 if (IsEmpty())，这样可以提高代码的一致性和可读性。
                {
                    front = node;
                    rear = node;
                }
                else if (rear != null) //AI:front 和 rear 的状态始终同步,队列不变量：front == null 当且仅当 rear == null。只要你的 Push / Pop 每次都正确维护这个不变量，就永远不会出现"front 有值但 rear 是 null"或反过来的情况。这里的 else if (rear != null) 完全可以改成 else。
                {
                    rear.next = node;
                    rear = rear.next;
                }
                queSize++;
            }

            public int Pop() 
            {
                int num = Peek();
                front = front?.next;
                queSize--;

                return num;
            }

            public int[] ToArray()
            {
                if (front == null)
                {
                    return [];
                }

                int[] res = new int[Size()];

                ListNode? node = front;
                for (int i = 0; i < Size(); i++)
                {
                    res[i] = node!.val;
                    node = node.next;
                }

                return res;
            }
        }
        */
    }
}
