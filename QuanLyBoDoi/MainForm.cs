using SQLite;
using SQLiteNetExtensions.Extensions;
using System.ComponentModel;
using System.Net.WebSockets;
using System.Reflection;

namespace QuanLyBoDoi
{
    public enum JOB
    {
        [Description("Biển")] BIEN,
        [Description("Công nghệ thông tin")] CNTT, 
        [Description("Khác")] KHAC
    }
    public enum DIEN
    {
        [Description("Vượt biên")] VBIEN,
        [Description("Bảo lãnh")] BLANH,
        [Description("XKLĐ")] XKLD,
        [Description("Du học")] DUHOC,
        [Description("Khác")] KHAC,
    }
    public enum HINHTHUCXULY
    {

        [Description("Phạt tiền")] TIEN,
        [Description("Phạt tù")] TU,
        [Description("Án treo")] TREO,
        [Description("Chưa xử lý")] CHUAXL
    }

    public enum QUANHE
    {
        [Description("Tôi")] TOI,
        [Description("Bố")] BO,
        [Description("Mẹ")] ME,
        [Description("Anh")] ANH,
        [Description("Chị")] CHI,
        [Description("Em trai")] EMT,
        [Description("Em gái")] EMG,
        [Description("Ông nội")] ONGN,
        [Description("Bà nội")] BAN,
        [Description("Ông ngoại")] ONGNG,
        [Description("Bà ngoại")] BANG,
        [Description("Vợ")] VO,
        [Description("Chồng")] CHONG,
        [Description("Con trai")] CONT,
        [Description("Con gái")] CONG,
        [Description("Anh họ")] ANHH,
        [Description("Chị họ")] CHIH,
        [Description("Em họ")] EMH,
        [Description("Cô")] CO,
        [Description("Dì")] DI,
        [Description("Chú")] CHU,
        [Description("Bác")] BAC,
        [Description("Dượng")] DUONG,
        [Description("Mẹ kế")] MEKE,
        [Description("Bố dượng")] BOD,
        [Description("Khác")] KHAC,
    }

    public enum TRINHDO
    {
        [Description("Lớp 1")] L1,
        [Description("Lớp 2")] L2,
        [Description("Lớp 3")] L3,
        [Description("Lớp 4")] L4,
        [Description("Lớp 5")] L5,
        [Description("Lớp 6")] L6,
        [Description("Lớp 7")] L7,
        [Description("Lớp 8")] L8,
        [Description("Lớp 9")] L9,
        [Description("Lớp 10")] L10,
        [Description("Lớp 11")] L11,
        [Description("Lớp 12")] L12,
        [Description("Cao đẳng")] CD,
        [Description("Đại học")] DH,
        [Description("Trung cấp")] TC,
        [Description("Không biết đọc")] KBD,
        [Description("Không biết viết")] KBV,
        [Description("Đọc, viết chậm")] DVC
    }

    public enum DANTOC
    {
        [Description("Kinh")] KINH,
        [Description("Mường")] MUONG,
        [Description("Bana")] BANA,
        [Description("Ê Đê")] EDE,
        [Description("Co")] CO,
        [Description("Giarai")] JRAI,
        [Description("Xơ Đăng")] XODANG,
        [Description("Hrê")] HRE,
        [Description("Mnông")] MNONG,

    }

    public enum TONGIAO
    {
        [Description("Khong")] KHONG,
        [Description("Phật giáo")] PHAT,
        [Description("Tin lành")] TINLANH,
        [Description("Thiên chúa")] THIENCHUA,
        [Description("Công giáo")] CONG,
        [Description("Cao đài")] CAODAI,
        [Description("Bà ni")] BANI,
        [Description("Bà la môn")] BALAMON,
        [Description("Cơ đốc")] CODOC,
    }

    public enum TINH
    {
        [Description("Bình Định")] BDH,
        [Description("Quảng Ngãi")] QNG,
        [Description("Gia Lai")] GL,
        [Description("Kon Tum")] KONTUM,
        [Description("Khánh Hòa")] KHHOA,
        [Description("Đắk Lắk")] DKLK,
    }

    public enum SK
    {
        [Description("Loại 1")] L1,
        [Description("Loại 2")] L2,
        [Description("Loại 3")] L3,
    }

