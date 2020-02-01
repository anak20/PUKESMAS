namespace puskesmas
{
    partial class tambahPoli
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
            System.Windows.Forms.ListViewGroup listViewGroup21 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup22 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup23 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup24 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.keluar_button = new System.Windows.Forms.Button();
            this.kembali_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.tambah_button = new System.Windows.Forms.Button();
            this.nama_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Poli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::puskesmas.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(594, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // keluar_button
            // 
            this.keluar_button.BackgroundImage = global::puskesmas.Properties.Resources.dsasa;
            this.keluar_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluar_button.Location = new System.Drawing.Point(27, 379);
            this.keluar_button.Margin = new System.Windows.Forms.Padding(2);
            this.keluar_button.Name = "keluar_button";
            this.keluar_button.Size = new System.Drawing.Size(65, 21);
            this.keluar_button.TabIndex = 44;
            this.keluar_button.Text = "KELUAR";
            this.keluar_button.UseVisualStyleBackColor = true;
            this.keluar_button.Click += new System.EventHandler(this.keluar_button_Click);
            // 
            // kembali_button
            // 
            this.kembali_button.BackColor = System.Drawing.Color.DarkCyan;
            this.kembali_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kembali_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kembali_button.Location = new System.Drawing.Point(559, 379);
            this.kembali_button.Name = "kembali_button";
            this.kembali_button.Size = new System.Drawing.Size(75, 23);
            this.kembali_button.TabIndex = 39;
            this.kembali_button.Text = "Kembali";
            this.kembali_button.UseVisualStyleBackColor = false;
            this.kembali_button.Click += new System.EventHandler(this.kembali_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.DarkCyan;
            this.update_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_button.Location = new System.Drawing.Point(559, 215);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 38;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // tambah_button
            // 
            this.tambah_button.BackColor = System.Drawing.Color.DarkCyan;
            this.tambah_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tambah_button.Location = new System.Drawing.Point(479, 215);
            this.tambah_button.Name = "tambah_button";
            this.tambah_button.Size = new System.Drawing.Size(75, 23);
            this.tambah_button.TabIndex = 37;
            this.tambah_button.Text = "Tambah";
            this.tambah_button.UseVisualStyleBackColor = false;
            this.tambah_button.Click += new System.EventHandler(this.tambah_button_Click);
            // 
            // nama_textbox
            // 
            this.nama_textbox.Location = new System.Drawing.Point(509, 154);
            this.nama_textbox.Name = "nama_textbox";
            this.nama_textbox.Size = new System.Drawing.Size(125, 20);
            this.nama_textbox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nama Poli";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(412, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "ID Poli";
            // 
            // id_textbox
            // 
            this.id_textbox.Enabled = false;
            this.id_textbox.Location = new System.Drawing.Point(509, 128);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(125, 20);
            this.id_textbox.TabIndex = 27;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            listViewGroup21.Header = "ListViewGroup";
            listViewGroup21.Name = "listViewGroup1";
            listViewGroup22.Header = "ListViewGroup";
            listViewGroup22.Name = "listViewGroup2";
            listViewGroup23.Header = "ListViewGroup";
            listViewGroup23.Name = "listViewGroup3";
            listViewGroup24.Header = "ListViewGroup";
            listViewGroup24.Name = "listViewGroup4";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup21,
            listViewGroup22,
            listViewGroup23,
            listViewGroup24});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(373, 273);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID Poli";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nama Poli";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            // 
            // tambahPoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(652, 419);
            this.Controls.Add(this.keluar_button);
            this.Controls.Add(this.kembali_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.tambah_button);
            this.Controls.Add(this.nama_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "tambahPoli";
            this.Text = "tambahPoli";
            this.Activated += new System.EventHandler(this.tambahPoli_Activated);
            this.Load += new System.EventHandler(this.tambahPoli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button keluar_button;
        private System.Windows.Forms.Button kembali_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button tambah_button;
        private System.Windows.Forms.TextBox nama_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}