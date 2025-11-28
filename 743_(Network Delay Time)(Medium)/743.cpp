class Solution {
public:
    int networkDelayTime(vector<vector<int>>& times, int n, int k) {
        vector<vector<pair<int, int>>> neighbours(n + 1);
        vector<int> visited(n + 1, INT_MAX);

        for (auto& triplets : times){
            neighbours[triplets[0]].push_back({triplets[1], triplets[2]});
        }
        
        priority_queue<pair<int, int>, vector<pair<int,int>>, greater<pair<int,int>>> q;
        q.push({0, k});

        while(!q.empty()){
            int Size = q.size();
            for (int i = 0 ; i < Size ; i++){
                auto front = q.top();
                q.pop();
                int time_taken = front.first;
                int curr = front.second;
                
                if (time_taken >= visited[curr]) continue; // already found a shorter path
                visited[curr] = time_taken;

                for (auto& edge : neighbours[curr]){
                    q.push({edge.second + time_taken, edge.first});                
                }
            }
        }int t = 0;
        for (int i = 1; i <= n; i++) {
            if (visited[i] == INT_MAX) return -1; // unreachable node
            t = max(t, visited[i]);
        }

        return t;
    }
};
