using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форма_регистрации_и_БД
{
    public partial class FormRecords : Form
    {
        public FormRecords()
        {
            InitializeComponent();
        }
        public void BDget(string date, DataGridViewCell time, DataGridViewCell client)
        {
            DB db = new DB();

            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT client FROM client WHERE time = @time AND date = @date", db.GetConnection());
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@time", time.Value);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows) // если есть данные
            {
                while (reader.Read())   // построчно считываем данные
                {
                    string name = reader.GetString(0);
                    client.Value = name;
                }
            }

            db.CloseConnection();
        }
        public void DoTable()
        {
            for (int i = 0; i < 24; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell time = new DataGridViewTextBoxCell();

                time.Value = i.ToString() + ":00";
                row.Cells.Add(time);

                DataGridViewCell client = new DataGridViewTextBoxCell();

                BDget(Params.DaySchedule, time, client);
                row.Cells.Add(client);
                RecordPanel.Rows.Add(row);
            }
           
        }

        private void FormRecords_Load(object sender, EventArgs e)
        {
            DoTable();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
