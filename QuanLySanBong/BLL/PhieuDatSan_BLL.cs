using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuDatSan_BLL
    {
        /*public static string checkDatSan(PhieuDatSan phieuDatSan)
        {
            if (phieuDatSan.loaiSan == "")
            {

            }
        }*/
        public static void AddPhieuDatSan(PhieuDatSan phieuDatSan)
        {
            phieuDatSan.maPhieuDatSan = autoCreateMaPhieuDatSan();
            PhieuDatSanAccess.AddPhieuDatSan(phieuDatSan);
        }

        private static string autoCreateMaPhieuDatSan()
        {
            if (PhieuDatSanAccess.SelectAllPhieuDatSan().Rows.Count == 0)
            {
                return "DS10000000";
            }
            else
            {
                DataTable dataTable = PhieuDatSanAccess.SelectTop1PhieuDatSan();
                string maHienTaiString = dataTable.Rows[0]["maPhieuDatSan"].ToString();
                string tamSoCuoiString = maHienTaiString.Substring(maHienTaiString.Length - 8);
                int tamSoCuoiIntPlussOne = int.Parse(tamSoCuoiString) + 1;
                string newPhieuDatSan = "DS" + tamSoCuoiIntPlussOne;
                return newPhieuDatSan;
            }
        }
    }
}
