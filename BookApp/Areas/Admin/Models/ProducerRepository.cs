using System.Collections.Generic;
using System.Data;
namespace WebApp.Areas.Admin.Models
{
    public class ProducerRepository : BaseRepository
    {
        public Producer GetProducerByIdProducer(string idproducer)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdProducer",Value=idproducer,DbType=DbType.String}
            };
            return GetSingle<Producer>("GetProducerByIdProducer", parameters, connectionString);
        }
        public List<Producer> GetProducer()
        {
            return GetList<Producer>("GetProducer",  connectionString);
        }
        public int Delete(string idproducer)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdProducer",Value=idproducer,DbType=DbType.String}
            };
            return Save("DeleteProducer", parameters);
        }
        public int Edit(Producer obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdProducer",Value=obj.IdProducer,DbType=DbType.String},
			new Parameter{Name="@NameProducer",Value=obj.NameProducer,DbType=DbType.String}
            };
            return Save("EditProducer", parameters);
        }
        public int Add(Producer obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdProducer",Value=obj.IdProducer,DbType=DbType.AnsiString},
            new Parameter{Name="@NameProducer",Value=obj.NameProducer,DbType=DbType.String}
            };
            return Save("AddProducer", parameters);
        }
    }
}