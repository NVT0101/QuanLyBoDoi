using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDoi
{
    public class NY
    {
        [PrimaryKey] public string Id { get; set; }
        public string Hoten {  get; set; }
        public string SDT { get; set; }
        public string Job { get; set; }
        [OneToOne]
        public Address DiaChi { get; set; }
    }
}
