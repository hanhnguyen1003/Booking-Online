using System.Collections.Generic;
using System.Data;
namespace WebApp.Areas.Admin.Models
{
    public class EducationRepository : BaseRepository
    {
        public Education GetEducationByIdEdu(int idedu)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdEdu",Value=idedu,DbType=DbType.Int32}
            };
            return GetSingle<Education>("GetEducationByIdEdu", parameters, connectionString);
        }
        public Education GetEducationByIdEmp(string id)
        {
            Parameter[] parameters = {
            new Parameter{Name="@Id",Value=id,DbType=DbType.String}
            };
            return GetSingle<Education>("GetEducationByIdEmp", parameters, connectionString);
        }
        public List<Education> GetEducation()
        {
            return GetList<Education>("GetEducation",  connectionString);
        }
        public int Delete(int idedu)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdEdu",Value=idedu,DbType=DbType.Int32}
            };
            return Save("DeleteEducation", parameters);
        }
        public int Edit(Education obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdEdu",Value=obj.IdEdu,DbType=DbType.Int32},
			new Parameter{Name="@EduName",Value=obj.EduName,DbType=DbType.String}
            };
            return Save("EditEducation", parameters);
        }
        public int Add(Education obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@EduName",Value=obj.EduName,DbType=DbType.String}
            };
            return Save("AddEducation", parameters);
        }
    }
}