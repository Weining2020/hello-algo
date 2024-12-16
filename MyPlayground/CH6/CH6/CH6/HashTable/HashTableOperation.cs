/*

Console.OutputEncoding = System.Text.Encoding.UTF8; // 设置控制台为 UTF-8，这样我的Console才能正常打印出汉字。
// 哈希表常用操作。

//初始化哈希表。//初始化器的写法可以再看看。
Dictionary<int, string> map = new Dictionary<int, string>()
{
    //添加操作。
    {12836, "小哈" },
    { 15937, "小啰" },
    { 16750, "小算" },
    { 13276, "小法" },
    { 10583, "小鸭" }
};

//添加操作。
map.Add(1, "Livy");

//查询操作。
string name = map[15937];
//Console.WriteLine(name);

//删除操作。//删除操作的写法可以再看看。
map.Remove(10583);
//三种遍历方法都没咋见过。
//遍历方式一,遍历键值对 Key->Value
foreach (var kv in map)
{
    Console.WriteLine(kv.Key + "->" + kv.Value);
}

//遍历方式二, 单独遍历键 key
foreach (var key in map.Keys)
{
    Console.WriteLine(key);
}
//遍历方式三, 单独遍历值 value
foreach (var val in map.Values)
{
    Console.WriteLine(val);
}
*/