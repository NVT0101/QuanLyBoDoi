using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDoi
{
    public static class Log
    {
        public static void LogError(Exception ex)
        {
            // Ghi log file hoặc console
            Console.WriteLine(ex.ToString());
        }

    }
}
