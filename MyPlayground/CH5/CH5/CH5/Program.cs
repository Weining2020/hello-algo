//C# 中的 LinkedList<T> 是一种实现了 双向链表（Doubly Linked List）的数据结构，而不是简单的单向链表（Singly Linked List）。教程中通过自制的 ListNode 单向链表来实现队列/栈，而没有使用 C# 内置的 LinkedList<T> 双向链表，主要原因确实是 队列本质上只需要单向链表即可实现。内置 LinkedList<T> 是双向链表，功能上有些多余，并且它的实现会占用额外的内存（每个节点需要两个指针：Previous 和 Next），而队列只需要前向链接即可满足功能需求。

// 双向队列常用操作。
LinkedList<int> deque = new LinkedList<int>();

//元素入队。//没见过这些入队操作，记忆一下。
deque.AddLast(2);
deque.AddLast(5);
deque.AddLast(4);
deque.AddFirst(3);
deque.AddFirst(1);

//访问元素。 //没见过这些访问操作，记忆一下。
int peekFirst = deque.First.Value;
int peekLast = deque.Last.Value;

//元素出队。//没见过这些出队操作，记忆一下。
deque.RemoveFirst();
deque.RemoveLast();