/*
//初始化堆
// 初始化小顶堆
PriorityQueue<int, int> minHeap = new();
// 初始化大顶堆（使用 lambda 表达式修改 Comparer 即可）
PriorityQueue<int, int> maxHeap = new(Comparer<int>.Create((x, y) => y.CompareTo(x)));

//元素入堆
maxHeap.Enqueue(1, 1);
maxHeap.Enqueue(3, 3);
maxHeap.Enqueue(2, 2);
maxHeap.Enqueue(5, 5);
maxHeap.Enqueue(4, 4);

//获取堆顶元素
int peek = maxHeap.Peek();//5

//堆顶元素出堆
// 出堆元素会形成一个从大到小的序列
peek = maxHeap.Dequeue();  // 5
peek = maxHeap.Dequeue();  // 4
peek = maxHeap.Dequeue();  // 3
peek = maxHeap.Dequeue();  // 2
peek = maxHeap.Dequeue();  // 1

//获取堆大小
int size = maxHeap.Count;

//判断堆是否为空
bool isEmpty = maxHeap.Count == 0;

//输入列表并建堆
minHeap = new PriorityQueue<int, int>([(1, 1), (3, 3), (2, 2), (5, 5), (4, 4)]);
*/