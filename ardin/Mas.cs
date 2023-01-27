using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ardin
{
    
    public partial class Mas : Form
    {
        string nomas;
        string dr;
        string rd;
        public Mas()
        {
            InitializeComponent();
        }

        private void Mas_Activated(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection(Data.Glob_connection_string); connection1.Open();

            string SQL = "Select nmas, fio, dolj from Mas";

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, connection1);
            DataTable tb = new DataTable();
            adapter.Fill(tb);

            dataGridView1.Refresh();
            dataGridView1.DataSource = tb;
            dataGridView1.Columns[0].HeaderText = "№ мастера";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].HeaderText = "Должность";
            dataGridView1.Columns[2].Width = 100;
            connection1.Close();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
                textBox1.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox2.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                nomas = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                button3.Enabled = false;
                button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();

            string SQL_izm = "UPDATE Mas set fio=N'" + textBox1.Text + "', dolj=N'" + textBox2.Text + "' WHERE nmas=" + nomas;
            SqlCommand command1 = new SqlCommand(SQL_izm, connection1);
            SqlDataReader dr = command1.ExecuteReader();
            connection1.Close();
            MessageBox.Show("Данные изменены");
            this.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            button3.Enabled = true;
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SQL_dob = "SELECT max(nmas) as max FROM Mas";

            SqlConnection connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();

            SqlCommand command1 = new SqlCommand(SQL_dob, connection1);
            SqlDataReader dr = command1.ExecuteReader();
            
          //  SQL_dob = "INSERT INTO Mas(nmas,fio,dolj) values (" + max + ", N'" + textBox1.Text +"', N'" + textBox2.Text + "')";

            connection1 = new SqlConnection(Data.Glob_connection_string);
            connection1.Open();

            command1 = new SqlCommand(SQL_dob, connection1);
            dr = command1.ExecuteReader();
            dr.Close();
            connection1.Close();
            MessageBox.Show("Данные сохранены");
            this.Activate();
        }

        
    }
}
