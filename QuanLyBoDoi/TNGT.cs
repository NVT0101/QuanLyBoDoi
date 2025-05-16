using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDoi
{
    public class TNGT
    {
        public string ThoiGian;
        public string Lydo;
        public string HauQua;
        public bool DPXuLy;
        public string HinhThuc;
        public string MucDo;
        public string GhiChu;

        public TNGT(string thoiGian, string lydo, string hauQua, bool dPXuLy, string hinhThuc, string mucDo, string ghiChu)
        {
            ThoiGian = thoiGian;
            Lydo = lydo;
            HauQua = hauQua;
            DPXuLy = dPXuLy;
            HinhThuc = hinhThuc;
            MucDo = mucDo;
            GhiChu = ghiChu;
        }
    }
}
