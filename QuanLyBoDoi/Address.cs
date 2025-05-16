using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDoi
{
    public class Address
    {
        [PrimaryKey]
        public string Id { get; set; }
        /*[ForeignKey(typeof(People))]
        public string PeopleID { get; set; }*/

        public string Thon;
        public string Xa;
        public string Huyen;
        public string Tinh;

        public Address(string thon, string xa, string huyen, string tinh)
        {
            Id = Guid.NewGuid().ToString();
            Thon = thon;
            Xa = xa;
            Huyen = huyen;
            Tinh = tinh;
        }
    }
}
