namespace TestProject
{
    public class Penguin
    {
        private static readonly int _teeth;
        private static readonly int _legs;

        private readonly string _familyName;

        private string _name;
        private string _rightWingItem;

        public int Age { get; set; }

        public string RightWingItem 
        {
            get { return _rightWingItem; } 
            set 
            { 
                if (Age < 18 && value == "knife")
                {
                    Console.WriteLine("Don't give a knife to the baby penguin");
                }
                else
                {
                    _rightWingItem = value;
                }
            } 
        }

        static Penguin()
        {
            Console.WriteLine("Primordial Penguin has been created");
            _teeth = 0;
            _legs = 2;
        }

        public Penguin()
        {
            Console.WriteLine($"A baby penguin was found. Nobody wants him. Poor baby.");
        }

        public Penguin(string name)
        {
            Console.WriteLine($"A baby {name} penguin was born.");
            _name = name;
        }

        public Penguin(string name, string familyName)
        {
            Console.WriteLine($"A baby {name} penguin was born. To the {familyName} family");
            _name = name;
            _familyName = familyName;
        }

        public void ChangeName(string name)
        {
            _name = name;
        }

        public void TellAboutYOuerself()
        {
            Console.WriteLine($"My name is {_name}. Quach, Quack!");
            if(!string.IsNullOrEmpty(_familyName))
            {
                Console.WriteLine($"My last name is {_familyName}. Quach, Quack!");
            }
            Console.WriteLine($"I have {_teeth} teeth, I have {_legs} legs. Quach, Quack!");
            Console.WriteLine($"And I have a {RightWingItem} in my right wing");
        }
    }
}
