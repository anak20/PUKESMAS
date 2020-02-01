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
    public partial class DetailAdmin : Form
    {
        koneksi konn = new koneksi();
        public DetailAdmin()
        {
            InitializeComponent();
        }
        private void loadDetail()
        {
            string queryPasien = "SELECT * from admin where no_pegawai=(select * from login)";
            SqlDataReader readerPasien = null;
            System.Data.SqlClient.SqlConnection con = konn.GetConn();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(queryPasien, con);
                command.ExecuteNonQuery();

                readerPasien = command.ExecuteReader();
                if (readerPasien.HasRows)
                {
                    while (readerPasien.Read())
                    {
                        id.Text = readerPasien["no_pegawai"].ToString();
                        nama.Text = readerPasien["nama_pegawai"].ToString();
                        alamat.Text = readerPasien["alamat_pegawai"].ToString();
                        hp.Text = readerPasien["nohp_pegawai"].ToString();
                        user.Text = readerPasien["username"].ToString();
                        pass.Text = readerPasien["password"].ToString();
                    }
                    readerPasien.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            nama.Enabled = true;
            alamat.Enabled = true;
            hp.Enabled = true;
            user.Enabled = true;
            pass.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string queryUpdate = "update admin set username ='"+user.Text+"',password='"+pass.Text+"'," +
                "nama_pegawai='"+nama.Text+"', alamat_pegawai='"+alamat.Text+"', nohp_pegawai='"+hp.Text+"' " +
                "where no_pegawai='"+id.Text+"'";
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryUpdate, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Admin " + nama.Text + " Berhasil di update");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            nama.Enabled = false;
            alamat.Enabled = false;
            hp.Enabled = false;
            user.Enabled = false;
            pass.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            home formHome = new home();
            formHome.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void DetailAdmin_Load(object sender, EventArgs e)
        {
            loadDetail();
        }
    }
}
