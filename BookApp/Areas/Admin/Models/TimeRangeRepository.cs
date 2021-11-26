using System;
using System.Collections.Generic;
using System.Data;
namespace WebApp.Areas.Admin.Models
{
    public class TimeRangeRepository : BaseRepository
    {
        public TimeRange GetTimeRangeByIdPeriod(int idperiod)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdPeriod",Value=idperiod,DbType=DbType.Int32}
            };
            return GetSingle<TimeRange>("GetTimeRangeByIdPeriod", parameters, connectionString);
        }
        public List<TimeRange> GetTimeRangeExceed(string dated,string idemp)
        {
            Parameter[] parameters = {
            new Parameter{Name="@Dated",Value=dated,DbType=DbType.String},
            new Parameter{Name="@IdEmp",Value=idemp,DbType=DbType.String}
            };
            return GetList<TimeRange>("GetTimeRangeExceed", parameters, connectionString);
        }
        public List<TimeRange> GetTimeRange()
        {
            return GetList<TimeRange>("GetTimeRange",  connectionString);
        }
        public int Delete(int idperiod)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdPeriod",Value=idperiod,DbType=DbType.Int32}
            };
            return Save("DeleteTimeRange", parameters);
        }
        public int Edit(TimeRange obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdPeriod",Value=obj.IdPeriod,DbType=DbType.Int32},
            new Parameter{Name="@IdSes",Value=obj.IdSes,DbType=DbType.Int32},
            
            };
            return Save("EditTimeRange", parameters);
        }
        public int Add(TimeRange obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdSes",Value=obj.IdSes,DbType=DbType.Int32},
 
            };
            return Save("AddTimeRange", parameters);
        }
    }
}