
namespace zd_23
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.zd_2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.магазинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плейлистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zd_3 = new System.Windows.Forms.Panel();
            this.aut_current_song = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.current_name_song = new System.Windows.Forms.Label();
            this.text_trans = new System.Windows.Forms.TextBox();
            this.TransBut = new System.Windows.Forms.Button();
            this.LaunchBut = new System.Windows.Forms.Button();
            this.PlayListData = new System.Windows.Forms.DataGridView();
            this.name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aut_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddSongBut = new System.Windows.Forms.Button();
            this.text_fname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_aut = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.zd_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.zd_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayListData)).BeginInit();
            this.SuspendLayout();
            // 
            // zd_2
            // 
            this.zd_2.Controls.Add(this.label3);
            this.zd_2.Controls.Add(this.numericUpDown2);
            this.zd_2.Controls.Add(this.label2);
            this.zd_2.Controls.Add(this.textBox1);
            this.zd_2.Controls.Add(this.label1);
            this.zd_2.Controls.Add(this.numericUpDown1);
            this.zd_2.Controls.Add(this.button1);
            this.zd_2.Controls.Add(this.price);
            this.zd_2.Controls.Add(this.dataGridView1);
            this.zd_2.Location = new System.Drawing.Point(196, 12);
            this.zd_2.Name = "zd_2";
            this.zd_2.Size = new System.Drawing.Size(583, 426);
            this.zd_2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(13, 114);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(209, 20);
            this.numericUpDown2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Стоимость";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название товара";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 75);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(209, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addBut_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(370, 12);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(59, 13);
            this.price.TabIndex = 1;
            this.price.Text = "Прибыль: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price_col,
            this.count});
            this.dataGridView1.Location = new System.Drawing.Point(13, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellProd);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.SellProd);
            // 
            // name
            // 
            this.name.HeaderText = "имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price_col
            // 
            this.price_col.HeaderText = "цена";
            this.price_col.Name = "price_col";
            this.price_col.ReadOnly = true;
            // 
            // count
            // 
            this.count.HeaderText = "количество";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.магазинToolStripMenuItem,
            this.плейлистToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // магазинToolStripMenuItem
            // 
            this.магазинToolStripMenuItem.Name = "магазинToolStripMenuItem";
            this.магазинToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.магазинToolStripMenuItem.Text = "Магазин";
            this.магазинToolStripMenuItem.Click += new System.EventHandler(this.магазинToolStripMenuItem_Click);
            // 
            // плейлистToolStripMenuItem
            // 
            this.плейлистToolStripMenuItem.Name = "плейлистToolStripMenuItem";
            this.плейлистToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.плейлистToolStripMenuItem.Text = "Плейлист";
            this.плейлистToolStripMenuItem.Click += new System.EventHandler(this.плейлистToolStripMenuItem_Click);
            // 
            // zd_3
            // 
            this.zd_3.Controls.Add(this.aut_current_song);
            this.zd_3.Controls.Add(this.label5);
            this.zd_3.Controls.Add(this.current_name_song);
            this.zd_3.Controls.Add(this.text_trans);
            this.zd_3.Controls.Add(this.TransBut);
            this.zd_3.Controls.Add(this.LaunchBut);
            this.zd_3.Controls.Add(this.PlayListData);
            this.zd_3.Controls.Add(this.label8);
            this.zd_3.Controls.Add(this.label7);
            this.zd_3.Controls.Add(this.AddSongBut);
            this.zd_3.Controls.Add(this.text_fname);
            this.zd_3.Controls.Add(this.label6);
            this.zd_3.Controls.Add(this.text_aut);
            this.zd_3.Controls.Add(this.text_name);
            this.zd_3.Location = new System.Drawing.Point(155, 20);
            this.zd_3.Name = "zd_3";
            this.zd_3.Size = new System.Drawing.Size(608, 400);
            this.zd_3.TabIndex = 2;
            // 
            // aut_current_song
            // 
            this.aut_current_song.AutoSize = true;
            this.aut_current_song.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aut_current_song.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aut_current_song.Location = new System.Drawing.Point(272, 373);
            this.aut_current_song.Name = "aut_current_song";
            this.aut_current_song.Size = new System.Drawing.Size(11, 16);
            this.aut_current_song.TabIndex = 15;
            this.aut_current_song.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Сейчас играет:";
            // 
            // current_name_song
            // 
            this.current_name_song.AutoSize = true;
            this.current_name_song.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.current_name_song.Location = new System.Drawing.Point(269, 341);
            this.current_name_song.Name = "current_name_song";
            this.current_name_song.Size = new System.Drawing.Size(23, 32);
            this.current_name_song.TabIndex = 13;
            this.current_name_song.Text = " ";
            // 
            // text_trans
            // 
            this.text_trans.Location = new System.Drawing.Point(12, 298);
            this.text_trans.Name = "text_trans";
            this.text_trans.Size = new System.Drawing.Size(201, 20);
            this.text_trans.TabIndex = 12;
            // 
            // TransBut
            // 
            this.TransBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransBut.Location = new System.Drawing.Point(12, 314);
            this.TransBut.Name = "TransBut";
            this.TransBut.Size = new System.Drawing.Size(201, 24);
            this.TransBut.TabIndex = 11;
            this.TransBut.Text = "Перейти";
            this.TransBut.UseVisualStyleBackColor = true;
            this.TransBut.Click += new System.EventHandler(this.TransBut_Click);
            // 
            // LaunchBut
            // 
            this.LaunchBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LaunchBut.Location = new System.Drawing.Point(12, 238);
            this.LaunchBut.Name = "LaunchBut";
            this.LaunchBut.Size = new System.Drawing.Size(201, 54);
            this.LaunchBut.TabIndex = 10;
            this.LaunchBut.Text = "Запустить";
            this.LaunchBut.UseVisualStyleBackColor = true;
            this.LaunchBut.Click += new System.EventHandler(this.LaunchBut_Click);
            // 
            // PlayListData
            // 
            this.PlayListData.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PlayListData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayListData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_col,
            this.aut_col,
            this.fname_col});
            this.PlayListData.GridColor = System.Drawing.Color.DarkRed;
            this.PlayListData.Location = new System.Drawing.Point(230, 13);
            this.PlayListData.Name = "PlayListData";
            this.PlayListData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlayListData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.PlayListData.Size = new System.Drawing.Size(357, 325);
            this.PlayListData.TabIndex = 9;
            this.PlayListData.DoubleClick += new System.EventHandler(this.PlayListData_CellContentClick);
            // 
            // name_col
            // 
            this.name_col.HeaderText = "Наиминование";
            this.name_col.Name = "name_col";
            this.name_col.ReadOnly = true;
            // 
            // aut_col
            // 
            this.aut_col.HeaderText = "Автор";
            this.aut_col.Name = "aut_col";
            this.aut_col.ReadOnly = true;
            // 
            // fname_col
            // 
            this.fname_col.HeaderText = "Имя файла";
            this.fname_col.Name = "fname_col";
            this.fname_col.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label8.Location = new System.Drawing.Point(12, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Наиминование";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label7.Location = new System.Drawing.Point(12, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Автор";
            // 
            // AddSongBut
            // 
            this.AddSongBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSongBut.Location = new System.Drawing.Point(12, 178);
            this.AddSongBut.Name = "AddSongBut";
            this.AddSongBut.Size = new System.Drawing.Size(201, 54);
            this.AddSongBut.TabIndex = 6;
            this.AddSongBut.Text = "Добавить";
            this.AddSongBut.UseVisualStyleBackColor = true;
            this.AddSongBut.Click += new System.EventHandler(this.AddSongBut_Click);
            // 
            // text_fname
            // 
            this.text_fname.Location = new System.Drawing.Point(12, 145);
            this.text_fname.Name = "text_fname";
            this.text_fname.Size = new System.Drawing.Size(201, 20);
            this.text_fname.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Имя файла";
            // 
            // text_aut
            // 
            this.text_aut.Location = new System.Drawing.Point(12, 88);
            this.text_aut.Name = "text_aut";
            this.text_aut.Size = new System.Drawing.Size(201, 20);
            this.text_aut.TabIndex = 3;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(12, 38);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(201, 20);
            this.text_name.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zd_3);
            this.Controls.Add(this.zd_2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.zd_2.ResumeLayout(false);
            this.zd_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.zd_3.ResumeLayout(false);
            this.zd_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayListData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel zd_2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem магазинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плейлистToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.Panel zd_3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddSongBut;
        private System.Windows.Forms.TextBox text_fname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_aut;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.DataGridView PlayListData;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn aut_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname_col;
        private System.Windows.Forms.Button LaunchBut;
        private System.Windows.Forms.TextBox text_trans;
        private System.Windows.Forms.Button TransBut;
        private System.Windows.Forms.Label aut_current_song;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label current_name_song;
    }
}

