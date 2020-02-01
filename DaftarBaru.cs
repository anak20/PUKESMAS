using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace puskesmas
{
    public partial class DaftarBaru : Form
    {
        
        koneksi konn = new koneksi();
        public DaftarBaru()
        {
            InitializeComponent();
        }
        private void kembali()
        {
            home formHome = new home();
            formHome.Show();
            this.Hide();
        }
        private void reset()
        {
            nama_textbox.Clear();
            alamat_textbox.Clear();
            tempat_lahir_textbox.Clear();
            pekerjaan_textbox.Clear();
            no_hp_textbox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kembali();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                string queryDaftar = "INSERT INTO pasien (nama_pasien, alamat_pasien, jenis_kelamin, tanggal_lahir, tempat_lahir, pekerjaan, nohp_pasien, id_pegawai)" +
                   "VALUES (@nama, @alamat, @jeniskelamin, @tanggalLahir, @tempatLahir, @pekerjaan, @noHp, (select * from login))";
                SqlCommand cmd = new SqlCommand(queryDaftar, conn);
                cmd.Parameters.AddWithValue("@nama", nama_textbox.Text);
                cmd.Parameters.AddWithValue("@alamat", alamat_textbox.Text);
                cmd.Parameters.AddWithValue("@jeniskelamin", jenis_kelamin_textbox.Text);
                cmd.Parameters.AddWithValue("@tanggalLahir", tanggal_lahir_datetimepicker.Value);
                cmd.Parameters.AddWithValue("@tempatLahir", tempat_lahir_textbox.Text);
                cmd.Parameters.AddWithValue("@pekerjaan", pekerjaan_textbox.Text);
                cmd.Parameters.AddWithValue("@noHp", no_hp_textbox.Text);
                string name = nama_textbox.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pasien " + name + " Berhasil Terdaftar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            kembali();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
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

    }
}
