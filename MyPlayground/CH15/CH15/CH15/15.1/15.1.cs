/*
//零钱兑换：贪心。
int CoinChangeGreedy(int[] coins, int amt)
{
    int i = coins.Length - 1;
    int count = 0;

    while (amt > 0)
    {
        while (i > 0 && coins[i] > amt)
        {
            i--;
        }

        //跳出 内层while循环意味着找到了选择，虽然这个选择可能直接导致amt < 0（即选择该硬币会超出额度）。
        amt -= coins[i];
        count++;
    }

    return amt == 0 ? count : -1;
}
*/