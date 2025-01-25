
//List<Student> studentList = new List<Student>();
//while (true)
//{
//    Console.Write("Enter Name:");
//    string ename = Console.ReadLine();
//    Console.Write("Enter Age:");
//    int eage = Convert.ToInt32(Console.ReadLine());
//    studentList.Add(new Student {name=ename,age=eage});

//    Console.WriteLine("Name \t Age");
//  foreach (var student in studentList)
//    {
//        Console.Write(student.name +"\t");
//        Console.WriteLine(student.age);
//    }
//}
//public class Student
//{
//    public string name { get; set; }
//    public int age { get; set; }
//}

using ConsoleApp1;

Child childobj = new Child();

childobj.sum(5,6);
childobj.substract(9, 6);
childobj.multiply(5, 6);
childobj.division(6, 3);