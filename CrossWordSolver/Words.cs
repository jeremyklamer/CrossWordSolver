using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossWordSolver
{
    internal class Words
    {
        private List<List<string>> wordLists = new List<List<string>>();

        public Words()
        {            
         
        }

        /// <summary>
        /// Get a list of words with a certain lenght. Returns null when none found.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public List<string> GetWords(int length)
        {            
            return wordLists[length - 1];
        }

        public void SetWords(int length, List<string> words)
        {
            wordLists.Insert(length - 1, words);
        }


    }
}
