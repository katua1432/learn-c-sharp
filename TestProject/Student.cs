namespace TestProject
{
    internal class Student
    {
        private string _name;
        private string _surname;
        private string _fatherName;

        private List<int> _programmingMarks;
        private List<int> _administrationMarks;
        private List<int> _designMarks;

        public int Age { get; set; }
        public string Group { get; set; }

        public Dictionary<string, List<int>> _marksDictionary = new Dictionary<string, List<int>>();

        public Student(string name, string surname, string fatherName)
        {
            _name = name;
            _surname = surname;
            _fatherName = fatherName;

            _programmingMarks = new List<int>();
            _administrationMarks = new List<int>();
            _designMarks = new List<int>();
        }

        public void AddMark(string subject, int mark)
        {
            switch (subject)
            {
                case "Programming":
                    _programmingMarks.Add(mark);
                    break;
                case "Administration":
                    _administrationMarks.Add(mark);
                    break;
                case "Design":
                    _designMarks.Add(mark);
                    break;
                default:
                    Console.WriteLine($"Error: the mark ({mark}) of {_name} {_surname} to the {subject} subject is not added.");
                    break;
            }

        }

        public void Info() 
        {
            Console.WriteLine($"Student name: {_name + " " + _surname + " " + _fatherName}");
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Group: " + Group);
            Console.WriteLine("Programming marks: " + string.Join(", ", _programmingMarks));
            Console.WriteLine("Design marks: " + string.Join(", ", _designMarks));
            Console.WriteLine("Administration marks: " + string.Join(", ", _administrationMarks));
        }

        public double AverageMark (string subject) 
        {
            switch (subject)
            {
                case "Programming":
                    if (_programmingMarks.Count > 0)
                    {
                        return _programmingMarks.Average();
                    }
                    else 
                    {
                        return 0; 
                    }

                case "Administration":
                    if (_administrationMarks.Count > 0)
                    {
                        return _administrationMarks.Average();
                    }
                    else
                    {
                        return 0;
                    }

                case "Design":
                    if (_designMarks.Count > 0)
                    {
                        return _designMarks.Average();
                    }
                    else
                    {
                        return 0;
                    }

                default: 
                    Console.WriteLine($"Error: average {subject} mark for {_name + " " + _surname} could not be got.");
                    return 0;
            }
        
        }
    }

}
