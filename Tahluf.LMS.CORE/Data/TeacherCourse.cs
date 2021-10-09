using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tahluf.LMS.CORE.Data
{
  public  class TeacherCourse
    {
        public int teachercourseid { get; set; }
        public int teachertid { get; set; }
        public int couresid { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
        [ForeignKey("TeacherId")]

        public virtual Teacher Teacher { get; set; }

    }
}
