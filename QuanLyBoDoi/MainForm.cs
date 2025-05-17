using SQLite;
using SQLiteNetExtensions.Extensions;
using System.ComponentModel;
using System.Net.WebSockets;
using System.Reflection;

namespace QuanLyBoDoi
{
    public enum JOB
    {
        [Description("Biển")]
        BIEN,
        [Description("Công nghệ thông tin")]
        CNTT,
        [Description("Khác")]
        KHAC
    }

    public enum DIEN
    {
        [Description("Vượt biên")]
        VBIEN,
        [Description("Bảo lãnh")]
        BLANH,
        [Description("XKLĐ")]
        XKLD,
        [Description("Du học")]
        DUHOC,
        [Description("Khác")]
        KHAC,
    }

    public enum HINHTHUCXULY
    {
        [Description("Phạt tiền")]
        TIEN,
        [Description("Phạt tù")]
        TU,
        [Description("Án treo")]
        TREO,
        [Description("Chưa xử lý")]
        CHUAXL
    }

    public enum QUANHE
    {
        [Description("Tôi")]
        TOI,
        [Description("Bố")]
        BO,
        [Description("Mẹ")]
        ME,
        [Description("Anh")]
        ANH,
        [Description("Chị")]
        CHI,
        [Description("Em trai")]
        EMT,
        [Description("Em gái")]
        EMG,
        [Description("Ông nội")]
        ONGN,
        [Description("Bà nội")]
        BAN,
        [Description("Ông ngoại")]
        ONGNG,
        [Description("Bà ngoại")]
        BANG,
        [Description("Vợ")]
        VO,
        [Description("Chồng")]
        CHONG,
        [Description("Con trai")]
        CONT,
        [Description("Con gái")]
        CONG,
        [Description("Anh họ")]
        ANHH,
        [Description("Chị họ")]
        CHIH,
        [Description("Em họ")]
        EMH,
        [Description("Cô")]
        CO,
        [Description("Dì")]
        DI,
        [Description("Chú")]
        CHU,
        [Description("Bác")]
        BAC,
        [Description("Dượng")]
        DUONG,
        [Description("Mẹ kế")]
        MEKE,
        [Description("Bố dượng")]
        BOD,
        [Description("Khác")]
        KHAC,
    }

    public enum TRINHDO
    {
        [Description("Lớp 1")]
        L1,
        [Description("Lớp 2")]
        L2,
        [Description("Lớp 3")]
        L3,
        [Description("Lớp 4")]
        L4,
        [Description("Lớp 5")]
        L5,
        [Description("Lớp 6")]
        L6,
        [Description("Lớp 7")]
        L7,
        [Description("Lớp 8")]
        L8,
        [Description("Lớp 9")]
        L9,
        [Description("Lớp 10")]
        L10,
        [Description("Lớp 11")]
        L11,
        [Description("Lớp 12")]
        L12,
        [Description("Cao đẳng")]
        CD,
        [Description("Đại học")]
        DH,
        [Description("Trung cấp")]
        TC,
        [Description("Không biết đọc")]
        KBD,
        [Description("Không biết viết")]
        KBV,
        [Description("Đọc, viết chậm")]
        DVC
    }

    public enum DANTOC
    {
        [Description("Kinh")]
        KINH,
        [Description("Mường")]
        MUONG,
        [Description("Bana")]
        BANA,
        [Description("Ê Đê")]
        EDE,
        [Description("Co")]
        CO,
        [Description("Giarai")]
        JRAI,
        [Description("Xơ Đăng")]
        XODANG,
        [Description("Hrê")]
        HRE,
        [Description("Mnông")]
        MNONG,
    }

    public enum TONGIAO
    {
        [Description("Khong")]
        KHONG,
        [Description("Phật giáo")]
        PHAT,
        [Description("Tin lành")]
        TINLANH,
        [Description("Thiên chúa")]
        THIENCHUA,
        [Description("Công giáo")]
        CONG,
        [Description("Cao đài")]
        CAODAI,
        [Description("Bà ni")]
        BANI,
        [Description("Bà la môn")]
        BALAMON,
        [Description("Cơ đốc")]
        CODOC,
    }

