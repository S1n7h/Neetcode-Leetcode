public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var ret = new List<int[]>();

        if (newInterval[1] < intervals[0][0])
        {
            ret.Add(newInterval);
            ret.AddRange(intervals);
            return ret.ToArray();
        }
        if (newInterval[0] > intervals[intervals.Length - 1][1])
        {
            ret.AddRange(intervals);
            ret.Add(newInterval);
            return ret.ToArray();
        }
        bool flag = false;
        for (int i = 0; i < intervals.Length; i++)
        {
            //flag is to check whether you have already passed the interval or not
            if (flag) ret.Add(intervals[i]);
            else
            {
                //there is some sort of an overlap
                if (newInterval[0] <= intervals[i][1] && intervals[i][0] <= newInterval[1])
                {
                    newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                    newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
                    if (i == intervals.Length - 1) ret.Add(newInterval);
                }
                //no overlap, but before the interval in inserted (flag is not true)
                else
                {
                    //check whether current interval is present before the newInterval
                    //if yes, add interval
                    if (intervals[i][1] < newInterval[0]) ret.Add(intervals[i]);
                    //else add newInterval, toggle flag
                    else
                    {
                        ret.Add(newInterval);
                        ret.Add(intervals[i]);
                        flag = true;
                    }
                }
            }
        }
        return ret.ToArray();
    }
}