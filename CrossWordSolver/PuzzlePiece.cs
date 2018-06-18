using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossWordSolver
{
    public class PuzzlePiece
    {
        public static char defaultLetter = '#';               
        public bool open = false;

        private char letter;

        public PuzzlePiece(bool open)
        {
            this.open = open;
            this.letter = PuzzlePiece.defaultLetter;
        }

        public char GetLetter()
        {
            return letter;
        }

    }
}
