using System.Collections.Generic;
using System.Data;
using WebApp.Models;

namespace WebApp.Areas.Admin.Models
{
    public class DepartmentRepository : BaseRepository
    {
        public Department GetDepartmentByIdDept(string iddept)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdDept",Value=iddept,DbType=DbType.String}
            };
            return GetSingle<Department>("GetDepartmentByIdDept", parameters, connectionString);
        }
        public Department GetDepartmentByIdEmp(string id)
        {
            Parameter[] parameters = {
            new Parameter{Name="@Id",Value=id,DbType=DbType.String}
            };
            return GetSingle<Department>("GetDepartmentByIdEmp", parameters, connectionString);
        }
        public List<Department> GetDepartment()
        {
            return GetList<Department>("GetDepartment",  connectionString);
        }
        public int Delete(string iddept)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdDept",Value=iddept,DbType=DbType.AnsiString}
            };
            return Save("DeleteDepartment", parameters);
        }
        public int Edit(Department obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdDept",Value=obj.IdDept,DbType=DbType.AnsiString},
            new Parameter{Name="@DeptName",Value=obj.DeptName,DbType=DbType.String},
            new Parameter{Name="@Price",Value=obj.Price,DbType=DbType.Int32},
            new Parameter{Name="@Images",Value=obj.Images,DbType=DbType.String}
            };
            return Save("EditDepartment", parameters);
        }
        public int Add(Department obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdDept",Value=obj.IdDept,DbType=DbType.AnsiString},
            new Parameter{Name="@DeptName",Value=obj.DeptName,DbType=DbType.String},
            new Parameter{Name="@Price",Value=obj.Price,DbType=DbType.Int32},
            new Parameter{Name="@Images",Value=obj.Images,DbType=DbType.String}
            };
            return Save("AddDepartment", parameters);
        }
    }
}