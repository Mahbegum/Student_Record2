using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Record2
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public byte[] RowVersion { get; set; }

        //fully defined relationship
        public int? GradeId { get; set; }

        private Grade grade;

        public virtual Grade GetGrade()
        {
            return grade;
        }

        public virtual void SetGrade(Grade value)
        {
            grade = value;
        }

        public virtual StudentAddress Address { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public class Grade
        {
        }
    }
}
