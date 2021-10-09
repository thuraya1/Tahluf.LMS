using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tahluf.LMS.CORE.Data
{
   public class Book
    {
        [Key]
        public int bookid { get; set; }
        public string bookname { get; set; }
        public double price { get; set; }
        public string publisher { get; set; }
        public DateTime enddate { get; set; }
        public int couresid { get; set; }
        
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }

        


    }
}
