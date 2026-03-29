using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH5
{
    internal class _5122
    {
        /*
        //基于数组实现的栈  //其实应该说基于动态数组（即列表）实现的栈。
        public class ArrayStack
        {
            List<int> stack; //我们是在基于数组实现栈，这里的List<int>而不是Array，应该是因为上面我们说了，用动态数组这样就无须自行处理数组扩容问题。Question：List就是动态数组吗？答：你提到的代码是以 List<int> 动态数组 实现栈的功能，而不是严格意义上使用固定大小的 原生数组 int[] 来实现栈。这里选择使用 List<int> 是因为它提供了内置的动态扩容能力，简化了栈的操作。没错，CH4的注意也说了，列表就是动态数组。

            public ArrayStack()
            {
                // 初始化列表（动态数组）
                stack = new List<int>(); //Question: 空数组用default关键字声明可以吗？答：用 default 声明数组时，arr 的值是 null(访问Count会炸)，而不是一个空数组(访问Count得到0)。
            }
            //获取栈的长度
            public int Size()
            {
                return stack.Count;
            }
            //判断栈是否为空
            public bool IsEmpty()
            {
                return Size() == 0;
            }
            //入栈
            public void Push(int num)
            {
                stack.Add(num);
            }
            //出栈
            public int Pop()
            {
                if (IsEmpty())
                {
                    throw new Exception();
                }
                int val = Peek();
                stack.RemoveAt(Size() - 1);
                return val;
            }
            //访问栈顶元素
            public int Peek()
            {
                if (IsEmpty())
                {
                    throw new Exception();
                }
                return stack[Size() - 1]; //小心啊，不是返回stack[0]。
            }
            //将 List 转化为 Array 并返回
            public int[] ToArray()
            {
                return [.. stack]; //[.. ] 是 C# 12 集合表达式里的展开运算符（Spread Operator），专门用来把一个现有集合的所有元素"展开铺进"新集合。.. 可以展开任何实现了 IEnumerable<T> 的集合，不限于数组。//没错，在4.3.1   列表常用操作1.   初始化列表也见过。它实际上等同于：return stack.ToArray();。
            }
        }
        */
    }
}
