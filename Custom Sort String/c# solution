public class Solution {
    public string CustomSortString(string order, string s) {
        if (s.Length == 0) return "";
        if (order.Length == 0){
            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }
        Queue <char> q = new Queue<char>();
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach(var character in order) q.Enqueue(character);

        foreach(var ch in s){
            if (!dict.ContainsKey(ch))  dict[ch] = 1;
            else dict[ch]++;
        }

        string ret = "";

        while(q.Count() > 0){
            if (dict.ContainsKey(q.Peek())){
                for(int i = 0 ; i < dict[q.Peek()] ; i++){
                    ret += q.Peek();
                }dict.Remove(q.Peek());
            }q.Dequeue();
        }

        foreach(var key in dict.Keys){
            for(int i = 0 ; i < dict[key] ; i++){
                ret += key;
            }
        }
        return ret;
    }
}