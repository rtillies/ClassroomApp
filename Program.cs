using ClassroomApp;

var alex = new Student { FirstName = "Alex", LastName = "Bukhmirov", Age = 19 };
var braden = new Student { FirstName = "Braden", LastName = "Smith", Age = 18 };
var eli = new Student { FirstName = "Eli", LastName = "Paris", Age = 19 };
var isiah = new Student { FirstName = "Isiah", LastName = "Worsham", Age = 20 };
var james = new Student { FirstName = "James", LastName = "Cepriano", Age = 18 };
var jeremy = new Student { FirstName = "Jeremy", LastName = "Kimball", Age = 21 };
var joe = new Student { FirstName = "Joe", LastName = "Centeno", Age = 22 };
var rafi = new Student { FirstName = "Rafi", LastName = "Wick", Age = 18 };
var seth = new Student { FirstName = "Seth", LastName = "Grinstead", Age = 20 };
var skylar = new Student { FirstName = "Skylar", LastName = "Sandler", Age = 24 };
var students = new List<Student> { alex, braden, eli, isiah, james, jeremy, joe, rafi, seth, skylar };

var launch = new Course { Name = "Launch Program", Capacity = 4 };
var fee = new Course { Name = "Front-End Engineering", Capacity = 7 };
var bee = new Course { Name = "Backend Engineering", Capacity = 5 };

using (var context = new ClassroomContext())
{
    // CREATE
    foreach (var student in students)
    {
        context.Students.Add(student);
    }
    context.SaveChanges();

    // READ
    displayStudents(context);
}

void displayStudents(ClassroomContext context)
{
    foreach (var s in context.Students)
    {
        Console.WriteLine($"Student: {s.FirstName} {s.LastName}, Age {s.Age}");
    }
}

void displayCourses(ClassroomContext context)
{

}

