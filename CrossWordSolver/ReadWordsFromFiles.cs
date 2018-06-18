using CrossWordSolver.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;
using System.Resources;

namespace CrossWordSolver
{
    public class ReadWordsFromFiles : IReadWordsInterface
    {
        Words LoadedWords = new Words();       

        public Words InitWords(string languageCode)
        {
            var applicableResources = GetApplicableResources(languageCode);

            foreach (var resource in applicableResources)
            {
                LoadResource(resource);
            }

            return LoadedWords;
        }

        private List<string> GetApplicableResources(string languageCode)
        {
            List<string> resourceNames = new List<string>();

            // Get all Resource files. 
            ResourceManager MyResourceClass = new ResourceManager(typeof(Resources));

            ResourceSet resourceSet = MyResourceClass.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            foreach (DictionaryEntry entry in resourceSet)
            {
                string resourceKey = entry.Key.ToString();
                if(resourceKey.StartsWith(languageCode))
                {
                    resourceNames.Add(resourceKey);
                }                
            }

            return resourceNames;
        }

        private void LoadResource(string resourceName)
        {
            var resource = Resources.ResourceManager.GetObject(resourceName);

            if(resource is string)
            {
                var fileWords = ((string)resource).Split('\n').ToList();
                var longestWord = fileWords.OrderByDescending(s => s.Length).First();

                for (int i = 0; i < longestWord.Length; i++)
                {
                    var wordsForLenght = fileWords.Where(e => e.Length == i).ToList();
                    LoadedWords.SetWords(i, wordsForLenght);
                }
            }          
        }

        

    }
}
