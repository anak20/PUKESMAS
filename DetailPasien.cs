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
using System.Data.SqlClient;

namespace puskesmas
{
    public partial class DetailPasien : Form
    {
        koneksi konn = new koneksi();
        public DetailPasien()
        {
            InitializeComponent();
        }
        public String id;
        private int nomor=1;
        private void loadDetail()
        {
            string queryPasien = "SELECT * from pasien where regid='"+id+"'";
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

                        textBox4.Text = readerPasien["regid"].ToString();
                        textBox3.Text = readerPasien["nama_pasien"].ToString();
                        textBox2.Text = readerPasien["alamat_pasien"].ToString();
                        textBox1.Text = readerPasien["jenis_kelamin"].ToString();
                        textBox5.Text = readerPasien["tempat_lahir"].ToString();
                        textBox6.Text = readerPasien["tanggal_lahir"].ToString();
                        textBox7.Text = readerPasien["nohp_pasien"].ToString();
                        textBox8.Text = readerPasien["pekerjaan"].ToString();
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
            String query = "SELECT * FROM riwayat_berobat rb " +
                "JOIN poli p ON p.room_id = rb.id_ruang " +
                "JOIN pasien pa ON pa.regid = rb.id_pasien " +
                "JOIN dokter d ON d.nip = rb.id_dokter " +
                "WHERE rb.id_pasien = '"+id+"'";
            SqlDataReader reader = null;
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem((nomor++).ToString());
                        listViewItem.SubItems.Add(reader["tanggal_berobat"].ToString());
                        listViewItem.SubItems.Add(reader["nama_ruangan"].ToString());
                        listViewItem.SubItems.Add(reader["nama_dokter"].ToString());
                        listViewItem.SubItems.Add(reader["keluhan"].ToString());
                        listView1.Items.Add(listViewItem);

                    }
                    reader.Close();
                }
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

        private void DetailPasien_Load(object sender, EventArgs e)
        {
            loadDetail();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pasien formPasien = new pasien();
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string queryUpdate = "update pasien set " +
                "nama_pasien = '" + textBox3.Text + "', alamat_pasien = '" + textBox2.Text + "', jenis_kelamin = '" + textBox1.Text + "', tanggal_lahir = '" + textBox6.Text + "', " +
                "tempat_lahir = '" + textBox5.Text + "', pekerjaan = '" + textBox8.Text + "', nohp_pasien = '" + textBox7.Text + "' " +
                "where regid = '"+textBox4.Text+"'";
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryUpdate, conn);
                cmd.ExecuteNonQuery();
                String name = textBox3.Text;
                MessageBox.Show("Pasien " + name + " Berhasil di update");
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
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
