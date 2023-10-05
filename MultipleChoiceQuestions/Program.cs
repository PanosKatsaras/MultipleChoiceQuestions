using System;
using System.Collections.Generic;

//Interface TestPaper
public interface ITestPaper
{
    string SubjectName { get; set; }
    string TestPaperName { get; set; }
    List<Question> Questions { get; set; }
}

//Interface IQuestion
public interface IQuestion
{
    string QuestionText { get; set; }
    List<Option> Options { get; set; }
    char CorrectAnswerLetter { get; set; }
    char OptionSelectedByStudent { get; set; }
    int MarksSecured { get; set; }

}
//Interface IOption
public interface IOption
{
    char OptionLetter { get; set; }
    string OptionText { get; set; }
}
//Interface IStudent
public interface IStudent
{
    int RollNo { get; set; }
    string StudentName { get; set; }
    List<TestPaper> TestPapers { get; set; }
}
//class TestPaper
public class TestPaper:ITestPaper
{
    private string _SubjectName;
    private string _TestPaperName;
    List<Question> _Questions;
    public string SubjectName
    {
        get
        {
            return _SubjectName;
        }
        set
        {
            _SubjectName = value;
        }
    }
        public string TestPaperName 
    { 
        get 
        {
            return _TestPaperName;
        } 
        set 
        {
            _TestPaperName = value;
        } 
    }
    public List<Question> Questions 
    {
        get
        {
            return _Questions;
        }
        set
        {
            _Questions = value;
        }
    }

}
//class Question
public class Question:IQuestion
{
    private string _QuestionText;
    private List<Option> _Options;
    private char _CorrectAnswerLetter;
    private char _OptionSelectedByStudent;
    private int _MarksSecured;

    public string QuestionText
    {
        get
        {
            return _QuestionText;
        }
        set
        {
            _QuestionText = value;
        }
    }
    public List<Option> Options
    {
        get
        {
            return _Options;
        }
        set
        {
            _Options = value;
        }
    }
    public char CorrectAnswerLetter
    {
        get
        {
            return _CorrectAnswerLetter;
        }
        set
        {
            _CorrectAnswerLetter = value;
        }
    }
    public char OptionSelectedByStudent
    {
        get
        {
            return _OptionSelectedByStudent;
        }
        set
        {
            _OptionSelectedByStudent = value;
        }
    }
    public int MarksSecured
    {
        get
        {
            return _MarksSecured;
        }
        set

        {
            if (OptionSelectedByStudent == CorrectAnswerLetter)
            {
                _MarksSecured = value;
            }
            else
            {
                _MarksSecured = 0;
            }

        }
    }
    //A method to display options
    public void displayOptions(List<Option> options)
    {
        for (var i = 0; i < options.Count; i++)
        {
            Console.WriteLine(options[i].OptionLetter + ":" + options[i].OptionText);
        }
    }
}
//class Option
public class Option
{
    private char _OptionLetter;
    private string _OptionText;
    public char OptionLetter
    {
        get
        {
            return _OptionLetter;
        }
        set
        {
            _OptionLetter = value;
        }
    }
    public string OptionText
    {
        get
        {
            return _OptionText;
        }
        set
        {
            _OptionText = value;
        }
    }
}
//class Student
public class Student
{
    private int _RollNo;
    private string _StudentName;
    private List<TestPaper> _TestPapers;
    public int RollNo
    {
        get
        {
            return _RollNo;
        }
        set
        {
            _RollNo = value;
        }
    }
    public string StudentName
    {
        get
        {
            return _StudentName;
        }
        set
        {
            _StudentName = value;
        }
    }
    public List<TestPaper> TestPapers
    {
        get
        {
            return _TestPapers;
        }
        set
        {
            _TestPapers = value;
        }
    }
}

