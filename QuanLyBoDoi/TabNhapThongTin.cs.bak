using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDoi
{
    public partial class MainForm
    {
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
        private void BindGD(List<GiaDinh> GDs)
        {
            var source = new BindingSource();

            foreach (var g in GDs)
            {
                source.Add(g);
            }
            tableGD.DataSource = source;
        }

        private void BindGDNN(List<GDNuocNgoai> GDNNs)
        {
            var source = new BindingSource();

            foreach (var g in GDNNs)
            {
                source.Add(g);
            }
            tabledinuocngoai.DataSource = source;
        }

        private void BindVPPL(List<VPPL> VPPLs)
        {
            var source = new BindingSource();

            foreach (var v in VPPLs)
            {
                source.Add(v);
            }
            tablevppl.DataSource = source;
        }

        private void BindXC(List<XamCham> XCs)
        {
            var source = new BindingSource();

            foreach (var x in XCs)
            {
                source.Add(x);
            }
            tablexamcham.DataSource = source;
        }
    }
}
