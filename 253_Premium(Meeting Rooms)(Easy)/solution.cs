/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution
{
    public bool CanAttendMeetings(List<Interval> intervals)
    {
        intervals.Sort((a, b) => { return a.start - b.start; });
        for (int i = 1; i < intervals.Count(); i++)
        {
            var previousInterval = intervals[i - 1];
            var currInterval = intervals[i];

            if (previousInterval.start < currInterval.end && currInterval.start < previousInterval.end) return false;
        }
        return true;
    }
}
