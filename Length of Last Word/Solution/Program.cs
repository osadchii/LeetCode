var testCases = new Dictionary<string, int>()
{
    ["Hello World"] = 5,
    ["   fly me   to   the moon  "] = 4,
    ["luffy is still joyboy"] = 6
};

var solution = new Solution();

foreach (var testCase in testCases)
{
    var result = solution.LengthOfLastWord(testCase.Key);
    if (result != testCase.Value)
    {
        throw new Exception("Wrong result");
    }
}

public class Solution {
    public int LengthOfLastWord(string s)
    {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var lastWord = words.Last();
        return lastWord.Length;
    }
}