using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDoi
{
    public class VPPL
    {
        [PrimaryKey] public string Id { get; set; }
        [ForeignKey(typeof(People))]
        public string PeopleID { get; set; }
        public QUANHE NguoiViPham {  get; set; }
        public string HoTen {  get; set; }
        public string ThoiGian { get; set; }
        public string NoiDung { get; set; }
        public HINHTHUCXULY HinhThuc { get; set; }
        public string MucDo { get; set; }
        public string GhiChu { get; set; }

        public LOAIVPPL LoaiViPham { get; set; }

        public string LyDoViPham { get; set; }

        public string HauQua {  get; set; }

       
    }
}
