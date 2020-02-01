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
    public partial class dokter : Form
    {
        koneksi konn = new koneksi();
        public dokter()
        {
            InitializeComponent();
        }
        private void loadDokter()
        {
            listView1.Items.Clear();
            string queryDokter = "SELECT d.nip, d.nama_dokter, d.alamat_dokter, d.nohp_dokter, p.nama_ruangan, d.status, d.password_d " +
                "from dokter d, poli p where d.poli_id = p.room_id";
            SqlDataReader reader = null;
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(queryDokter, conn);
                command.ExecuteNonQuery();

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem(reader["nip"].ToString());
                        listViewItem.SubItems.Add(reader["nama_dokter"].ToString());
                        listViewItem.SubItems.Add(reader["alamat_dokter"].ToString());
                        listViewItem.SubItems.Add(reader["nohp_dokter"].ToString());
                        listViewItem.SubItems.Add(reader["nama_ruangan"].ToString());
                        listViewItem.SubItems.Add(reader["status"].ToString());
                        listViewItem.SubItems.Add(reader["password_d"].ToString());
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
        private void loadPoli()
        {
            string queryPoli = "Select * from poli";
            SqlDataReader reader = null;
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(queryPoli, conn);
                command.ExecuteNonQuery();

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        poli_combobox.Items.Add(reader["nama_ruangan"].ToString());
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
        private void reset()
        {
            nip_textbox.Clear();
            nama_textbox.Clear();
            alamat_textbox.Clear();
            no_hp_textbox.Clear();
            poli_combobox.ResetText();
            status_combobox.ResetText();
            password.Clear();
        }
        private void kembali()
        {
            home formHome = new home();
            formHome.Show();
            this.Hide();
        }
        private void kembali_button_Click(object sender, EventArgs e)
        {
            kembali();
        }
        private void tambah_button_Click(object sender, EventArgs e)
        {
            string queryHitung = "SELECT count(id_pasien) FROM riwayat_berobat WHERE id_ruang =(SELECT room_id FROM poli WHERE nama_ruangan='"+poli_combobox.Text+"')";
            string query = "INSERT INTO dokter VALUES (@nip, @nama, @alamat, @nohp, @password_d," +
                "(SELECT room_id FROM poli WHERE nama_ruangan='"+poli_combobox.Text+"'), @status)";
            
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@nip", nip_textbox.Text);
                command.Parameters.AddWithValue("@nama", nama_textbox.Text);
                command.Parameters.AddWithValue("@alamat", alamat_textbox.Text);
                command.Parameters.AddWithValue("@nohp", no_hp_textbox.Text);
                command.Parameters.AddWithValue("@password_d", password.Text);
                command.Parameters.AddWithValue("@status", status_combobox.Text);
                command.ExecuteNonQuery();
                String name = nama_textbox.Text;
                reset();
                MessageBox.Show("Dokter " + name + " Berhasil Terdaftar");
                conn.Close();
                loadDokter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mohon data diperiksa lagi");
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void dokter_Load(object sender, EventArgs e)
        {
            loadPoli();
            loadDokter();
        }
        private void update_button_Click(object sender, EventArgs e)
        {
            string queryUpdate = "update dokter set nip = @nip, nama_dokter=@nama, alamat_dokter=@alamat, nohp_dokter=@nohp, " +
                "poli_id=(select room_id from poli where nama_ruangan='"+poli_combobox.Text+"'),password_d=@pwd, status=@status where nip=@nip";
            
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryUpdate, conn);
                cmd.Parameters.AddWithValue("@nip", nip_textbox.Text);
                cmd.Parameters.AddWithValue("@nama", nama_textbox.Text);
                cmd.Parameters.AddWithValue("@alamat", alamat_textbox.Text);
                cmd.Parameters.AddWithValue("@nohp", no_hp_textbox.Text);
                cmd.Parameters.AddWithValue("@pwd", password.Text);
                cmd.Parameters.AddWithValue("@status", status_combobox.Text);
                cmd.ExecuteNonQuery();
                String name = nama_textbox.Text;
                reset();
                MessageBox.Show("Dokter " + name + " Berhasil di update");
                conn.Close();
                loadDokter();

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection row = listView1.SelectedIndices;
            if (row.Count == 1)
            {
                ListViewItem item = listView1.Items[row[0]];
                nip_textbox.Text = item.SubItems[0].Text;
                nama_textbox.Text = item.SubItems[1].Text;
                alamat_textbox.Text = item.SubItems[2].Text;
                no_hp_textbox.Text = item.SubItems[3].Text;
                poli_combobox.Text = item.SubItems[4].Text;
                status_combobox.Text = item.SubItems[5].Text;
                password.Text = item.SubItems[6].Text;
            }
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
