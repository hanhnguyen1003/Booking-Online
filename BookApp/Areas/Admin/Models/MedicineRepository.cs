using System.Collections.Generic;
using System.Data;
using WebApp.Areas.Doctor.Models;

namespace WebApp.Areas.Admin.Models
{
    public class MedicineRepository : BaseRepository
    {
        public List<SearchMedicine> SearchMedicine(string q)
        {
            Parameter parameter = new Parameter { Name = "@q", Value = q, DbType = DbType.String };
          
            return GetList<SearchMedicine>("SearchMedicine", parameter, connectionString);
        }
        public Medicine GetMedicineByIdMedicine(string idmedicine)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdMedicine",Value=idmedicine,DbType=DbType.String}
            };
            return GetSingle<Medicine>("GetMedicineByIdMedicine", parameters, connectionString);
        }
        public List<Medicine> GetMedicine()
        {
            return GetList<Medicine>("GetMedicine",  connectionString);
        }
        public int Delete(string idmedicine)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdMedicine",Value=idmedicine,DbType=DbType.String}
            };
            return Save("DeleteMedicine", parameters);
        }
        public int Edit(Medicine obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdMedicine",Value=obj.IdMedicine,DbType=DbType.String},
			new Parameter{Name="@NameMedicine",Value=obj.NameMedicine,DbType=DbType.String},
			new Parameter{Name="@IdMeElement",Value=obj.IdMeElement,DbType=DbType.String},
			new Parameter{Name="@IdProducer",Value=obj.IdProducer,DbType=DbType.String},
            new Parameter{Name="@IdMeGroup",Value=obj.IdMeGroup,DbType=DbType.String},
            new Parameter{Name="@Unit",Value=obj.Unit,DbType=DbType.String}
            };
            return Save("EditMedicine", parameters);
        }
        public int Add(Medicine obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdMedicine",Value=obj.IdMedicine,DbType=DbType.String},
            new Parameter{Name="@NameMedicine",Value=obj.NameMedicine,DbType=DbType.String},
			new Parameter{Name="@IdMeElement",Value=obj.IdMeElement,DbType=DbType.String},
			new Parameter{Name="@IdProducer",Value=obj.IdProducer,DbType=DbType.String},
            new Parameter{Name="@IdMeGroup",Value=obj.IdMeGroup,DbType=DbType.String},
            new Parameter{Name="@Unit",Value=obj.Unit,DbType=DbType.String}
            };
            return Save("AddMedicine", parameters);
        }
    }
}