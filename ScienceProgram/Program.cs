using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceProgram
{
    internal static class Program
    {
        public static SQLiteConnection DB = new SQLiteConnection(DataBase.connectionString);
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogForm());
        }
    }
    class DataBase
    {
        public static string connectionString = @"Data source = database.db";
    }
}
