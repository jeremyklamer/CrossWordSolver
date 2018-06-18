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
        public SolverForm()
        {
            InitializeComponent();
        }

        public void SetWordsLoadedCount(int count)
        {
            wordsLoadedCountLabel.Text = count.ToString();
        }
    }
}
