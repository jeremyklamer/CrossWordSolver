using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossWordSolver
{
    public partial class SolverForm : Form
    {
        private const int pieceSize = 30;

        public SolverForm()
        {
            InitializeComponent();

            var puzzle = new Puzzle();
            
            ShowPuzzle(puzzle);
        }

        public void SetWordsLoadedCount(int count)
        {
            wordsLoadedCountLabel.Text = count.ToString();
        }

        public void ShowPuzzle(Puzzle puzzle)
        {
            var allPieces = puzzle.GetPieces();

            for (int x = 0; x < allPieces.GetLength(0); x++)
            {
                for (int y = 0; y < allPieces.GetLength(1); y++)
                {
                    DrawPiece(allPieces[x, y], x, y);
                }
               
            }
            
        }

        private void DrawPiece(PuzzlePiece piece, int x, int y)
        {            
            Label pieceLabel = new Label();
            pieceLabel.Text = piece.GetLetter().ToString();
            pieceLabel.Bounds = new Rectangle(x * pieceSize, y * pieceSize, pieceSize, pieceSize);
            pieceLabel.ForeColor = Color.White;

            if (!piece.CanBeFilled())
            {
                pieceLabel.BackColor = Color.Black;
                
            }
            else if (piece.openRight && piece.openDown)
            {
                pieceLabel.BackColor = Color.Purple;
            }
            else if(piece.openRight && !piece.openDown)
            {
                pieceLabel.BackColor = Color.Green;
            }
            else if(!piece.openRight && piece.openDown)
            {
                pieceLabel.BackColor = Color.Blue;
            }
           
            pieceLabel.ForeColor = Color.White;
                
            

            puzzlePanel.Controls.Add(pieceLabel);
        }
    }
}
