using System.Collections.Generic;
using System.Data;
namespace WebApp.Areas.Admin.Models
{
    public class MeElementRepository : BaseRepository
    {
        public MeElement GetMeElementByIdMeElement(string idmeelement)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdMeElement",Value=idmeelement,DbType=DbType.String}
            };
            return GetSingle<MeElement>("GetMeElementByIdMeElement", parameters, connectionString);
        }
        public List<MeElement> GetMeElement()
        {
            return GetList<MeElement>("GetMeElement", connectionString);
        }
        public int Delete(string idmeelement)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdMeElement",Value=idmeelement,DbType=DbType.String}
            };
            return Save("DeleteMeElement", parameters);
        }
        public int Edit(MeElement obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdMeElement",Value=obj.IdMeElement,DbType=DbType.String},
			new Parameter{Name="@NameMeElement",Value=obj.NameMeElement,DbType=DbType.String}
            };
            return Save("EditMeElement", parameters);
        }
        public int Add(MeElement obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdMeElement",Value=obj.IdMeElement,DbType=DbType.String},
			new Parameter{Name="@NameMeElement",Value=obj.NameMeElement,DbType=DbType.String}
            };
            return Save("AddMeElement", parameters);
        }
    }
}