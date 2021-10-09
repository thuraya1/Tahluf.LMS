using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tahluf.LMS.CORE.Data
{
   public class StudentCourse
    {
        public int id { get; set; }
        public int studentid { get; set; }
        public int couresid { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
        [ForeignKey("StudentId")]

        public virtual Student Student { get; set; }
    }
}
