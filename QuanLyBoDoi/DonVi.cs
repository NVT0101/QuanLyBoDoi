using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDoi
{
    public class DonVi
    {
        [PrimaryKey] public string Id { get; set; }
        [ForeignKey(typeof(People))]
        public string PeopleID { get; set; }
        public string TieuDoi {  get; set; }
        public string TrungDoi { get; set; }
        public string DaiDoi { get; set; }
        public string TieuDoan { get; set; }
        public string TrungDoan { get; set; }
        public string SuDoan { get; set; }
        public string QuanKhu { get; set; }

        public DonVi() { }
        public DonVi(string tieuDoi, string trungDoi, string daiDoi, string tieuDoan, string trungDoan, string suDoan)
        {
            Id = Guid.NewGuid().ToString();
            TieuDoi = tieuDoi;
            TrungDoi = trungDoi;
            DaiDoi = daiDoi;
            TieuDoan = tieuDoan;
            TrungDoan = trungDoan;
            SuDoan = suDoan;
        }
    }
}
