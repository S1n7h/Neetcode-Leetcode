public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        var dict = new Dictionary<char, int>();

        foreach(var task in tasks){
            if (!dict.ContainsKey(task))    dict[task] = 0;
            dict[task]++;
        }

        var pq = new PriorityQueue<int, int>();
        var q = new Queue<(int, int)>();

        foreach(var key in dict.Keys){
            pq.Enqueue(-dict[key], -dict[key]);
        }

        int time = 0;
        
        while(pq.Count != 0 || q.Count != 0){
            time++;            
            if (pq.TryDequeue(out int top, out int priority))
                if (top + 1 != 0) 
                    q.Enqueue((top + 1, time + n));

            while(q.Count != 0 && q.Peek().Item2 == time){
                int count = q.Dequeue().Item1;
                pq.Enqueue(count, count);
            }
        }return time;
    }
}
