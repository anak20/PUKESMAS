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
    public partial class TampilanDokter : Form
    {
        koneksi konn = new koneksi();
        public string idDokter;
        public TampilanDokter()
        {
            InitializeComponent();
        }
        public string transaksi, idPasien, namaPasien, keluhanPasien, ResepPasien, hargaPasien;
        public void loadPasien()
        {
            listView1.Items.Clear();
            string query = "SELECT rb.trx, p.nama_pasien, rb.keluhan, rb.tanggal_berobat, rb.resep_obat, rb.harga_berobat FROM riwayat_berobat rb " +
                "JOIN pasien p ON p.regid = rb.id_pasien WHERE rb.id_dokter = '"+idDokter+"' AND rb.status='Antri'";
            SqlDataReader reader = null;
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            int count = 0;
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
                        ListViewItem((++count).ToString()) ;
                        listViewItem.SubItems.Add(reader["trx"].ToString());
                        listViewItem.SubItems.Add(reader["nama_pasien"].ToString());
                        listViewItem.SubItems.Add(reader["keluhan"].ToString());
                        listViewItem.SubItems.Add(reader["tanggal_berobat"].ToString());
                        listViewItem.SubItems.Add(reader["resep_obat"].ToString());
                        listViewItem.SubItems.Add(reader["harga_berobat"].ToString());
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

        public void historyPasien()
        {
            listView2.Items.Clear();
            string query = "SELECT rb.trx, p.nama_pasien, rb.keluhan, rb.tanggal_berobat, rb.resep_obat, rb.harga_berobat FROM riwayat_berobat rb " +
                "JOIN pasien p ON p.regid = rb.id_pasien WHERE rb.id_dokter = '" + idDokter + "' AND rb.status='Selesai'";
            SqlDataReader reader = null;
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                int count = 0;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem((++count).ToString());
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

        private void TampilanDokter_Shown(object sender, EventArgs e)
        {
            loadPasien();
            historyPasien();
        }

        private void TampilanDokter_Activated(object sender, EventArgs e)
        {
            loadPasien();
            historyPasien();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void TampilanDokter_Load(object sender, EventArgs e)
        {
            loadPasien();
            historyPasien();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateData formUpdate = new updateData();
            ListView.SelectedIndexCollection row = listView1.SelectedIndices;
            if (row.Count == 1)
            {
                ListViewItem item = listView1.Items[row[0]];
                transaksi = item.SubItems[1].Text;
                namaPasien = item.SubItems[2].Text;
                keluhanPasien = item.SubItems[3].Text;
                ResepPasien = item.SubItems[5].Text;
                hargaPasien = item.SubItems[6].Text;
            }
        }

        private void tambah_button_Click(object sender, EventArgs e)
        {
            string query = "UPDATE riwayat_berobat SET status='Selesai' WHERE trx='" + transaksi + "'";
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Berobat telah diselesaikan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            loadPasien();
            historyPasien();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            updateData formUpdate = new updateData();
            formUpdate.Show();
            formUpdate.trx_textbox.Text = transaksi;
            formUpdate.nama_textbox.Text = namaPasien;
            formUpdate.keluhan_textbox.Text = keluhanPasien;
            formUpdate.resep_textbox.Text = ResepPasien;
            formUpdate.harga_textbox.Text = hargaPasien;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            historyPasien();
            loadPasien();
        }
    }
}
