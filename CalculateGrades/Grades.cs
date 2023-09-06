namespace CalculateGrades
{
    public class Grades
    {
        public List<int> GradeList = new List<int>();

        public List<string> LabeledGrades = new List<string>();

        public bool Continue = true;


        public void StartApplication()
        {
            Continue = true;
            Console.WriteLine("Welcome to our Calculate Grade Application!");

            Console.WriteLine("_________________________");

            Console.WriteLine("Could you please tell us your name, we are so excited to know you");

            var name = Console.ReadLine();

            Console.WriteLine(
                $"Hello {name}!, if you press enter the program will start taking grades from you, they will be added one by one.\n");

            Console.WriteLine("When you want to stop adding grades press: 0\n");

            var keepAdding = true;

            while (keepAdding)
            {
                var grade = int.Parse(Console.ReadLine() ?? string.Empty);
                if (grade != 0)
                {
                    AddGrade(grade);
                }
                else
                {
                    keepAdding = false;
                }
            }

            Console.WriteLine("Adding grades ...");

            Console.WriteLine("The adding process is complete!");

            Console.WriteLine("Press 'show' if you want to see all the grades\n" +
                              "Press 'calculate' to see the sum of all grades together\n" +
                              "Press 'label' if you want to see all grades labeled alphabetically\n" +
                              "Press 'restart' if you want to restart the application and start again\n" +
                              "Press 'exit' if you want to quit the application");
        }


        private void AddGrade(int grade)
        {
            if (grade > 0 && grade < 100.00)
            {
                GradeList.Add(grade);
            }
            else
            {
                Console.WriteLine("The grade should be more than 0 and less than 100.");
            }
        }

        private double CalculateGrades()
        {
            return GradeList.Sum();
        }

        private void LabelGrades()
        {
            foreach (var grade in GradeList)
            {
                if (grade > 80)
                {
                    LabeledGrades.Add("A");
                }
                else if (grade > 60 && grade < 80)
                {
                    LabeledGrades.Add("B");
                }
                else if (grade > 50 && grade < 60)
                {
                    LabeledGrades.Add("C");
                }
                else
                {
                    LabeledGrades.Add("F");
                }
            }
        }

        private void ResetGradesLists()
        {
            GradeList.Clear();
            LabeledGrades.Clear();
        }

        public void CheckCommand(string? command)
        {
            if (command.ToLower() == "show")
            {
                foreach (var grade in GradeList)
                {
                    Console.WriteLine(grade);
                }

                while (Continue)
                {
                    ReCommand();
                }
            }

            else if (command.ToLower() == "calculate")
            {
                Console.WriteLine(CalculateGrades());

                while (Continue)
                {
                    ReCommand();
                }
            }
            else if (command.ToLower() == "label")
            {
                LabelGrades();
                foreach (var labeledGrade in LabeledGrades)
                {
                    Console.WriteLine(labeledGrade);
                }

                while (Continue)
                {
                    ReCommand();
                }
            }
            else if (command.ToLower() == "restart")
            {
                ResetGradesLists();
                StartApplication();
            }
            else if (command.ToLower() == "exit")
            {
                Console.WriteLine("\nThank you for using my test application!");
            }
        }

        private void ReCommand()
        {
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("\nPress 'show' if you want to see all the grades\n" +
                              "Press 'calculate' to see the sum of all grades together\n" +
                              "Press 'label' if you want to see all grades labeled alphabetically\n" +
                              "Press 'restart' if you want to restart the application and start again\n" +
                              "Press 'exit' if you want to quit the application");

            CheckCommand(Console.ReadLine());
        }
    }
}