namespace MultipleChoiceQuestions
{
    class Program
    {
        static void Main()
        {
            //Change the color of the console text
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
            }
            //All options
            Option opt1 = new Option
            {
                OptionLetter = 'A',
                OptionText = "New York"
            };
            Option opt2 = new Option
            {
                OptionLetter = 'B',
                OptionText = "Washington D.C."
            };
            Option opt3 = new Option
            {
                OptionLetter = 'C',
                OptionText = "London"
            };
            Option opt4 = new Option
            {
                OptionLetter = 'D',
                OptionText = "New Delhi"
            };
            Option opt5 = new Option
            {
                OptionLetter = 'A',
                OptionText = "Madrid"
            };
            Option opt6 = new Option
            {
                OptionLetter = 'B',
                OptionText = "Rome"
            };
            Option opt7 = new Option
            {
                OptionLetter = 'C',
                OptionText = "Athens"
            };
            Option opt8 = new Option
            {
                OptionLetter = 'D',
                OptionText = "Paris"
            };
            Option opt9 = new Option
            {
                OptionLetter = 'A',
                OptionText = "Germany"
            };
            Option opt10 = new Option
            {
                OptionLetter = 'B',
                OptionText = "Brazil"
            };
            Option opt11 = new Option
            {
                OptionLetter = 'C',
                OptionText = "Australia"
            };
            Option opt12 = new Option
            {
                OptionLetter = 'D',
                OptionText = "Japan"
            };
            Option opt13 = new Option
            {
                OptionLetter = 'A',
                OptionText = "China"
            };
            Option opt14 = new Option
            {
                OptionLetter = 'B',
                OptionText = "Italy"
            };
            Option opt15 = new Option
            {
                OptionLetter = 'C',
                OptionText = "India"
            };
            Option opt16 = new Option
            {
                OptionLetter = 'D',
                OptionText = "Argentina"
            };

            //lists of options
            List<Option> options1 = new List<Option>();
            options1.Add(opt1);
            options1.Add(opt2);
            options1.Add(opt3);
            options1.Add(opt4);
            List<Option> options2 = new List<Option>();
            options2.Add(opt5);
            options2.Add(opt6);
            options2.Add(opt7);
            options2.Add(opt8);
            List<Option> optionsA = new List<Option>();
            optionsA.Add(opt9);
            optionsA.Add(opt10);
            optionsA.Add(opt11);
            optionsA.Add(opt12);
            List<Option> optionsB = new List<Option>();
            optionsB.Add(opt13);
            optionsB.Add(opt14);
            optionsB.Add(opt15);
            optionsB.Add(opt16);

            //Questions
            Question question1 = new Question();
            question1.QuestionText = "What is the Capital of U.S.A.?";
            question1.CorrectAnswerLetter = 'B';
            question1.Options = options1;
            Question question2 = new Question();
            question2.QuestionText = "What is the Capital of France?";
            question2.CorrectAnswerLetter = 'D';
            question2.Options = options2;
            Question question3 = new Question();
            question3.QuestionText = "Where can you find a kangaroo?";
            question3.CorrectAnswerLetter = 'C';
            question3.Options = optionsA;
            Question question4 = new Question();
            question4.QuestionText = "Where can you find a giant panda?";
            question4.CorrectAnswerLetter = 'A';
            question4.Options = optionsB;

            //TestPaper 1 with a list of questions
            TestPaper testPaper1 = new TestPaper();
            testPaper1.TestPaperName = "Test 1";
            testPaper1.SubjectName = "Capitals";
            testPaper1.Questions = new List<Question>() { question1, question2 };
            //TestPaper 2 with a list of questions
            TestPaper testPaper2 = new TestPaper();
            testPaper2.TestPaperName = "Test 2";
            testPaper2.SubjectName = "Animals";
            testPaper2.Questions = new List<Question>() { question3, question4 };

            //Student's details with a list of TestPapers
            Console.WriteLine("PLEASE ENTER STUDENT'S DETAILS");
            Console.WriteLine();
            Student student = new Student();
            string roll;
            label1:
            Console.WriteLine("Enter student's Roll Number:");
            roll = Console.ReadLine();
            bool b = int.TryParse(roll, out int number);
            while(true)
            {
                if (b == true)
                {
                    student.RollNo = number;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    goto label1;
                }
            }
            Console.WriteLine("Enter student's full name:");
            student.StudentName = Console.ReadLine();
            student.TestPapers = new List<TestPaper>() { testPaper1,testPaper2 };

