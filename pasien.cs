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
    public partial class pasien : Form
    {
        koneksi konn = new koneksi();
        public pasien()
        {
            InitializeComponent();
        }
        private void loadPasien()
        {
            listView1.Items.Clear();
            string querySelect = "select * from pasien";
            SqlDataReader reader = null;
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(querySelect, conn);
                command.ExecuteNonQuery();

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem(reader["regid"].ToString());
                        listViewItem.SubItems.Add(reader["nama_pasien"].ToString());
                        listViewItem.SubItems.Add(reader["alamat_pasien"].ToString());
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
        private void loadDokter()
        {
            string queryDokter = "select nama_dokter from dokter where poli_id = " +
                "(SELECT room_id from poli where nama_ruangan = '" + poli_combobox.Text + "') AND status = 'Aktif'";
            
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
                    dokter_combobox.ResetText();
                    dokter_combobox.Items.Clear();
                    while (reader.Read())
                    {
                        dokter_combobox.Items.Add(reader["nama_dokter"].ToString());
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
        private void daftar()
        {
            ListView.SelectedIndexCollection row = listView1.SelectedIndices;
            if (row.Count == 1)
            {
                ListViewItem item = listView1.Items[row[0]];
                regid_textbox.Text = item.SubItems[0].Text;
                nama_textbox.Text = item.SubItems[1].Text;
            }
        }
        private void reset()
        {
            regid_textbox.Clear();
            nama_textbox.Clear();
            poli_combobox.ResetText();
            dokter_combobox.ResetText();
        }
        private void kembali()
        {
            home formHome = new home();
            formHome.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            kembali();
        }
        private void pasien_Load(object sender, EventArgs e)
        {
            loadPasien();
            loadPoli();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daftar();
            button1.Enabled = true;
        }

        private void poli_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDokter();
        }
        public String id;
        private void button2_Click(object sender, EventArgs e)
        {
            string queryTambah = "INSERT INTO riwayat_berobat (id_pasien, id_dokter, id_ruang, tanggal_berobat) VALUES" +
                "(@id, (SELECT nip FROM dokter WHERE nama_dokter='" + dokter_combobox.Text + "'), " +
                "(SELECT room_id FROM poli WHERE nama_ruangan='" + poli_combobox.Text + "'), @tanggal)" +
                "\n" +
                "insert into memeriksa values ('"+regid_textbox.Text+ "', " +
                "(SELECT nip FROM dokter WHERE nama_dokter='" + dokter_combobox.Text + "'))" +
                "\n" +
                "insert into berobat values ('" + regid_textbox.Text + "'," +
                "(select room_id FROM poli where nama_ruangan='"+poli_combobox.Text+"'))" +
                "\n" +
                "insert into memiliki values('"+ regid_textbox.Text+"'," +
                "(select trx from riwayat_berobat where id_pasien = '"+regid_textbox.Text+"'))";
            
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryTambah, conn);
                cmd.Parameters.AddWithValue("@id", regid_textbox.Text);
                cmd.Parameters.AddWithValue("@tanggal", tanggal_berobat_datetimepicker.Value);
                
                String name = nama_textbox.Text;
                DetailPasien formDetail = new DetailPasien();
                id = regid_textbox.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pasien " + nama_textbox.Text + " \n" +
                                "" + poli_combobox.Text + " \n" +
                                "Silahkan Menunggu . . .");
                reset();
                
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

        private void dokter_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailPasien formDetail = new DetailPasien();
            formDetail.id = regid_textbox.Text;
            formDetail.Show();
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string querySelect = "select * from pasien where nama_pasien LIKE'%"+textBox4.Text+"%'";
            SqlDataReader reader = null;
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(querySelect, conn);
                command.ExecuteNonQuery();

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem(reader["regid"].ToString());
                        listViewItem.SubItems.Add(reader["nama_pasien"].ToString());
                        listViewItem.SubItems.Add(reader["alamat_pasien"].ToString());
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
    }
}
