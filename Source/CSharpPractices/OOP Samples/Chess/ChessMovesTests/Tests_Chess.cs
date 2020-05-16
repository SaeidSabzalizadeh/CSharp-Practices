using ChessCore;
using ChessMoves;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace Tests
{
    public class ChessMovesTests
    {
        [Fact]
        public void Test_003()
        {
            var moves = new List<string>()
            {
              // White, Black
                "G1F3", "G8F6",
                "C2C4", "G7G6",
                "B1C3", "F8G7",
                "D1D4", "E8G8", // castle
                "C1C4", "D7D5",
                "D1B3", "D5C4", // capture
                "B3C4", // capture, ...
            };

            var printer = new BoardPrinter();

            ChessMove result = null;

            var gameMoves = new List<ChessMove>();

            foreach (var move in moves)
            {
                if (ChessMove.Try(move, ref result))
                {
                    Debug.WriteLine($"");
                    Debug.WriteLine($"Move Number: {result.MoveNumber}");
                    Debug.WriteLine($"Origin: {result.Move.Substring(0,2)}");
                    Debug.WriteLine($"Destination: {result.Move.Substring(2,2)}");
                    Debug.WriteLine($"");

                    printer.Show(result.Before);
                    printer.Show(result.After);

                    gameMoves.Add(result);
                }
                else
                {
                    break;
                }
            }
        }

        private class BoardPrinter
        {
            internal void Show(Board board)
            {
                for (int c = 1; c <= 8; c++)
                {
                    for (int r = 1; r <= 8; r++)
                    {
                        Debug.Write($"[{board[c, r]?.ToString() ?? " "}]");
                    }
                    Debug.WriteLine(string.Empty);
                }
                Debug.WriteLine(string.Empty.PadRight(8 * 3, '-'));
            }

            internal void Show(ChessMoves.ChessMove.ChessPieces[,] board)
            {
                for (int c = 0; c <= 7; c++)
                {
                    for (int r = 0; r <= 7; r++)
                    {
                        var symbol = board[c, r] == ChessMove.ChessPieces.None ? " " : Enum.GetName(typeof(ChessMove.ChessPieces), board[c, r]).Substring(6,1);
                        Debug.Write($"[{symbol}]");
                    }
                    Debug.WriteLine(string.Empty);
                }
                Debug.WriteLine(string.Empty.PadRight(8 * 3, '-'));
            }
        }
    }
}
