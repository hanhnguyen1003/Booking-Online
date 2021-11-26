using System.Collections.Generic;
using System.Data;
using WebApp.Models;

namespace WebApp.Areas.Admin.Models
{
    public class MeGroupRepository : BaseRepository
    {
        public MeGroup GetMeGroupByIdMeGroup(string idmegroup)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdMeGroup",Value=idmegroup,DbType=DbType.String}
            };
            return GetSingle<MeGroup>("GetMeGroupByIdMeGroup", parameters, connectionString);
        }
        public List<MeGroup> GetMeGroup()
        {
            return GetList<MeGroup>("GetMeGroup",  connectionString);
        }
        public int Delete(string idmegroup)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdMeGroup",Value=idmegroup,DbType=DbType.String}
            };
            return Save("DeleteMeGroup", parameters);
        }
        public int Edit(MeGroup obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdMeGroup",Value=obj.IdMeGroup,DbType=DbType.String},
			new Parameter{Name="@MeGroupName",Value=obj.MeGroupName,DbType=DbType.String}
            };
            return Save("EditMeGroup", parameters);
        }
        public int Add(MeGroup obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdMeGroup",Value=obj.IdMeGroup,DbType=DbType.String},
			new Parameter{Name="@MeGroupName",Value=obj.MeGroupName,DbType=DbType.String}
            };
            return Save("AddMeGroup", parameters);
        }
    }
}