using System;
using System.Collections.Generic;
using System.Text;
using Tahluf.LMS.CORE.Data;

namespace Tahluf.LMS.CORE.Service
{
    public interface IStdService
    {
        public List<Student> getallstd();

        public bool insertstd(Student student);
        public bool updatestd(Student student);
        public bool deletestd(int id);
        public Student getstdudentbyid(int id);
    }
}
