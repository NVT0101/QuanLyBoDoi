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
            try
            {
                var people = conn.GetAllWithChildren<People>(recursive: true).Where(p => p.ConNgoaiHon).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau1", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau2()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.BomeLyHon).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau2", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau3()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.GDNN.Count(g => g.QuanHe != QUANHE.TOI) > 0).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau3", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau4()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => (p.GD.Count(g => g.QuanHe == QUANHE.VO) > 0 && !p.DKKH) || (p.GD.Count(g => g.QuanHe == QUANHE.VO) <= 0 && (p.GD.Count(g => g.QuanHe == QUANHE.CONG) > 0 || p.GD.Count(g => g.QuanHe == QUANHE.CONT) > 0))).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau4", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau5a6()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.ConNQNQ).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau5a6", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau7()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.vppl.Count(v => v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.VPHC) > 0).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau7", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau8()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.vppl.Count(v => v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.TNGT) > 0).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau8", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau9()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.TrinhDo == TRINHDO.KBD || p.TrinhDo == TRINHDO.KBV || p.TrinhDo == TRINHDO.DVC).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau9", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau10()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.HoanCanh != HOANCANH.BTH && p.HoanCanh != HOANCANH.KHAG).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau10", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau11()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.GDNN.Exists(g => g.QuanHe == QUANHE.TOI)).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau11", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau12()
        {
            try
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
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau12", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau13()
        {
            try
            {
            //to do
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau13", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau14()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.XC.Count > 0).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau14", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau15()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.LamAnXa).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau15", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau16()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.Dantoc != DANTOC.KINH).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau16", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau17()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.Tongiao != TONGIAO.KHONG).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau17", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau18()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.TinhNguyen).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau18", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau19()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.vppl.Count(v => v.HinhThuc == HINHTHUCXULY.TU) > 0).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau19", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau20()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.Job == JOB.BIEN).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau20", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau21()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.ThuongBenhBinh).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau21", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau22()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.CTTrongQD).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau22", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau23()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.LietSi).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau23", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau24()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.MeVNAH).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau24", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau25()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.NghienThuoc || p.NghienRuou).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau25", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau26()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.MXH).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau26", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau27()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.NhuomToc).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau27", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau28()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.CDDH).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau28", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau29()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.CBDV).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau29", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau30()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.Dang).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau30", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau31()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.CoNY).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau31", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau32()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.GD.Exists(g => g.QuanHe == QUANHE.VO)).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau32", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau33()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.GD.Exists(g => g.QuanHe == QUANHE.VO) && p.DKKH).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau33", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau34()
        {
            try
            {
            /*var people = conn.GetAllWithChildren<People>().Where(p => p.GD.Exists(g => g.QuanHe == QUANHE.VO) && p.DKKH).ToList();
            AddViewDataSource(people);*/
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau34", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void LoadMau35()
        {
            try
            {
                var people = conn.GetAllWithChildren<People>().Where(p => p.NguoiThanMacBenh).ToList();
                AddViewDataSource(people);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadMau35", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}