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
    public int MinMeetingRooms(List<Interval> intervals)
    {
        if (intervals.Count() == 0) return 0;
        intervals.Sort((a, b) => { return a.start - b.start; });
        int ret = 1;
        List<int> ListOfEnds = new List<int>();
        ListOfEnds.Add(intervals[0].end);
        //check through all intervals
        for (int i = 1; i < intervals.Count(); i++)
        {
            //iterate through list of ends
            for (int j = 0; j < ListOfEnds.Count(); j++)
            {
                // check whether there is an element in the ListOfEnds having a value less than  or equal to 
                //the current interval's start or not
                //if yes, make the element have the same value as the current interval's end and break this loop
                if (intervals[i].start >= ListOfEnds[j])
                {
                    ListOfEnds[j] = intervals[i].end;
                    ListOfEnds.Sort();
                    break;
                }//if not present and you have reached list of ends
                else if (j == ListOfEnds.Count() - 1)
                {
                    //increment ret, and add current interval's end to the ListOfEnds
                    ret++;
                    ListOfEnds.Add(intervals[i].end);
                    break;
                }
            }
        }
        return ret;
    }
}
