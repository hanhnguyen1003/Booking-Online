using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebApp.Areas.Users.Models;

namespace WebApp.Areas.Admin.Models
{
    public class EmployeeRepository : BaseRepository
    {
        public Employee GetEmployeeByEmail(string email)
        {
            Parameter parameter = new Parameter { Name = "@Email", Value = email, DbType = DbType.String };
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetEmployeeByEmail";
            command.CommandType = CommandType.StoredProcedure;
            SetParameter(command, parameter);
            connection.Open();
            //return command.ExecuteNonQuery();
            using (IDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new Employee
                    {
                        NameEmp = (string)reader["NameEmp"],
                        IdEmp = (string)reader["IdEmp"],
                        Phone = (string)reader["Phone"],
                        Email = (string)reader["Email"],
                        Username = (string)reader["Username"]
                    };
                }
            }
            return null;
        }
        public int ChangePass(string username, string password)
        {
            Parameter[] parameters =
            {
                new Parameter{Name="@Username",Value=username,DbType=DbType.AnsiString},
                new Parameter{Name="@Password",Value=Helper.Hash(username+"@#$%"+password),DbType=DbType.Binary}
            };
            return Save("ChangePassword", parameters);

        }
        public List<Role> GetRoleByEmployeeId(string id)
        {
            Parameter parameter = new Parameter { Name = "@IdEmp", Value = id, DbType = DbType.AnsiString };
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetRoleByEmployeeId";
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SetParameter(command, parameter);
            IDataReader reader = command.ExecuteReader();
            List<Role> list = new List<Role>();
            while (reader.Read())
            {
                Role obj = new Role
                {
                    RoleId = (int)reader["RoleId"],
                    RoleName = (string)reader["RoleName"]
                };
                list.Add(obj);
            }
            return list;
        }
        public Employee SignIn(string username, string password)
        {
            Parameter[] parameters =
            {
                new Parameter{Name="@Username",Value=username,DbType=DbType.AnsiString},
                new Parameter{Name="@Password",Value=Helper.Hash(username+"@#$%"+password),DbType=DbType.Binary}
            };
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "SignIn";
            command.CommandType = CommandType.StoredProcedure;
            SetParameter(command, parameters);
            connection.Open();
            //return command.ExecuteNonQuery();
            using (IDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new Employee
                    {
                        NameEmp = (string)reader["NameEmp"],
                        IdEmp = (string)reader["IdEmp"],
                        Phone = (string)reader["Phone"],
                        Email = (string)reader["Email"],
                        Username = (string)reader["Username"]
                    };
                }
            }
            return null;
        }
        public Employee GetEmployeeByIdEmp(string id)
        {

            Parameter parameter = new Parameter { Name = "@IdEmp", Value = id, DbType = DbType.AnsiString };

            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetEmployeeByIdEmp";
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SetParameter(command, parameter);
            IDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Employee obj = new Employee
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
                    DOB = (DateTime)reader["DOB"],
                    Images = (string)reader["Images"],
                    Position = (string)reader["Position"],
                    EduName = (string)reader["EduName"],
                    DeptName = (string)reader["DeptName"],
                    Price = (int)reader["Price"],
                    Username = (string)reader["Username"]
                };
                return obj;
            }
            return null;
        }
        public List<Employee> GetEmployee()
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetEmployee";
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            IDataReader reader = command.ExecuteReader();
            List<Employee> list = new List<Employee>();
            while (reader.Read())
            {
                Employee obj = new Employee
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
                    DOB = (reader["DOB"]==null||Convert.IsDBNull(reader["DOB"]))?null:(DateTime?)reader["DOB"],
                    Position =( reader["Position"] == null ||Convert.IsDBNull(reader["Position"])) ?String.Empty: (string)reader["Position"],
                    Images = (reader["Images"] == null||Convert.IsDBNull(reader["Images"])) ?String.Empty: (string)reader["Images"] ,
                    EduName = (string)reader["EduName"],
                    DeptName = (string)reader["DeptName"],
                    Username = (string)reader["Username"]
                };
                list.Add(obj);
            }
            return list;
            //return GetList<Employee>("GetEmployee", null, connectionString);
        }
        public List<Employee> GetEmployeeByPosition(string position)
        {
            Parameter parameter = new Parameter { Name = "@position", Value = position, DbType = DbType.String };
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetEmployee";
            command.CommandType = CommandType.StoredProcedure;
            SetParameter(command, parameter);
            connection.Open();
            IDataReader reader = command.ExecuteReader();
            List<Employee> list = new List<Employee>();
            while (reader.Read())
            {
                Employee obj = new Employee
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
                    EduName = (string)reader["EduName"],
                    DeptName = (string)reader["DeptName"],
                    Username = (string)reader["Username"]
                };
                list.Add(obj);
            }
            return list;
            //return GetList<Employee>("GetEmployee", null, connectionString);
        }
        public List<Employee> GetDoctorByDepartment(string id)
        {
            Parameter parameter = new Parameter { Name = "@id", Value = id, DbType = DbType.String };
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetDoctorByDepartment";
            command.CommandType = CommandType.StoredProcedure;
            SetParameter(command, parameter);
            connection.Open();
            IDataReader reader = command.ExecuteReader();
            List<Employee> list = new List<Employee>();
            while (reader.Read())
            {
                Employee obj = new Employee
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
                    EduName = (string)reader["EduName"],
                    DeptName = (string)reader["DeptName"],
                    Username = (string)reader["Username"]
                };
                list.Add(obj);
            }
            return list;
        }
        public int CheckUsername(string username)
        {
            Parameter parameter = new Parameter { Name = "@Username", Value = username, DbType = DbType.String };

            return SaveScalar("CheckUsername", parameter);
            //return GetList<Employee>("GetEmployee", null, connectionString);
        }

        public int CheckPassword(string password)
        {
            Parameter parameter = new Parameter { Name = "@Password", Value = password, DbType = DbType.AnsiString };

            return SaveScalar("CheckPassword", parameter);
            //return GetList<Employee>("GetEmployee", null, connectionString);
        }
        public int Delete(string idemp)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdEmp",Value=idemp,DbType=DbType.String}
            };
            return Save("DeleteEmployee", parameters);
        }
        public int Edit(Employee obj)
        {
            Parameter[] parameters = {
            //new Parameter{Name="@IdEmp",Value=Helper.RandomString(16),DbType=DbType.AnsiString},
            //đây rồi mấy má ơi, sủa thì lấy cái id cũ chứ tạo mới chi nó không cập nhật đúng rồi
            new Parameter{Name="@IdEmp",Value=obj.IdEmp,DbType=DbType.AnsiString},
            new Parameter{Name="@NameEmp",Value=obj.NameEmp,DbType=DbType.String},
            new Parameter{Name="@Phone",Value=obj.Phone,DbType=DbType.String},
            new Parameter{Name="@Username",Value=obj.Username,DbType=DbType.AnsiString},
           // new Parameter{Name="@Password",Value=Helper.Hash(obj.Username+"@#$%"+obj.Password),DbType=DbType.Binary},
            new Parameter{Name="@AddE",Value=obj.AddE,DbType=DbType.String},
            new Parameter{Name="@Email",Value=obj.Email,DbType=DbType.AnsiString},
            new Parameter{Name="@City",Value=obj.City,DbType=DbType.Int32},
            new Parameter{Name="@District",Value=obj.District,DbType=DbType.Int32},
            new Parameter{Name="@Village",Value=obj.Village,DbType=DbType.Int32},
            new Parameter{Name="@SexE",Value=obj.SexE,DbType=DbType.Boolean},
            new Parameter{Name="@Images",Value=obj.Images,DbType=DbType.String},
            new Parameter{Name="@DOB",Value=obj.DOB,DbType=DbType.Date },
            new Parameter{Name="@Position",Value=obj.Position,DbType=DbType.String},
            new Parameter{Name="@IdEdu",Value=obj.IdEdu,DbType=DbType.Int32},
            new Parameter{Name="@IdDept",Value=obj.IdDept,DbType=DbType.String}
            };
            return Save("EditEmployee", parameters);
        }
        public int Add(Employee obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdEmp",Value=Helper.RandomString(16),DbType=DbType.AnsiString},
            new Parameter{Name="@NameEmp",Value=obj.NameEmp,DbType=DbType.String},
            new Parameter{Name="@Phone",Value=obj.Phone,DbType=DbType.String},
            new Parameter{Name="@Username",Value=obj.Username,DbType=DbType.AnsiString},
            new Parameter{Name="@Password",Value=Helper.Hash(obj.Username+"@#$%"+obj.Password),DbType=DbType.Binary},
            new Parameter{Name="@AddE",Value=obj.AddE,DbType=DbType.String},
            new Parameter{Name="@Email",Value=obj.Email,DbType=DbType.AnsiString},
            new Parameter{Name="@City",Value=obj.City,DbType=DbType.Int32},
            new Parameter{Name="@District",Value=obj.District,DbType=DbType.Int32},
            new Parameter{Name="@Village",Value=obj.Village,DbType=DbType.Int32},
            new Parameter{Name="@SexE",Value=obj.SexE,DbType=DbType.Boolean},
            new Parameter{Name="@Images",Value=obj.Images,DbType=DbType.AnsiString},
            new Parameter{Name="@Position",Value=obj.Position,DbType=DbType.String},
            new Parameter{Name="@DOB",Value=obj.DOB,DbType=DbType.Date},
            new Parameter{Name="@IdEdu",Value=obj.IdEdu,DbType=DbType.Int32},
            new Parameter{Name="@IdDept",Value=obj.IdDept,DbType=DbType.String}
            };
            return Save("AddEmployee", parameters);
        }
        public List<Employee> SearchDoctor(SearchDoctor obj)
        {
            Parameter[] parameters = {
            new Parameter { Name = "@Name", Value = obj.Name, DbType = DbType.String },
            new Parameter { Name = "@SexE", Value = obj.SexE, DbType = DbType.Boolean },
            new Parameter { Name = "@IdEdu", Value = obj.IdEdu, DbType = DbType.Int32 },
            new Parameter { Name = "@IdDept", Value = obj.IdDept, DbType = DbType.String },
            new Parameter { Name = "@Schedule", Value = obj.Schedule, DbType = DbType.Int32 }
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
                    Price=(int)reader["Price"]
                };
                list.Add(em);
            }
            return list;


        }
        public List<Employee> GetDoctors(int pagenumber,int rowofpage )
        {
            Parameter[] parameters =
            {
                new Parameter {Name="@PageNumber",Value=pagenumber,DbType=DbType.Int32},
                new Parameter {Name="@RowOfPage",Value=rowofpage,DbType=DbType.Int32}
            };
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetDoctors";
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


    }
}