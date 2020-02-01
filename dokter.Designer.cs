namespace puskesmas
{
    partial class dokter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.listView1 = new System.Windows.Forms.ListView();
            this.NIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Alamat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.No_hp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Poli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nip_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nama_textbox = new System.Windows.Forms.TextBox();
            this.alamat_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.no_hp_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.poli_combobox = new System.Windows.Forms.ComboBox();
            this.tambah_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.kembali_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.status_combobox = new System.Windows.Forms.ComboBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NIP,
            this.Nama,
            this.Alamat,
            this.No_hp,
            this.Poli,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup3";
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup4";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(373, 273);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // NIP
            // 
            this.NIP.Text = "NIP";
            // 
            // Nama
            // 
            this.Nama.Text = "NAMA";
            this.Nama.Width = 65;
            // 
            // Alamat
            // 
            this.Alamat.Text = "ALAMAT";
            this.Alamat.Width = 65;
            // 
            // No_hp
            // 
            this.No_hp.Text = "NO HP";
            // 
            // Poli
            // 
            this.Poli.Text = "POLI";
            this.Poli.Width = 65;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Password";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // nip_textbox
            // 
            this.nip_textbox.Location = new System.Drawing.Point(505, 71);
            this.nip_textbox.Name = "nip_textbox";
            this.nip_textbox.Size = new System.Drawing.Size(125, 20);
            this.nip_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "NIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama";
            // 
            // nama_textbox
            // 
            this.nama_textbox.Location = new System.Drawing.Point(505, 97);
            this.nama_textbox.Name = "nama_textbox";
            this.nama_textbox.Size = new System.Drawing.Size(125, 20);
            this.nama_textbox.TabIndex = 4;
            // 
            // alamat_textbox
            // 
            this.alamat_textbox.Location = new System.Drawing.Point(505, 123);
            this.alamat_textbox.Name = "alamat_textbox";
            this.alamat_textbox.Size = new System.Drawing.Size(125, 20);
            this.alamat_textbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alamat";
            // 
            // no_hp_textbox
            // 
            this.no_hp_textbox.Location = new System.Drawing.Point(505, 149);
            this.no_hp_textbox.Name = "no_hp_textbox";
            this.no_hp_textbox.Size = new System.Drawing.Size(125, 20);
            this.no_hp_textbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "No HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Poli";
            // 
            // poli_combobox
            // 
            this.poli_combobox.FormattingEnabled = true;
            this.poli_combobox.Location = new System.Drawing.Point(505, 201);
            this.poli_combobox.Name = "poli_combobox";
            this.poli_combobox.Size = new System.Drawing.Size(125, 21);
            this.poli_combobox.TabIndex = 14;
            this.poli_combobox.Text = "Pilih Poli";
            // 
            // tambah_button
            // 
            this.tambah_button.BackColor = System.Drawing.Color.DarkCyan;
            this.tambah_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tambah_button.Location = new System.Drawing.Point(475, 263);
            this.tambah_button.Name = "tambah_button";
            this.tambah_button.Size = new System.Drawing.Size(75, 23);
            this.tambah_button.TabIndex = 15;
            this.tambah_button.Text = "Tambah";
            this.tambah_button.UseVisualStyleBackColor = false;
            this.tambah_button.Click += new System.EventHandler(this.tambah_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.DarkCyan;
            this.update_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_button.Location = new System.Drawing.Point(555, 263);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 16;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dokter";
            // 
            // kembali_button
            // 
            this.kembali_button.BackColor = System.Drawing.Color.DarkCyan;
            this.kembali_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kembali_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kembali_button.Location = new System.Drawing.Point(555, 374);
            this.kembali_button.Name = "kembali_button";
            this.kembali_button.Size = new System.Drawing.Size(75, 23);
            this.kembali_button.TabIndex = 20;
            this.kembali_button.Text = "Kembali";
            this.kembali_button.UseVisualStyleBackColor = false;
            this.kembali_button.Click += new System.EventHandler(this.kembali_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(408, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Status";
            // 
            // status_combobox
            // 
            this.status_combobox.FormattingEnabled = true;
            this.status_combobox.Items.AddRange(new object[] {
            "Aktif",
            "Tidak Aktif",
            "Resign",
            "Cuti"});
            this.status_combobox.Location = new System.Drawing.Point(505, 228);
            this.status_combobox.Name = "status_combobox";
            this.status_combobox.Size = new System.Drawing.Size(125, 21);
            this.status_combobox.TabIndex = 22;
            this.status_combobox.Text = "Status";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(505, 175);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(125, 20);
            this.password.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(408, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::puskesmas.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(597, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::puskesmas.Properties.Resources.dsasa;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(23, 374);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 21);
            this.button4.TabIndex = 25;
            this.button4.Text = "KELUAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // dokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(652, 419);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.status_combobox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kembali_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.tambah_button);
            this.Controls.Add(this.poli_combobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.no_hp_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alamat_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nama_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nip_textbox);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "dokter";
            this.Text = "dokter";
            this.Load += new System.EventHandler(this.dokter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NIP;
        private System.Windows.Forms.ColumnHeader Nama;
        private System.Windows.Forms.ColumnHeader Alamat;
        private System.Windows.Forms.ColumnHeader No_hp;
        private System.Windows.Forms.ColumnHeader Poli;
        private System.Windows.Forms.TextBox nip_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nama_textbox;
        private System.Windows.Forms.TextBox alamat_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox no_hp_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox poli_combobox;
        private System.Windows.Forms.Button tambah_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button kembali_button;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox status_combobox;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}