public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Count() == 0) return intervals;
        Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });

        var ret = new List<int[]>();

        var dummy = new int[] { intervals[0][0], intervals[0][1] };

        for (int i = 1; i < intervals.Count(); i++)
        {
            //if overlap
            if (dummy[0] <= intervals[i][1] && intervals[i][0] <= dummy[1])
            {
                //change dummy
                dummy[0] = Math.Min(dummy[0], intervals[i][0]);
                dummy[1] = Math.Max(dummy[1], intervals[i][1]);
            }
            else
            {
                //insert dumy and make dummy = current interval
                Console.WriteLine($"{dummy[0]}, {dummy[1]}");
                ret.Add(dummy);
                dummy = new int[2];
                dummy[0] = intervals[i][0];
                dummy[1] = intervals[i][1];
                Console.WriteLine($"{dummy[0]}, {dummy[1]}");
            }
        }
        ret.Add(dummy);
        foreach (var interval in ret)
        {
            Console.WriteLine($"{interval[0]}, {interval[1]}");
        }
        return ret.ToArray();
    }
}