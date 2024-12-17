/*
//初始化堆。

//初始化小顶堆。
//注意！！在 C# 的 PriorityQueue<TElement, TPriority> 中，比较器（Comparer<TPriority>）是根据 Priority 的值来比较两个元素的优先级，而不是直接比较 Element 的值。
PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>(); //PriorityQueue<TElement, TPriority> 默认实现的是 小顶堆。因此这里的调用构造器没有传参。在没有提供 Comparer<T> 的情况下，PriorityQueue 使用 默认的比较器（Comparer<T>.Default）来比较优先级。对于 int 类型，Comparer<int>.Default 是按升序排序，即最小值具有最高优先级。
//初始化大顶堆（使用 lambda 表达式修改 Comparer 即可）。
PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x))); //这里Comparer<int>.Create()这个静态方法接收一个Comparison<int>类型的实例（鼠标放Create上看到的），而Comparison<int>类型是一个内置委托类型型，其签名为：public delegate int Comparison<in T>(T x, T y);。Create()接收的comparison参数，只要是满足输入两个int，能返回一个int的方法就行，而对于我们写的lambda表达式，刚好方法体内y.CompareTo(x)就能返回一个int，因此整个lambda表达式满足了作为comparison的要求，而成为了Create()的参数。
//注意！！y.CompareTo(x)是y-x。在大顶堆中，我们要和小顶堆相反，即需要最大值拥有最高优先级。当比较器返回负值时，意味着y-x<0，即y<x，此时x比y优先级更高；当比较器返回正值时，意味着y-x>0，即y>x，此时y比x优先级更高。因此，对于两个元素之间的比较，本例中的比较器返回负值时，x比y优先级更高；本例中的比较器返回正值时，y比x优先级更高。总之，比较器返回的 负值/正值 会作为一个信号，诉 PriorityQueue 如何排列两个元素。

//元素入堆。
maxHeap.Enqueue(1, 1);
maxHeap.Enqueue(3, 3);
maxHeap.Enqueue(2, 2);
maxHeap.Enqueue(5, 5);
maxHeap.Enqueue(4, 4);

//获取堆顶元素。
int peek = maxHeap.Peek(); //5。

//堆顶元素出堆。
//出堆元素会形成一个从大到小的序列。//这句话说的不清楚。本意是：每次出堆操作都会移除当前的最大值（大顶堆）或最小值（小顶堆）。堆会自动重新调整，使得剩余元素中的最大值或最小值成为新的堆顶。如果用个集合装载maxHeap.Dequeue();多次执行的结果，那个集合会是有序的。
peek = maxHeap.Dequeue();  // 5
peek = maxHeap.Dequeue();  // 4
peek = maxHeap.Dequeue();  // 3
peek = maxHeap.Dequeue();  // 2
peek = maxHeap.Dequeue();  // 1

//获取堆大小。
int size = maxHeap.Count;

//判断堆是否为空。
bool isEmpty = maxHeap.Count == 0;

//输入列表并建堆。//我仔细问过想过，这里应该是输入数组并建堆，而不是列表。
minHeap = new PriorityQueue<int, int>([(1, 1), (3, 3), (2, 2), (5, 5), (4, 4)]); //这里是调用了 PriorityQueue<TElement, TPriority> 类的其中一个构造器，这个构造器要求传入一个 IEnumerable<ValueTuple<TElement, TPriority>> 类型的集合。ValueTuple 是 C# 内置的值类型元组，(1, 2) 这种形式即为 ValueTuple。
*/