using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDoi
{
    public  class GiaDinh
    {
        [PrimaryKey]
        public string ID { get; set; }

        [ForeignKey(typeof(People))]
        public string PeopleID { get; set; }
        public string Name { get; set; }
        public QUANHE QuanHe { get; set; }
        public string NgaySinh { get; set; }
        public string NgheNghiep { get; set; }
        public string SDT { get; set; }
        public bool Mat { get; set; }
        public string TGMat { get; set; }
        public string LyDoMat { get; set; }
        public bool BenhHiemNgheo {  get; set; }
        public string TTBenhHiemngheo {  get; set; }
        public bool BenhDiTruyen { get; set; }
        public string TTBenhDiTruyen { get; set; }

        
        public bool NQNQ {  get; set; }
        public string TTNQNQ { get; set; }
        public bool laCBDV {  get; set; }
        public string TTCBDV {  get; set; }


        
        [ForeignKey(typeof(GDNuocNgoai))]
        public string GDNNID { get; set; }
        [OneToOne]
        public GDNuocNgoai GDNN {  get; set; }
        public bool KhaiSinh {  get; set; }

        public bool NguoiNuoiDuong {  get; set; }
    }
}
