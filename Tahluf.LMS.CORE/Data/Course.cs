using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tahluf.LMS.CORE.Data
{
   public class Course
    {
        [Key]
        public int couresid { get; set; }
        public string coursename { get; set; }
        public double price { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }

        public ICollection<Book> Books { get; set; }

        public ICollection<TeacherCourse> TeacherCourses
        {
            get;

            set;
        }

        public ICollection<StudentCourse> StudentCourses
        {
            get;

            set;
        }


    }
}
