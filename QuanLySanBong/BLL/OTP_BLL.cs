using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class OTP_BLL
    {

        public static void SendOTP(string email,string sendWhat)
        {
            //Tạo code OTP random 6 chữ số
            int otpCode = new Random().Next(100000, 999999);

            OTP otp = new OTP(email, otpCode);
            OTPAccess.AddOTP(otp);

            var fromAddress = new MailAddress("dinhtainang@gmail.com"); //Mail gửi
            var toAddress = new MailAddress(otp.email); //Mail nhận
            const string fromPass = "yywutphsverkqeji"; //Mật khẩu ứng dụng tạo qua google
            string mailSubject = "";

            if (sendWhat == "Register")
            {
                mailSubject = "Đăng ký tài khoản sân bóng Trí Hải - Mã xác thực OTP"; //Tiêu đề mail gửi mã tạo tài khoản
                
            }
            if (sendWhat == "ChangePassword")
            {
                mailSubject = "Đổi mật khẩu tài khoản sân bóng Trí Hải - Mã xác thực OTP"; //Tiêu đề mail gửi mã đổi mật khẩu
            }

            string mailBody = $"Mã xác thực OTP của bạn là:\n{otp.otpCode}\nĐây là mail được gửi tự động, vui lòng không trả lời mail này.";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPass),
                Timeout = 200000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = mailSubject,
                Body = mailBody
            })
            {
                smtp.Send(message);
            }
        }

        public static bool checkOTP(string email,string otpInput)
        {
            return OTPAccess.CheckOTP(email, otpInput);
        }
    }
}
