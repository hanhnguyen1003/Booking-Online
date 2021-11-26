using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class DetailTransactionRepository:BaseRepository
    {
        public List<DetailTransaction> GetDetailTransactions()
        {
            return GetList<DetailTransaction>("GetDetailTransaction", connectionString);
        }
        public DetailTransaction GetDetailTransactionById(string id)
        {
            Parameter[] parameters =
            {
                new Parameter{Name="@tranId",Value=id,DbType=System.Data.DbType.String}
            };
            return GetSingle<DetailTransaction>("GetDetailTransactionById", parameters, connectionString);
        }
        public int Add(DetailTransaction obj)
        {
            Parameter[] parameters =
           {
                new Parameter{Name="@orderId",Value=obj.orderId,DbType=System.Data.DbType.String},
                new Parameter{Name="@tranId",Value=obj.tranId,DbType=System.Data.DbType.String},
                new Parameter{Name="@vnp_Amount",Value=obj.vnp_Amount,DbType=System.Data.DbType.String},
                new Parameter{Name="@vnp_BankCode",Value=obj.vnp_BankCode,DbType=System.Data.DbType.String},
                new Parameter{Name="@vnp_BankTranNo",Value=obj.vnp_BankTranNo,DbType=System.Data.DbType.String},
                new Parameter{Name="@vnp_CardType",Value=obj.vnp_CardType,DbType=System.Data.DbType.String},
                new Parameter{Name="@vnp_OrderInfo",Value=obj.vnp_OrderInfo,DbType=System.Data.DbType.String},
                new Parameter{Name="@vnp_PayDate",Value=obj.vnp_PayDate,DbType=System.Data.DbType.String},
                new Parameter{Name="@vnp_ResponseCode",Value=obj.vnp_ResponseCode,DbType=System.Data.DbType.String},
                new Parameter{Name="@vnp_SecureHash",Value=obj.vnp_SecureHash,DbType=System.Data.DbType.String},
                new Parameter{Name="@vnp_SecureHashType",Value=obj.vnp_SecureHashType,DbType=System.Data.DbType.String},
                new Parameter{Name="@vnp_TmnCode",Value=obj.vnp_TmnCode,DbType=System.Data.DbType.String},
                new Parameter{Name="@vnp_TransactionNo",Value=obj.vnp_TransactionNo,DbType=System.Data.DbType.String},
                new Parameter{Name="@vnp_TxnRef",Value=obj.vnp_TxnRef,DbType=System.Data.DbType.String}
            };
            return Save("AddDetailTransaction", parameters);
        }
    }
}
