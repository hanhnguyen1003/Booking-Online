using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class PKBRepository : BaseRepository
    {
        public int SumOfPatientExammedByDoctor(string idemp)
        {
            Parameter parameter = new Parameter { Name = "@IdEmp", Value = idemp, DbType = DbType.AnsiString };
            return SaveScalar("SumOfPatientExammedByDoctor", parameter);
        }
        public int SumOfPatientTodayByDoctor(string idemp)
        {
            Parameter parameter = new Parameter { Name = "@IdEmp", Value = idemp, DbType = DbType.AnsiString };
            return SaveScalar("SumOfPatientTodayByDoctor", parameter);
        }
        public int SumOfPatientFromToday(string idemp)
        {
            Parameter parameter = new Parameter { Name = "@IdEmp", Value = idemp, DbType = DbType.AnsiString };
            return SaveScalar("SumOfPatientFromToday", parameter);
        }
        public List<PKB> GetPKBByIdEmp(string id)
        {
            Parameter parameter = new Parameter { Name = "@id", Value = id, DbType = DbType.AnsiString };
            return GetList<PKB>("GetPKBByIdEmp", parameter, connectionString);            
        }
        public int AddTransactionIdToPKB(string IdPKB, string vnp_TransactionNo)
        {
            Parameter[] parameters = {
            new Parameter {  Name="@IdPKB",Value=IdPKB,DbType=DbType.String},
             new Parameter {  Name="@vnp_TransactionNo",Value=vnp_TransactionNo,DbType=DbType.String}
            };
            return Save("AddTransactionIdToPKB", parameters);
        }
        public List<PKB> GetPKBByIdPatient(string phone)
        {
            Parameter parameter = new Parameter { Name = "@phone", Value = phone, DbType = DbType.String };
            return GetList<PKB>("GetPKBByIdPatient", parameter, connectionString);
        }
        public int Delete(string idPKB)
        {
            Parameter parameter = new Parameter { Name = "@IdPKB", Value = idPKB, DbType = DbType.String };
            return Save("DeletePKB", parameter);
        }
        public PKB GetPKBByID(string id)
        {
            Parameter parameter = new Parameter { Name = "@IdPKB", Value = id, DbType = DbType.AnsiString };
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetPKBByID";
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SetParameter(command, parameter);
            IDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                PKB obj = new PKB
                {
                    IdPKB = (string)reader["IdPKB"],
                    STTPatient = (int)reader["STTPatient"],
                    IdDept = (string)reader["IdDept"],
                    DeptName = (string)reader["DeptName"],
                    OrdinalRoom = (int)reader["OrdinalRoom"],
                    RoomName = (string)reader["RoomName"],
                    Price = (int)reader["Price"],
                    IdEmp = (string)reader["IdEmp"],
                    NameEmp = (string)reader["NameEmp"],
                    IdPatient = (string)reader["IdPatient"],
                    NamePatient = (string)reader["NamePatient"],
                    SexP = (bool)reader["SexP"],
                    AddP = (string)reader["AddP"],
                    DOB = (DateTime)reader["DOB"],
                    Dated = (DateTime)reader["Dated"],
                    IdSes = (int)reader["IdSes"],
                    Ses = (string)reader["Ses"],
                    RangeTime = (string)reader["RangeTime"],
                    PaymentCode = (string)(reader["PaymentCode"]==DBNull.Value?"": reader["PaymentCode"])
                };
                return obj;
            }
            return null;
        }
        public int Add(PKB obj)
        {
            Parameter[] parameters = {
            new Parameter
            {  Name="@IdPKB",Value=obj.IdPKB,DbType=DbType.AnsiString},
            new Parameter{Name="@STTPatient",Value=obj.STTPatient,DbType=DbType.String},
            new Parameter{Name="@IdDept",Value=obj.IdDept,DbType=DbType.String},
            new Parameter{Name="@DeptName",Value=obj.DeptName,DbType=DbType.String},
            new Parameter{Name="@OrdinalRoom",Value=obj.OrdinalRoom,DbType=DbType.Int32},
            new Parameter{Name="@RoomName",Value=obj.RoomName,DbType=DbType.String},
            new Parameter{Name="@Price",Value=obj.Price,DbType=DbType.Int32},
            new Parameter{Name="@IdEmp",Value=obj.IdEmp,DbType=DbType.String},
            new Parameter{Name="@NameEmp",Value=obj.NameEmp,DbType=DbType.String},
            new Parameter{Name="@IdPatient",Value=obj.IdPatient,DbType=DbType.String},
            new Parameter{Name="@NamePatient",Value=obj.NamePatient,DbType=DbType.String},
            new Parameter{Name="@SexP",Value=obj.SexP,DbType=DbType.Boolean},
            new Parameter{Name="@AddP",Value=obj.AddP,DbType=DbType.String},
            new Parameter{Name="@DOB",Value=obj.DOB,DbType=DbType.Date},
            new Parameter{Name="@Dated",Value=obj.Dated,DbType=DbType.Date},
            new Parameter{Name="@IdSes",Value=obj.IdSes,DbType=DbType.Int32},
            new Parameter{Name="@Ses",Value=obj.Ses,DbType=DbType.String},
            new Parameter{Name="@RangeTime",Value=obj.RangeTime,DbType=DbType.String}
            //new Parameter{Name="@PaymentCode",Value=obj.PaymentCode,DbType=DbType.String}
            };
            return SaveScalar("AddPKB", parameters);
        }
        public int GetCurrentRow()
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetTotalRowPKB";
            command.CommandType = CommandType.StoredProcedure;           
            connection.Open();
            object result = command.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int countDis = Convert.ToInt32(result);
            return countDis;
        }
    }
}
