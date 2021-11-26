using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.Models
{
    public class DetailPreReponsitory : BaseRepository
    {
        public DetailPre GetDetailPreByPre(string id)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdPres",Value=id,DbType=DbType.String}
            };
            return GetSingle<DetailPre>("GetDetailPreByPre", parameters, connectionString);
        }
        public List<DetailPreToShow> GetPresDetailByIdPres(string id)
        {

            Parameter parameter = new Parameter { Name = "@id", Value = id, DbType = DbType.AnsiString };
                       
            return GetList<DetailPreToShow>("GetPresDetailByIdPres", parameter,connectionString);
        }
        public int Edit(DetailPre obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@Id",Value=obj.Id,DbType=DbType.String},
            new Parameter{Name="@IdPres",Value=obj.IdPres,DbType=DbType.String},
            new Parameter{Name="@IdMedicine",Value=obj.IdMedicine,DbType=DbType.String},
            new Parameter{Name="@Quantity",Value=obj.Quantity,DbType=DbType.Int32},
            new Parameter{Name="@Dosage",Value=obj.Dosage,DbType=DbType.String},
            new Parameter{Name="@Usage",Value=obj.Usage,DbType=DbType.String },
            new Parameter{Name="@Unit",Value=obj.Unit,DbType=DbType.String}
            };
            return Save("EditDetailPres", parameters);
        }
        public int Add(DetailPre obj)
        {
            Parameter[] parameters = {           
            new Parameter{Name="@IdPres",Value=obj.IdPres,DbType=DbType.String},
            new Parameter{Name="@IdMedicine",Value=obj.IdMedicine,DbType=DbType.String},
            new Parameter{Name="@Quantity",Value=obj.Quantity,DbType=DbType.Int32},
            new Parameter{Name="@Dosage",Value=obj.Dosage,DbType=DbType.String},
            new Parameter{Name="@Usage",Value=obj.Usage,DbType=DbType.String },
            new Parameter{Name="@Unit",Value=obj.Unit,DbType=DbType.String}
            };
            return Save("AddDetailPres", parameters);
        }
        public int DeleteByIdPres(string iddetailpres)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdPres",Value=iddetailpres,DbType=DbType.String}
            };
            return Save("DeleteDetailPres", parameters);
        }
        public int DeleteById(int id)
        {
            Parameter[] parameters = {
            new Parameter{Name="@Id",Value=id,DbType=DbType.Int32}
            };
            return Save("DeleteDP", parameters);
        }
    }
}
