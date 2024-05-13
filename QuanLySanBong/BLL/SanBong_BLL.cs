using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanBong_BLL
    {
        public static bool CheckSanBongTonTaiByList(List<int> list)
        {
            return SanBongAccess.CheckSanBongTonTaiByList(list);
        }

        public static DataTable SelectAllSanBong()
        {
            return SanBongAccess.SelectAllSanBong();
        }

        public static void UpdateGiaSanTheoPhut(string maSanBong, int giaSanTheoPhut)
        {
           SanBongAccess.UpdateGiaSanTheoPhut(maSanBong, giaSanTheoPhut);
        }

        public static DataTable XemGiaSan()
        {
            return SanBongAccess.XemGiaSan();
        }
    }
}
