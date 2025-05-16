using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDoi
{
    public class ChoO
    {
        [PrimaryKey]
        public string Id { get; set; }
        [ForeignKey(typeof(People))]
        public string PeopleID { get; set; }

        public string Thon { get; set; }
        public string Xa { get; set; }
        public string Huyen { get; set; }
        public string Tinh { get; set; }

        public ChoO() { }
        public ChoO(string thon, string xa, string huyen, string tinh)
        {
            Id = Guid.NewGuid().ToString();
            Thon = thon;
            Xa = xa;
            Huyen = huyen;
            Tinh = tinh;
        }
    }
}
