using Newtonsoft.Json;
using System;
using System.Text;
using System.Xml;
using TestProject;

//StringTasks stringTasks = new StringTasks();
//stringTasks.Run();

//ConditionalsTasks conditionalsTasks = new ConditionalsTasks();
//conditionalsTasks.Run();

//Square greenSquare = new Square(5, "green");
//Square blueSqeareSquare = new Square(2, "blue");
//Square lightBlueSquare = new Square(15, "light blue");

//greenSquare.SquareInformation();
//blueSqeareSquare.SquareInformation();
//lightBlueSquare.SquareInformation();

//greenSquare.side = blueSqeareSquare.side * 3;

//greenSquare.SquareInformation();
//blueSqeareSquare.SquareInformation();
//lightBlueSquare.SquareInformation();

//var penguin1 = new Penguin("Mattew", "Perry");
//var penguin2 = new Penguin("Cherry");
//var penguin3 = new Penguin();

//penguin1.Age = 1;
//penguin2.Age = 17;
//penguin3.Age = 18;

//penguin3.ChangeName("Bob");

//penguin1.RightWingItem = "beaver";
//penguin2.RightWingItem = "knife";
//penguin3.RightWingItem = "knife";

//penguin1.TellAboutYOuerself();
//penguin2.TellAboutYOuerself();
//penguin3.TellAboutYOuerself();

var student1 = new Student("Bob", "Peris", "Viktorivich");
student1.Age = 23;
student1.Group = "401C";

int[] student1ProgrammingMarks = new int[] { 7, 6, 9, 2, 3 };

student1.AddMark("Design", 9);
student1.AddMark("History", 6);
foreach (int i in student1ProgrammingMarks) 
{
    student1.AddMark("Programming", i); 
}
student1.Info();

Console.WriteLine(student1.AverageMark("Administration"));
