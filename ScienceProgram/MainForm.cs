using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceProgram
{
    public partial class MainForm : Form
    {
        public static SQLiteConnection DB = new SQLiteConnection(DataBase.connectionString);
        public MainForm()
        {
            InitializeComponent();
            DB.Open();
            OpenListScientist();
        }

        public async void OpenListScientist()
        {
            SQLiteCommand copy = new SQLiteCommand(@"SELECT * FROM Scientist", DB);
            copy.ExecuteNonQuery();
            SQLiteDataReader reader = copy.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            listDataGridView.DataSource = table;
        }

        private void listScientistBtn_Click(object sender, EventArgs e)
        {
            OpenListScientist();
        }

        private void listConferenceBtn_Click(object sender, EventArgs e)
        {
            SQLiteCommand copy = new SQLiteCommand(@"SELECT * FROM Conference", DB);
            copy.ExecuteNonQuery();
            SQLiteDataReader reader = copy.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            listDataGridView.DataSource = table;
        }

        private void listParticipationBtn_Click(object sender, EventArgs e)
        {
            SQLiteCommand copy = new SQLiteCommand(@"SELECT * FROM Participation", DB);
            copy.ExecuteNonQuery();
            SQLiteDataReader reader = copy.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            listDataGridView.DataSource = table;
        }
    }
}
