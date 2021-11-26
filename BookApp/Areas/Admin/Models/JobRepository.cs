using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class JobRepository : BaseRepository
    {
        public List<Job> GetJob()
        {
            return GetList<Job>("GetJob", connectionString);
        }
        public List<Job> GetJobByIdjob(int id)
        {
            Parameter[] parameters =
                {
                new Parameter { Name="@Id",Value=id,DbType=System.Data.DbType.Int32}
                };
            return GetList<Job>("GetJobByIdjob", parameters, connectionString);
        }
    }
}
