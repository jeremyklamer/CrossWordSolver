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

        public bool IsRightPieceOpen(int x, int y)
        {
            if (x < puzzle.GetLength(0) -1)
                return puzzle[x + 1, y].open;
            else
                return false;
        }

        public bool IsBottomPieceOpen(int x, int y)
        {
            if (y < puzzle.GetLength(1) - 1)
                return puzzle[x, y + 1].open;
            else
                return false;
        }        

        public bool IsTopPieceOpen(int x, int y)
        {
            if (y >= 1)
                return puzzle[x, y - 1].open;
            else
                return false;
        }

        public bool IsLeftPieceOpen(int x, int y)
        {
            if (x >= 1)
                return puzzle[x - 1, y].open;
            else
                return false;
        }


        public void LoadTestPuzzle()
        {
            puzzle = new PuzzlePiece[6,4];

            puzzle[0, 0] = new PuzzlePiece(true);
            puzzle[0, 1] = new PuzzlePiece(true);
            puzzle[0, 2] = new PuzzlePiece(true);
            puzzle[0, 3] = new PuzzlePiece(true);

            puzzle[1, 0] = new PuzzlePiece(false);
            puzzle[1, 1] = new PuzzlePiece(false);
            puzzle[1, 2] = new PuzzlePiece(false);
            puzzle[1, 3] = new PuzzlePiece(true);

            puzzle[2, 0] = new PuzzlePiece(false);
            puzzle[2, 1] = new PuzzlePiece(false);
            puzzle[2, 2] = new PuzzlePiece(false);
            puzzle[2, 3] = new PuzzlePiece(true);

            puzzle[3, 0] = new PuzzlePiece(false);
            puzzle[3, 1] = new PuzzlePiece(true);
            puzzle[3, 2] = new PuzzlePiece(false);
            puzzle[3, 3] = new PuzzlePiece(true);

            puzzle[4, 0] = new PuzzlePiece(false);
            puzzle[4, 1] = new PuzzlePiece(true);
            puzzle[4, 2] = new PuzzlePiece(true);
            puzzle[4, 3] = new PuzzlePiece(true);

            puzzle[5, 0] = new PuzzlePiece(false);
            puzzle[5, 1] = new PuzzlePiece(false);
            puzzle[5, 2] = new PuzzlePiece(false);
            puzzle[5, 3] = new PuzzlePiece(true);

            //puzzle[0, 0] = new PuzzlePiece(true, false);
            //puzzle[0, 1] = new PuzzlePiece(true, false);
            //puzzle[0, 2] = new PuzzlePiece(true, true);
            //puzzle[0, 3] = new PuzzlePiece(false, true);

            //puzzle[1, 0] = new PuzzlePiece(false, false);
            //puzzle[1, 1] = new PuzzlePiece(false, false);
            //puzzle[1, 2] = new PuzzlePiece(false, true);
            //puzzle[1, 3] = new PuzzlePiece(false, false);

            //puzzle[2, 0] = new PuzzlePiece(false, false);
            //puzzle[2, 1] = new PuzzlePiece(false, false);
            //puzzle[2, 2] = new PuzzlePiece(false, true);
            //puzzle[2, 3] = new PuzzlePiece(false, false);

            //puzzle[3, 0] = new PuzzlePiece(false, false);
            //puzzle[3, 1] = new PuzzlePiece(false, false);
            //puzzle[3, 2] = new PuzzlePiece(false, true);
            //puzzle[3, 3] = new PuzzlePiece(false, false);

        }

        public PuzzlePiece[,] GetPieces()
        {
            return puzzle;
        }

        public List<Word> FindWords()
        {
            var words = new List<Word>();

            for (int x = 0; x < puzzle.GetLength(0); x++)
            {
                for (int y = 0; y < puzzle.GetLength(1); y++)
                {
                    var piece = puzzle[x, y];
                    if(piece.open)
                    {                 
                        if(IsRightPieceOpen(x,y) && !IsLeftPieceOpen(x,y))
                        {
                            //Start of horizontal word.
                            int length = 1;

                            while (IsRightPieceOpen(x + length, y))
                            {
                                length++;
                            }

                            words.Add(new Word(x, y, length + 1, true));
                        }
                        if (IsBottomPieceOpen(x, y) && !IsTopPieceOpen(x, y))
                        {
                            // Start of vertical word. 
                            int length = 1;

                            while (IsBottomPieceOpen(x, y + length))
                            {
                                length++;
                            }

                            words.Add(new Word(x, y, length + 1, false));
                        }
                    }
                }

            }

            return words;
        }
    }
}
