namespace byb
{
    partial class etrend
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonEtelek = new System.Windows.Forms.Button();
            this.dataGridViewEtelek = new System.Windows.Forms.DataGridView();
            this.buttonEtkezesek = new System.Windows.Forms.Button();
            this.panelEtelek = new System.Windows.Forms.Panel();
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.panelUjEtel = new System.Windows.Forms.Panel();
            this.buttonMegse = new System.Windows.Forms.Button();
            this.buttonUjMentes = new System.Windows.Forms.Button();
            this.textBoxMennyiseg = new System.Windows.Forms.TextBox();
            this.textBoxZsir = new System.Windows.Forms.TextBox();
            this.textBoxSzenhidrat = new System.Windows.Forms.TextBox();
            this.textBoxFeherje = new System.Windows.Forms.TextBox();
            this.textBoxKaloria = new System.Windows.Forms.TextBox();
            this.EtelNev = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Étel = new System.Windows.Forms.Label();
            this.buttonTorolEtel = new System.Windows.Forms.Button();
            this.dataGridViewEtkezesek = new System.Windows.Forms.DataGridView();
            this.panelEtkezesek = new System.Windows.Forms.Panel();
            this.panelUjEtkezes = new System.Windows.Forms.Panel();
            this.buttonEtkezesMegse = new System.Windows.Forms.Button();
            this.buttonMentesEtkezes = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEtelNev = new System.Windows.Forms.ComboBox();
            this.buttonUjEtkezes = new System.Windows.Forms.Button();
            this.buttonTorolEtkezes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtelek)).BeginInit();
            this.panelEtelek.SuspendLayout();
            this.panelUjEtel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtkezesek)).BeginInit();
            this.panelEtkezesek.SuspendLayout();
            this.panelUjEtkezes.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEtelek
            // 
            this.buttonEtelek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.buttonEtelek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEtelek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEtelek.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEtelek.ForeColor = System.Drawing.Color.White;
            this.buttonEtelek.Location = new System.Drawing.Point(16, 14);
            this.buttonEtelek.Name = "buttonEtelek";
            this.buttonEtelek.Size = new System.Drawing.Size(84, 32);
            this.buttonEtelek.TabIndex = 0;
            this.buttonEtelek.Text = "Ételek";
            this.buttonEtelek.UseVisualStyleBackColor = false;
            this.buttonEtelek.Click += new System.EventHandler(this.buttonEtelek_Click);
            // 
            // dataGridViewEtelek
            // 
            this.dataGridViewEtelek.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEtelek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEtelek.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEtelek.Name = "dataGridViewEtelek";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.dataGridViewEtelek.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEtelek.Size = new System.Drawing.Size(497, 296);
            this.dataGridViewEtelek.TabIndex = 1;
            // 
            // buttonEtkezesek
            // 
            this.buttonEtkezesek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.buttonEtkezesek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEtkezesek.FlatAppearance.BorderSize = 0;
            this.buttonEtkezesek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEtkezesek.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEtkezesek.ForeColor = System.Drawing.Color.White;
            this.buttonEtkezesek.Location = new System.Drawing.Point(106, 14);
            this.buttonEtkezesek.Name = "buttonEtkezesek";
            this.buttonEtkezesek.Size = new System.Drawing.Size(84, 32);
            this.buttonEtkezesek.TabIndex = 3;
            this.buttonEtkezesek.Text = "Étkezések";
            this.buttonEtkezesek.UseVisualStyleBackColor = false;
            this.buttonEtkezesek.Click += new System.EventHandler(this.buttonEtkezesek_Click);
            // 
            // panelEtelek
            // 
            this.panelEtelek.Controls.Add(this.buttonHozzaad);
            this.panelEtelek.Controls.Add(this.panelUjEtel);
            this.panelEtelek.Controls.Add(this.buttonTorolEtel);
            this.panelEtelek.Controls.Add(this.dataGridViewEtelek);
            this.panelEtelek.Location = new System.Drawing.Point(16, 52);
            this.panelEtelek.Name = "panelEtelek";
            this.panelEtelek.Size = new System.Drawing.Size(526, 509);
            this.panelEtelek.TabIndex = 4;
            // 
            // buttonHozzaad
            // 
            this.buttonHozzaad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.buttonHozzaad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonHozzaad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHozzaad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHozzaad.ForeColor = System.Drawing.Color.White;
            this.buttonHozzaad.Location = new System.Drawing.Point(93, 305);
            this.buttonHozzaad.Name = "buttonHozzaad";
            this.buttonHozzaad.Size = new System.Drawing.Size(84, 32);
            this.buttonHozzaad.TabIndex = 8;
            this.buttonHozzaad.Text = "Új";
            this.buttonHozzaad.UseVisualStyleBackColor = false;
            this.buttonHozzaad.Click += new System.EventHandler(this.buttonHozzaad_Click);
            // 
            // panelUjEtel
            // 
            this.panelUjEtel.Controls.Add(this.buttonMegse);
            this.panelUjEtel.Controls.Add(this.buttonUjMentes);
            this.panelUjEtel.Controls.Add(this.textBoxMennyiseg);
            this.panelUjEtel.Controls.Add(this.textBoxZsir);
            this.panelUjEtel.Controls.Add(this.textBoxSzenhidrat);
            this.panelUjEtel.Controls.Add(this.textBoxFeherje);
            this.panelUjEtel.Controls.Add(this.textBoxKaloria);
            this.panelUjEtel.Controls.Add(this.EtelNev);
            this.panelUjEtel.Controls.Add(this.label7);
            this.panelUjEtel.Controls.Add(this.label6);
            this.panelUjEtel.Controls.Add(this.label5);
            this.panelUjEtel.Controls.Add(this.label4);
            this.panelUjEtel.Controls.Add(this.label3);
            this.panelUjEtel.Controls.Add(this.Étel);
            this.panelUjEtel.Location = new System.Drawing.Point(183, 305);
            this.panelUjEtel.Name = "panelUjEtel";
            this.panelUjEtel.Size = new System.Drawing.Size(317, 169);
            this.panelUjEtel.TabIndex = 7;
            // 
            // buttonMegse
            // 
            this.buttonMegse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.buttonMegse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMegse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMegse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMegse.ForeColor = System.Drawing.Color.White;
            this.buttonMegse.Location = new System.Drawing.Point(202, 122);
            this.buttonMegse.Name = "buttonMegse";
            this.buttonMegse.Size = new System.Drawing.Size(84, 32);
            this.buttonMegse.TabIndex = 20;
            this.buttonMegse.Text = "Mégse";
            this.buttonMegse.UseVisualStyleBackColor = false;
            this.buttonMegse.Click += new System.EventHandler(this.buttonMegse_Click);
            // 
            // buttonUjMentes
            // 
            this.buttonUjMentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.buttonUjMentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUjMentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUjMentes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUjMentes.ForeColor = System.Drawing.Color.White;
            this.buttonUjMentes.Location = new System.Drawing.Point(202, 9);
            this.buttonUjMentes.Name = "buttonUjMentes";
            this.buttonUjMentes.Size = new System.Drawing.Size(84, 32);
            this.buttonUjMentes.TabIndex = 9;
            this.buttonUjMentes.Text = "Mentés";
            this.buttonUjMentes.UseVisualStyleBackColor = false;
            this.buttonUjMentes.Click += new System.EventHandler(this.buttonUjMentes_Click);
            // 
            // textBoxMennyiseg
            // 
            this.textBoxMennyiseg.Location = new System.Drawing.Point(82, 141);
            this.textBoxMennyiseg.Name = "textBoxMennyiseg";
            this.textBoxMennyiseg.Size = new System.Drawing.Size(100, 20);
            this.textBoxMennyiseg.TabIndex = 19;
            this.textBoxMennyiseg.TextChanged += new System.EventHandler(this.textBoxMennyiseg_TextChanged);
            // 
            // textBoxZsir
            // 
            this.textBoxZsir.Location = new System.Drawing.Point(82, 115);
            this.textBoxZsir.Name = "textBoxZsir";
            this.textBoxZsir.Size = new System.Drawing.Size(100, 20);
            this.textBoxZsir.TabIndex = 18;
            // 
            // textBoxSzenhidrat
            // 
            this.textBoxSzenhidrat.Location = new System.Drawing.Point(82, 84);
            this.textBoxSzenhidrat.Name = "textBoxSzenhidrat";
            this.textBoxSzenhidrat.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzenhidrat.TabIndex = 17;
            // 
            // textBoxFeherje
            // 
            this.textBoxFeherje.Location = new System.Drawing.Point(82, 57);
            this.textBoxFeherje.Name = "textBoxFeherje";
            this.textBoxFeherje.Size = new System.Drawing.Size(100, 20);
            this.textBoxFeherje.TabIndex = 16;
            // 
            // textBoxKaloria
            // 
            this.textBoxKaloria.Location = new System.Drawing.Point(82, 31);
            this.textBoxKaloria.Name = "textBoxKaloria";
            this.textBoxKaloria.Size = new System.Drawing.Size(100, 20);
            this.textBoxKaloria.TabIndex = 15;
            // 
            // EtelNev
            // 
            this.EtelNev.Location = new System.Drawing.Point(82, 6);
            this.EtelNev.Name = "EtelNev";
            this.EtelNev.Size = new System.Drawing.Size(100, 20);
            this.EtelNev.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mennyiség(gr)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Zsír";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Szenhidrat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fehérje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kalória";
            // 
            // Étel
            // 
            this.Étel.AutoSize = true;
            this.Étel.Location = new System.Drawing.Point(3, 9);
            this.Étel.Name = "Étel";
            this.Étel.Size = new System.Drawing.Size(25, 13);
            this.Étel.TabIndex = 8;
            this.Étel.Text = "Étel";
            // 
            // buttonTorolEtel
            // 
            this.buttonTorolEtel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.buttonTorolEtel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTorolEtel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTorolEtel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTorolEtel.ForeColor = System.Drawing.Color.White;
            this.buttonTorolEtel.Location = new System.Drawing.Point(3, 305);
            this.buttonTorolEtel.Name = "buttonTorolEtel";
            this.buttonTorolEtel.Size = new System.Drawing.Size(84, 32);
            this.buttonTorolEtel.TabIndex = 5;
            this.buttonTorolEtel.Text = "Törlés";
            this.buttonTorolEtel.UseVisualStyleBackColor = false;
            this.buttonTorolEtel.Click += new System.EventHandler(this.buttonTorolEtel_Click);
            // 
            // dataGridViewEtkezesek
            // 
            this.dataGridViewEtkezesek.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEtkezesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEtkezesek.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEtkezesek.Name = "dataGridViewEtkezesek";
            this.dataGridViewEtkezesek.Size = new System.Drawing.Size(441, 255);
            this.dataGridViewEtkezesek.TabIndex = 5;
            // 
            // panelEtkezesek
            // 
            this.panelEtkezesek.Controls.Add(this.panelUjEtkezes);
            this.panelEtkezesek.Controls.Add(this.buttonUjEtkezes);
            this.panelEtkezesek.Controls.Add(this.buttonTorolEtkezes);
            this.panelEtkezesek.Controls.Add(this.dataGridViewEtkezesek);
            this.panelEtkezesek.Location = new System.Drawing.Point(16, 52);
            this.panelEtkezesek.Name = "panelEtkezesek";
            this.panelEtkezesek.Size = new System.Drawing.Size(518, 506);
            this.panelEtkezesek.TabIndex = 9;
            // 
            // panelUjEtkezes
            // 
            this.panelUjEtkezes.Controls.Add(this.buttonEtkezesMegse);
            this.panelUjEtkezes.Controls.Add(this.buttonMentesEtkezes);
            this.panelUjEtkezes.Controls.Add(this.dateTimePicker1);
            this.panelUjEtkezes.Controls.Add(this.label2);
            this.panelUjEtkezes.Controls.Add(this.label1);
            this.panelUjEtkezes.Controls.Add(this.comboBoxEtelNev);
            this.panelUjEtkezes.Location = new System.Drawing.Point(12, 305);
            this.panelUjEtkezes.Name = "panelUjEtkezes";
            this.panelUjEtkezes.Size = new System.Drawing.Size(264, 157);
            this.panelUjEtkezes.TabIndex = 13;
            // 
            // buttonEtkezesMegse
            // 
            this.buttonEtkezesMegse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.buttonEtkezesMegse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEtkezesMegse.FlatAppearance.BorderSize = 0;
            this.buttonEtkezesMegse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEtkezesMegse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEtkezesMegse.ForeColor = System.Drawing.Color.White;
            this.buttonEtkezesMegse.Location = new System.Drawing.Point(172, 102);
            this.buttonEtkezesMegse.Name = "buttonEtkezesMegse";
            this.buttonEtkezesMegse.Size = new System.Drawing.Size(84, 32);
            this.buttonEtkezesMegse.TabIndex = 16;
            this.buttonEtkezesMegse.Text = "Mégse";
            this.buttonEtkezesMegse.UseVisualStyleBackColor = false;
            this.buttonEtkezesMegse.Click += new System.EventHandler(this.buttonEtkezesMegse_Click);
            // 
            // buttonMentesEtkezes
            // 
            this.buttonMentesEtkezes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.buttonMentesEtkezes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMentesEtkezes.FlatAppearance.BorderSize = 0;
            this.buttonMentesEtkezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMentesEtkezes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMentesEtkezes.ForeColor = System.Drawing.Color.White;
            this.buttonMentesEtkezes.Location = new System.Drawing.Point(14, 102);
            this.buttonMentesEtkezes.Name = "buttonMentesEtkezes";
            this.buttonMentesEtkezes.Size = new System.Drawing.Size(84, 32);
            this.buttonMentesEtkezes.TabIndex = 14;
            this.buttonMentesEtkezes.Text = "Mentés";
            this.buttonMentesEtkezes.UseVisualStyleBackColor = false;
            this.buttonMentesEtkezes.Click += new System.EventHandler(this.buttonMentesEtkezes_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 40);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2020, 2, 10, 19, 26, 30, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Időpont";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Étel";
            // 
            // comboBoxEtelNev
            // 
            this.comboBoxEtelNev.FormattingEnabled = true;
            this.comboBoxEtelNev.Location = new System.Drawing.Point(56, 12);
            this.comboBoxEtelNev.Name = "comboBoxEtelNev";
            this.comboBoxEtelNev.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEtelNev.TabIndex = 12;
            this.comboBoxEtelNev.SelectedIndexChanged += new System.EventHandler(this.comboBoxEtelNev_SelectedIndexChanged);
            // 
            // buttonUjEtkezes
            // 
            this.buttonUjEtkezes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.buttonUjEtkezes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUjEtkezes.FlatAppearance.BorderSize = 0;
            this.buttonUjEtkezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUjEtkezes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUjEtkezes.ForeColor = System.Drawing.Color.White;
            this.buttonUjEtkezes.Location = new System.Drawing.Point(116, 267);
            this.buttonUjEtkezes.Name = "buttonUjEtkezes";
            this.buttonUjEtkezes.Size = new System.Drawing.Size(84, 32);
            this.buttonUjEtkezes.TabIndex = 11;
            this.buttonUjEtkezes.Text = "Új";
            this.buttonUjEtkezes.UseVisualStyleBackColor = false;
            this.buttonUjEtkezes.Click += new System.EventHandler(this.buttonUjEtkezes_Click);
            // 
            // buttonTorolEtkezes
            // 
            this.buttonTorolEtkezes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.buttonTorolEtkezes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTorolEtkezes.FlatAppearance.BorderSize = 0;
            this.buttonTorolEtkezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTorolEtkezes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTorolEtkezes.ForeColor = System.Drawing.Color.White;
            this.buttonTorolEtkezes.Location = new System.Drawing.Point(12, 267);
            this.buttonTorolEtkezes.Name = "buttonTorolEtkezes";
            this.buttonTorolEtkezes.Size = new System.Drawing.Size(84, 32);
            this.buttonTorolEtkezes.TabIndex = 10;
            this.buttonTorolEtkezes.Text = "Törlés";
            this.buttonTorolEtkezes.UseVisualStyleBackColor = false;
            this.buttonTorolEtkezes.Click += new System.EventHandler(this.buttonTorolEtkezes_Click);
            // 
            // etrend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelEtelek);
            this.Controls.Add(this.panelEtkezesek);
            this.Controls.Add(this.buttonEtkezesek);
            this.Controls.Add(this.buttonEtelek);
            this.Name = "etrend";
            this.Size = new System.Drawing.Size(727, 579);
            this.Load += new System.EventHandler(this.Etrend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtelek)).EndInit();
            this.panelEtelek.ResumeLayout(false);
            this.panelUjEtel.ResumeLayout(false);
            this.panelUjEtel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtkezesek)).EndInit();
            this.panelEtkezesek.ResumeLayout(false);
            this.panelUjEtkezes.ResumeLayout(false);
            this.panelUjEtkezes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEtelek;
        private System.Windows.Forms.DataGridView dataGridViewEtelek;
        private System.Windows.Forms.Button buttonEtkezesek;
        private System.Windows.Forms.Panel panelEtelek;
        private System.Windows.Forms.Button buttonTorolEtel;
        private System.Windows.Forms.DataGridView dataGridViewEtkezesek;
        private System.Windows.Forms.Button buttonHozzaad;
        private System.Windows.Forms.Panel panelUjEtel;
        private System.Windows.Forms.TextBox textBoxMennyiseg;
        private System.Windows.Forms.TextBox textBoxZsir;
        private System.Windows.Forms.TextBox textBoxSzenhidrat;
        private System.Windows.Forms.TextBox textBoxFeherje;
        private System.Windows.Forms.TextBox textBoxKaloria;
        private System.Windows.Forms.TextBox EtelNev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Étel;
        private System.Windows.Forms.Button buttonUjMentes;
        private System.Windows.Forms.Button buttonMegse;
        private System.Windows.Forms.Panel panelEtkezesek;
        private System.Windows.Forms.Button buttonUjEtkezes;
        private System.Windows.Forms.Button buttonTorolEtkezes;
        private System.Windows.Forms.ComboBox comboBoxEtelNev;
        private System.Windows.Forms.Panel panelUjEtkezes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMentesEtkezes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonEtkezesMegse;
    }
}
