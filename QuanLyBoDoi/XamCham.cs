using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDoi
{
    public class XamCham
    {
        [PrimaryKey]
        public string Id {  get; set; }
        [ForeignKey(typeof(People))]
        public string PeopleID { get; set; }
        public bool IsXC { get; set; }
        public string ND { get; set; }
        public string KichThuoc { get; set; }
        public string ViTri { get; set; }
        public string YNghia { get; set; }
        public string Img { get; set; }

        public string Lydo {  get; set; }

        
    }
}
