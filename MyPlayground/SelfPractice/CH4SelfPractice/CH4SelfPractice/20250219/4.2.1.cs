/*
using CH4SelfPractice.utils.ListNode;

//1.初始化LinkedList。
ListNode node0 = new ListNode(0);
ListNode node1 = new ListNode(1);
ListNode node2 = new ListNode(2);
ListNode node3 = new ListNode(3);
ListNode node4 = new ListNode(4);

node0.next = node1;
node1.next = node2;
node2.next = node3;
node3.next = node4;

//2.随机访问。不可能。

//2.添加节点。
void Insert(ListNode n0, ListNode p)
{
    ListNode? n1 = n0.next;
    p.next = n1;
    n1.next = p;
}

//3.删除节点。
void Remove(ListNode n0)
{
    if (n0.next == null)
    {
        return;
    }
    ListNode p = n0.next;
    ListNode? n1 = p.next;
    n0.next = n1;
}



//4.访问节点。
ListNode? Access(ListNode? head, int index)
{
    for (global::System.Int32 i = 0; i < index; i++)
    {
        if (head == null)
        {
            return null;
        }
        head = head.next;
    }
    return head;
}

//5.查找节点。
int Find(ListNode? head, int target)
{
    int index = 0;
    while (head != null)
    {
        if (head.val == target)
        {
            return index;
        }
        head = head.next;
        index++;
    }
    return -1;

}
*/