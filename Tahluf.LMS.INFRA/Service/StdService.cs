using System;
using System.Collections.Generic;
using System.Text;
using Tahluf.LMS.CORE.Common;
using Tahluf.LMS.CORE.Data;
using Tahluf.LMS.CORE.Repoisitory;
using Tahluf.LMS.CORE.Service;

namespace Tahluf.LMS.INFRA.Service
{
    public class StdService: IStdService
    {
        private readonly IStudentRepoisitory istd;


        public StdService(IStudentRepoisitory istd)
        {
            this.istd = istd;



        }

        public bool deletestd(int id)
        {
            return istd.deletestd(id);
        }

        public List<Student> getallstd()
        {
            return istd.getallstd();
        }

        public Student getstdudentbyid(int id)
        {
            return istd.getstdudentbyid(id);
        }

        public bool insertstd(Student student)
        {
            return istd.insertstd(student);
        }

        public bool updatestd(Student student)
        {
            return istd.updatestd(student);
        }
    }
}
