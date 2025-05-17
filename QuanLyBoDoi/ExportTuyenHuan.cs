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
        private void ExportTuyenHuanProcess(object sender, EventArgs e)
        {
            try
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
                        lp.AddRange(conn.GetAllWithChildren<People>().Where(p => (p.GD.Count(g => g.QuanHe == QUANHE.VO) <= 0 && (p.GD.Count(g => g.QuanHe == QUANHE.CONG) > 0 || p.GD.Count(g => g.QuanHe == QUANHE.CONT) > 0))).ToList());
                        word.Mau4(lp);
                        break;
                    case 4 or 5:
                        lp = conn.GetAllWithChildren<People>().Where(p => p.ConNQNQ).ToList();
                        word.Mau5a6(lp);
                        break;
                    case 6:
                        lp = conn.GetAllWithChildren<People>().Where(p => p.vppl.Count(v => v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.VPHC) > 0).ToList();
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
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "ExportTuyenHuanProcess", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}