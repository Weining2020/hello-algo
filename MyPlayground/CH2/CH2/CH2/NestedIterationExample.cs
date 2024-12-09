/*
//我自己写的嵌套循环例子。
using System.Text;
string myString = NestedIteration(5);
Console.WriteLine(myString);
string NestedIteration(int x)   //能看出来这个NestedIteration()的时间复杂度是n^2。
{
    StringBuilder sb = new StringBuilder();
    for (int i = 1; i < x + 1; i++)
    {
        for (int j = 0; j < x + 1; j++)
        {
            sb.Append($"{i}, {j}, ");
        }
    }
    return sb.ToString();
}
*/