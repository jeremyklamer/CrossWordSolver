using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossWordSolver
{
    public class Word
    {
        List<Letter> Letters;
        int X;
        int Y;
        int Lenght;
        bool IsHorizontal;


        public Word(int x, int y, int lenght, bool isHorizontal)
        {
            this.X = x;
            this.Y = y;
            this.Lenght = lenght;
            this.IsHorizontal = isHorizontal;
        }        
    }
}
