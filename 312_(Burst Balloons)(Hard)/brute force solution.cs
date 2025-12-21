public class Solution
{
    public int MaxCoins(int[] nums)
    {
        var dict = new Dictionary<(int, (int, int)), int>();
        var list = nums.ToList();

        return DfsWithMemo(dict, list);
    }

    int DfsWithoutMemo(Dictionary<(int, (int, int)), int> dict, List<int> list)
    {
        if (list.Count() == 0) return 0;
        int ret = 0;
        var tempList = new List<int>();

        foreach (var item in list) tempList.Add(item);

        for (int i = 0; i < tempList.Count(); i++)
        {
            int before, curr, after;

            if (i == 0)
            {
                before = 1;
                curr = list[0];
                if (list.Count() == 1) after = 1;
                else after = list[i + 1];
            }
            else if (i == list.Count() - 1)
            {
                if (i - 1 < 0) before = 1;
                else before = list[i - 1];
                curr = list[i];
                after = 1;
            }
            else
            {
                before = list[i - 1];
                curr = list[i];
                after = list[i + 1];
            }
            int product = before * curr * after;
            list.RemoveAt(i);

            //dict.Add((before, (curr, after)), product);
            ret = Math.Max(ret, product + DfsWithMemo(dict, list));

            list.Insert(i, curr);
        }
        return ret;
    }
}