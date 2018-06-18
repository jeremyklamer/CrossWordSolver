using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossWordSolver
{
    public class ReadWords : ReadWordsInterface
    {
        public ReadWords(string LanguageCode)
        {
            Directory.GetCurrentDirectory();

        }

        public Words InitWordsFromFiles(List<string> filePaths)
        {
            throw new NotImplementedException();
        }
    }
}
