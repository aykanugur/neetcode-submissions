public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        //bunu doldurmadan yaparsam . değerleri hata veriyordu.
        //null
        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int y = 0; y < 9; y++)
        {
            for (int x = 0; x < 9; x++)
            {
                char value = board[y][x];

                if (value == '.')
                {
                    continue;
                }

                // row kontrolü
                if (rows[y].Contains(value))
                {
                    return false;
                }

                // col kontrolü
                if (cols[x].Contains(value))
                {
                    return false;
                }

                int box = x / 3 + 3 * (y / 3);

                // box kontrolü
                if (boxes[box].Contains(value))
                {
                    return false;
                }
                rows[y].Add(value);
                cols[x].Add(value);
                boxes[box].Add(value);
            }
        }

        return true;
    }
}