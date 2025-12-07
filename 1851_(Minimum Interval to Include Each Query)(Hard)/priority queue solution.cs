public class Solution
{
    public int[] MinInterval(int[][] intervals, int[] queries)
    {
        if (intervals.Count() == 0) return new int[] { };
        Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });
        var returnArray = new int[queries.Count()];
        PriorityQueue<int, int> minQ = new PriorityQueue<int, int>();

        for (int i = 0; i < intervals.Count(); i++)
        {
            //start is the element stored in minQ, length is the priority, so small length is preferred
            minQ.Enqueue(intervals[i][0], intervals[i][1] - intervals[i][0] + 1);
        }

        for (int i = 0; i < queries.Count(); i++)
        {
            int curr_query = queries[i];
            //if SearchQueue returns false, add the end of current interval to the queue
            if (SearchQueue(curr_query, minQ) == -1)
            {
                returnArray[i] = -1;
            }
            else
            {
                returnArray[i] = SearchQueue(curr_query, minQ);
            }
        }
        return returnArray;
    }
    private int SearchQueue(int query, PriorityQueue<int, int> minQ)
    {
        //a base case which if met the criteria means that you have popped all the elements of the minQ
        if (minQ.Count == 0)
        {
            return -1;
        }
        minQ.TryDequeue(out int start, out int length_priority);
        if (start <= query && query <= start + length_priority - 1)
        {
            minQ.Enqueue(start, length_priority);
            return length_priority;
        }
        int ret = SearchQueue(query, minQ);
        minQ.Enqueue(start, length_priority);
        return ret;
    }
}
