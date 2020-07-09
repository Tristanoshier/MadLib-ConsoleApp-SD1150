using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    public enum WordType { Adjective, Name, Food, Emotion, ProgrammingTerm }
    public class WordRepo
    {
        public void Question(WordType word)
        {
           if(word == WordType.Adjective || word == WordType.Emotion)
            {
                Console.WriteLine($"Enter an {word}:");
            }
           else if(word == WordType.ProgrammingTerm)
            {
                Console.WriteLine($"Enter a Programming Term:");
            }
           else
            {
                Console.WriteLine($"Enter a {word}:");
            }
        }

        public string AddWord(string word)
        {
            return word;
        }
    }
}
