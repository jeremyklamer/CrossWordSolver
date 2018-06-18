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

        public bool openRight = false;
        public bool openDown = false;
        public bool open = false;
        private char letter;

        public PuzzlePiece()
        {

        }


        public PuzzlePiece(bool openRight, bool openDown)
        {
            this.openDown = openDown;
            this.openRight = openRight;
            this.letter = PuzzlePiece.defaultLetter;
        }

        public PuzzlePiece(bool openRight, bool openDown, char letter)
        {
            this.openDown = openDown;
            this.openRight = openRight;
            this.letter = letter;
        }

        public char GetLetter()
        {
            return letter;
        }

        public bool CanBeFilled()
        {
            return openDown || openRight;
        }
    }
}
