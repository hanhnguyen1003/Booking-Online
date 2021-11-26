using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebApp.Areas.Patient.Models;
using WebApp.Models;

namespace WebApp.Areas.Admin.Models
{
    public class ScheduleRepository : BaseRepository
    {
        public List<Schedule> GetScheduleAvailable()
        {
          
            return GetList<Schedule>("GetDoctorByDay",connectionString);
        }
        public int RenderSchedule()
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "RunRenderSchedule";
            command.CommandType = CommandType.StoredProcedure;            
            connection.Open();
            int ret = command.ExecuteNonQuery();             
            return ret;
        } 
        public List<DoctorInfo> GetScheduleByDateAndDeptId(DateTime dated, string idDept)
        {
            Parameter[] parameters =
           {
                new Parameter{Name="@Dated",Value=dated,DbType=DbType.DateTime},
                new Parameter{Name="@IdDept",Value=idDept,DbType=DbType.String}
              
            };
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetScheduleByDateAndDeptId";
            command.CommandType = CommandType.StoredProcedure;
            SetParameter(command, parameters);
            connection.Open();
            IDataReader reader = command.ExecuteReader();
            List<DoctorInfo> list = new List<DoctorInfo>();
            while (reader.Read())
            {
                DoctorInfo obj = new DoctorInfo
                {
                    ScheduleId = (int)reader["Id"],
                    IdEmp = (string)reader["IdEmp"],
                    NameEmp = (string)reader["NameEmp"],
                    Dated = (DateTime)reader["Dated"],
                    IdEdu = (int)reader["IdEdu"],
                    EduName = (string)reader["EduName"],
                    IdDept = (string)reader["IdDept"],
                    DeptName = (string)reader["DeptName"],
                    TimeRange = (string)reader["TimeRange"],
                    OrdinalRoom = (int)reader["OrdinalRoom"],
                    Images = (reader["Images"] == null || Convert.IsDBNull(reader["Images"])) ? String.Empty : (string)reader["Images"],
                    SexE = (bool)reader["SexE"]
                };
                list.Add(obj);
            }
            return list;

        }
        public List<Department> GetDepartmentByDate(DateTime dated)
        {
            Parameter parameter = new Parameter { Name = "@Dated", Value = dated, DbType = DbType.DateTime };
            return GetList<Department>("GetDepartmentByDate", parameter, connectionString);
        }
        public List<Employee> GetDoctorByDate(DateTime dated, string idept)
        {
            Parameter[] parameters =
            {
                new Parameter{Name="@Dated",Value=dated,DbType=DbType.DateTime},
                new Parameter{Name="@IdDept",Value=idept,DbType=DbType.String}
            };
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "SearchDoctor";
            command.CommandType = CommandType.StoredProcedure;
            SetParameter(command, parameters);
            connection.Open();
            IDataReader reader = command.ExecuteReader();
            List<Employee> list = new List<Employee>();
            while (reader.Read())
            {
                Employee em = new Employee
                {
                    IdEmp = (string)reader["IdEmp"],
                    NameEmp = (string)reader["NameEmp"],
                    Phone = (string)reader["Phone"],
                    AddE = (string)reader["AddE"],
                    Email = (string)reader["Email"],
                    City = (int)reader["City"],
                    District = (int)reader["District"],
                    Village = (int)reader["Village"],
                    SexE = (bool)reader["SexE"],
                    DOB = (reader["DOB"] == null || Convert.IsDBNull(reader["DOB"])) ? null : (DateTime?)reader["DOB"],
                    Position = (reader["Position"] == null || Convert.IsDBNull(reader["Position"])) ? String.Empty : (string)reader["Position"],
                    Images = (reader["Images"] == null || Convert.IsDBNull(reader["Images"])) ? String.Empty : (string)reader["Images"],
                    ImagesDept = (reader["ImagesDept"] == null || Convert.IsDBNull(reader["ImagesDept"])) ? String.Empty : (string)reader["ImagesDept"],
                    EduName = (string)reader["EduName"],
                    DeptName = (string)reader["DeptName"],
                    Price = (int)reader["Price"]
                };
                list.Add(em);
            }
            return list;
        }
        public Schedule GetScheduleById(int id)
        {
            Parameter[] parameters = {
            new Parameter{Name="@Id",Value=id,DbType=DbType.Int32}
            };
            return GetSingle<Schedule>("GetScheduleById", parameters, connectionString);
        }
        public List<Schedule> GetScheduleByDoctor(string id,bool ispatient=false)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdEmp",Value=id,DbType=DbType.String},
            new Parameter{Name="@Ispatient",Value=ispatient,DbType=DbType.Boolean}
            };
            return GetList<Schedule>("GetScheduleByDoctor", parameters, connectionString);
        }
        public List<Schedule> GetSchedule(string id)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdEmp",Value=id,DbType=DbType.String}
            };
            return GetList<Schedule>("GetSchedule", parameters, connectionString);
        }

        public List<Schedule> GetCurrentWeekSchedule()
        {
            return GetList<Schedule>("GetCurrentWeekSchedule", connectionString);
        }
        public int Delete(int id)
        {
            Parameter[] parameters = {
            new Parameter{Name="@Id",Value=id,DbType=DbType.Int32}
            };
            return Save("DeleteSchedule", parameters);
        }
        public int Edit(Schedule obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@Id",Value=obj.Id,DbType=DbType.Int32},
            new Parameter{Name="@Color",Value=obj.Color,DbType=DbType.String},
            new Parameter{Name="@Dated",Value=obj.Dated,DbType=DbType.DateTime},
            new Parameter{Name="@OrdinalRoom",Value=obj.OrdinalRoom,DbType=DbType.Int32},
            new Parameter{Name="@TimeRange",Value=obj.TimeRange,DbType=DbType.String},
            new Parameter{Name="@Description",Value=obj.Description,DbType=DbType.String}
            };
            return Save("EditSchedule", parameters);
        }
        public int Add(Schedule obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdEmp",Value=obj.IdEmp,DbType=DbType.String},
            new Parameter{Name="@Color",Value=obj.Color,DbType=DbType.String},
            new Parameter{Name="@Dated",Value=obj.Dated,DbType=DbType.DateTime},
            new Parameter{Name="@OrdinalRoom",Value=obj.OrdinalRoom,DbType=DbType.Int32},
            new Parameter{Name="@TimeRange",Value=obj.TimeRange,DbType=DbType.String},
            new Parameter{Name="@Description",Value=obj.Description,DbType=DbType.String}
            };
            return Save("AddSchedule", parameters);
        }

    }
}