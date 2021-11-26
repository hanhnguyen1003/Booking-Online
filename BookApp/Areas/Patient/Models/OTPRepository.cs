using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Patient.Models
{
    public class OTPRepository:BaseRepository
    {
        public int AddOTP(string phone, string otp)
        {
            Parameter[] parameters=
            {
                new Parameter{Name="@Phone",Value=phone,DbType=DbType.String},
                new Parameter{Name="@OTP",Value=otp,DbType=DbType.String}
            };
            return Save("AddOTP", parameters);
        }
        public int DeleteOTP(string phone)
        {
            Parameter[] parameters =
            {
                new Parameter{Name="@Phone",Value=phone,DbType=DbType.String}               
            };
            return Save("DeleteOTP", parameters);
        }
        public OTPS GetOTPByPhone(string phone)
        {
            Parameter[] parameters =
                       {
                new Parameter{Name="@Phone",Value=phone,DbType=DbType.String}
            };
            return GetSingle<OTPS>("GetOTPByPhone", parameters, connectionString);
        }
        public OTPS GetOTPByPhoneAndOTP(string phone, string otp)
        {
            Parameter[] parameters =
           {
                new Parameter{Name="@Phone",Value=phone,DbType=DbType.String},
                new Parameter{Name="@OTP",Value=otp,DbType=DbType.String}
            };
            return GetSingle<OTPS>("GetOTPByPhoneAndOTP", parameters, connectionString);
        }
    }
}
