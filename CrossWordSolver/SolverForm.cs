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
        //TODO remove temp var.
        private List<Word> tempWords;

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
                    DrawPiece(puzzle, x, y);
                }
               
            }
            tempWords = puzzle.FindWords();
            
        }

        private void DrawPiece(Puzzle puzzle, int x, int y)
        {
            var piece = puzzle.GetPieces()[x, y];

            Label pieceLabel = new Label();
            pieceLabel.Text = piece.GetLetter().ToString();
            pieceLabel.Bounds = new Rectangle(x * pieceSize, y * pieceSize, pieceSize, pieceSize);
            pieceLabel.ForeColor = Color.White;

            if(x == 5 && y == 3)
            {
                pieceLabel.BackColor = Color.OldLace;
            }

            if (!piece.open)
            {
                pieceLabel.BackColor = Color.Black;
            }
            else if ((puzzle.IsRightPieceOpen(x, y) || puzzle.IsLeftPieceOpen(x, y)) && (puzzle.IsBottomPieceOpen(x, y) || puzzle.IsTopPieceOpen(x, y)))
            {
                pieceLabel.BackColor = Color.Purple;
            }
            else if(puzzle.IsRightPieceOpen(x,y) || puzzle.IsLeftPieceOpen(x, y))
            {
                pieceLabel.BackColor = Color.Green;
            }
            else if (puzzle.IsBottomPieceOpen(x, y) || puzzle.IsTopPieceOpen(x, y))
            {
                pieceLabel.BackColor = Color.Blue;
            }
            else
            {
                pieceLabel.BackColor = Color.White;
                pieceLabel.ForeColor = Color.Black;
            }
           
            puzzlePanel.Controls.Add(pieceLabel);
        }

        private void showWordsButton_Click(object sender, EventArgs e)
        {
              var test = 1;
        }
    }
}
