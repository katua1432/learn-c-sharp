using Newtonsoft.Json;
using System;
using System.Text;
using System.Xml;
using TestProject;

//StringTasks stringTasks = new StringTasks();
//stringTasks.Run();

//ConditionalsTasks conditionalsTasks = new ConditionalsTasks();
//conditionalsTasks.Run();



//task 1
var myXmlText = "<root> <title>users storage</title> <user id='1'> <name>Vasya</name> </user> <user id='2'> <name>Kolya</name> </user> </root>";

XmlDocument doc = new XmlDocument();
doc.LoadXml(myXmlText);
string json = JsonConvert.SerializeXmlNode(doc);
Console.WriteLine(json);

//task 2

static void SayVasya()
{
    Console.WriteLine("My name is Vasya");
}

static void SayKolya()
{
    Console.WriteLine("My name is Kolya");
}

//task 3
static void SayName(string name)
{
    Console.WriteLine($"My name is {name}.");
}
//SayName("Katya");
//SayName("Misha");

//task 4,5,6
static void SayNameAndAge(string name, int age)
{
    if (age == 1)
    {
        Console.WriteLine($"My name is {name} and I'm 1 year old.");
    }
    else if (age == 0)
    {
        return;
    }
    else
    {
        Console.WriteLine($"My name is {name} and I'm {age} years old.");
    }

}
//SayNameAndAge("Alex", 1);
//SayNameAndAge("Marry", 22);
//SayNameAndAge("test", 0);

//taks 7



