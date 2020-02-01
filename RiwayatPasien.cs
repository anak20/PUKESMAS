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
    public partial class RiwayatPasien : Form
    {
        koneksi konn = new koneksi();
        public RiwayatPasien()
        {
            InitializeComponent();
        }

        private void Pasien()
        {
            listView2.Items.Clear();
            string query = "SELECT rb.trx, p.nama_pasien, rb.keluhan, rb.tanggal_berobat, rb.resep_obat, rb.harga_berobat FROM riwayat_berobat rb " +
                "JOIN pasien p ON p.regid = rb.id_pasien ";
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
                        ListViewItem(reader["trx"].ToString());
                        listViewItem.SubItems.Add(reader["nama_pasien"].ToString());
                        listViewItem.SubItems.Add(reader["keluhan"].ToString());
                        listViewItem.SubItems.Add(reader["tanggal_berobat"].ToString());
                        listViewItem.SubItems.Add(reader["resep_obat"].ToString());
                        listViewItem.SubItems.Add(reader["harga_berobat"].ToString());
                        listView2.Items.Add(listViewItem);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            string query = "SELECT rb.trx, p.nama_pasien, rb.keluhan, rb.tanggal_berobat, rb.resep_obat, rb.harga_berobat FROM riwayat_berobat rb " +
                "JOIN pasien p ON p.regid = rb.id_pasien where p.nama_pasien LIKE '%"+ textBox1.Text+"%'";
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
                        ListViewItem(reader["trx"].ToString());
                        listViewItem.SubItems.Add(reader["nama_pasien"].ToString());
                        listViewItem.SubItems.Add(reader["keluhan"].ToString());
                        listViewItem.SubItems.Add(reader["tanggal_berobat"].ToString());
                        listViewItem.SubItems.Add(reader["resep_obat"].ToString());
                        listViewItem.SubItems.Add(reader["harga_berobat"].ToString());
                        listView2.Items.Add(listViewItem);
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

        private void RiwayatPasien_Load(object sender, EventArgs e)
        {
            Pasien();
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

        private void button3_Click(object sender, EventArgs e)
        {
            home formHome = new home();
            formHome.Show();
            this.Hide();
        }
    }
}
