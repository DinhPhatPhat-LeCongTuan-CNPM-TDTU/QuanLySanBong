using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanBong
    {
        public string maSanBong {  get; set; } 
        public string tenSanBong { get; set; }

        public int giaSanTheoPhut { get; set; }

        public SanBong(string maSanBong, string tenSanBong, int giaSanTheoPhut)
        {
            this.maSanBong = maSanBong;
            this.tenSanBong= tenSanBong;
            this.giaSanTheoPhut = giaSanTheoPhut;
        }
    }
}
