/*
 
//next字段是私有啊，这写的这些方法都会报错啊。难道是教程 只是在 初始化链表那里的class中用的私有next字段，而其他时候要用到ListNode类时，在类声明中next都是共有字段？
void InsertLinkedList (ListNode n0, ListNode p)
{
    ListNode n1 = n0.next;
    p.next = n1;
    n0.next = p;
}

void DeleteLinkedList(ListNode n0)
{
    ListNode P = n0.next;
    ListNode n1 = P.next;
    n0.next = n1;
}

//public class ListNode
//{
//    int val;
//    ListNode? next;
//    public ListNode(int x)
//    {
//        val = x;
//    }
//}
class ListNode(int x)
{  //构造函数
    int val = x;         // 节点值
    ListNode? next;      // 指向下一节点的引用
}
*/