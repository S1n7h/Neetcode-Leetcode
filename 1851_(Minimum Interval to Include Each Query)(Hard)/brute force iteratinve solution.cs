public class Solution
{
    public int[] MinInterval(int[][] intervals, int[] queries)
    {
        Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });
        var returnArray = new int[queries.Count()];

        //iterate through queries
        for (int i = 0; i < queries.Count(); i++)
        {
            int ret = -1;
            int j = 0;
            while (j < intervals.Count())
            {
                if (intervals[j][0] > queries[i]) break;
                else
                {
                    //check whether query is present within the interval at j
                    if (intervals[j][0] <= queries[i] && queries[i] <= intervals[j][1])
                    {
                        //if yes, update ret accordingly
                        if (ret == -1) ret = intervals[j][1] - intervals[j][0] + 1;
                        else ret = Math.Min(ret, intervals[j][1] - intervals[j][0] + 1);
                    }
                }
                j++;
            }
            returnArray[i] = ret;
        }
        return returnArray;
    }
}
