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
using MySql.Data.MySqlClient;

namespace puskesmas
{
    public partial class FormLogin : Form
    {
        public string username, usernameDokter;
        public string password, passwordDokter;
        public string nama, namaDokter;
        public string nipDokter;

        public home formHome = new home();

        private void Username_textbox_TextChanged(object sender, EventArgs e)
        {

        }
        string idAdmin;

        private void label7_Click(object sender, EventArgs e)
        {
            registerAdmin formRegisterAdmin = new registerAdmin();
            formRegisterAdmin.Show();
        }

        koneksi konn = new koneksi();
        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void login_Click(object sender, EventArgs e)
        {
            
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM admin WHERE username = '" + username_textbox.Text + "'AND password = '" + password_textbox.Text + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                SqlDataReader reader = null;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        username = reader["username"].ToString();
                        password = reader["password"].ToString();
                        nama = reader["nama_pegawai"].ToString();
                        idAdmin= reader["no_pegawai"].ToString();
                    }
                    reader.Close();
                }
                
                else
                {
                    string queryDokter = "SELECT * FROM dokter WHERE nip='" + username_textbox.Text + "' AND password_d='" + password_textbox.Text + "'";
                    SqlCommand commandDokter = new SqlCommand(queryDokter, conn);
                    reader.Close();
                    reader = commandDokter.ExecuteReader();
                    while (reader.Read())
                    {
                        nipDokter = usernameDokter = reader["nip"].ToString();
                        passwordDokter = reader["password_d"].ToString();
                        namaDokter = reader["nama_dokter"].ToString();
                    }
                    reader.Close();
                }

                if (username_textbox.Text.Equals(username) && password_textbox.Text.Equals(password))
                {
                    MessageBox.Show("Selamat Datang " + nama);
                    formHome.Show();
                    this.Hide();
                }
                else if (username_textbox.Text.Equals(usernameDokter) && password_textbox.Text.Equals(passwordDokter))
                {
                    MessageBox.Show("Selamat Datang " + namaDokter);
                    TampilanDokter formDokter = new TampilanDokter();
                    formDokter.idDokter = nipDokter;
                    formDokter.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password Salah");
                }
                System.Data.SqlClient.SqlConnection con = konn.GetConn();
                try
                {
                    con.Open();
                    string queryInsert = "INSERT INTO login VALUES(@id)";
                    SqlCommand cmd = new SqlCommand(queryInsert, con);
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
            catch (Exception ex)
            {
                MessageBox.Show("Silahkan periksa username dan Password anda");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
