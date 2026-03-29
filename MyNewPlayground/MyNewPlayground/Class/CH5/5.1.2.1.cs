using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH5
{
    internal class _5121
    {
        /*
//基于链表的实现 //基于链表的实现代码，有一个特点就是一定会有一个field用来管理长度。对于基于“数组”的实现代码，就不需要这个field因为“数组”可以轻易获取到长度。
using hello_algo.utils;

public class LinkedListStack
{
    private ListNode? stackPeek;    // 将头节点作为栈顶
    private int stkSize = 0;    // 栈的长度
    public LinkedListStack()
    {
        stackPeek = null;
    }
    //获取栈的长度
    public int Size()
    {
        return stkSize;
    }
    //判断栈是否为空
    public bool IsEmpty()
    {
        return Size() == 0;
    }
    //入栈 //整个方法的逻辑是：先做新节点，再建立向旧头节点的引用，再动态更新头节点，再增加栈长度。//我们在实现这个Push()方法时，没法用stackPeek = new ListNode(n)这种代码，因为现在的stackPeek一旦改变，我们就丢失了整个LinkedListStack实例，即丢失了LinkedListStack实例中其他ListNode节点的引用。还是这里的 新造一个ListNode节点，然后由新造出的ListNode节点的next指向stackPeek，然后将栈顶指针stackPeek指向这个新节点以形成新的栈顶，的做法好。
    public void Push(int num)
    {
        ListNode node = new(num)
        {
            next = stackPeek
        };
        stackPeek = node;
        stkSize++;
    }
    //出栈//整个方法的逻辑是：先拿到值，再删除节点引用，再减少栈长度，最后返回值。
    public int Pop()
    {
        int num = Peek();   //教科书的做法有个设计优点：Peek() 是获取栈顶值的唯一出口，空栈检查只写一次，Pop() 复用它，避免了两处维护同一逻辑。这是"Don't Repeat Yourself（DRY）"原则的体现。//教程的Peek()声明在下面。//Question：这里写int num = stackPeek.val;行不行？答：在大多数情况下，推荐使用 Peek()，因为它更加安全且符合封装原则。遵循封装的原则：通过 Peek() 方法访问栈顶值，而不是直接访问 stackPeek。统一了栈顶值的访问逻辑。如果后续需要在 Peek() 中加入更多的逻辑检查，只需要修改 Peek() 方法，而不需要修改其他地方的代码。避免了重复的空栈检查（IsEmpty() 检查逻辑集中在 Peek() 中）。注意！！stackPeek 的类型是 ListNode?，编译器无法保证在运行时它不会是 null。如果链表栈为空时调用 Pop() 方法（例如未先检查是否为空），stackPeek 会是 null，访问 stackPeek.val 会抛出 NullReferenceException。使用 ! 表示对编译器承诺 "此处 stackPeek 不会为 null"。在这种情况下，编译器不再检查 stackPeek 是否为空，运行时你需要自己确保 stackPeek 不为 null，否则仍会抛出 NullReferenceException。
        stackPeek = stackPeek!.next;//这行代码很巧妙，直接把原stackPeek栈顶元素的上一个元素 设置为了新的 stackPeek，以此达到了删除原stackPeek栈顶元素的目的。//Question: stackPeek!什么意思？答：使用 ! 表示对编译器承诺 "此处 stackPeek 不会为 null"。在这种情况下，编译器不再检查 stackPeek 是否为空，运行时你需要自己确保 stackPeek 不为 null，否则仍会抛出 NullReferenceException。
        stkSize--;
        return num;
    }
    //访问栈顶元素
    public int Peek()
    {
        if (IsEmpty())
            throw new Exception();//嗯这里自己写的时候要注意，当为空时应抛异常而不是返回null。这同时也使得Peek()的返回类型无需是int? ， 而是确定的int类型。
        return stackPeek!.val;
    }
    //将 List 转化为 Array 并返回
    public int[] ToArray()  //ToArray() 的语义是"读取"，不应该有任何副作用，不应影响到原来的栈。
    {
        if (IsEmpty())
        {
            return []; // 推荐的老写法，性能更好return Array.Empty<int>();或者 return new int[0];。
        }

        int[] res = new int[Size()];
        ListNode node = stackPeek;    //用一个局部变量做遍历指针，不要动 stackPeek,不要影响到原来的栈。
        for (int i = res.Length - 1; i >= 0 ; i--) //挺好，看清楚，这里是从链表头节点（栈顶）开始，往array里塞元素，即头节点会塞到res[res.Length - 1]里。原因是和数组实现的栈保持一致。数组实现天然是"尾部 = 栈顶"，因为在尾部 push/pop 是 O(1)，不需要移动元素。所以 ToArray() 输出 [1, 2, 3]（栈顶在末尾），两种实现的对外行为就完全统一了。无论链表实现还是数组实现，ToArray() 结果都是：[底部元素, ..., 栈顶元素]。
        {
            res[i] = node.val;  // ← 用临时变量遍历
            node = node.next;   // ← 移动临时变量，不碰 stackPeek
        }

        return res;
    }
}
*/
    }
}
