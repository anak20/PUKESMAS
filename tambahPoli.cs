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
    public partial class tambahPoli : Form
    {
        koneksi konn = new koneksi();
        public tambahPoli()
        {
            InitializeComponent();
        }
        private void reset()
        {
            id_textbox.Clear();
            nama_textbox.Clear();
        }
        private void tambah_button_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO poli values ('"+nama_textbox.Text+"')";

            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Poli "+nama_textbox.Text+" Berhasil terdaftar");
                reset();
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

        private void update_button_Click(object sender, EventArgs e)
        {
            string query = "update poli set nama_ruangan = '"+nama_textbox.Text+"' where room_id = '"+id_textbox.Text+"'";

            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Poli " + nama_textbox.Text + " Berhasil di Update");
                reset();
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
        private int count = 1;
        private void loadPoli()
        {
            listView1.Items.Clear();
            string query = "select * from poli";
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
                        ListViewItem((count++).ToString());
                        listViewItem.SubItems.Add(reader["room_id"].ToString());
                        listViewItem.SubItems.Add(reader["nama_ruangan"].ToString());
                        listView1.Items.Add(listViewItem);
                    }
                    reader.Close();
                    count = 1;
                }
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection row = listView1.SelectedIndices;
            if (row.Count == 1)
            {
                ListViewItem item = listView1.Items[row[0]];
                id_textbox.Text = item.SubItems[1].Text;
                nama_textbox.Text = item.SubItems[2].Text;
            }
        }

        private void tambahPoli_Load(object sender, EventArgs e)
        {
            loadPoli();
        }

        private void kembali_button_Click(object sender, EventArgs e)
        {
            home formHome = new home();
            formHome.Show();
            this.Hide();
        }

        private void keluar_button_Click(object sender, EventArgs e)
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

        private void tambahPoli_Activated(object sender, EventArgs e)
        {
            loadPoli();
        }
    }
}
