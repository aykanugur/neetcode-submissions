public class Solution {
    public bool IsPalindrome(string s) {
        int x = 0;
        int y = s.Length - 1;

        while (x < y) {

            while (x < y && !char.IsLetterOrDigit(s[x])) {
                x++;
            }

            while (x < y && !char.IsLetterOrDigit(s[y])) {
                y--;
            }

            if (char.ToLower(s[x]) != char.ToLower(s[y])) {
                return false;
            }

            x++;
            y--;
        }

        return true;
    }
}