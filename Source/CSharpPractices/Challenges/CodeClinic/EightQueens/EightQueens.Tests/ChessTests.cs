using EightQueens.Chess;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace EightQueens.Tests
{
    public class ChessTests
    {
        [Fact]
        public void Test_010_EmptyBoardIsSafe()
        {
            var board = new ChessBoard("00000000");

            Assert.True(board.IsSafe());
        }

        [Fact]
        public void Test_011_BoardIsSafe()
        {
            var board = new ChessBoard("10000000");

            Assert.True(board.IsSafe());
        }

        [Fact]
        public void Test_012_BoardIsSafe()
        {
            var board = new ChessBoard("15863720");

            Assert.True(board.IsSafe());
        }

        [Fact]
        public void Test_019_EachKnownSolutionIsSafe()
        {
            var boards = from solution in ChessBoard.Solutions
                         select new ChessBoard(solution);

            Assert.True(boards.All(board => board.IsSafe()));
        }

        [Fact]
        public void Test_020_PlaceQueens()
        {
            // starting from an empty board, can we find one solution

            Assert.True(ChessBoard.PlaceQueens());
            
        }

        [Fact]
        public void Test_030_PlaceQueens()
        {
            // starting from an empty board, can we find all solutions

            var solutions = new List<ChessBoard>(92);
            ChessBoard.PlaceQueens(solutions);

            
            Assert.True(solutions.Count == 92);

            int lol1 = ChessBoard.numberOfloops;
            int lol2 = ChessBoard.numberOfMetod;

            // confirm all found solutions are known
            Assert.True(solutions.All(board => ChessBoard.Solutions.Contains(board.ToString())));
        }
    }
}
