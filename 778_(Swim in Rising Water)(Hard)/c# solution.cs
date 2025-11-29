public class Solution
{
    void Insert(ref int[][] grid, ref PriorityQueue<(int, int), int> q, int r, int c, int prev_priority)
    {
        //you update priority in a way such that the priority is basically the highest peak among all the indexes travelled
        //before reaching that node. you aren't tracking the time, instead, you track the highest peak encountered up until
        //now. that's the trick.
        if (prev_priority >= grid[r][c])
        {
            q.Enqueue((r, c), prev_priority);
        }
        else q.Enqueue((r, c), grid[r][c]);
        Console.WriteLine($"    x:{r}  y:{c}  value:{grid[r][c]}");
    }
    bool IsValid(ref int[][] grid, int curr_r, int curr_c, int r, int c)
    {
        //check whether within bounds or not
        if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length) return false;

        //check whether visited or not
        if (grid[r][c] == -1) return false;

        return true;
    }
    public int SwimInWater(int[][] grid)
    {
        //using a priority queue because using a queue doesn't let you control which object is present at the top of the 
        //queue especially since this question requires you to make adjustments based on certain priorities.
        var q = new PriorityQueue<(int, int), int>();
        q.Enqueue(new(0, 0), 0);

        while (q.Count != 0)
        {
            int Size = q.Count;
            for (int i = 0; i < Size; i++)
            {
                //the priority is basically the total time it would take to reach that node
                q.TryDequeue(out (int, int) coordinates, out int priority);
                int r = coordinates.Item1;
                int c = coordinates.Item2;

                if (r == grid.Length - 1 && c == grid.Length - 1) return priority;
                Console.WriteLine($"Curr Node--> x:{r}  y:{c}  value:{grid[r][c]}");

                if (IsValid(ref grid, r, c, r + 1, c))
                    Insert(ref grid, ref q, r + 1, c, priority);

                if (IsValid(ref grid, r, c, r - 1, c))
                    Insert(ref grid, ref q, r - 1, c, priority);

                if (IsValid(ref grid, r, c, r, c + 1))
                {
                    Insert(ref grid, ref q, r, c + 1, priority);
                    Console.Write("Reaching here.");
                }

                if (IsValid(ref grid, r, c, r, c - 1))
                    Insert(ref grid, ref q, r, c - 1, priority);

                //once explored, mark it as visited 
                grid[r][c] = -1;
                Console.WriteLine();
            }
        }
        return 0;
    }
}