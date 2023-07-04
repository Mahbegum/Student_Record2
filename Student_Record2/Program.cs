using System;

namespace Student_Record2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Bill" };
                _ = ctx.Students.Add(student);
                object p1 = ctx.SaveChanges();
            }
            Console.WriteLine("Demo completed.");
            Console.ReadLine();
        }

        private class SchoolContext : IDisposable
        {
            internal readonly object Students;

            public SchoolContext()
            {
            }

            public SchoolContext(object students)
            {
                Students = students;
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            internal object SaveChanges()
            {
                throw new NotImplementedException();
            }
        }
    }
   }
