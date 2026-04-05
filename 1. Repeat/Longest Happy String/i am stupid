public class Solution {
    public string LongestDiverseString(int a, int b, int c) {
        var pq = new PriorityQueue<(char ch, int count), int>();

        if (a > 0) pq.Enqueue(('a', a), -a);
        if (b > 0) pq.Enqueue(('b', b), -b);
        if (c > 0) pq.Enqueue(('c', c), -c);

        string result = "";

        while (pq.Count > 0) {
            pq.TryDequeue(out var first, out _);

            int n = result.Length;

            // If last two characters are same as current
            if (n >= 2 && result[n - 1] == first.ch && result[n - 2] == first.ch) {
                if (pq.Count == 0) break;

                pq.TryDequeue(out var second, out _);

                result += second.ch;
                second.count--;

                if (second.count > 0)
                    pq.Enqueue(second, -second.count);

                // push first back
                pq.Enqueue(first, -first.count);
            } else {
                result += first.ch;
                first.count--;

                if (first.count > 0)
                    pq.Enqueue(first, -first.count);
            }
        }

        return result;
    }
}