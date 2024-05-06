using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OTP
    {
        public string email { get; set; }
        public int otpCode { get; set; }
        public OTP(string email, int otpCode) 
        {

            this.email = email;
            this.otpCode = otpCode;
        }

    }
}
