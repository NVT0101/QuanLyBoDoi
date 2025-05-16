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
        private void ViewPeople(object sender, EventArgs e)
        {
            string selID = alldatatable.SelectedRows[0].Cells[0].Value.ToString();
            curentMode = CONTROL.EDITMODE;
            tabControl1.SelectedIndex = 0;
            BindData(selID);
        }
        private void BindData(string peopleID)
        {
            var newPeople = conn.GetWithChildren<People>(peopleID);
            hoten.Text = newPeople.Name;
            hoten1.Text = newPeople.OtherName;
            ngaysinh.Text = newPeople.Birth;
            dantoc.SelectedValue = newPeople.Dantoc;
            tongiao.SelectedValue = newPeople.Tongiao;
            vanhoa.SelectedValue = newPeople.Vanhoa;
            dang.Checked = newPeople.Dang;
            ngayvaodang.Text = newPeople.NgayDang;
            doan.Checked = newPeople.Doan;
            ngayvaodoan.Text = newPeople.NgayDoan;
            nghenghiep.SelectedValue = newPeople.Job;
            thunhap.Text = newPeople.ThuNhapCaNhan;
            noilamviecthon.Text = newPeople.NoilamViec[0].Thon;
            noilamviecxa.Text = newPeople.NoilamViec[0].Xa;
            noilamviechuyen.Text = newPeople.NoilamViec[0].Huyen;
            noilamviectinh.Text = newPeople.NoilamViec[0].Tinh;
            trinhdo.SelectedValue = newPeople.TrinhDo;
            quequanthon.Text = newPeople.QueQuan[0].Thon;
            quequanxa.Text = newPeople.QueQuan[0].Xa;
            quequanhuyen.Text = newPeople.QueQuan[0].Huyen;
            quequantinh.Text = newPeople.QueQuan[0].Tinh;
            noiothon.Text = newPeople.ChoO[0].Thon;
            noioxa.Text = newPeople.ChoO[0].Xa;
            noiohuyen.Text = newPeople.ChoO[0].Huyen;
            noiotinh.Text = newPeople.ChoO[0].Tinh;
            tieudoi.Text = newPeople.DonVi[0].TieuDoi;
            trungdoi.Text = newPeople.DonVi[0].TrungDoi;
            daidoi.Text = newPeople.DonVi[0].DaiDoi;
            tieudoan.Text = newPeople.DonVi[0].TieuDoan;
            trungdoan.Text = newPeople.DonVi[0].TrungDoan;
            sudoan.Text = newPeople.DonVi[0].SuDoan;
            conngoaihon.Checked = newPeople.ConNgoaiHon;
            hoancanhgiadinh.SelectedValue = newPeople.HoanCanh;
            motahoancanh.Text = newPeople.MoTaHoanCanh;
            bomelyhon.Checked = newPeople.BomeLyHon;
            lydolyhon.Text = newPeople.LydoLyHon;
            banthandkkh.Checked = newPeople.DKKH;
            lydococon.Text = newPeople.LydoCoCon;
            conthuongbinh.Checked = newPeople.ThuongBenhBinh;
            thongtinthuongbinh.Text = newPeople.TTThuongBB;
            concanbotrongqd.Checked = newPeople.CTTrongQD;
            thongtincanbotrongqd.Text = newPeople.TTCTTrongQD;
            chaumevnah.Checked = newPeople.MeVNAH;
            thongtinchaumevnah.Text = newPeople.TTMeVNAH;
            chaulietsi.Checked = newPeople.LietSi;
            thongtinchaulietsi.Text = newPeople.TTLietsi;
            uongruou.Checked = newPeople.NghienRuou;
            ttuongruou.Text = newPeople.MucDoNR;
            hutthuocla.Checked = newPeople.NghienThuoc;
            tthutthuoc.Text = newPeople.MucDoNT;
            choigame.Checked = newPeople.NghienGame;
            ttchoigame.Text = newPeople.MucDoNG;
            nhuomtoc.Checked = newPeople.NhuomToc;
            ttnhuomtoc.Text = newPeople.TTNhuomToc;
            lydonhuomtoc.Text = newPeople.TTNhuomToc;
            mxh.Checked = newPeople.MXH;
            ttmxh.Text = newPeople.TTMXH;
            ghichumxh.Text = newPeople.GhiChuMXH;
            cddh.Checked = newPeople.CDDH;
            truonghoc.Text = newPeople.TruongHoc;
            nganhhoc.Text = newPeople.ChuyenNganh;
            concbdv.Checked = newPeople.CBDV;
            hotencbdv.Text = newPeople.HotenCBDV;
            quanhecbdv.Text = newPeople.QuanheCBDV;
            nguoithanmacbenh.Checked = newPeople.NguoiThanMacBenh;
            motanguoithanmacbenh.Text = newPeople.MotaBenhNguoiThan;
            thoigiannguoithanmacbenh.Text = newPeople.ThoiGianBenhNguoiThan;
            phucvulaudai.Checked = newPeople.TinhNguyen;
            noidungphucvulaudai.Text = newPeople.TTTinhNguyen;
            bomedkkh.Checked = newPeople.BoMeDKKH;

            cony.Checked = newPeople.CoNY;
            tenny.Text = newPeople.HotenNY;
            tuoiny.Text = newPeople.TuoiNY;
            sdtny.Text = newPeople.SDTNY;
            //GD
            BindGD(newPeople.GD);
            //GDNN
            BindGDNN(newPeople.GDNN);
            //VPPL
            BindVPPL(newPeople.vppl);
            //CreateXamCham() = newPeople.XC;
            BindXC(newPeople.XC);

        }
        private void DeletePeople(object sender, EventArgs e)
        {
            
            People newPeople = CreatePeople();
            DialogResult dialogResult = MessageBox.Show("Xác nhận xóa", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in alldatatable.SelectedRows)
                {

                    string selID = r.Cells[0].Value.ToString();
                    conn.Delete<People>(selID);
                    //SQLConnection.InsertData(conn, newPeople);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
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
