using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Question
    {


        public string questionBody { get; set; }
        public int Mark { get; set; }
        public int ID { get; set; }

        public Question(int ID, string questionBody, int Mark)
        {

            this.ID = ID;
            this.questionBody = questionBody;
            this.Mark = Mark;

        }

        public override string ToString()
        {
            return $"Question {ID}: {questionBody} ? ({Mark} Mark)";
        }


    }
    class Choices
    {


        public string answerBody { get; set; }

        public int Num { get; set; }

        public Choices(int Num, string answerBody)
        {

            this.Num = Num;
            this.answerBody = answerBody;

        }

        public override string ToString()
        {
            return $" Choice {Num}- {answerBody} )";
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<Question, List<Choices>> exam = new Dictionary<Question, List<Choices>>();
            exam.Add(new Question(1, "What is the primary characteristic of a queue in data structures", 10),
                new List<Choices>() { new Choices(1, "First In, Last Out (FILO)"), new Choices(2, "Last In, First Out (LIFO)"), new Choices(3, " First In, First Out (FIFO)"), new Choices(4, " Last In, Last Out (LILO)") });

            exam.Add(new Question(2, "Which method in a queue is responsible for adding new elements", 20),
               new List<Choices>() { new Choices(1, "pop()"), new Choices(2, "peek()"), new Choices(3, "push()"), new Choices(4, " remove()") });

            exam.Add(new Question(3, "Which method in a queue allows you to view the front element without removing it", 15),
                   new List<Choices>() { new Choices(1, "pop()"), new Choices(2, "peek()"), new Choices(3, "push()"), new Choices(4, " remove()") });



            foreach (KeyValuePair<Question, List<Choices>> item in exam)
            {


                Console.WriteLine(item.Key);
                foreach (Choices s in item.Value) {

                    Console.WriteLine( s );

                }

            }

            Console.ReadKey();
        }
    }
}
