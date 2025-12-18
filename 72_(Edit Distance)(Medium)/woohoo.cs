public class Solution {
    //figured out a significant portion, but got stuck with when to do what
    public int MinDistance(string word1, string word2) {
        var dict = new Dictionary<(int, int), int>();
        return DfsWithMemo(word1, word2, 0, 0, dict);
    }

    private int DfsWithMemo(string word1, string word2, int i, int j, Dictionary<(int, int), int> dict){
        if (i == word1.Length && j == word2.Length)  return 0;
        if (i == word1.Length)  return word2.Length - j;
        if (j == word2.Length)  return word1.Length - i;

        int ret = 0;

        if (word1[i] == word2[j])   ret = DfsWithMemo(word1, word2, i + 1, j + 1, dict);

        else{
        int replace = 1 + DfsWithMemo(word1, word2, i + 1, j + 1, dict);
        int delete = 1 + DfsWithMemo(word1, word2, i + 1, j, dict);
        int add = 1 + DfsWithMemo(word1, word2, i, j + 1, dict);

        ret = Math.Min(replace, Math.Min(delete, add));
        }
        dict[(i, j)] = ret;
        return dict[(i, j)];
    }
}
