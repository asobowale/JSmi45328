// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
Console.WriteLine("**************************************");
Console.WriteLine("Hello, World!");
Console.WriteLine("**************************************");
Console.WriteLine("");

// Another modification scripts
Console.WriteLine(""); // creating white space
Console.WriteLine("What is your name?");

// variable studentName decalation and definition
var studentName = Console.ReadLine();

Console.WriteLine(""); // creating white space
// this is the prompt to enter courseNum
Console.WriteLine("What is this course number?");
// variable studentName decalation and definition
var CourseNum = Console.ReadLine();

// Console.WriteLine() to display the content
Console.WriteLine($"{Environment.NewLine} Hello, {studentName}!");
Console.WriteLine($"{Environment.NewLine}You are welcome to {CourseNum} \n");
