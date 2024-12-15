/*
//我没验算。
int num = 3;
int hashNum = num.GetHashCode();
// 整数 3 的哈希值为 3;

bool bol = true;
int hashBol = bol.GetHashCode();
// 布尔量 true 的哈希值为 1;

double dec = 3.14159;
int hashDec = dec.GetHashCode();
// 小数 3.14159 的哈希值为 -1340954729;

string str = "Hello 算法";
int hashStr = str.GetHashCode();
// 字符串“Hello 算法”的哈希值为 -586107568;

object[] arr = [12836, "小哈"];
int hashTup = arr.GetHashCode();
// 数组 [12836, 小哈] 的哈希值为 42931033;

ListNode obj = new(0);
int hashObj = obj.GetHashCode();
// 节点对象 0 的哈希值为 39053774;

public class ListNode //为了防止报错。
{
    int val;
    ListNode? next;
    public ListNode(int n)
    {
        val = n;
    }
}
*/