using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Record2
{
    class Teachers
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public TeachingMode ModeOfTeaching { get; set; }
    }

    public enum TeachingMode
    {
        Online,
        ClassRoom,
        LiveOnline
    }
}
