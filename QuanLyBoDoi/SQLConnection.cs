using SQLite;
//using System.Data.SQLite;

namespace QuanLyBoDoi
{
    public static class SQLConnection
    {
        public static SQLiteConnection CreateConnection()
        {
            
            try
            {
                string curentFolder = Path.GetDirectoryName(Application.ExecutablePath);
                List<string> dbFiles = Directory.GetFiles(curentFolder, "*.db").ToList();
                List<string> dbFileNames = new List<string>();
                foreach (string dbFile in dbFiles)
                {
                    dbFileNames.Add(Path.GetFileName(dbFile));
                }
            
                string fileName = "database.db";
                int c = 1;
                while(dbFiles.Contains(fileName))
                {
                    fileName = "database_" + c + ".db";

                }

                SQLiteConnection sqlite_conn;
                // Create a new database connection:
                sqlite_conn = new SQLiteConnection($"database.db");
                // Open the connection:
         
                //sqlite_conn.
                return sqlite_conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tạo dữ liệu mới");
                return null;
            }
           
        }

        public static SQLiteConnection CreateConnection(string dbname)
        {
            
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection($"database.db");
            // Open the connection:
            try
            {
                CreateTable(sqlite_conn);
            }
            catch (Exception ex)
            {
                //do no thing
            }
            //sqlite_conn.Open();
            return sqlite_conn;
        }

        public static void CreateTable(SQLiteConnection conn)
        {
            conn.CreateTable<People>();
            conn.CreateTable<GiaDinh>();
            conn.CreateTable<XamCham>();
            conn.CreateTable<GDNuocNgoai>();
            conn.CreateTable<QueQuan>();
            conn.CreateTable<DiaChiLamViec>();
            conn.CreateTable<ChoO>();
            conn.CreateTable<DonVi>();
            conn.CreateTable<NY>();
            conn.CreateTable<VPPL>();
        }

        public static void InsertData(SQLiteConnection conn, People people)
        {

        }

        public static void ReadData(SQLiteConnection conn)
        {
            
        }
    }
}
