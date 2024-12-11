//0.ListNode声明在最下面，为了保证编译器不报错。

//1.初始化。
//ListNode n0 = new ListNode(1);
//ListNode n1 = new ListNode(3);
//ListNode n2 = new ListNode(2);
//ListNode n3 = new ListNode(5);
//ListNode n4 = new ListNode(4);
//n0.next = n1;
//n1.next = n2;
//n2.next = n3;
//n3.next = n4;

//2.增加节点。
//void Insert(ListNode n0, ListNode P)
//{
//    ListNode n1 = n0.next;
//    P.next = n1;
//    n0.next = P;
//}

//3.删除。
//void Delete(ListNode n0)
//{
//    if (n0.next == null) return;
//    ListNode P = n0.next;
//    ListNode? n1 = P.next;
//    n0.next = n1;
//}

//4.访问。
//ListNode? Access(ListNode? head, int index)
//{
//    for (global::System.Int32 i = 0; i < index; i++)
//    {
//        if (head == null)
//        {
//            return null;
//        }
//        head = head.next;
//    }
//    return head;
//}

//5.查询。
//int Find(ListNode? head, int n)
//{
//    int index = 0;
//    while (head != null)
//    {
//        if (head.val == n) return index;

//        head = head.next;
//        index++;
//    }
//    return -1;
//}

//0.ListNode的声明。
//public class ListNode
//{
//    public int val;
//    public ListNode? next;

//    public ListNode(int x)
//    {
//        val = x;
//    }
//}