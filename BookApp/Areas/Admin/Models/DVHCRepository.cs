using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class DVHCRepository : BaseRepository
    {
        public List<DVHC> GetProvince()
        {
            return GetList<DVHC>("GetProvince",  connectionString);
        }
        public List<DVHC> GetDVHCByParentId(int id)
        {
            Parameter[] parameters =
                {
                new Parameter { Name="@Id",Value=id,DbType=System.Data.DbType.Int32}
                };
            return GetList<DVHC>("GetDonViHanhChinhByIdParent", parameters, connectionString);
        }
    }
}
