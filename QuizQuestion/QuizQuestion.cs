using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class QuizQuestion<T>
    {
        public T Answer { get; private set; } // Generic property.

        public T Option1 { get; private set; } // Generic property.

        public T Option2 { get; private set; } // Generic property.

        public T Option3 { get; private set; } // Generic property.

        public string Option4 { get; set; }   // String property.

        private string Question { get; set; } // String property.

        public QuizQuestion(string question, T answer, T option1, T option2, T option3, string option4) // Constructor.
        {
            Question = question;
            Answer = answer;
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
            Option4 = option4;

        }
        public void ShowType() // Show data type.
        {
            Console.Write("The instance type is: ");
            Console.WriteLine(typeof(T).ToString());
        }

        public void ShowQ() // Question & Answer
        {
            Console.WriteLine("Question: " + Question);
        }

        public void ShowOptions()
        {
            Console.WriteLine("a. "+Option1.ToString());
            Console.WriteLine("b. "+Option2.ToString());
            Console.WriteLine("c. "+Option3.ToString());
            Console.WriteLine("d. "+Option4.ToString());
        }
        public void ShowA() // Question & Answer
        {
            Console.WriteLine("Answer: " + Answer.ToString() + "\n");
        }
    }
    

}
