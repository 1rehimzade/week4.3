//namespace ConsoleApp4
//{
//    internal class Program
//    {

//        static void Main(string[] args)
//        {
//            Employee employee = new Employee("Nihat", 5000);
//            Console.WriteLine("Employee Salary: " + employee.Salary);

//            Assistant assistant = new Assistant("JETT", 3000);
//            assistant.GetFeedback(true);
//            Console.WriteLine("Assistant Salary: " + assistant.Salary);
//        }

//        public class Employee
//        {
//            public string Name { get; set; }
//            private double _salary;

//            public double Salary
//            {
//                get { return _salary; }
//                set { _salary = value; }
//            }

//            public Employee(string name, double salary)
//            {
//                Name = name;
//                Salary = salary;
//            }

//            public Employee GetPromotion()
//            {
//                Salary += 100;
//                return this;
//            }
//        }

//        public class Assistant : Employee
//        {
//            public Assistant(string name, double salary) : base(name, salary) { }

//            public void GetFeedback(bool isSuccessful)
//            {
//                if (isSuccessful)
//                {
//                    GetPromotion();
//                }
//            }
//        }

//    }
//}
//using System;

//public class Student
//{
//    static void Main()
//    {
//        Student student = new Student();

//        Console.WriteLine("\nYeni öğrenci bilgileri:");
//        Console.WriteLine("Ad: " + student.Name);
//        Console.WriteLine("Yaş: " + student.Age);
//        Console.WriteLine("Qiymet: " + student.Grade);
//    }
//    public string Name { get; private set; }
//    public int Age { get; private set; }
//    public int Grade
//    {
//        get; private set;
//    }
//    public Student()
//    {
//        SetName();
//        SetAge();
//        SetGrade();
//    }

//    private void SetName()
//    {
//        while (true)
//        {
//            Console.Write("Adı daxil edin: ");
//            string name = Console.ReadLine();
//            if (IsNameValid(name))
//            {
//                Name = name;
//                break;
//            }
//            else
//            {
//                Console.WriteLine("Ad uygun deyil. Yeniden daxil edin.");
//            }
//        }
//    }

//    private void SetAge()
//    {
//        while (true)
//        {
//            Console.Write("Yaşı daxil edin: ");
//            if (int.TryParse(Console.ReadLine(), out int age) && age > 0)
//            {
//                Age = age;
//                break;
//            }
//            else
//            {
//                Console.WriteLine("Yaş uygun deyil. Yeniden daxil edin.");
//            }
//        }
//    }

//    private void SetGrade()
//    {
//        while (true)
//        {
//            Console.Write("Qiymeti daxil edin: ");
//            if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
//            {
//                Grade = grade;
//                break;
//            }
//            else
//            {
//                Console.WriteLine("Qiymet uygun deyil. Yeniden daxil edin.");
//            }
//        }
//    }

//    private bool IsNameValid(string name)
//    {
//        if (string.IsNullOrWhiteSpace(name) || char.IsDigit(name[0]) || char.IsWhiteSpace(name[0]) || char.IsWhiteSpace(name[name.Length - 1]))
//        {
//            return false;
//        }
//        foreach (char c in name)
//        {
//            if (char.IsDigit(c))
//            {
//                return false;
//            }
//        }
//        return true;
//    }
//}