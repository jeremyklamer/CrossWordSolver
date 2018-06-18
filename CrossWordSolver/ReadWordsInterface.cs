using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossWordSolver
{
    interface ReadWordsInterface
    {
        Words InitWordsFromFiles(List<string> filePaths);        
    }
}
