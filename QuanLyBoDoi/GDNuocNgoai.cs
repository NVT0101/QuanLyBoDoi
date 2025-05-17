using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDoi
{
    public class GDNuocNgoai
    {
        [PrimaryKey]
        public string Id { get; set; }
        [ForeignKey(typeof(People))]
        public string PeopleID { get; set; }

        public string Name { get; set; } = "";
        public QUANHE QuanHe { get; set; }
        public DIEN Dien { get; set; }
        public string QuocTich { get; set; } = "";
        public string ThoiGian { get; set; } = "";
        public string GhiChu { get; set; } = "";


    }
}
