using DAL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietPhieuDatSan_BLL
    {
        public static void AddChiTietPhieuDatSan(string maPhieuDatSan, string chonSan)
        {
            string [] split = chonSan.Replace("Sân ", "").Split('-');
            List<int> list = new List<int>();
            list= Array.ConvertAll(split,int.Parse).ToList();

            foreach (int haiSoCuoiMaSanBong in list)
            {
                ChiTietPhieuDatSanAccess.FindSanBongToAddChiTietPhieuDatSan(maPhieuDatSan, haiSoCuoiMaSanBong);
            }
        }
    }
}