            //initialize a choice for do/while loop
            int choice = -1;
            do
            {
                Console.WriteLine("\nMenu:"); //Main Menu
                Console.WriteLine("1:Test Paper 1 ");
                Console.WriteLine("2:Test Paper 2 ");
                Console.WriteLine("0:Exit ");
                Console.WriteLine("Please enter a choice:");
                string input;
                label2:
                input = Console.ReadLine();
                bool bo = int.TryParse(input, out int num);
                while (true)
                {
                    if (bo == true)
                    {
                        choice = num;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        Console.WriteLine("Enter 1 or 2 or 0:Exit!");
                        goto label2;
                    }
                }
                //choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: //TestPaper 1
                        Console.WriteLine("Question 1:");
                        Console.WriteLine(question1.QuestionText);
                        question1.displayOptions(options1);
                        Console.Write("Enter your choice: ");
                        question1.OptionSelectedByStudent = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Student's answer: " + question1.OptionSelectedByStudent);
                        Console.WriteLine("Correct answer: " + question1.CorrectAnswerLetter);
                        question1.MarksSecured = 1;
                        Console.WriteLine("Marks: " + question1.MarksSecured);
                        Console.WriteLine();
                        Console.WriteLine("Question 2:");
                        Console.WriteLine(question2.QuestionText);
                        question2.displayOptions(options2);
                        Console.Write("Enter your choice: ");
                        question2.OptionSelectedByStudent = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Student's answer: " + question2.OptionSelectedByStudent);
                        Console.WriteLine("Correct answer: " + question2.CorrectAnswerLetter);
                        question2.MarksSecured = 1;
                        Console.WriteLine("Marks: " + question2.MarksSecured);
                        int totalMarks = question1.MarksSecured + question2.MarksSecured;
                        Console.WriteLine();
                        Console.WriteLine("Student name: " + student.StudentName + ", " + "Roll No: " + student.RollNo);
                        Console.WriteLine("Test Paper: " + testPaper1.TestPaperName + ", Subject: " + testPaper1.SubjectName + ", Total Marks: " + totalMarks);
                        Console.WriteLine("Enter a key to continue!");
                        Console.ReadKey();
                        break;
                    case 2: //TestPaper 2
                        Console.WriteLine("Question 1:");
                        Console.WriteLine(question3.QuestionText);
                        question3.displayOptions(optionsA);
                        Console.Write("Enter your choice: ");
                        question3.OptionSelectedByStudent = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Student's answer: " + question3.OptionSelectedByStudent);
                        Console.WriteLine("Correct answer: " + question3.CorrectAnswerLetter);
                        question3.MarksSecured = 1;
                        Console.WriteLine("Marks: " + question3.MarksSecured);
                        Console.WriteLine();
                        Console.WriteLine("Question 2:");
                        Console.WriteLine(question4.QuestionText);
                        question4.displayOptions(optionsB);
                        Console.Write("Enter your choice: ");
                        question4.OptionSelectedByStudent = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Student's answer: " + question4.OptionSelectedByStudent);
                        Console.WriteLine("Correct answer: " + question4.CorrectAnswerLetter);
                        question4.MarksSecured = 1;
                        Console.WriteLine("Marks: " + question4.MarksSecured);
                        int totalMarks2 = question3.MarksSecured + question4.MarksSecured;
                        Console.WriteLine();
                        Console.WriteLine("Student name: " + student.StudentName + ", " + "Roll No: " + student.RollNo);
                        Console.WriteLine("Test Paper: " + testPaper2.TestPaperName + ", Subject: " + testPaper2.SubjectName + ", Total Marks: " + totalMarks2);
                        Console.WriteLine("Enter a key to continue!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Thanks!");
                        break;
                } 
            } while (choice != 0); //continue do/while loop when choice is not 0 
        }
    }
}
