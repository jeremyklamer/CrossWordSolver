using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossWordSolver
{
    public class Words
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
            return wordLists[length];
        }

        public void SetWords(int length, List<string> words)
        {
            if(wordLists.Count <= length)
            { 
                wordLists.Add(words);
            }
            else
            {
                words.AddRange(wordLists[length]);

                wordLists[length] = words;
            }
        }

        public int CountWords()
        {
            int total = 0;
            foreach (var wordList in wordLists)
            {
                total += wordList.Count;
            }

            return total;
        }

    }
}
