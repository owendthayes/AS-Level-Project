using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_Quiz_Game
{
    [Serializable]
    public class Questions
    {

        string question;
        string correctAnswer;

        public Questions()
        {
            question = "";
            correctAnswer = "";        }

        public Questions(string question, string correctAnswer)
        {
            Question = question;
            CorrectAnswer = correctAnswer;
        }

        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }             
    }
}
