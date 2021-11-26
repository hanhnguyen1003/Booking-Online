using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.Models
{
    public class PatientsRepository : BaseRepository
    {
        public List<Precription> GetPresByIdPatient(string id)
        {
         
            Parameter parameter = new Parameter { Name = "@id", Value = id, DbType = DbType.AnsiString };

            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetPresByIdPatient";
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SetParameter(command, parameter);
            IDataReader reader = command.ExecuteReader();
            List<Precription> list = new List<Precription>();
            while (reader.Read())
            {

                Precription obj = new Precription
                {
                    IdPres = (string)reader["IdPres"],
                    InDate = (DateTime)reader["InDate"],
                    IdPKB = (string)reader["IdPKB"] ,
                    IdEmp = (string)reader["IdEmp"],
                    IdPatient = (string)reader["IdPatient"],
                    Diagnose = (string)reader["Diagnose"],
                    Advice = (string)reader["Advice"],
                    FollowAppoint = (string)reader["FollowAppoint"],
                    NameEmp=(string)reader["NameEmp"]          ,         
                    DeptName=(string)reader["DeptName"],
                    Images=reader["Images"] == DBNull.Value ? "" : (string)reader["Images"]

                };
                list.Add(obj);
            }
            return list;
        }
        public List<Patients> GetPatientByIdDocTor(string id)
        {
            //đứa nào ?
            Parameter parameter = new Parameter { Name = "@id", Value = id, DbType = DbType.AnsiString };

            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetPatientByIdDocTor";
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SetParameter(command, parameter);
            IDataReader reader = command.ExecuteReader();
            List<Patients> list = new List<Patients>();
            while (reader.Read())
            {

                Patients obj = new Patients
                {
                    IdPatient = (string)reader["IdPatient"],
                    NamePatient = (string)reader["NamePatient"],
                    Phone = reader["Phone"] == DBNull.Value ? "" : (string)reader["Phone"],
                    SubPhone = reader["SubPhone"] == DBNull.Value ? "" : (string)reader["SubPhone"],
                    AddP = (string)reader["AddP"],
                    Email = (string)reader["Email"],
                    City = (int)reader["City"],
                    District = (int)reader["District"],
                    Village = (int)reader["Village"],
                    SexPatient = (bool)reader["SexPatient"],
                    DOB = (DateTime)reader["DOB"],
                    ImageP = (string)reader["ImageP"],
                    JobName = (string)reader["JobName"],
                    Ident = (Int64)reader["Ident"]

                };
                list.Add(obj);
            }
            return list;
        }
        public Patients GetPatientByIdPatient(string id)
        {

            Parameter parameter = new Parameter { Name = "@IdPatient", Value = id, DbType = DbType.AnsiString };

            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetPatientByIdPatient";
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SetParameter(command, parameter);
            IDataReader reader = command.ExecuteReader();
            
            if (reader.Read())
            {
                Patients obj = new Patients
                {
                    IdPatient = (string)reader["IdPatient"],
                    NamePatient = (string)reader["NamePatient"],
                    Phone = (string)reader["Phone"],
                    SubPhone = (string)reader["SubPhone"],
                    AddP = (string)reader["AddP"],
                    Email = (string)reader["Email"],
                    City = (int)reader["City"],
                    District = (int)reader["District"],
                    Village = (int)reader["Village"],
                    SexPatient = (bool)reader["SexPatient"],
                    DOB = (DateTime)reader["DOB"],
                    ImageP = (string)reader["ImageP"],
                    JobName = (string)reader["Jobname"],
                    Idjob=(int)reader["Idjob"],
                    Ident = (Int64)reader["Ident"],

                };
                return obj;
            }
            return null;
        }
        public List<Patients> GetPatientByPhone(string phone)
        {

            Parameter parameter = new Parameter { Name = "@Phone", Value = phone, DbType = DbType.String };

            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetPatientByPhone";
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SetParameter(command, parameter);
            IDataReader reader = command.ExecuteReader();
            List<Patients> list = new List<Patients>();
            while (reader.Read())
            {
                
                Patients obj = new Patients
                {
                    IdPatient = (string)reader["IdPatient"],
                    NamePatient = (string)reader["NamePatient"],
                    Phone = reader["Phone"] == DBNull.Value ? "" : (string)reader["Phone"],
                    SubPhone = reader["SubPhone"] == DBNull.Value ? "" : (string)reader["SubPhone"],
                    AddP = (string)reader["AddP"],
                    Email = (string)reader["Email"],
                    City = (int)reader["City"],
                    District = (int)reader["District"],
                    Village = (int)reader["Village"],
                    SexPatient = (bool)reader["SexPatient"],
                    DOB = (DateTime)reader["DOB"],
                    ImageP = (string)reader["ImageP"],
                    JobName = (string)reader["JobName"],
                    Ident = (Int64)reader["Ident"]

                };
                list.Add(obj);                
            }
            return list;
        }
        public List<Patients> GetPatients()
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetPatient";
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            IDataReader reader = command.ExecuteReader();
            List<Patients> list = new List<Patients>();
            while (reader.Read())
            {
                Patients obj = new Patients
                {
                    IdPatient = (string)reader["IdPatient"],
                    NamePatient = (string)reader["NamePatient"],
                    Phone = (string)reader["Phone"],
                    SubPhone = (string)reader["SubPhone"],
                    AddP = (string)reader["AddP"],
                    Email = (string)reader["Email"],
                    City = (int)reader["City"],
                    District = (int)reader["District"],
                    Village = (int)reader["Village"],
                    SexPatient = (bool)reader["SexPatient"],
                    DOB = (reader["DOB"] == null || Convert.IsDBNull(reader["DOB"])) ? null : (DateTime?)reader["DOB"],
                    JobName = (string)reader["Job"],
                    ImageP = (reader["ImageP"] == null || Convert.IsDBNull(reader["ImageP"])) ? String.Empty : (string)reader["ImageP"],
                    Ident = (Int64)reader["Ident"]
                    
                };
                list.Add(obj);
            }
            return list;
            //return GetList<Employee>("GetEmployee", null, connectionString);
        }


        public int Delete(string idpatient)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdPatient",Value=idpatient,DbType=DbType.String}
            };
            return Save("DeletePatient", parameters);
        }
        public int Edit(Patients obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdPatient",Value=obj.IdPatient,DbType=DbType.AnsiString},
            new Parameter{Name="@NamePatient",Value=obj.NamePatient,DbType=DbType.String},
            new Parameter{Name="@DOB",Value=obj.DOB,DbType=DbType.Date },
            new Parameter{Name="@Phone",Value=obj.Phone,DbType=DbType.String},
            new Parameter{Name="@SubPhone",Value=obj.SubPhone,DbType=DbType.String},
            new Parameter{Name="@Ident",Value=obj.Ident,DbType=DbType.String },
            new Parameter{Name="@Idjob",Value=obj.Idjob,DbType=DbType.Int32},
            new Parameter{Name="@AddP",Value=obj.AddP,DbType=DbType.String},
            new Parameter{Name="@Email",Value=obj.Email,DbType=DbType.AnsiString},
            new Parameter{Name="@City",Value=obj.City,DbType=DbType.Int32},
            new Parameter{Name="@District",Value=obj.District,DbType=DbType.Int32},
            new Parameter{Name="@Village",Value=obj.Village,DbType=DbType.Int32},
            new Parameter{Name="@SexPatient",Value=obj.SexPatient,DbType=DbType.Boolean},
            new Parameter{Name="@ImageP",Value=obj.ImageP,DbType=DbType.String},

            };
            return Save("EditPatient", parameters);
        }
        public int Add(Patients obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdPatient",Value=Helper.RandomString(16),DbType=DbType.AnsiString},
            new Parameter{Name="@NamePatient",Value=obj.NamePatient,DbType=DbType.String},
            new Parameter{Name="@DOB",Value=obj.DOB,DbType=DbType.Date},
            new Parameter{Name="@SexPatient",Value=obj.SexPatient,DbType=DbType.Boolean},
            new Parameter{Name="@Ident",Value=obj.Ident,DbType=DbType.String },
            new Parameter{Name="@Phone",Value=obj.Phone,DbType=DbType.String},
            new Parameter{Name="@SubPhone",Value=obj.SubPhone,DbType=DbType.String},
            new Parameter{Name="@Idjob",Value=obj.Idjob,DbType=DbType.Int32},
            new Parameter{Name="@AddP",Value=obj.AddP,DbType=DbType.String},
            new Parameter{Name="@Email",Value=obj.Email,DbType=DbType.AnsiString},
            new Parameter{Name="@City",Value=obj.City,DbType=DbType.Int32},
            new Parameter{Name="@District",Value=obj.District,DbType=DbType.Int32},
            new Parameter{Name="@Village",Value=obj.Village,DbType=DbType.Int32},
            new Parameter{Name="@ImageP",Value=obj.ImageP,DbType=DbType.AnsiString},

            };
            return Save("AddPatient", parameters);
        }
    }
}