    public enum TINH
    {
        [Description("Bình Định")]
        BDH,
        [Description("Quảng Ngãi")]
        QNG,
        [Description("Gia Lai")]
        GL,
        [Description("Kon Tum")]
        KONTUM,
        [Description("Khánh Hòa")]
        KHHOA,
        [Description("Đắk Lắk")]
        DKLK,
    }

    public enum SK
    {
        [Description("Loại 1")]
        L1,
        [Description("Loại 2")]
        L2,
        [Description("Loại 3")]
        L3,
    }

    public enum HOANCANH
    {
        [Description("Hộ nghèo")]
        HONGH,
        [Description("Hộ cận nghèo")]
        CANNGH,
        [Description("Bình thường")]
        BTH,
        [Description("Khá giả")]
        KHAG,
        [Description("Khó khăn")]
        KK,
        [Description("Đặc biệt khó khăn")]
        DBKK,
    }

    public enum LOAIVPPL
    {
        [Description("Vi phạm hành chính")]
        VPHC,
        [Description("Tai nạn giao thông")]
        TNGT,
    }

    public enum CONTROL
    {
        EDITMODE = 1,
        INSERTMODE = 2
    }

    public partial class MainForm : Form
    {
        public SQLiteConnection conn;
        public WordProcess word;
        public People currentPeople = new People();
        public CONTROL curentMode = CONTROL.INSERTMODE;
        public MainForm()
        {
            InitializeComponent();
        }

        private void radMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "radMenuItem7_Click", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void CreateDatabase(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection con = SQLConnection.CreateConnection();
                SQLConnection.CreateTable(con);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "CreateDatabase", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        private System.Windows.Forms.Timer resizeTimer;
        private void MainFormLoad(object sender, EventArgs e)
        {
            try
            {
                InitForm();
                GetCurrentDB();
                word = new WordProcess();
                conn = SQLConnection.CreateConnection(Common.CurentDB);
                Common.outPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Output");
                menupanel.Controls.Add(CreateButton("Nhập thông tin", AddTodatabase), 2, 1);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "MainFormLoad", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        void InitForm()
        {
            try
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

                this.DoubleBuffered = true;
                _originalWidth = this.Width;
                _originalHeight = this.Height;
                resizeTimer = new System.Windows.Forms.Timer();
                resizeTimer.Interval = 100; // delay 200ms
                resizeTimer.Tick += ResizeTimer_Tick;
                SaveOriginalStates(this);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "InitForm", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.WindowState = FormWindowState.Maximized;
            /*this.Visible = false;

            *//*_originalWidth = this.Width;
            _originalHeight = this.Height;

            SaveOriginalStates(this);

            float scaleX = (float)this.Width / _originalWidth;
            float scaleY = (float)this.Height / _originalHeight;

            ScaleAllControls(this, scaleX, scaleY);*//*

            this.Visible = true;*/
        }

        private void OpenTabpageSelectdatabase(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "OpenTabpageSelectdatabase", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void GetCurrentDB()
        {
            try
            {
                Common.CurentDB = Properties.Settings.Default.CurrentDB;
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "GetCurrentDB", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void LoadData(object sender, EventArgs e)
        {
            try
            {
                //SQLConnection.ReadData(conn);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "LoadData", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Closed(object sender, FormClosedEventArgs e)
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Closed", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void CreateGiaDinh(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                currentPeople.GD = CreateGiaDinh();
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "CreateGiaDinh", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void MenuChange(object sender, EventArgs e)
        {
            try
            {
                menupanel.Controls.Clear();
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        if (curentMode == CONTROL.INSERTMODE)
                        {
                            //menupanel.Controls.Add(CreateButton("Tải thông tin", AddTodatabase), 1, 1);
                            menupanel.Controls.Add(CreateButton("Nhập thông tin", AddTodatabase), 2, 1);
                        }
                        else
                        {
                            menupanel.Controls.Add(CreateButton("Lưu thông tin", AddTodatabase), 2, 1);
                        }

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
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "MenuChange", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private Button CreateButton(string name, Action<object, EventArgs> click)
        {
            var btn = new Button();
            try
            {

                btn.Text = name;
                btn.Height = 80;
                btn.Width = 150;
                btn.Click += new EventHandler(click);
                return btn;
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "CreateButton", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return btn;
            }
        }
    }
}