    public enum HOANCANH
    {
        [Description("Hộ nghèo")] HONGH,
        [Description("Hộ cận nghèo")] CANNGH,
        [Description("Bình thường")] BTH,
        [Description("Khá giả")] KHAG,
        [Description("Khó khăn")] KK,
        [Description("Đặc biệt khó khăn")] DBKK,
    }

    public enum LOAIVPPL
    {
        [Description("Vi phạm hành chính")] VPHC,
        [Description("Tai nạn giao thông")] TNGT,
    }


    public partial class MainForm : Form
    {
        public SQLiteConnection conn;
        public WordProcess word;
        public People currentPeople = new People();
        public MainForm()
        {
            InitializeComponent();
        }



        private void radMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void CreateDatabase(object sender, EventArgs e)
        {
            SQLiteConnection con = SQLConnection.CreateConnection();
            SQLConnection.CreateTable(con);

        }


        private void MainFormLoad(object sender, EventArgs e)
        {
            InitForm();
            GetCurrentDB();
            word = new WordProcess();
            conn = SQLConnection.CreateConnection(Common.CurentDB);
            Common.outPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Output");
            menupanel.Controls.Add(CreateButton("Nhập thông tin", AddTodatabase), 2, 1);
        }

        void InitForm()
        {
            //Nghề nghiệp


            //trình độ
            trinhdo.BindEnumToCombobox<TRINHDO>(TRINHDO.L12);

            //Dân tộc
            dantoc.BindEnumToCombobox<DANTOC>(DANTOC.KINH);

            //Văn hóa
            vanhoa.BindEnumToCombobox<TRINHDO>(TRINHDO.L12);

            //Tôn giáo
            tongiao.BindEnumToCombobox<TONGIAO>(TONGIAO.KHONG);

            //Quan hệ
            quanhegiadinh.BindEnumToTableBand<QUANHE>();
            quanhedinuocngoai.BindEnumToTableBand<QUANHE>();
            nguoivipham.BindEnumToTableBand<QUANHE>();

            //Diện đi nước ngoài
            diendinuocngoai.BindEnumToTableBand<DIEN>();

            //default value
            loaivipham.BindEnumToTableBand<LOAIVPPL>();
            hinhthucxuly.BindEnumToTableBand<HINHTHUCXULY>();

            //hoàn cảnh gia đình
            hoancanhgiadinh.BindEnumToCombobox<HOANCANH>(HOANCANH.BTH);

            //nghề nghiệp
            nghenghiep.BindEnumToCombobox<JOB>(JOB.KHAC);

        }

