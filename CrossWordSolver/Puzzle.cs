using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossWordSolver
{
    public class Puzzle
    {
        private PuzzlePiece[,] puzzle;

        public Puzzle()
        {
            //TODO load actual puzzle
            LoadTestPuzzle();
        }

        public void LoadTestPuzzle()
        {
            puzzle = new PuzzlePiece[4,4];

            puzzle[0, 0] = new PuzzlePiece(true, false);
            puzzle[0, 1] = new PuzzlePiece(true, false);
            puzzle[0, 2] = new PuzzlePiece(true, true);
            puzzle[0, 3] = new PuzzlePiece(false, true);

            puzzle[1, 0] = new PuzzlePiece(false, false);
            puzzle[1, 1] = new PuzzlePiece(false, false);
            puzzle[1, 2] = new PuzzlePiece(false, true);
            puzzle[1, 3] = new PuzzlePiece(false, false);

            puzzle[2, 0] = new PuzzlePiece(false, false);
            puzzle[2, 1] = new PuzzlePiece(false, false);
            puzzle[2, 2] = new PuzzlePiece(false, true);
            puzzle[2, 3] = new PuzzlePiece(false, false);

            puzzle[3, 0] = new PuzzlePiece(false, false);
            puzzle[3, 1] = new PuzzlePiece(false, false);
            puzzle[3, 2] = new PuzzlePiece(false, true);
            puzzle[3, 3] = new PuzzlePiece(false, false);

        }

        public PuzzlePiece[,] GetPieces()
        {
            return puzzle;
        }
    }
}
