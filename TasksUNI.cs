using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // gather data 

            Console.WriteLine("Enter Student Name:");
            string sName = Console.ReadLine();

            Console.WriteLine("Enter Student Gender:");
            string sGender = Console.ReadLine();

            Console.WriteLine("Enter Student ID:");
            int sId = int.Parse(Console.ReadLine());

            Course[] myCoursesList =
            {
                new Course("MATH", "MA101", 99),
                new Course("Programming", "CS202", 89),
                new Course("Electronic circuits", "ESE303", 100)
            };

            
            Student student = new Student(sName, sId, sGender, myCoursesList);

            
            Console.WriteLine($"\n--- Details for {student.name} ---");

            
            for (int i = 0; i < myCoursesList.Length; i++)
            {
                
                Console.WriteLine(student[i]);
            }
        }

        // courses struct 
        struct Course
        {
            public string courseName { get; set; }
            public string courseCode { get; set; }
            public double courseDegree { get; set; }

            public Course(string name, string code, double degree)
            {
                courseName = name;
                courseCode = code;
                courseDegree = degree;
            }

            public override string ToString()
            {
                return $"Course Code: {courseCode} | Course Name: {courseName} | Degree: {courseDegree}";
            }
        }

        // student struct
        struct Student
        {
            public string name { get; set; }
            public int Id { get; set; }
            public string Gender { get; set; }

            
            public Course[] courses;

            public Student(string _name, int _id, string _gender, Course[] _courses)
            {
                name = _name;
                Id = _id;
                Gender = _gender;
                courses = _courses;
            }

            
            public Course this[int index]
            {
                get
                {
                   
                    if (courses != null && index >= 0 && index < courses.Length)
                    {
                        return courses[index];
                    }

                    
                    return new Course("Not Found", "N/A", 0.0);
                }
                set
                {
                    if (courses != null && index >= 0 && index < courses.Length)
                    {
                        courses[index] = value;
                    }
                }
            }
        }
    }
}
