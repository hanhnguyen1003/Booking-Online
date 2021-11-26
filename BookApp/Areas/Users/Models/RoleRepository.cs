using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Users.Models
{
    public class RoleRepository : BaseRepository
    {
        public int AddEmployeeInRole(int idrole,string idemp)
        {
            Parameter[] parameters =
            {
                new Parameter{Name="@RoleId",Value=idrole,DbType=DbType.Int32},
                new Parameter{Name="@IdEmp",Value=idemp,DbType=DbType.AnsiString}
            };
            return Save("AddEmployeeInRole", parameters);
        }
        public List<Role> GetRoles()
        {
            //return GetList<Role>("GetRoles", connectionString);
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetRoles";
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
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
        public Role GetRoleById(int id)
        {
            //Parameter parameter = new Parameter { Name = "@Role", Value = id, DbType = DbType.Int32 };
            //return GetSingle<Role>("GetRoleById", parameter, connectionString);
            Parameter parameter = new Parameter { Name = "@RoleId", Value = id, DbType = DbType.Int32 };

            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetRoleById";
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SetParameter(command, parameter);
            IDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Role obj = new Role
                {
                    RoleId = (int)reader["RoleId"],
                    RoleName = (string)reader["RoleName"]
                };
                return obj;
            }
            return null;
        }
        public int Add(Role obj)
        {
            Parameter parameter = new Parameter { Name = "@RoleName", Value = obj.RoleName, DbType = DbType.String };
            return Save("AddRole", parameter);
        }
        public int Edit(Role obj)
        {
            Parameter[] parameters = {
                new Parameter { Name = "@RoleId", Value = obj.RoleId, DbType = DbType.Int32 },
                new Parameter { Name = "@RoleName", Value = obj.RoleName, DbType = DbType.String }
            };
            return Save("EditRole", parameters);
        }
        public int Delete(int id)
        {
            Parameter parameter = new Parameter { Name = "@RoleId", Value = id, DbType = DbType.Int32 };
            return Save("DeleteRole", parameter);
        }
        public Employee GetEmployeeAndRoleById(string id)
        {
            Parameter parameter = new Parameter { Name = "@IdEmp", Value = id, DbType = DbType.AnsiString };

            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetEmployeeAndRoleById";
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SetParameter(command, parameter);
            IDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Employee obj = new Employee
                {
                    IdEmp = (string)reader["IdEmp"],
                    Username = (string)reader["Username"]
                };
                if (reader.NextResult())
                {
                    List<Role> listRole = new List<Role>();
                    while (reader.Read())
                    {
                        Role role = new Role
                        {
                            RoleId = (int)reader["RoleId"],
                            RoleName = (string)reader["RoleName"],
                            Checked = (bool)reader["Checked"]
                        };
                        listRole.Add(role);
                    }
                    obj.Roles = listRole;
                }
                return obj;
            }
            return null;
        }
    }
}
