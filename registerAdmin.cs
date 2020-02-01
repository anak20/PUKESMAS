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
    public partial class registerAdmin : Form
    {
        koneksi konn = new koneksi();
        public registerAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                string queryDaftar = "INSERT INTO admin (nama_pegawai, username, password, alamat_pegawai, nohp_pegawai) VALUES" +
                    "('"+nama_textbox.Text+"','"+username_textbox.Text+"','"+password_textbox.Text+"','"+alamat_textbox.Text+"','"+noHp_textbox.Text+"')";
                SqlCommand cmd = new SqlCommand(queryDaftar, conn);
                string name = nama_textbox.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Admin " + name + " Berhasil Terdaftar");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nama_textbox.Clear();
            alamat_textbox.Clear();
            username_textbox.Clear();
            password_textbox.Clear();
            noHp_textbox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