        private void OpenTabpageSelectdatabase(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void GetCurrentDB()
        {
            Common.CurentDB = Properties.Settings.Default.CurrentDB;
        }

        private void AddTodatabase(object sender, EventArgs e)
        {
            People newPeople = CreatePeople();
            DialogResult dialogResult = MessageBox.Show("Xác nhận thông tin", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                conn.InsertWithChildren(newPeople, recursive: true);
                //SQLConnection.InsertData(conn, newPeople);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void LoadData(object sender, EventArgs e)
        {
            //SQLConnection.ReadData(conn);

        }

        private void Closed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }


        People CreatePeople()
        {
            People newPeople = new People();
            newPeople.PeopleID = Guid.NewGuid().ToString();
            newPeople.Name = hoten.Text;
            newPeople.OtherName = hoten1.Text;
            newPeople.Birth = ngaysinh.Text;
            newPeople.Dantoc = (DANTOC)dantoc.SelectedValue;
            newPeople.Tongiao = (TONGIAO)tongiao.SelectedValue;
            newPeople.Vanhoa = (TRINHDO)vanhoa.SelectedValue;
            newPeople.Dang = dang.Checked;
            newPeople.NgayDang = ngayvaodang.Text;
            newPeople.Doan = doan.Checked;
            newPeople.NgayDoan = ngayvaodoan.Text;
            newPeople.Job = (JOB)nghenghiep.SelectedValue;
            newPeople.ThuNhapCaNhan = thunhap.Text;
            newPeople.NoilamViec = new List<DiaChiLamViec> { new DiaChiLamViec(noilamviecthon.Text, noilamviecxa.Text, noilamviechuyen.Text, noilamviectinh.Text) };
            newPeople.TrinhDo = (TRINHDO)trinhdo.SelectedValue;
            newPeople.QueQuan = new List<QueQuan> { new QueQuan(quequanthon.Text, quequanxa.Text, quequanhuyen.Text, quequantinh.Text) };
            newPeople.ChoO = new List<ChoO> { new ChoO(noiothon.Text, noioxa.Text, noiohuyen.Text, noiotinh.Text) };
            newPeople.DonVi = new List<DonVi> { new DonVi(tieudoi.Text, trungdoi.Text, daidoi.Text, tieudoan.Text, trungdoan.Text, sudoan.Text) };
            newPeople.GD = CreateGiaDinh();
            newPeople.ConNgoaiHon = conngoaihon.Checked;
            newPeople.GDNN = CreateGDNuocNgoai();
            newPeople.vppl = CreateVPPL();
            newPeople.HoanCanh = (HOANCANH)hoancanhgiadinh.SelectedValue;
            newPeople.MoTaHoanCanh = motahoancanh.Text;
            newPeople.BomeLyHon = bomelyhon.Checked;
            newPeople.LydoLyHon = lydolyhon.Text;
            newPeople.DKKH = banthandkkh.Checked;
            newPeople.LydoCoCon = lydococon.Text;
            newPeople.ThuongBenhBinh = conthuongbinh.Checked;
            newPeople.TTThuongBB = thongtinthuongbinh.Text;
            newPeople.CTTrongQD = concanbotrongqd.Checked;
            newPeople.TTCTTrongQD = thongtincanbotrongqd.Text;
            newPeople.MeVNAH = chaumevnah.Checked;
            newPeople.TTMeVNAH = thongtinchaumevnah.Text;
            newPeople.LietSi = chaulietsi.Checked;
            newPeople.TTLietsi = thongtinchaulietsi.Text;
            newPeople.NghienRuou = uongruou.Checked;
            newPeople.MucDoNR = ttuongruou.Text;
            newPeople.NghienThuoc = hutthuocla.Checked;
            newPeople.MucDoNT = tthutthuoc.Text;
            newPeople.NghienGame = choigame.Checked;
            newPeople.MucDoNG = ttchoigame.Text;
            newPeople.NhuomToc = nhuomtoc.Checked;
            newPeople.TTNhuomToc = ttnhuomtoc.Text;
            newPeople.TTNhuomToc = lydonhuomtoc.Text;
            newPeople.MXH = mxh.Checked;
            newPeople.TTMXH = ttmxh.Text;
            newPeople.GhiChuMXH = ghichumxh.Text;
            newPeople.CDDH = cddh.Checked;
            newPeople.TruongHoc = truonghoc.Text;
            newPeople.ChuyenNganh = nganhhoc.Text;
            newPeople.CBDV = concbdv.Checked;
            newPeople.HotenCBDV = hotencbdv.Text;
            newPeople.QuanheCBDV = quanhecbdv.Text;
            newPeople.NguoiThanMacBenh = nguoithanmacbenh.Checked;
            newPeople.MotaBenhNguoiThan = motanguoithanmacbenh.Text;
            newPeople.ThoiGianBenhNguoiThan = thoigiannguoithanmacbenh.Text;
            newPeople.TinhNguyen = phucvulaudai.Checked;
            newPeople.TTTinhNguyen = noidungphucvulaudai.Text;
            newPeople.BoMeDKKH = bomedkkh.Checked;
            newPeople.GD = CreateGiaDinh();
            newPeople.CoNY = cony.Checked;
            newPeople.HotenNY = tenny.Text;
            newPeople.TuoiNY = tuoiny.Text;
            newPeople.SDTNY = sdtny.Text;
            newPeople.XC = CreateXamCham();
            return newPeople;
        }

        List<GiaDinh> CreateGiaDinh()
        {
            List<GiaDinh> newGDs = new List<GiaDinh>();
            foreach (DataGridViewRow row in tableGD.Rows)
            {
                if (row.Cells[quanhegiadinh.Index].Value != null)
                {
                    GiaDinh newGD = new GiaDinh();
                    newGD.ID = Guid.NewGuid().ToString();
                    newGD.Name = row.Cells[hotengiadinh.Index].EditedFormattedValue.ToString();
                    newGD.QuanHe = (QUANHE)row.Cells[quanhegiadinh.Index].Value;
                    newGD.NgaySinh = row.Cells[ngaysinhgiadinh.Index].EditedFormattedValue.ToString();
                    newGD.NgheNghiep = row.Cells[nghenghiepgiadinh.Index].EditedFormattedValue.ToString();
                    newGD.Mat = (bool)row.Cells[mat.Index].EditedFormattedValue;
                    newGD.NguoiNuoiDuong = (bool)row.Cells[nguoinuoiduong.Index].EditedFormattedValue;
                    newGD.LyDoMat = row.Cells[lydomat.Index].EditedFormattedValue.ToString();
                    newGD.TGMat = row.Cells[thoigianmat.Index].EditedFormattedValue.ToString();

                    newGDs.Add(newGD);
                }
            }
            return newGDs;
        }

        List<XamCham> CreateXamCham()
        {
            List<XamCham> newXC = new List<XamCham>();
            foreach (DataGridViewRow row in tablexamcham.Rows)
            {
                XamCham xc = new XamCham();
                xc.Id = Guid.NewGuid().ToString();
                xc.ND = row.Cells[noidungxamcham.Index].EditedFormattedValue.ToString();
                xc.ViTri = row.Cells[vitridientich.Index].EditedFormattedValue.ToString();
                xc.Lydo = row.Cells[lydothoigianxam.Index].EditedFormattedValue.ToString();
                xc.YNghia = row.Cells[ynghiahinhxam.Index].EditedFormattedValue.ToString();
                newXC.Add(xc);
            }
            return newXC;
        }

        List<GDNuocNgoai> CreateGDNuocNgoai()
        {
            List<GDNuocNgoai> newGDs = new List<GDNuocNgoai>();
            foreach (DataGridViewRow row in tabledinuocngoai.Rows)
            {
                if (row.Cells[quanhedinuocngoai.Index].Value != null)
                {
                    GDNuocNgoai newGD = new GDNuocNgoai();
                    newGD.Id = Guid.NewGuid().ToString();
                    newGD.Name = row.Cells[hotendinuocngoai.Index].EditedFormattedValue.ToString();
                    newGD.QuanHe = (QUANHE)row.Cells[quanhedinuocngoai.Index].Value;

                    newGD.QuocTich = row.Cells[quoctichdinuocngoai.Index].EditedFormattedValue.ToString();
                    newGD.Dien = (DIEN)row.Cells[diendinuocngoai.Index].Value;
                    newGD.ThoiGian = row.Cells[thoigiandinuocngoai.Index].EditedFormattedValue.ToString();
                    newGD.GhiChu = row.Cells[ghichudinuocngoai.Index].EditedFormattedValue.ToString();
                    newGDs.Add(newGD);
                }
            }
            return newGDs;
        }

        List<VPPL> CreateVPPL()
        {
            List<VPPL> vppls = new List<VPPL>();
            foreach (DataGridViewRow row in tablevppl.Rows)
            {
                if (row.Cells[quanhedinuocngoai.Index].Value != null)
                {
                    VPPL vppl = new VPPL();
                    vppl.Id = Guid.NewGuid().ToString();
                    vppl.HoTen = row.Cells[hotenvipham.Index].EditedFormattedValue.ToString();
                    vppl.NguoiViPham = (QUANHE)row.Cells[nguoivipham.Index].Value;
                    vppl.MucDo = row.Cells[mucdoxuly.Index].EditedFormattedValue.ToString();
                    vppl.ThoiGian = row.Cells[thoigianvipham.Index].EditedFormattedValue.ToString();
                    vppl.NoiDung = row.Cells[noidungvipham.Index].EditedFormattedValue.ToString();
                    vppl.HinhThuc = (HINHTHUCXULY)row.Cells[hinhthucxuly.Index].Value;
                    vppl.GhiChu = row.Cells[ghichuvipham.Index].EditedFormattedValue.ToString();
                    vppl.LoaiViPham = (LOAIVPPL)row.Cells[loaivipham.Index].Value;
                    vppl.LyDoViPham = row.Cells[lydovipham.Index].EditedFormattedValue.ToString();
                    vppl.HauQua = row.Cells[hauqua.Index].EditedFormattedValue.ToString();
                    vppls.Add(vppl);
                }
            }
            return vppls;
        }




        private void SelectTemplate(object sender, EventArgs e)
        {
            try
            {
                //LoadMau ld = new LoadMau();

                Type thisType = this.GetType();
                MethodInfo theMethod = thisType.GetMethod($"LoadMau{ListTemplate.SelectedIndex + 1}");
                theMethod.Invoke(this, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ExportTuyenHuanProcess(object sender, EventArgs e)
        {
            List<People> lp;
            switch (ListTemplate.SelectedIndex)
            {
                case 0:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.ConNgoaiHon).ToList();
                    word.Mau1(lp);
                    break;
                case 1:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.BomeLyHon).ToList();
                    word.Mau2(lp);
                    break;
                case 2:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.GDNN.Count(g => g.QuanHe != QUANHE.TOI) > 0).ToList();
                    word.Mau3(lp);
                    break;
                case 3:
                    lp = conn.GetAllWithChildren<People>().Where(p => (p.GD.Count(g => g.QuanHe == QUANHE.VO) > 0 && !p.DKKH)).ToList();
                    lp.AddRange(conn.GetAllWithChildren<People>().Where(p => (p.GD.Count(g => g.QuanHe == QUANHE.VO) <= 0 &&
                    (p.GD.Count(g => g.QuanHe == QUANHE.CONG) > 0 ||
                    p.GD.Count(g => g.QuanHe == QUANHE.CONT) > 0))).ToList());
                    word.Mau4(lp);
                    break;
                case 4 or 5:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.ConNQNQ).ToList();
                    word.Mau5a6(lp);
                    break;
                case 6:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.vppl.Count(v => v.NguoiViPham == QUANHE.TOI &&
                    v.LoaiViPham == LOAIVPPL.VPHC) > 0).ToList();
                    word.Mau7(lp);
                    break;
                case 7:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.vppl.Count(v => v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.TNGT) > 0).ToList();
                    word.Mau8(lp);
                    break;
                case 8:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.TrinhDo == TRINHDO.KBD || p.TrinhDo == TRINHDO.KBV || p.TrinhDo == TRINHDO.DVC).ToList();
                    word.Mau9(lp);
                    break;
                case 9:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.HoanCanh != HOANCANH.BTH && p.HoanCanh != HOANCANH.KHAG).ToList();
                    word.Mau10(lp);
                    break;
                case 10:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.GDNN.Exists(g => g.QuanHe == QUANHE.TOI)).ToList();
                    word.Mau11(lp);
                    break;
                case 11:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.GD.Exists(g =>
                    {
                        GiaDinh me = p.GetMember(QUANHE.ME);
                        GiaDinh bo = p.GetMember(QUANHE.BO);
                        if (me != null)
                        {
                            return me.Mat;
                        }
                        if (bo != null)
                        {
                            return bo.Mat;
                        }
                        return false;
                    })).ToList();
                    word.Mau12(lp);
                    break;
                case 12:

                    break;
                case 13:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.XC.Count > 0).ToList();
                    word.Mau14(lp);
                    break;
                case 14:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.LamAnXa).ToList();
                    word.Mau15(lp);
                    break;
                case 15:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.Dantoc != DANTOC.KINH).ToList();
                    word.Mau16(lp);
                    break;
                case 16:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.Tongiao != TONGIAO.KHONG).ToList();
                    word.Mau17(lp);
                    break;
                case 17:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.TinhNguyen).ToList();
                    word.Mau18(lp);
                    break;
                case 18:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.vppl.Count(v => v.HinhThuc == HINHTHUCXULY.TU) > 0).ToList();
                    word.Mau19(lp);
                    break;
                case 19:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.Job == JOB.BIEN).ToList();
                    word.Mau20(lp);
                    break;
                case 20:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.ThuongBenhBinh).ToList();
                    word.Mau21(lp);
                    break;
                case 21:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.CTTrongQD).ToList();
                    word.Mau22(lp);
                    break;
                case 22:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.LietSi).ToList();
                    word.Mau23(lp);
                    break;
                case 23:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.MeVNAH).ToList();
                    word.Mau24(lp);
                    break;
                case 24:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.NghienThuoc || p.NghienRuou).ToList();
                    word.Mau25(lp);
                    break;
                case 25:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.MXH).ToList();
                    word.Mau26(lp);
                    break;
                case 26:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.NhuomToc).ToList();
                    word.Mau27(lp);
                    break;
                case 27:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.CDDH).ToList();
                    word.Mau28(lp);
                    break;
                case 28:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.CBDV).ToList();
                    word.Mau29(lp);
                    break;
                case 29:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.Dang).ToList();
                    word.Mau30(lp);
                    break;
                case 30:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.CoNY).ToList();
                    word.Mau31(lp);
                    break;
                case 31:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.GD.Exists(g => g.QuanHe == QUANHE.VO)).ToList();
                    word.Mau32(lp);
                    break;
                case 32:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.GD.Exists(g => g.QuanHe == QUANHE.VO) && p.DKKH).ToList();
                    word.Mau33(lp);
                    break;
                case 33:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.GD.Exists(g => g.QuanHe == QUANHE.VO) && p.DKKH).ToList();
                    word.Mau34(lp);
                    break;
                case 34:
                    lp = conn.GetAllWithChildren<People>().Where(p => p.NguoiThanMacBenh).ToList();
                    word.Mau35(lp);
                    break;
                case 35:
                    lp = conn.GetAllWithChildren<People>().ToList();
                    word.Mau36(lp);
                    break;
                default:
                    break;
            }
        }

        public void AddViewDataSource(List<People> people)
        {
            var source = new BindingSource();

            foreach (var p in people)
            {
                source.Add(p);
            }

            TuyenHuanDataView.DataSource = source;
        }

        private void CreateGiaDinh(object sender, DataGridViewCellEventArgs e)
        {
            currentPeople.GD = CreateGiaDinh();


        }

        public void MenuChange(object sender, EventArgs e)
        {
            menupanel.Controls.Clear();
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    //menupanel.Controls.Add(CreateButton("Tải thông tin", AddTodatabase), 1, 1);
                    menupanel.Controls.Add(CreateButton("Nhập thông tin", AddTodatabase), 2, 1);
                    break;

                case 1:
                    menupanel.Controls.Add(CreateButton("Xuất file", ExportTuyenHuanProcess), 2, 1);
                    break;

                case 2:
                    menupanel.Controls.Add(CreateButton("Xem", ViewPeople), 1, 1);
                    //menupanel.Controls.Add(CreateButton("Sửa", ExportTuyenHuanProcess), 2, 1);
                    menupanel.Controls.Add(CreateButton("Xóa", DeletePeople), 3, 1);
                    break;
            }

        }

        private Button CreateButton(string name, Action<object, EventArgs> click)
        {
            var btn = new Button();
            btn.Text = name;
            btn.Height = 80;
            btn.Width = 150;
            btn.Click += new EventHandler(click);
            return btn;
        }

        private void ViewPeople(object sender, EventArgs e)
        {
            string selID = alldatatable.SelectedRows[0].ToString();
            var people = conn.GetWithChildren<People>(selID);

        }

        private void DeletePeople(object sender, EventArgs e)
        {

        }

        private void SearchPeople(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            var res = conn.GetAllWithChildren<People>().Where(p =>
            {
                bool match = false;
                match = p.Name.Contains(txt) || p.QueQuan[0].Thon.Contains(txt) || p.QueQuan[0].Xa.Contains(txt)
                || p.QueQuan[0].Huyen.Contains(txt) || p.QueQuan[0].Tinh.Contains(txt);
                match |= p.GD.Exists(g => g.Name.Contains(txt));
                match |= p.HotenNY.Contains(txt);
                match |= p.CCCD.Contains(txt);
                return match;
            });
            var source = new BindingSource();

            foreach (var p in res)
            {
                source.Add(p);
            }
            alldatatable.DataSource = source;
        }

        public void LoadMau1()
        {
            var people = conn.GetAllWithChildren<People>(recursive: true).Where(p => p.ConNgoaiHon).ToList();
            AddViewDataSource(people);
        }
        public void LoadMau2()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.BomeLyHon).ToList();
            AddViewDataSource(people);
        }
        public void LoadMau3()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.GDNN.Count(g => g.QuanHe != QUANHE.TOI) > 0).ToList();
            AddViewDataSource(people);
        }
        public void LoadMau4()
        {
            var people = conn.GetAllWithChildren<People>().Where(p =>
             (p.GD.Count(g => g.QuanHe == QUANHE.VO) > 0 && !p.DKKH) ||
             (p.GD.Count(g => g.QuanHe == QUANHE.VO) <= 0 &&
             (p.GD.Count(g => g.QuanHe == QUANHE.CONG) > 0 ||
             p.GD.Count(g => g.QuanHe == QUANHE.CONT) > 0))).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau5a6()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.ConNQNQ).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau7()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.vppl.Count(v => v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.VPHC) > 0).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau8()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.vppl.Count(v => v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.TNGT) > 0).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau9()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.TrinhDo == TRINHDO.KBD || p.TrinhDo == TRINHDO.KBV || p.TrinhDo == TRINHDO.DVC).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau10()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.HoanCanh != HOANCANH.BTH && p.HoanCanh != HOANCANH.KHAG).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau11()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.GDNN.Exists(g => g.QuanHe == QUANHE.TOI)).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau12()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.GD.Exists(g =>
            {
                GiaDinh me = p.GetMember(QUANHE.ME);
                GiaDinh bo = p.GetMember(QUANHE.BO);
                if (me != null)
                {
                    return me.Mat;
                }
                if (bo != null)
                {
                    return bo.Mat;
                }
                return false;
            })).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau13()
        {
            //to do
        }

        public void LoadMau14()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.XC.Count > 0).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau15()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.LamAnXa).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau16()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.Dantoc != DANTOC.KINH).ToList();
            AddViewDataSource(people);
        }
        public void LoadMau17()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.Tongiao != TONGIAO.KHONG).ToList();
            AddViewDataSource(people);
        }
        public void LoadMau18()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.TinhNguyen).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau19()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.vppl.Count(v => v.HinhThuc == HINHTHUCXULY.TU) > 0).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau20()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.Job == JOB.BIEN).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau21()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.ThuongBenhBinh).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau22()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.CTTrongQD).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau23()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.LietSi).ToList();
            AddViewDataSource(people);
        }
        public void LoadMau24()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.MeVNAH).ToList();
            AddViewDataSource(people);
        }
        public void LoadMau25()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.NghienThuoc || p.NghienRuou).ToList();
            AddViewDataSource(people);
        }
        public void LoadMau26()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.MXH).ToList();
            AddViewDataSource(people);
        }
        public void LoadMau27()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.NhuomToc).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau28()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.CDDH).ToList();
            AddViewDataSource(people);
        }
        public void LoadMau29()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.CBDV).ToList();
            AddViewDataSource(people);
        }
        public void LoadMau30()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.Dang).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau31()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.CoNY).ToList();
            AddViewDataSource(people);
        }
        public void LoadMau32()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.GD.Exists(g => g.QuanHe == QUANHE.VO)).ToList();
            AddViewDataSource(people);
        }

        public void LoadMau33()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.GD.Exists(g => g.QuanHe == QUANHE.VO) && p.DKKH).ToList();
            AddViewDataSource(people);
        }
        public void LoadMau34()
        {
            /*var people = conn.GetAllWithChildren<People>().Where(p => p.GD.Exists(g => g.QuanHe == QUANHE.VO) && p.DKKH).ToList();
            AddViewDataSource(people);*/
        }
        public void LoadMau35()
        {
            var people = conn.GetAllWithChildren<People>().Where(p => p.NguoiThanMacBenh).ToList();
            AddViewDataSource(people);
        }

        private void viewAll_Click(object sender, EventArgs e)
        {
            var listPeople = conn.GetAllWithChildren<People>();

            var source = new BindingSource();

            foreach (var p in listPeople)
            {
                source.Add(p);
            }
            alldatatable.DataSource = source;
        }
    }
}
