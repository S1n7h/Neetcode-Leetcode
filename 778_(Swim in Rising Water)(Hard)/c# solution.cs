public class Solution
{
    void Insert(ref int[][] grid, ref PriorityQueue<(int, int), int> q, int r, int c, int prev_priority)
    {
        if (prev_priority >= grid[r][c])
        {
            q.Enqueue((r, c), prev_priority);
        }
        else q.Enqueue((r, c), grid[r][c]);
        Console.WriteLine($"    x:{r}  y:{c}  value:{grid[r][c]}");
    }
    bool IsValid(ref int[][] grid, int curr_r, int curr_c, int r, int c)
    {
        if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length) return false;

        if (grid[r][c] == -1) return false;

        return true;
    }
    public int SwimInWater(int[][] grid)
    {
        var q = new PriorityQueue<(int, int), int>();
        q.Enqueue(new(0, 0), 0);

        while (q.Count != 0)
        {
            int Size = q.Count;
            for (int i = 0; i < Size; i++)
            {
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

                grid[r][c] = -1;
                Console.WriteLine();
            }
        }
        return 0;
    }
}