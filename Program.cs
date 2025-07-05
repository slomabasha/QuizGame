//Second C# Project By Me, SLOMA ADEL
namespace QuizGame
{
    internal class Program
    {
        static readonly string[] Questions = new string[30]
        {
            "What is the capital of Italy?",
            "What is the red planet?",
            "What is the largest animal?",
            "What is the chemical symbol for gold?",
            "How many continents are there?",
            "What is the largest ocean on Earth?",
            "What is the tallest mountain in the world?",
            "What is the currency of Japan?",
            "How many days are in a leap year?",
            "What is the hardest natural substance on Earth?",
            "What gas do plants absorb from the air?",
            "Which organ pumps blood through the body?",
            "What is the square root of 64?",
            "Which planet is famous for its rings?",
            "What do we call animals that eat only plants?",
            "Who wrote 'Romeo and Juliet'?",
            "What is the chemical formula for water?",
            "Which ocean is between Africa and Australia?",
            "What is the freezing point of water in Celsius?",
            "Which part of the plant conducts photosynthesis?",
            "Which metal is liquid at room temperature?",
            "Who painted the Mona Lisa?",
            "What is the capital of Canada?",
            "What part of the cell contains DNA?",
            "What is the largest internal organ in the human body?",
            "Which country has the most population?",
            "Who is the richest person in the world untill 2024?", ////////////////////////////
            "Which blood type is known as the universal donor?",
            "Which element is needed for strong bones?",
            "Which planet is closest to Earth?"
        };

        static string[] Answers = new string[30]
        {
            "rome",
            "mars",
            "blue whale",
            "au",
            "7",
            "pacific ocean",
            "everest",
            "yen",
            "366",
            "diamond",
            "carbon dioxide",
            "heart",
            "8",
            "saturn",
            "herbivores",
            "shakespeare",
            "h2o",
            "indian",
            "0",
            "leaves",
            "mercury",
            "da vinci",
            "ottawa",
            "nucleus",
            "liver",
            "china",
            "Elon Musk",
            "o negative",
            "calcium",
            "venus"
        };
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the Ultimate Quiz Game!");
            Console.WriteLine("Let's begin!");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬\n");

            Console.WriteLine("1. Start");
            Console.WriteLine("2. Instructions");

            string Choise = Console.ReadLine()!;
            switch (Choise)
            {
                case "1": //Start
                    StartQuiz();
                    break;

                case "2": //Instructions
                    Instructions();
                    StartQuiz();
                    break;

                default:
                    Console.WriteLine("Please enter a valid choise");
                    break;
            }

        }

        private static void StartQuiz()
        {
        sloma:
            bool[] UsedIndexs = new bool[Questions.Length]; //To save questions that were asked
            Random rnd = new Random();
            int score = 0;

            for (int i = 0; i < 3; i++)
            {
                int index = rnd.Next(Questions.Length); // To generate a random number for questions

                if (UsedIndexs[index])  //If that index was used, skip it and go a step back (i--)
                {
                    i--;
                    continue;
                }
                UsedIndexs[index] = true;

                Console.WriteLine(Questions[index]);
                string UserAnswer = Console.ReadLine()!.Trim().ToLower();
                bool result = IsCorrct(UserAnswer, Answers[index]);
                score += result ? 1 : 0;
                
                if (UserAnswer == Answers[index])
                {
                    Console.WriteLine("Correct Answer! ♥\n");
                    continue;
                }
                Console.WriteLine($"Incorrect Answer! The correct answer is {Answers[index]} ☼☼☼\n");
            }
            Console.WriteLine($"Your score is: {score} of 3");
            Console.WriteLine("Quiz Completed, Thank you for playing!\n");

            Console.WriteLine("Want to play again?");
            Console.WriteLine("1. YES");
            Console.WriteLine("2. NO");
            string Replay = Console.ReadLine()!;
            if (Replay == "1")
            {
                Console.WriteLine("OK! Let`s play again.\n");
                goto sloma;
            }
            else
            {
                Console.WriteLine("Game Ended, Thank you for playing!\n");
            }

        }

        private static void Instructions()
        {
            Console.WriteLine("\n\b HOW TO PLAY? \b");
            Console.WriteLine("1) You will be asked 3 random general knoledge questions.");
            Console.WriteLine("2) Type your answer exactly as expected. Starting with a**capital letter**.");
            Console.WriteLine("  For example: 'Rome'.");
            Console.WriteLine("3. Each correct answer gives you one point.");
            Console.WriteLine("4. Try to answer all 3 correctly. Good luck!");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬\n\n");

            Console.WriteLine("Now let's play!\n");
        }
        private static bool IsCorrct(string UserInput, string CorrectInput)
        {
            return UserInput == CorrectInput ? true : false;
        }
    }
}