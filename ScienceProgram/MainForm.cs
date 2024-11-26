using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        public void OpenListScientist()
        {
            listDataGridView.DataSource = null;
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
            listDataGridView.DataSource = null;
            SQLiteCommand copy1 = new SQLiteCommand(@"SELECT * FROM Conference", DB);
            copy1.ExecuteNonQuery();
            SQLiteDataReader reader1 = copy1.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(reader1);
            listDataGridView.DataSource = table1;
        }

        private void listParticipationBtn_Click(object sender, EventArgs e)
        {
            listDataGridView.DataSource = null;
            SQLiteCommand copy2 = new SQLiteCommand(@"SELECT * FROM Participation", DB);
            copy2.ExecuteNonQuery();
            SQLiteDataReader reader2 = copy2.ExecuteReader();
            DataTable table2 = new DataTable();
            table2.Load(reader2);
            listDataGridView.DataSource = table2;
        }

        public void OpenLogForm()
        {
            Application.Run(new LogForm());
        }

        private void zapros1Btn_Click(object sender, EventArgs e)
        {
            listDataGridView.DataSource = null;
            SQLiteCommand search = new SQLiteCommand($@"
            SELECT Scientist.name, COUNT(Participation.ID_Participation) AS count_publications
            FROM Scientist
            JOIN Participation ON Scientist.ID_Scientist = Participation.ID_Scientist
            JOIN Conference ON Participation.ID_Conference = Conference.ID_Conference
            WHERE Conference.Date1 LIKE '%1999' AND Participation.Publication LIKE 'Да'
            GROUP BY Scientist.ID_Scientist", DB);
            search.ExecuteNonQuery();
            SQLiteDataReader reader = search.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            listDataGridView.DataSource = table;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DB.Close();
            Application.Exit();
            var thread = new Thread(OpenLogForm);
            thread.Start();
        }

        private void zapros2Btn_Click(object sender, EventArgs e)
        {
            listDataGridView.DataSource = null;
            SQLiteCommand search = new SQLiteCommand($@"
            SELECT DISTINCT Name
            FROM Conference
            JOIN Participation ON Participation.ID_Conference = Conference.ID_Conference
            WHERE Participation.Publication LIKE 'Нет'
            ORDER BY Conference.ID_Conference;", DB);
            search.ExecuteNonQuery();
            SQLiteDataReader reader = search.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            listDataGridView.DataSource = table;
        }

        private void zapros3Btn_Click(object sender, EventArgs e)
        {
            listDataGridView.DataSource = null;
            SQLiteCommand search = new SQLiteCommand($@"
            SELECT Conference.Name, COUNT(Participation.ID_Participation) AS count_doctors
            FROM Conference
            JOIN Participation ON Conference.ID_Conference = Participation.ID_Conference
            JOIN Scientist ON Participation.ID_Scientist = Scientist.ID_Scientist
            WHERE Scientist.Academic_Degree LIKE 'Доктор наук'
            GROUP BY Conference.ID_Conference
            ORDER BY count_doctors DESC
            LIMIT 1;", DB);
            search.ExecuteNonQuery();
            SQLiteDataReader reader = search.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            listDataGridView.DataSource = table;
        }

        private void zapros4Btn_Click(object sender, EventArgs e)
        {
            listDataGridView.DataSource = null;
            SQLiteCommand search = new SQLiteCommand($@"
            SELECT Conference.Name, COUNT(DISTINCT Scientist.Country) AS count_countries
            FROM Conference
            JOIN Participation ON Conference.ID_Conference = Participation.ID_Conference
            JOIN Scientist ON Participation.ID_Scientist = Scientist.ID_Scientist
            GROUP BY Conference.ID_Conference;", DB);
            search.ExecuteNonQuery();
            SQLiteDataReader reader = search.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            listDataGridView.DataSource = table;
        }
    }
}
