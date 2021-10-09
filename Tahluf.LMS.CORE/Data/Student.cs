using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tahluf.LMS.CORE.Data
{
   public class Student
    {
        [Key]
        public int studentid { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public DateTime birthdate { get; set; }
        public double mark { get; set; }
        public ICollection<StudentCourse> StudentCourses
        {

            get; set;
        }

    }
}
