using SQLite;
using SQLiteNetExtensions.Attributes;
using System.ComponentModel;

namespace QuanLyBoDoi
{
    public class People
    {
        [PrimaryKey]
        public string PeopleID { get; set; }
        [Description("Họ tên")]
        public string Name { get; set; } = "";
        public string OtherName{ get; set; } = "";
        public string Birth{ get; set; } = "";
        public string CCCD{ get; set; } = "";
        public DANTOC Dantoc{ get; set; }
        public TONGIAO Tongiao{ get; set; }
        public TRINHDO Vanhoa{ get; set; }
        public bool Dang{ get; set; }
        public string NgayDang{ get; set; } = "";
        public bool Doan{ get; set; }
        public string NgayDoan{ get; set; } = "";
        public JOB Job{ get; set; }
        public bool LamAnXa {  get; set; }
        public string ThuNhapCaNhan{ get; set; } = "";
        public string NangKhieu{ get; set; } = "";
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<QueQuan> QueQuan{ get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<DiaChiLamViec> NoilamViec { get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<ChoO> ChoO{ get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<DonVi> DonVi {  get; set; }
        //Table GiaDinh
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<GiaDinh> GD{ get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<GDNuocNgoai> GDNN { get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<VPPL> vppl { get; set; }
        public string GDBlobbed { get; set; } = "";
        public bool BoMeDKKH { get; set; }
        public bool ConNgoaiHon { get; set; }

        public HOANCANH HoanCanh {  get; set; }
        public string MoTaHoanCanh{ get; set; } = "";
        public int ThuNhapGiaDinh{ get; set; }
        public string LydoKhoKhan{ get; set; } = "";
        public string SongVoi{ get; set; } = "";
        public bool ConGiaThu{ get; set; }
        public bool BomeLyHon{ get; set; }
        public string LydoLyHon{ get; set; } = "";
        public int ConThu{ get; set; }
        public bool ChaCoVoKe{ get; set; }
        public string TTVoKe{ get; set; } = "";
        public bool MeCoChongKhac{ get; set; }
        public string TTChongKhac{ get; set; } = "";
        public bool XamCham{ get; set; }
        //Table XamCham
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<XamCham> XC { get; set; }
        public string XamChamBlobbed { get; set; } = "";
        public bool NghienRuou{ get; set; }
        public string MucDoNR{ get; set; } = "";
        public bool NghienThuoc{ get; set; }
        public string MucDoNT{ get; set; } = "";
        public bool NghienGame{ get; set; }
        public string MucDoNG{ get; set; } = "";
        public bool NhuomToc{ get; set; }
        public string TTNhuomToc{ get; set; } = "";
        public string LydoNhuomToc { get; set; } = "";
        public bool MXH { get; set; }
        public string TTMXH { get; set; } = "";
        public string GhiChuMXH { get; set; } = "";
        public string SK{ get; set; } = "";
        public string Benh{ get; set; } = "";
        public bool GDbenhDiTruyen{ get; set; }
        public string BenhDiTruyen{ get; set; } = "";
        public bool GDBenhHiemNgheo{ get; set; }
        public string TTBenhHiemNgheo{ get; set; } = "";
        public bool TNGT{ get; set; }
        public string TTTNGT{ get; set; } = "";
        public bool TNGTPLXL{ get; set; }
        public string MucDoXuLyTNGT{ get; set; } = "";

        public string GDNNBlobbed { get; set; } = "";
        public bool GDNuocNgoai { get; set; }
        [ForeignKey(typeof(NY))]
        public string NYID { get; set; }
        [OneToOne]
        public NY ny {  get; set; }
        public bool DKKH{ get; set; }
        public string LydoCoCon { get; set; } = "";
        public bool ConDKKS{ get; set; }
        public string TTBanThan{ get; set; } = "";
        public TRINHDO TrinhDo{ get; set; }
        public bool CDDH { get; set; }
        public string TruongHoc { get; set; } = "";
        public string ChuyenNganh { get; set; } = "";
        public bool BaoLuu{ get; set; }
        public string TTBaoLuu{ get; set; } = "";
        public bool ConNQNQ{ get; set; }
        public string TTConNQNQ{ get; set; } = "";
        public bool NoNan{ get; set; }
        public string TTNoNan{ get; set; } = "";
        public bool CungDPVPPL{ get; set; }
        public string TTCungDPVPPL{ get; set; } = "";
        public bool TinhNguyen{ get; set; }
        public string TTTinhNguyen{ get; set; } = "";
        public string VPPLXL { get; set; } = "";
        public bool ThuongBenhBinh { get; set; }
        public string TTThuongBB { get; set; } = "";
        public bool CTTrongQD { get; set; }
        public string TTCTTrongQD { get; set; } = "";
        public bool LietSi { get; set; }
        public string TTLietsi { get; set; } = "";
        public bool MeVNAH { get; set; }
        public string TTMeVNAH { get; set; } = "";
        public bool CBDV { get; set; }
        public string HotenCBDV { get; set; } = "";
        public string QuanheCBDV { get; set; } = "";

        public bool CoNY {  get; set; }
        public string HotenNY {  get; set; } = "";
        public string TuoiNY { get; set; } = "";
        public string SDTNY { get; set; } = "";

        public bool NguoiThanMacBenh {  get; set; }
        public string MotaBenhNguoiThan {  get; set; } = "";
        public string ThoiGianBenhNguoiThan { get; set; } = "";
        public GiaDinh GetMember(string QuanHe)
        {
            return null;
        }

        public string txtDonVi()
        {
           return $"a{DonVi[0].TieuDoi}, b{DonVi[0].TrungDoi}, c{DonVi[0].DaiDoi}, " +
                $"d{DonVi[0].TieuDoan}, e{DonVi[0].TrungDoan}, f{DonVi[0].SuDoan}";
        }
        public string txtChoO()
        {
            return $"{ChoO[0].Thon}, {ChoO[0].Xa}, {ChoO[0].Huyen}, {ChoO[0].Tinh}";
        }

        public string txtNoiLamViec()
        {
            return $"{NoilamViec[0].Thon}, {NoilamViec[0].Xa}, {NoilamViec[0].Huyen}, {NoilamViec[0].Tinh}";
        }

        public string PrintParent()
        {
            string txt = "";
            GiaDinh bo =  GD.Find(g => g.QuanHe == QUANHE.BO);
            GiaDinh me = GD.Find(g => g.QuanHe == QUANHE.ME);
            txt += bo == null ? "" : $"{bo.Name}";
            if (bo.Mat) txt += $"    mất: {bo.TGMat}";
            txt += "\n";
            if (me.Mat) txt += $"    mất: {me.TGMat}";
            txt += me == null ? "" : $"{me.Name}";
            return txt;
        }
        public string PrintLydoBomeMat()
        {
            string txt = "";
            GiaDinh bo = GD.Find(g => g.QuanHe == QUANHE.BO);
            GiaDinh me = GD.Find(g => g.QuanHe == QUANHE.ME);
            txt += bo == null ? "" : $"{bo.LyDoMat}";
            txt += "\n";
            txt += me == null ? "" : $"{me.LyDoMat}";
            return txt;
        }
        public GiaDinh GetMember(QUANHE q)
        {
            return GD.Find(g => g.QuanHe == q);
        }
        public string PrintAllGDNNName(int Mau)
        {
            string txt = "";
            foreach (var g in GDNN)
            {
                if(Mau == 3)
                {
                    if(g.QuanHe != QUANHE.TOI)
                    {
                        txt += $"{g.Name}\n";
                    }    
                }    
                if(Mau == 11)
                {
                    if (g.QuanHe == QUANHE.TOI)
                    {
                        txt += $"{g.Name}\n";
                    }
                }    
               
            }    
            return txt;
        }
        public string PrintAllGDNNQuanHe(int Mau)
        {
            string txt = "";
            foreach (var g in GDNN)
            {
                if (Mau == 3)
                {
                    if (g.QuanHe != QUANHE.TOI)
                    {
                        txt += $"{Common.GetEnumDescription(g.QuanHe)}\n";
                    }
                }
            }
            return txt;
        }

        public string PrintAllGDNNQuocGia(int Mau)
        {
            string txt = "";
            foreach (var g in GDNN)
            {
                if (Mau == 3)
                {
                    if (g.QuanHe != QUANHE.TOI)
                    {
                        txt += $"{g.QuocTich}\n";
                    }
                }
                if (Mau == 11)
                {
                    if (g.QuanHe == QUANHE.TOI)
                    {
                        txt += $"{g.QuocTich}\n";
                    }
                }
            }
            return txt;
        }

        public string[] PrintAllGDNNThoiGian(int Mau)
        {
            string[] txt = {"", "", "", ""};
            foreach (var g in GDNN)
            {
                if (Mau == 3)
                {
                    if (g.QuanHe != QUANHE.TOI)
                    {
                        switch (g.Dien)
                        {
                            case DIEN.VBIEN:
                                txt[0] += $"{g.ThoiGian}\n";
                                break;
                            case DIEN.BLANH:
                                txt[1] += $"{g.ThoiGian}\n";
                                break;
                            case DIEN.XKLD:
                                txt[2] += $"{g.ThoiGian}\n";
                                break;
                            case DIEN.DUHOC:
                                txt[3] += $"{g.ThoiGian}\n";
                                break;
                        }
                    }
                }
                if (Mau == 11)
                {
                    if (g.QuanHe == QUANHE.TOI)
                    {
                        switch (g.Dien)
                        {
                            case DIEN.VBIEN:
                                txt[0] += $"{g.ThoiGian}\n";
                                break;
                            case DIEN.BLANH:
                                txt[1] += $"{g.ThoiGian}\n";
                                break;
                            case DIEN.XKLD:
                                txt[2] += $"{g.ThoiGian}\n";
                                break;
                            case DIEN.DUHOC:
                                txt[3] += $"{g.ThoiGian}\n";
                                break;
                        }
                    }
                }
                
            }
            return txt;
        }

        public string PrintAllGDNNGhiChu(int Mau)
        {
            string txt = "";
            foreach (var g in GDNN)
            {
                if (Mau == 3)
                {
                    if (g.QuanHe != QUANHE.TOI)
                    {
                        txt += $"{g.Name}\n";
                    }
                }
                if (Mau == 11)
                {
                    if (g.QuanHe == QUANHE.TOI)
                    {
                        txt += $"{g.Name}\n";
                    }
                }
            }
            return txt;
        }

        public string PrintVoCon()
        {
            string txt = $"";
            GiaDinh vo = GD.Find(g => g.QuanHe == QUANHE.VO);
            List<GiaDinh> contrai = GD.FindAll(g=>g.QuanHe == QUANHE.CONT);
            List<GiaDinh> congai = GD.FindAll(g=>g.QuanHe == QUANHE.CONG);
            if (vo != null)
            {
                txt += $"Vợ: {vo.Name} {vo.NgaySinh}\n";
            }    
            foreach (var g in contrai)
            {
                txt += $"Con trai: {g.Name} {g.NgaySinh}\n";
            }
            foreach (var g in congai)
            {
                txt += $"Con gái: {g.Name} {g.NgaySinh}\n";
            }
            return txt;
        }
        public string PrintCon()
        {
            string txt = $"";
            List<GiaDinh> contrai = GD.FindAll(g => g.QuanHe == QUANHE.CONT);
            List<GiaDinh> congai = GD.FindAll(g => g.QuanHe == QUANHE.CONG);
            foreach (var g in contrai)
            {
                txt += $"{g.Name} {g.NgaySinh}\n";
            }
            foreach (var g in congai)
            {
                txt += $"{g.Name} {g.NgaySinh}\n";
            }
            return txt;
        }

        public int GetConTrai()
        {

           return GD.FindAll(g=>g.QuanHe == QUANHE.CONT).Count;
        }

        public int GetCongai()
        {
            return GD.FindAll(g=>g.QuanHe == QUANHE.CONG).Count;
        }

        public string PrintAllVPPLNoiDung(int Mau)
        {
            string txt = $"";
            foreach(var v in vppl)
            {
                if(Mau == 7)
                {
                    if(v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.VPHC)
                    {
                        txt += $"{v.NoiDung}\n";
                    }    
                }
                if (Mau == 8)
                {
                    if (v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.TNGT)
                    {
                        txt += $"{v.NoiDung}\n";
                    }
                }

            }    
            return txt;
        }

        public string PrintAllVPPLThoiGian(int Mau)
        {
            string txt = $"";
            foreach (var v in vppl)
            {
                if (Mau == 7)
                {
                    if (v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.VPHC)
                    {
                        txt += $"{v.ThoiGian}\n";
                    }
                }
                if (Mau == 8)
                {
                    if (v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.TNGT)
                    {
                        txt += $"{v.ThoiGian}\n";
                    }
                }
            }
            return txt;
        }
        public string PrintAllVPPLGhiChu(int Mau)
        {
            string txt = $"";
            foreach (var v in vppl)
            {
                if (Mau == 7)
                {
                    if (v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.VPHC)
                    {
                        txt += $"{v.GhiChu}\n";
                    }
                }
                if (Mau == 8)
                {
                    if (v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.TNGT)
                    {
                        txt += $"{v.GhiChu}\n";
                    }
                }
            }
            return txt;
        }
        public string PrintAllVPPLLyDo(int Mau)
        {
            string txt = $"";
            foreach (var v in vppl)
            {
                if (Mau == 8)
                {
                    if (v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.TNGT)
                    {
                        txt += $"{v.LyDoViPham}\n";
                    }
                }
            }
            return txt;
        }

        public string PrintAllVPPLHauQua(int Mau)
        {
            string txt = $"";
            foreach (var v in vppl)
            {
                if (Mau == 8)
                {
                    if (v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.TNGT)
                    {
                        txt += $"{v.HauQua}\n";
                    }
                }
            }
            return txt;
        }
        public string[] PrintAllVPPLMucDo(int Mau)
        {
            string[] txt = { "", "", "", "" };
            foreach (var v in vppl)
            {
                if (Mau == 7)
                {
                    if (v.NguoiViPham == QUANHE.TOI || v.LoaiViPham == LOAIVPPL.VPHC)
                    {
                        switch (v.HinhThuc)
                        {
                            case HINHTHUCXULY.TIEN:
                                txt[0] += $"{v.MucDo}\n";
                                break;
                            case HINHTHUCXULY.TU:
                                txt[1] += $"{v.MucDo}\n";
                                break;
                            case HINHTHUCXULY.TREO:
                                txt[2] += $"{v.MucDo}\n";
                                break;
                            case HINHTHUCXULY.CHUAXL:
                                txt[3] += $"{v.MucDo}\n";
                                break;
                        }
                    }
                }
                if (Mau == 8)
                {
                    if (v.NguoiViPham == QUANHE.TOI || v.LoaiViPham == LOAIVPPL.TNGT)
                    {
                        switch (v.HinhThuc)
                        {
                            case HINHTHUCXULY.TIEN:
                                txt[0] += $"{v.MucDo}\n";
                                break;
                            case HINHTHUCXULY.TU:
                                txt[1] += $"{v.MucDo}\n";
                                break;
                            case HINHTHUCXULY.TREO:
                                txt[2] += $"{v.MucDo}\n";
                                break;
                            case HINHTHUCXULY.CHUAXL:
                                txt[3] += $"{v.MucDo}\n";
                                break;
                        }
                    }
                }
                
            }
            return txt;
        }

        public string PrintAllNDXam()
        {
            string txt = "";
            foreach (var x in XC)
            {
                txt += $"{x.ND}\n";
            }
            return txt;
        }
        public string PrintAllViTriDienTichXam()
        {
            string txt = "";
            foreach (var x in XC)
            {
                txt += $"{x.ViTri}\n";
            }
            return txt;
        }
        public string PrintAllYNghiaXam()
        {
            string txt = "";
            foreach (var x in XC)
            {
                txt += $"{x.YNghia}\n";
            }
            return txt;
        }
        public string PrintAllLydothoigianXam()
        {
            string txt = "";
            foreach (var x in XC)
            {
                txt += $"{x.Lydo}\n";
            }
            return txt;
        }
    }
}
