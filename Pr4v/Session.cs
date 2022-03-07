using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4V
{
    internal class Session
    {
        private string Semester;
        public void GetSemester()
        {
            Console.WriteLine(Semester);
        }

        public void SetSemester(string S)
        {
            this.Semester = S;
        }
        private int Test;
        private int Exam;
        public void SetExams(int Test, int Exam)
        {
            if (Test + Exam >= 7 && Test + Exam <= 9)
            {
                this.Test = Test;
                this.Exam = Exam;
            }
            else
            {
                Console.WriteLine("Кол-во экзаменов и зачётов не входят в диапазон");
            }
        }
        public void CountExam()
        {
            int C = Exam + Test;
            Console.WriteLine("Кол-во экзаменов и зачётов = " + C);
        }
        public void PrintSession()
        {
            Console.WriteLine("Семестр = " + Semester + " |" +
                " Зачётов = " + Test + " |" +
                " Екзаменов = " + Exam + " |");
        }
        public Session()
        {

        }
        public Session(int Test, int Exam)
        {
            if (Test + Exam >= 7 && Test + Exam <= 9)
            {
                this.Test = Test;
                this.Exam = Exam;
            }
            else
            {
                Console.WriteLine("Кол-во экзаменов и зачётов не входят в диапазон");
            }

        }
        public Session(string Semester)
        {
            this.Semester = Semester;
        }
    }
}
