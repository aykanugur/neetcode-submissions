public class Solution
{
    public string Encode(IList<string> strs)
    {
        string sol = "";

        foreach (string s in strs)
        {
            sol += s.Length + "#" + s;
        }

        return sol;
    }

    public List<string> Decode(string s)
    {
        List<string> strs = new List<string>();

        int i = 0;

        while (i < s.Length)
        {
            int j = i;

            while (s[j] != '#')
            {
                j++;
            }

            int length = int.Parse(s.Substring(i, j - i));

            i = j + 1;

            strs.Add(s.Substring(i, length));

            i = i + length;
        }

        return strs;
    }
}