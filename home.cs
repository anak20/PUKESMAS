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

namespace puskesmas
{
    public partial class home : Form
    {
        koneksi konn = new koneksi();
        DaftarBaru formDaftarBaru = new DaftarBaru();
        pasien formPasien = new pasien();
        dokter formDokter = new dokter();
        public string idAdmin;
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formDaftarBaru.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formDokter.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formPasien.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                string queryDelete = "delete from login";
                SqlCommand cmd = new SqlCommand(queryDelete, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Terimakasih");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RiwayatPasien formRiwayat = new RiwayatPasien();
            formRiwayat.Show();
            this.Hide();
        }
        private void insertLogin()
        {
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {conn.Open();
                string queryInsert = "INSERT INTO login VALUES(@id)";
                SqlCommand cmd = new SqlCommand(queryInsert, conn);
                cmd.Parameters.AddWithValue("@id", idAdmin);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tambahPoli formPoli = new tambahPoli();
            formPoli.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DetailAdmin formAdmin = new DetailAdmin();
            formAdmin.Show();
            this.Hide();
        }
    }
}
