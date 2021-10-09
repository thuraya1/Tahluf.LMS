using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tahluf.LMS.CORE.Data
{
     public class Login
    {
        [Key]
        public int id { get; set; }
        
        public string username { get; set; }
        public string password { get; set; }
        
        public string rolename { get; set; }
        public ICollection<Teacher> Teacher
        {

            get; set;
        }
    }
}
