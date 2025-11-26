public class Solution
{
    int ret = 0;
    public int NetworkDelayTime(int[][] times, int n, int k)
    {
        var graph = new Dictionary<int, List<(int, int)>>();
        int[] visited = new int[n + 1];
        var q = new Queue<(int, int)>();

        foreach (int[] edge in times)
        {
            if (!graph.ContainsKey(edge[0]))
                graph[edge[0]] = new List<(int, int)>();
            graph[edge[0]].Add(new(edge[1], edge[2]));
        }

        //foreach (var pair in graph)
        //{
        //    Console.WriteLine($"{pair.Key}");
        //    foreach (var edge in pair.Value)
        //    {
        //        Console.WriteLine($"{edge.Item1}, {edge.Item2}");
        //    }
        //}
        for (int i = 1; i <= n; i++) visited[i] = int.MaxValue;
        q.Enqueue(new(k, 0));
        visited[k] = 0;
        while (q.Count != 0)
        {
            int Size = q.Count;
            for (int i = 0; i < Size; i++)
            {
                (int, int) curr_edge = q.Dequeue();
                int curr_node = curr_edge.Item1; //k
                int curr_time = curr_edge.Item2; //0

                if (!graph.ContainsKey(curr_node)) continue;
                //pair contains the nodes and time attached to reach that node from the current node
                foreach (var pairs in graph[curr_node])
                {
                    //Already found shorter path
                    if (curr_time + pairs.Item2 >= visited[pairs.Item1]) continue;
                    visited[pairs.Item1] = curr_time + pairs.Item2;
                    q.Enqueue((pairs.Item1, visited[pairs.Item1]));
                }
            }
        }
        foreach (var hoo in visited)
        {
            Console.WriteLine($"{hoo}");
            if (hoo == int.MaxValue) return -1;
            ret = Math.Max(hoo, ret);
        }
        return ret;
    }
}