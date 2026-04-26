using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH8
{
    internal class _811
    {/*
// 初始化小顶堆
PriorityQueue<int, int> minHeap = new(); //不可以写成“PriorityQueue<int, int> minHeap = [];”，[] 集合表达式只能用于实现了 ICollection<T> 接口的类型，比如 List<T>、HashSet<T> 等 。PriorityQueue<TElement, TPriority> 没有实现这个接口，所以编译器不知道如何用 [] 初始化它，直接报错。
// 初始化大顶堆（使用 lambda 表达式修改 Comparer 即可）
PriorityQueue<int, int> maxHeap = new(Comparer<int>.Create((x, y) => y.CompareTo(x))); //20260425补充：要理解这个“传入的比较器”，首先必须理解PriorityQueue的内部逻辑，只有一条：PriorityQueue 完全盲目地信任比较器，PriorityQueue不理解"大"和"小"，不理解数字含义，PriorityQueue只看比较器返回的正负。“比较器XXX（比如 Compare(x, y) ）” 返回负数，就代表比较器给出结论 x和y比较得到了负数（具体如何比较无所谓），PriorityQueue此时就认为 x 应该排在 y 前面（先出队）。而我们可以通过传给PriorityQueue 不同的比较器，来控制PriorityQueue的行为，因为比较器重新定义了如何返回正值负值，而PriorityQueue只关心 比较器返回的正值负值。//接着，我们讲解“Comparer<int>.Create((x, y) => y.CompareTo(x))”的语法细节。第一层，Create 是 Comparer<int> 的静态工厂方法，签名时“public static Comparer<T> Create(Comparison<T> comparison);”，它接收一个 Comparison<int> 类型的参数。第二层，Comparison<T> 是 C# 内置的一个委托类型（delegate），定义如下：“public delegate int Comparison<in T>(T x, T y);”，就是"接受两个 int 参数、返回 int"的委托。第三层，“(x, y) => y.CompareTo(x)”，这是一个 lambda 表达式，C# 会自动把它转换成 Comparison<int> 委托的实例。lambda 写法（你看到的）：“(x, y) => y.CompareTo(x)”。匿名方法写法（等价）：delegate(int x, int y) { return y.CompareTo(x); }。具名方法写法（等价）：int MyCompare(int x, int y) { return y.CompareTo(x); }。

//元素入堆
maxHeap.Enqueue(1, 1);
maxHeap.Enqueue(3, 3);
maxHeap.Enqueue(2, 2);
maxHeap.Enqueue(5, 5);
maxHeap.Enqueue(4, 4);

//获取堆顶元素
int peek = maxHeap.Peek();

//堆顶元素出堆
//出堆元素会形成一个从大到小的序列
peek = maxHeap.Dequeue();   //5
peek = maxHeap.Dequeue();   //4
peek = maxHeap.Dequeue();   //3
peek = maxHeap.Dequeue();   //2
peek = maxHeap.Dequeue();   //1

//获取堆大小
int size = maxHeap.Count;

//判断堆是否为空
bool isEmpty = maxHeap.Count == 0;

//输入列表并建堆
minHeap = new PriorityQueue<int, int>([(1, 1), (3, 3), (2, 2), (5, 5), (4, 4)]); //这部分，这里其实真正有业务逻辑的是第一项的数字，但是优先队列要求优先级数字，因此才必须得捆绑着第二项数字，也就是这种ValueTuple形式。//20260425补充：这部分，这里其实真正有业务逻辑的是第一项的数字，但是优先队列要求优先级数字，因此才必须得捆绑着第二项数字，也就是这种ValueTuple形式。
*/
    }
}
