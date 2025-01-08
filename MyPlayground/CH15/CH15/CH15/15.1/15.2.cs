/*



//分数背包：贪心。
double FractionalKnapsack(int[] wgt, int[] val, int cap)
{
    int n = wgt.Length;
    Item[] items = new Item[n];
    for (global::System.Int32 i = 0; i < n; i++)
    {
        items[i] = new Item(wgt[i], val[i]);
    }
    Array.Sort(items, ((x, y) => (y.v / y.w).CompareTo(x.v / x.w))); //后面的这一整个(x, y) => (y.v / y.w).CompareTo(x.v / x.w)是Sort()的第二个参数。//在 C# 中，Array.Sort 默认是从小到大(按照 instanceX.CompareTo()返回的结果）排序，可这里是y作为instance调用CompateTo()与x比较，即与正常的x作为instance与y比较正好相反。因此本题的这种写法刚好实现了按XXX的单位重量价值 从大到小排序。

    double res = 0;
    foreach (Item item in items)
    {
        if (item.w <= cap)
        {
            res += item.v;
            cap -= item.w;
        }
        else
        {
            res += (double)(item.v / item.w) * item.v;
            break;
        }
    }

    return res;

}
//物品。
class Item(int w, int v)
{
    public int w = w; // 物品重量
    public int v = v; // 物品价值
}

*/