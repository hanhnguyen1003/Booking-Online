using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace WebApp.Areas.Admin.Models
{
    public class BaseRepository
    {
        protected static string connectionString;       
        static BaseRepository()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();
            connectionString = configuration.GetConnectionString("Hospital");
        }
        protected static void SetParameter(IDbCommand command, Parameter parameter)
        {
            IDbDataParameter dataParameter = command.CreateParameter();
            dataParameter.ParameterName = parameter.Name;
            dataParameter.Value = parameter.Value;
            dataParameter.DbType = parameter.DbType;
            if (Enum.IsDefined(typeof(ParameterDirection), parameter.Direction))
            {
                dataParameter.Direction = parameter.Direction;
            }
            command.Parameters.Add(dataParameter);
        }
        protected static void SetParameter(IDbCommand command, Parameter[] parameters)
        {
            foreach (var parameter in parameters)
            {
                SetParameter(command, parameter);
            }
        }
        protected int Save(string sql, Parameter[] parameters)
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;
            SetParameter(command, parameters);
            connection.Open();
            return command.ExecuteNonQuery();
        }
        protected int Save(string sql, Parameter parameter)
        {
            return Save(sql, new Parameter[] { parameter });
        }
        protected int Save(string sql)
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            return command.ExecuteNonQuery();
        }
        protected int SaveScalar(string sql, Parameter[] parameters)
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.StoredProcedure;
            SetParameter(command, parameters);
            connection.Open();
            object result = command.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            int countDis = Convert.ToInt32(result);
            return countDis;
        }
        protected int SaveScalar(string sql, Parameter parameter)
        {
            return SaveScalar(sql, new Parameter[] { parameter });
        }
        protected List<T> GetList<T>(string procedureName, Parameter[] parameters, string connectionString)
        {
            using IDbConnection cnn = new SqlConnection(connectionString);
            using IDbCommand cmd = cnn.CreateCommand();
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                SetParameter(cmd, parameters);
            }
            cnn.Open();
            return ReaderCommandList<T>(cmd);
        }
        protected List<T> GetList<T>(string procedureName, string connectionString)
        {
            using IDbConnection cnn = new SqlConnection(connectionString);
            using IDbCommand cmd = cnn.CreateCommand();
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;           
            cnn.Open();
            return ReaderCommandList<T>(cmd);
        }
        private List<T> ReaderCommandList<T>(IDbCommand cmd)
        {
            using IDataReader reader = cmd.ExecuteReader();
            List<T> list = new List<T>();
            T obj = default(T);
            while (reader.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo property in obj.GetType().GetProperties())
                {
                    if (!Equals(reader[property.Name], DBNull.Value))
                    {
                        property.SetValue(obj, reader[property.Name], null);
                    }
                }
                list.Add(obj);
            }
            return list;
        }
        protected List<T> GetList<T>(string procedureName, Parameter parameter, string connectionString)
        {
            using IDbConnection cnn = new SqlConnection(connectionString);
            using IDbCommand cmd = cnn.CreateCommand();
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (parameter!= null)
            {
                SetParameter(cmd, parameter);
            }
            cnn.Open();
            return ReaderCommandList<T>(cmd);
        }
        protected T GetSingle<T>(string procedureName, Parameter[] parameters, string connectionString)
        {
            using IDbConnection cnn = new SqlConnection(connectionString);
            using IDbCommand cmd = cnn.CreateCommand();
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                SetParameter(cmd, parameters);
            }
            cnn.Open();
            return ReaderCommandSingle<T>(cmd);
        }
        protected T GetSingle<T>(string procedureName, Parameter parameter, string connectionString)
        {
            using IDbConnection cnn = new SqlConnection(connectionString);
            using IDbCommand cmd = cnn.CreateCommand();
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (parameter != null)
            {
                SetParameter(cmd, parameter);
            }
            cnn.Open();
           return ReaderCommandSingle<T>(cmd);
        }
        private T ReaderCommandSingle<T>(IDbCommand cmd)
        {
            using IDataReader reader = cmd.ExecuteReader();

            T obj = default;

            if (reader.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo property in obj.GetType().GetProperties())
                {
                    if (!object.Equals(reader[property.Name], DBNull.Value))
                    {
                        property.SetValue(obj, reader[property.Name], null);
                    }
                }

            }
            return obj;
        }
    }
}
