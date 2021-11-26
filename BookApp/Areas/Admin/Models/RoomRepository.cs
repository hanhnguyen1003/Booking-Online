using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WebApp.Areas.Admin.Models
{
    public class RoomRepository : BaseRepository
    {
        public Room GetRoomByOrdinalRoom(int ordinalroom)
        {
            Parameter[] parameters = {
            new Parameter{Name="@OrdinalRoom",Value=ordinalroom,DbType=DbType.Int32}
            };
            return GetSingle<Room>("GetRoomByOrdinalRoom", parameters, connectionString);
        }
        public List<Room> GetRoomByIdDept(string id)
        {
            Parameter[] parameters = {
            new Parameter{Name="@IdDept",Value=id,DbType=DbType.String}
            };
            return GetList<Room>("GetRoomByIdDept", parameters, connectionString);
        }
        public List<Room> GetRoom()
        {
            return GetList<Room>("GetRoom",  connectionString);
        }
        public int Delete(int ordinalroom)
        {
            Parameter[] parameters = {
            new Parameter{Name="@OrdinalRoom",Value=ordinalroom,DbType=DbType.Int32}
            };
            return Save("DeleteRoom", parameters);
        }
        public int Edit(Room obj)
        {
            Parameter[] parameters = {
            new Parameter{Name="@OrdinalRoom",Value=obj.OrdinalRoom,DbType=DbType.Int32},
			new Parameter{Name="@IdDept",Value=obj.IdDept,DbType=DbType.String},
			new Parameter{Name="@RoomName",Value=obj.RoomName,DbType=DbType.String},
			new Parameter{Name="@QuantityPatient",Value=obj.QuantityPatient,DbType=DbType.Int32}
            };
            return Save("EditRoom", parameters);
        }
        public int Add(Room obj)
        {
            Parameter[] parameters = {            
			new Parameter{Name="@IdDept",Value=obj.IdDept,DbType=DbType.String},
			new Parameter{Name="@RoomName",Value=obj.RoomName,DbType=DbType.String},
			new Parameter{Name="@QuantityPatient",Value=obj.QuantityPatient,DbType=DbType.Int32}
            };
            return Save("AddRoom", parameters);
        }
        //public List<Room> GetNameRoom()
        //{
        //    using IDbConnection cnn = new SqlConnection(connectionString);            
        //    using IDbCommand cmd = cnn.CreateCommand();
        //    cmd.CommandText = "";
        //    cmd.CommandType = CommandType.StoredProcedure;
            
            
        //}
    }
}