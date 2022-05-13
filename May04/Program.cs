using System;
using System.Collections.Generic;
using System.Linq;


namespace May04
{
    public class Program
    {
        static void Main(string[] args)
        {
           var value = Student.Getstudent();

            int[] odd = {1,3,5,7,9, 11,13,15,17,19};
            int[] even = { };
            int[] onenum = { 1,1,1,1,1,1,1,1,1,1,1,1,1};
            //thred
            //// Quantifiers
            //// any
            //var num = odd.Any(x => x >= 9);
            //Console.WriteLine(num);

            //all
            var newnum = onenum.All(x => x ==1);
            Console.WriteLine(newnum);


            var items = value.SelectMany(x => x.courses, (student,dept)=> new
            {
                student,dept
            }
                );
            foreach(var item in items)
            {
                Console.WriteLine($"{item.dept} {item.student.Place}: {item.student.Name}");
            }

            // convertion of lis to dictionary
            var product = value.ToDictionary(s => s.Name);
            foreach(var pro in product.Keys)
            {
                Console.WriteLine($"key:{pro} => value:{product[pro].Place }");
            }
        }
    }

    public class Student
    {
        public string Place { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public List<string> courses {get; set; }
        

        public static List<Student> Getstudent()
        {
            return new List<Student>
            {
                new Student{Id= 1,Name = "John", Place = "Lagos", courses = new List<string>{"bio111", "chem111", "phy111", "mat111", "csc 111"} },
                new Student{Id =2, Name = "Edward", Place = "ibadan", courses = new List<string>{"bio111", "chem111", "phy111", "mat111", "csc 111"} },
                new Student{ Id=3, Name = "Ali", Place = "river", courses = new List<string>{"bio111", "chem111", "phy111", "mat111", "csc 111"} },
                new Student{Id =4, Name = "jum", Place = "Lagos", courses = new List<string>{"bio111", "chem111", "phy111", "mat111", "csc 111"} },

            };
        }
    }
}
