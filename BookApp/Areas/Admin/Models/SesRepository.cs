using System.Collections.Generic;
using System.Data;
namespace WebApp.Areas.Admin.Models
{
    public class SesRepository : BaseRepository
    {
        public Sess GetSesByIdSes(int idses)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdSes",Value=idses,DbType=DbType.Int32}
            };
            return GetSingle<Sess>("GetSesByIdSes", parameters, connectionString);
        }
        public List<Sess> GetSes()
        {
            return GetList<Sess>("GetSes",  connectionString);
        }
        public int Delete(int idses)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdSes",Value=idses,DbType=DbType.Int32}
            };
            return Save("DeleteSes", parameters);
        }
        public int Edit(Sess obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdSes",Value=obj.IdSes,DbType=DbType.Int32},
			new Parameter{Name="@Ses",Value=obj.Ses,DbType=DbType.String}
            };
            return Save("EditSes", parameters);
        }
        public int Add(Sess obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@Ses",Value=obj.Ses,DbType=DbType.String}
            };
            return Save("AddSes", parameters);
        }
    }
}