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
    public partial class updateData : Form
    {
        koneksi konn = new koneksi();
        public updateData()
        {
            InitializeComponent();
        }
        private void kembali()
        {
            updateData formUpdate = new updateData();
            formUpdate.Close();
            this.Close();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            kembali();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE riwayat_berobat SET keluhan=@keluhan, resep_obat=@resep, harga_berobat=@harga WHERE trx='" + trx_textbox.Text + "'";
            System.Data.SqlClient.SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keluhan", keluhan_textbox.Text);
                cmd.Parameters.AddWithValue("@resep", resep_textbox.Text);
                cmd.Parameters.AddWithValue("@harga", harga_textbox.Text);
                cmd.ExecuteNonQuery();
                reset();
                MessageBox.Show("Data telah di update");
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
        public void reset()
        {
            keluhan_textbox.ResetText();
            resep_textbox.ResetText();
            harga_textbox.ResetText();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
