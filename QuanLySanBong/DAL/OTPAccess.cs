using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class OTPAccess
    {
        public static void AddOTP(OTP otp )
        {
            string query = @$"Delete from OTP where email = '{otp.email}'";
            try
            {

                Connection.actionQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi xóa OTP");
            }
            try 
            { 
                query = $@"Insert into OTP values 
                    (
                        '{otp.email}','{otp.otpCode}'
                    )";
                Connection.actionQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi thêm OTP",e);
            }
        }

        public static bool CheckOTP(string email, string otpInput)
        {
            int intInput;

            if (int.TryParse(otpInput, out intInput))
            {
                string query = $@"Select * from OTP where email = '{email}' AND otpCode = {intInput}";
                if (Connection.selectQuery(query).Rows.Count > 0)
                {
                    return true;
                }
                return false;

            }
            else
            {
                return false;
            }
        }
    }
}
