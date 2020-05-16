namespace ChessCore
{
    public class Board
    {
        private ChessPiece[,] board = new ChessPiece[8, 8]
        {
            // BUG!
            // The columns and rows were transposed in the original copy & paste:

            //{ new Rook(Player.White), new Knight(Player.White), new Bishop(Player.White), new Queen(Player.White), new King(Player.White), new Bishop(Player.White), new Knight(Player.White), new Rook(Player.White) },
            //{ new Pawn(Player.White), new Pawn(Player.White), new Pawn(Player.White), new Pawn(Player.White), new Pawn(Player.White), new Pawn(Player.White), new Pawn(Player.White), new Pawn(Player.White)},
            //{ null, null, null, null, null, null, null, null },
            //{ null, null, null, null, null, null, null, null },
            //{ null, null, null, null, null, null, null, null },
            //{ null, null, null, null, null, null, null, null },
            //{ new Pawn(Player.Black), new Pawn(Player.Black), new Pawn(Player.Black), new Pawn(Player.Black), new Pawn(Player.Black), new Pawn(Player.Black), new Pawn(Player.Black), new Pawn(Player.Black)},
            //{ new Rook(Player.Black), new Knight(Player.Black), new Bishop(Player.Black), new Queen(Player.Black), new King(Player.Black), new Bishop(Player.Black), new Knight(Player.Black), new Rook(Player.Black) }

            // Correct initialization as per unit tests and video:

            { new Rook(Player.White)  , new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new Rook(Player.Black)  },
            { new Knight(Player.White), new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new Knight(Player.Black)},
            { new Bishop(Player.White), new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new Bishop(Player.Black)},
            { new Queen(Player.White) , new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new Queen(Player.Black) },
            { new King(Player.White)  , new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new King(Player.Black)  },
            { new Bishop(Player.White), new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new Bishop(Player.Black)  },
            { new Knight(Player.White), new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new Knight(Player.Black)},
            { new Rook(Player.White)  , new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new Rook(Player.Black)}
        };

        public ChessPiece this[int col, int row]
        {
            get
            {
                return board[col-1, row-1];
            }
            set
            {
                board[col-1, row-1] = value;
            }
        }
    }
}