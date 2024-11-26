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
    public partial class LogForm : Form
    {
        public static SQLiteConnection DB = new SQLiteConnection(DataBase.connectionString);
        public LogForm()
        {
            InitializeComponent();
            DB.Open();
        }

        private void transitionBtn_Click(object sender, EventArgs e)
        {
            loginLbl.Text = "Регистрация";
            loginLbl.Location = new Point(119, 9);
            logLbl.Text = "Придумайте логин";
            passLbl.Text = "Придумайте пароль";
            transitionBtn.Visible = false;
            logBtn.Visible = false;
            logTxt.Visible = false;
            passTxt.Visible = false;
            transitionLogBtn.Visible = true;
            regBtn.Visible = true;
            thinkLogTxt.Visible = true;
            thinkPassTxt.Visible = true;
        }

        private void transitionLogBtn_Click(object sender, EventArgs e)
        {
            loginLbl.Text = "Вход";
            loginLbl.Location = new Point(219, 9);
            logLbl.Text = "Логин";
            passLbl.Text = "Пароль";
            transitionBtn.Visible = true;
            logBtn.Visible = true;
            logTxt.Visible = true;
            passTxt.Visible = true;
            transitionLogBtn.Visible = false;
            regBtn.Visible = false;
            thinkLogTxt.Visible = false;
            thinkPassTxt.Visible = false;
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            SQLiteCommand log = new SQLiteCommand(@"SELECT Login, Password FROM User WHERE Login = @Login AND Password = @Password", DB);
            log.Parameters.AddWithValue("@Login", logTxt.Text);
            log.Parameters.AddWithValue("@Password", passTxt.Text);
            SQLiteDataReader reader = log.ExecuteReader();
            bool logEnter = reader.HasRows;
            if (logEnter)
            {
                DB.Close();
                Application.Exit();
                var thread = new Thread(OpenMainForm);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
        
        private void regBtn_Click(object sender, EventArgs e)
        {
            if (thinkLogTxt.Text != "" && thinkPassTxt.Text != "")
            {
                SQLiteCommand adduser = new SQLiteCommand(@"
                INSERT INTO User (Login, Password)
                VALUES (@Login, @Password)", DB);
                adduser.Parameters.AddWithValue("@Login", thinkLogTxt.Text);
                adduser.Parameters.AddWithValue("@Password", thinkPassTxt.Text);
                adduser.ExecuteNonQuery();
                DB.Close();
                Application.Exit();
                var thread = new Thread(OpenMainForm);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Вы оставили кое-какие поля пустыми");
            }
        }
        public void OpenMainForm()
        {
            Application.Run(new MainForm());
        }
    }
}
