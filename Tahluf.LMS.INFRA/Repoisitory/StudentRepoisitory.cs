using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahluf.LMS.CORE.Common;
using Tahluf.LMS.CORE.Data;
using Tahluf.LMS.CORE.Repoisitory;

namespace Tahluf.LMS.INFRA.Repoisitory
{
   public class StudentRepoisitory: IStudentRepoisitory
    {

        private IDBContext dBContext;
       

        public StudentRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;



        }

        public bool deletestd(int id)
        {
            var p= new DynamicParameters();
            p.Add("@id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("deletestd", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Student> getallstd()
        {

            IEnumerable<Student> result = dBContext.Connection.Query<Student>("getallstd", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Student getstdudentbyid(int id)
        {
           var par= new DynamicParameters();
            par.Add("@id", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
            var result= dBContext.Connection.Query<Student>("getstdudentbyid", par, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool insertstd(Student student)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@fname", student.fname, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@lname", student.lname, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@birthdate", student.birthdate, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);
            parameters.Add("@mark", student.mark, dbType: System.Data.DbType.Double, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("insertstd", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool updatestd(Student student)
        {

            var param = new DynamicParameters();
            param.Add("@id", student.studentid, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Input);
            param.Add("@fname", student.fname, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            param.Add("@lname", student.lname, dbType: System.Data.DbType.String, direction: System.Data.ParameterDirection.Input);
            param.Add("@birthdate", student.birthdate, dbType: System.Data.DbType.DateTime, direction: System.Data.ParameterDirection.Input);
            param.Add("@mark", student.mark, dbType: System.Data.DbType.Double, direction: System.Data.ParameterDirection.Input);
            var result = dBContext.Connection.Execute("updatestd", param, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
