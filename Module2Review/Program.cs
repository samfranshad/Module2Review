using Module2Review;

// Creates new list of students, 4 instances of Students, and adds those instances to the students list

var students = new List<Student>();

var studentOne = new Student() { Name = "Megan", ID = 320, Grades = new List<double>() { } };
var studentTwo = new Student() { Name = "Jimmy", ID = 644, Grades = new List<double>() { } };
var studentThree = new Student() { Name = "Casey", ID = 164, Grades = new List<double>() { } };
var studentFour = new Student() { Name = "Jacob", ID = 067, Grades = new List<double>() { } };

students.Add(studentOne);
students.Add(studentTwo);
students.Add(studentThree);
students.Add(studentFour);

// Adds students grades to the Grades list and calculate averages

studentOne.AddGrade(92.6);
studentOne.AddGrade(87.3, 96.1, 82.9, 85.8);

studentTwo.AddGrade(88.2);
studentTwo.AddGrade(95.2, 91.6, 84.5, 87.4);

studentThree.AddGrade(99.4);
studentThree.AddGrade(93.7, 95.5, 89.1, 92.8);

studentFour.AddGrade(93.4);
studentFour.AddGrade(96.9, 91.8, 88.3, 90.7);


// Prints student information and grades to console

Console.WriteLine("Student\t\tID #\t\t\tGrades\t\t\tAverage Grade");

foreach (var student in students)
{
    Console.Write($"{student.Name}\t\t{student.ID}\t\t");
    foreach (var grade in student.Grades)
    {
        Console.Write($"{grade} ");
    }
    Console.WriteLine($"\t   {student.CalculateAverageGrade()}");
}


