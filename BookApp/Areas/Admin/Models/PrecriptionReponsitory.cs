using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.Models
{
    public class PrecriptionReponsitory : BaseRepository
    {
        public List<Precription> GetPreByIdPatient(string id)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdPatient",Value=id,DbType=DbType.String}
            };
            return GetList<Precription>("GetPreByIdPatient", parameters, connectionString);
        }
        
        public int Edit(Precription obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdPres",Value=obj.IdPres,DbType=DbType.String},
            new Parameter{Name="@InDate",Value=obj.InDate,DbType=DbType.DateTime},
            new Parameter{Name="@IdPKB",Value=obj.IdPKB,DbType=DbType.String},
            new Parameter{Name="@IdPatient",Value=obj.IdPatient,DbType=DbType.String},
            new Parameter{Name="@IdEmp",Value=obj.IdEmp,DbType=DbType.String },
            new Parameter{Name="@Diagnose",Value=obj.Diagnose,DbType=DbType.String},
            new Parameter{Name="@Advice",Value=obj.Advice,DbType=DbType.String},
            new Parameter{Name="@FollowAppoint",Value=obj.FollowAppoint,DbType=DbType.String},

            };
            return Save("EditPres", parameters);
        }
        public int Add(Precription obj)
        {
            Console.WriteLine(obj.IdPres);
            Console.WriteLine(obj.IdPKB);
            Console.WriteLine(obj.IdPatient);
            Console.WriteLine(obj.IdEmp);
            Console.WriteLine(obj.Diagnose);
            Console.WriteLine(obj.Advice);
            Console.WriteLine(obj.FollowAppoint);
            Parameter[] parameters = {
            new Parameter{Name="@IdPres",Value=obj.IdPres,DbType=DbType.String},
            //new Parameter{Name="@InDate",Value=obj.InDate,DbType=DbType.DateTime},
            new Parameter{Name="@IdPKB",Value=obj.IdPKB,DbType=DbType.String},
            new Parameter{Name="@IdPatient",Value=obj.IdPatient,DbType=DbType.String},
            new Parameter{Name="@IdEmp",Value=obj.IdEmp,DbType=DbType.String },
            new Parameter{Name="@Diagnose",Value=obj.Diagnose,DbType=DbType.String},
            new Parameter{Name="@Advice",Value=obj.Advice,DbType=DbType.String},
            new Parameter{Name="@FollowAppoint",Value=obj.FollowAppoint,DbType=DbType.String}
            };
            return Save("AddPres", parameters);
        }
        public int Delete(string idpres)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdPres",Value=idpres,DbType=DbType.String}
            };
            return Save("DeletePres", parameters);
        }
    }
}
