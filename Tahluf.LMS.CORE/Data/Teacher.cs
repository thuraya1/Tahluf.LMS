using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tahluf.LMS.CORE.Data
{
    public class Teacher
    {
        [Key]
        public int teachertid { get; set; }

        public string teachername { get; set; }
        public string email { get; set; }

        public string phone { get; set; }
        public double salary { get; set; }

        public int loginid { get; set; }

        public ICollection<TeacherCourse> TeacherCourses
        {

            get; set;
        }

        [ForeignKey("loginid")]

        public virtual Login Login { get; set; }
    }
    

}
