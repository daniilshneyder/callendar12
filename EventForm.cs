using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace callendar12
{
    public partial class EventForm : Form
    {

        String connString = "server=localhost;user id=root;dabase=db_calendar;sslmode=none";


        public EventForm()
        {
            InitializeComponent();
        }


        private void EventForm_Load(object sender, EventArgs e)
        {
            txtDate.Text = UserControlDays.static_day + "/" + Form1.static_month + "/" + Form1.static_year;
        }

        private void butnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO tbl_calendar(date,event)values(?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", txtDate.Text);
            cmd.Parameters.AddWithValue("event", txtEvent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Сохранено.");
            cmd.Dispose();
            conn.Close();
        }
    }
}
