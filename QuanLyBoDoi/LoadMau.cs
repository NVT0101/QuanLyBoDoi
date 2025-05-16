using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace QuanLyBoDoi
{
    public partial class MainForm
    {
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
    }
}
