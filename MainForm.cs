using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial1KayPro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent(); 
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "LiteratureForm")
                {
                    f.Close();
                    break;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            MenuForm objMenuWindow = new MenuForm();
            this.Visible = false;
            objMenuWindow.Show();
        }

        private void literaturebtn_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "LiteratureForm")
                {
                    f.Close();
                    break;
                }
            }

            if (open == false)
            {
                LiteratureForm objLiteratureWindow = new LiteratureForm();
                this.Visible = true;
                objLiteratureWindow.Show();
            }
        }

        //private void literaturebtn_Click(object sender, EventArgs e)
        //{

        //}

        private void refreshtimer_Tick(object sender, EventArgs e)
        {
            loadData();
        }

        
        public void loadData()
        {
            var database = new Database();
            if (database.connect_db())
            {
                // Ambil data dari tabel sensordata dan urutkan dari terbaru ke terlama
                string querySensorData = "SELECT timestamp, volt, watt, amp FROM sensordata ORDER BY timestamp DESC";
                MySqlCommand mySqlCommandSensorData = new MySqlCommand(querySensorData, database.mySqlConnection);
                MySqlDataAdapter adapterSensorData = new MySqlDataAdapter(mySqlCommandSensorData);
                DataTable dtSensorData = new DataTable();
                adapterSensorData.Fill(dtSensorData);

                // Ambil data dari tabel targetpower
                string queryTargetPower = "SELECT timestamp, targetpower FROM powerlog ORDER BY timestamp DESC";
                MySqlCommand mySqlCommandTargetPower = new MySqlCommand(queryTargetPower, database.mySqlConnection);
                MySqlDataAdapter adapterTargetPower = new MySqlDataAdapter(mySqlCommandTargetPower);
                DataTable dtTargetPower = new DataTable();
                adapterTargetPower.Fill(dtTargetPower);

                // Tambahkan kolom "HIGHLIGHTED POWER" ke DataTable sensordata
                dtSensorData.Columns.Add("HIGHLIGHTED POWER", typeof(int));

                // Isi kolom "HIGHLIGHTED POWER" dengan data dari targetpower
                for (int i = 0; i < dtSensorData.Rows.Count; i++)
                {
                    if (i < dtTargetPower.Rows.Count)
                    {
                        dtSensorData.Rows[i]["HIGHLIGHTED POWER"] = dtTargetPower.Rows[i]["targetpower"];
                    }
                    else
                    {
                        dtSensorData.Rows[i]["HIGHLIGHTED POWER"] = 0;
                    }
                }

                // Mapping kolom ke DataGridView
                dtSensorData.Columns["timestamp"].ColumnName = "TIMESTAMP";
                dtSensorData.Columns["volt"].ColumnName = "VOLTAGE";
                dtSensorData.Columns["watt"].ColumnName = "WATT";
                dtSensorData.Columns["amp"].ColumnName = "AMPERE";

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dtSensorData;

                dataGridView1.DataSource = bindingSource;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                database.close_db();
            }
            else
            {
                MessageBox.Show("Database Connection Fail");
            }
        }

        public void EnableTimer(bool data)
        {
            if (data)
            {
                refreshtimer.Start(); // Aktifkan Timer1
            }
            else
            {
                refreshtimer.Stop(); // Nonaktifkan Timer1
            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            string newValue = pwrbox.Text;
            if (string.IsNullOrEmpty(newValue))
            {
                MessageBox.Show("Invalid Number!");
                return;
            }
            string query = "UPDATE targetpower SET targetpower = @newValue;";

            var database = new Database();
            if (database.connect_db())
            {
                try
                {
                    int rowsAffected = database.ExecuteNonQuery(query, new Dictionary<string, object>
                {
                    { "@newValue", newValue }
                });
                    if (rowsAffected > 0)
                    {
                        //MessageBox.Show("Data berhasil diupdate!");
                    }
                    else
                    {
                        MessageBox.Show("Tidak ada data yang diupdate.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
