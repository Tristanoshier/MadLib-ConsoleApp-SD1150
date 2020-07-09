using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Words;

namespace MadLib_Console
{
    public class ConsoleUI
    {
        protected readonly WordRepo _repo = new WordRepo();

        public void Run()
        {
            MainMenu();
        }

        private void MainMenu()
        {
            bool continueToRun = true;
            while(continueToRun)
            {
                Console.WriteLine
               (
                   "------------------------------------------\n" +
                   "|    WElCOME TO THE PROGRAMMING MADLIB   |\n" +
                   "| PRESS ANY KEY TO CONTINUE OR q TO QUIT |\n" +
                   "------------------------------------------"
               );

                string userInput = Console.ReadLine();
                if (userInput == "q")
                {
                    continueToRun = false;
                }
                else
                {
                    Questions();
                    Story();
                    Outro();
                }
            }   
        }

        //Input Variables
        public string adjectiveOne;
        public string emotionOne;
        public string nameOne;
        public string adjectiveTwo;
        public string programTermOne;
        public string adjectiveThree;
        public string adjectiveFour;
        public string programTermTwo;
        public string foodOne;

        private void Questions()
        {
            Console.Clear();

            //Question One
            _repo.Question(WordType.Adjective);
            adjectiveOne = Console.ReadLine();
            Console.Clear();

            //Question Two
            _repo.Question(WordType.Emotion);
            emotionOne = Console.ReadLine();
            Console.Clear();

            //Question Three
            _repo.Question(WordType.Name);
            nameOne = Console.ReadLine();
            Console.Clear();

            //Question Four
            _repo.Question(WordType.Adjective);
            adjectiveTwo = Console.ReadLine();
            Console.Clear();

            //Question Five
            _repo.Question(WordType.ProgrammingTerm);
            programTermOne = Console.ReadLine();
            Console.Clear();

            //Question Six
            _repo.Question(WordType.Adjective);
            adjectiveThree = Console.ReadLine();
            Console.Clear();

            //Question Seven
            _repo.Question(WordType.Adjective);
            adjectiveFour = Console.ReadLine();
            Console.Clear();

            //Question Eight
            _repo.Question(WordType.ProgrammingTerm);
            programTermTwo = Console.ReadLine();
            Console.Clear();

            //Question Nine
            _repo.Question(WordType.Food);
            foodOne = Console.ReadLine();
            Console.Clear();
        }

        private void Story()
        {
            Console.Clear();
            Console.WriteLine("------------------------------PROGRAMMING STORY--------------------------------\n");
            Console.WriteLine
                (
                    $"My first day at Eleven Fifty Academy was {_repo.AddWord(adjectiveOne)} and I was very {_repo.AddWord(emotionOne)}.\n" +
                    $"My instructor's name is {_repo.AddWord(nameOne)} and they are very {_repo.AddWord(adjectiveTwo)}.\n" +
                    $"The first thing we learned was {_repo.AddWord(programTermOne)} and I thought this topic was {_repo.AddWord(adjectiveThree)}.\n" +
                    $"My first assignment was very {_repo.AddWord(adjectiveFour)} and it was over {_repo.AddWord(programTermTwo)}.\n" +
                    $"It was finally time for lunch, and I had {_repo.AddWord(foodOne)} to eat. yum.\n"
                );
        }

        private void Outro()
        {
            Console.WriteLine
               (
                   "-------------------------------------------------\n" +
                   "| THANKS FOR PLAYING! PRESS ANY KEY TO CONTINUE |\n" +
                   "-------------------------------------------------"
               );
            Console.ReadKey();
            Console.Clear();
        }
    }
}
