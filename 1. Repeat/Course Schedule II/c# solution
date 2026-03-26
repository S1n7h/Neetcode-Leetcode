public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var prereq = new Dictionary<int, List<int>>();
        var cycle = new HashSet<int>();
        var visited = new Dictionary<int, bool>();
        var ret = new List<int>();

        for(int i = 0 ; i < numCourses ; i++)  visited[i] = false;
        for(int i = 0 ; i < prerequisites.Length ; i++){
            if (!prereq.ContainsKey(prerequisites[i][0]))
                prereq[prerequisites[i][0]] = new List<int>();
            prereq[prerequisites[i][0]].Add(prerequisites[i][1]);
        }

        foreach(var pair in prereq){
            Console.Write($"Key: {pair.Key} - ");
            foreach(var item in pair.Value)    Console.Write($"{item} ");
            Console.WriteLine();
        }

        for (int i = 0 ; i < numCourses ; i++){
            if (!Dfs(prereq, visited, ret, i, cycle)){
                ret.Clear();
                return ret.ToArray();
            }
        }
        for(int i = 0 ; i < numCourses ; i++){
            if (!ret.Contains(i))   ret.Add(i);
        }
        return ret.ToArray();    
    }

    bool Dfs(Dictionary<int, List<int>> prereq, Dictionary<int, bool> visited, 
            List<int> ret, int course, HashSet<int> cycle){
        
        //cycle detected
        if (cycle.Contains(course)) return false;

        //course has been visited AND said course wasn't a part of a cycle
        if (visited[course])    return true;      
        
        cycle.Add(course);
        if (prereq.ContainsKey(course)){
            foreach(var crs in prereq[course]){
                if (!Dfs(prereq, visited, ret, crs, cycle))
                    return false;
            }
        }

        cycle.Remove(course);
        visited[course] = true;
        ret.Add(course);        
        return true;
    }
}