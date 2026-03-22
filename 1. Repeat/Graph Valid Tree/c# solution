public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        if (edges.Length != n - 1)  return false;
        if (n == 1) return true;
        var graph = new Dictionary<int, List<int>>();
        for (int r = 0 ; r < edges.Length ; r++){
            if (!graph.ContainsKey(edges[r][0]))    graph[edges[r][0]] = new List<int>();
            graph[edges[r][0]].Add(edges[r][1]);
            if (!graph.ContainsKey(edges[r][1]))    graph[edges[r][1]] = new List<int>();
            graph[edges[r][1]].Add(edges[r][0]);
        }
        foreach(var pair in graph){
            Console.Write($"Key:{pair.Key}   Values:");
            foreach(var val in pair.Value)  Console.Write($"{val} ,");
            Console.WriteLine();
        }
        var visited = new Dictionary<int, bool>();

        int traversed = 0;
        foreach(var pair in graph){
            var root = pair.Key;
            if (!Dfs(graph, visited, -1, root, ref traversed)) return false;
            break;
        }
        if (n != traversed) return false;
        return true;
    }

    bool Dfs(Dictionary<int, List<int>> graph, Dictionary<int, bool> visited, int parent, int node, ref int traversed){
        if (!visited.ContainsKey(node)) visited[node] = true;
        traversed++;

        foreach(var child in graph[node]){
            if (child == parent)    continue;
            if (visited.ContainsKey(child)) return false;
            if (graph.ContainsKey(child)){
                if(!Dfs(graph, visited, node, child, ref traversed)) return false;
            }
        }
        return true;
    }
}