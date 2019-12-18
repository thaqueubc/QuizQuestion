using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize question with a 'int' type.
            QuizQuestion<int> questionA = new QuizQuestion<int>
                ("How many teeth do sharks use in a lifetime?", 30000, 30000, 20000, 10000, "none of the above");
            questionA.ShowType();
            questionA.ShowQ();
            questionA.ShowOptions();
            questionA.ShowA();

            // Initialize question with a 'string' type.
            QuizQuestion<string> questionB = new QuizQuestion<string>
                ("What type of shark swims fastest?", "The short fin mako shark.", 
                "The Great white shark", "The short fin mako shark.","Tiger shark", "Blue shark");
            questionB.ShowType();
            questionB.ShowQ();
            questionB.ShowOptions();
            questionB.ShowA();
        }
    }
}
