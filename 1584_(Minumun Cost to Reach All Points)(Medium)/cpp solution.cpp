class Solution
{
    public:
    int minCostConnectPoints(vector<vector<int>>& points)
    {
        vector<int> Distance(points.size(), INT_MAX);
        vector<bool> visited(points.size(), false);

        int ret = 0, node = 0;
        for (int i = 0; i < points.size() - 1; i++)
        {
            int Nextnode = -1;
            visited[node] = true;
            for (int j = 0; j < points.size(); j++)
            {
                if (visited[j]) continue;
                int distance = abs(points[j][0] - points[node][0]) + abs(points[j][1] - points[node][1]);
                Distance[j] = min(Distance[j], distance);
                if (Nextnode == -1 || Distance[j] < Distance[Nextnode])
                {
                    Nextnode = j;
                }
            }
            ret += Distance[Nextnode];
            node = Nextnode;
        }
        return ret;
    }
};
