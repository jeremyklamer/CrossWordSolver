using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossWordSolver
{
    public interface IReadWordsInterface
    {
        Words InitWords(string languageCode);        
    }
}
