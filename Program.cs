using System;

public class Program
{
    public static void Main()
    {
        var student = new Person.Student
        {
            Name = "Saimon",
            Age = 20,
            Gender = "Male",
            Address = "1k3 Kasiglahan Village.",
            ContactNumber = "0924832552",
            School = "Colegio De Montalban"
        };

        var teacher = new Person.Teacher
        {
            Name = "Mr. lagerson",
            Age = 35,
            Gender = "Male",
            Address = "1k2 kasiglahan Village.",
            ContactNumber = "0923445323",
            Subject = "Mathematics"
        };

        var admin = new Person.Admin
        {
            Name = "Ms. Maricar",
            Age = 25,
            Gender = "Female",
            Address = "342 1k1 kasiglahan village.",
            ContactNumber = "0944323223",
            Faculty = "Registrar office"
        };

        student.DisplayInfo();
        student.Speak();
        student.Study();

        Console.WriteLine();

        teacher.DisplayInfo();
        teacher.Speak();
        teacher.Teach();

        Console.WriteLine();

        admin.DisplayInfo();
        admin.Manage();
        admin.Eat();
    }
}
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }

    public void Speak()
    {
        Console.WriteLine($"{Name} is speaking");
    }
    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping");
    }
    public void Walk()
    {
        Console.WriteLine($"{Name} is walking");
    }
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }
    public void Watch()
    {
        Console.WriteLine($"{Name} is watching");
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}, Address: {Address}, ContactNumber: {ContactNumber}");
    }

    public class Student : Person
    {
        public string School { get; set; }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying at {School}");
        }
    }

    public class Teacher : Person
    {
        public string Subject { get; set; }

        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching the {Subject}");
        }
    }

    public class Admin : Person
    {
        public string Faculty { get; set; }

        public void Manage()
        {
            Console.WriteLine($"{Name} is managing at the {Faculty}");
        }
    }
}


