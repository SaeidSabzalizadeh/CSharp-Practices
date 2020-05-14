namespace ChessCore
{
    public class Chess
    {
        public void Apply(string move, Board board)
        {
            var start = move.Substring(0, 2);
            var dest = move.Substring(2, 2);

            // BUG: the char for the column needs to have 64 subtracted, not 65.
            //      thus ('A' - 64) == 1
            //      which is what we want because the board will 'minus 1' when converting col & row to array indexes.

            board[dest[0] - 64, dest[1] - 48] = board[start[0] - 64, start[1] - 48];
            board[start[0] - 64, start[1] - 48] = null;
        }
    }
}
