using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanBongAccess
    {

        public static bool CheckSanBongTonTaiByList(List<int> list)
        {
            foreach (int num in list)
            {
                if (SelectSanBongByInt(num) == false)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool SelectSanBongByInt(int  num)
        {
            string query = $"Select * from SanBong where tenSanBong ='Sân {num}'";
            if (Connection.selectQuery(query).Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        public static DataTable SelectAllSanBong()
        {
            string query = $"Select * from SanBong";
            return Connection.selectQuery(query);
        }

        public static void UpdateGiaSanTheoPhut(string maSanBong, int giaSanTheoPhut)
        {
            string query = $"Update SanBong set giaSanTheoPhut = {giaSanTheoPhut} where maSanBong = '{maSanBong}'";
            Connection.actionQuery(query);
        }

        public static DataTable XemGiaSan()
        {
            string query = "Select tenSanBong as N'Tên Sân', (giaSanTheoPhut * 30) as N'Giá Sân 30 phút', (giaSanTheoPhut * 60) as N'Giá sân 60 phút', (giaSanTheoPhut * 90) as N'Giá sân 90 phút' from SanBong";
            return Connection.selectQuery(query);
        }
    }
}
