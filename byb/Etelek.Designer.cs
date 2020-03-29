namespace byb
{
    partial class Etelek
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Etelek));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEtelek = new System.Windows.Forms.DataGridView();
            this.buttonUjEtel = new System.Windows.Forms.Button();
            this.panelEtel = new System.Windows.Forms.Panel();
            this.buttonSaveUjEtel = new System.Windows.Forms.Button();
            this.textBoxMennyiseg = new System.Windows.Forms.TextBox();
            this.textBoxKaloria = new System.Windows.Forms.TextBox();
            this.textBoxCh = new System.Windows.Forms.TextBox();
            this.textBoxZsir = new System.Windows.Forms.TextBox();
            this.textBoxEtelNev = new System.Windows.Forms.TextBox();
            this.Feherje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUjEtkezes = new System.Windows.Forms.Button();
            this.panelEtkezes = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSaveUjEtkezes = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerIdopont = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxEtel = new System.Windows.Forms.ComboBox();
            this.buttonDeleteEtel = new System.Windows.Forms.Button();
            this.errorProviderEtelNev = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFeherje = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEnevFirstLetter = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMennyiseg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMindenMezo = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtelek)).BeginInit();
            this.panelEtel.SuspendLayout();
            this.panelEtkezes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEtelNev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFeherje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEnevFirstLetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMennyiseg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMindenMezo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 56);
            this.panel3.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 56);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Válassz egy ételt:";
            // 
            // dataGridViewEtelek
            // 
            this.dataGridViewEtelek.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewEtelek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEtelek.Location = new System.Drawing.Point(32, 180);
            this.dataGridViewEtelek.Name = "dataGridViewEtelek";
            this.dataGridViewEtelek.Size = new System.Drawing.Size(406, 117);
            this.dataGridViewEtelek.TabIndex = 32;
            // 
            // buttonUjEtel
            // 
            this.buttonUjEtel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonUjEtel.FlatAppearance.BorderSize = 0;
            this.buttonUjEtel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUjEtel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUjEtel.ForeColor = System.Drawing.Color.White;
            this.buttonUjEtel.Location = new System.Drawing.Point(261, 75);
            this.buttonUjEtel.Name = "buttonUjEtel";
            this.buttonUjEtel.Size = new System.Drawing.Size(117, 27);
            this.buttonUjEtel.TabIndex = 36;
            this.buttonUjEtel.Text = "Étel hozzáadás";
            this.buttonUjEtel.UseVisualStyleBackColor = false;
            this.buttonUjEtel.Click += new System.EventHandler(this.buttonUjEtel_Click);
            // 
            // panelEtel
            // 
            this.panelEtel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelEtel.Controls.Add(this.buttonSaveUjEtel);
            this.panelEtel.Controls.Add(this.textBoxMennyiseg);
            this.panelEtel.Controls.Add(this.textBoxKaloria);
            this.panelEtel.Controls.Add(this.textBoxCh);
            this.panelEtel.Controls.Add(this.textBoxZsir);
            this.panelEtel.Controls.Add(this.textBoxEtelNev);
            this.panelEtel.Controls.Add(this.Feherje);
            this.panelEtel.Controls.Add(this.label7);
            this.panelEtel.Controls.Add(this.label6);
            this.panelEtel.Controls.Add(this.label5);
            this.panelEtel.Controls.Add(this.label4);
            this.panelEtel.Controls.Add(this.label3);
            this.panelEtel.Controls.Add(this.label2);
            this.panelEtel.Location = new System.Drawing.Point(461, 180);
            this.panelEtel.Name = "panelEtel";
            this.panelEtel.Size = new System.Drawing.Size(214, 221);
            this.panelEtel.TabIndex = 37;
            // 
            // buttonSaveUjEtel
            // 
            this.buttonSaveUjEtel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSaveUjEtel.FlatAppearance.BorderSize = 0;
            this.buttonSaveUjEtel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveUjEtel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveUjEtel.ForeColor = System.Drawing.Color.White;
            this.buttonSaveUjEtel.Location = new System.Drawing.Point(66, 174);
            this.buttonSaveUjEtel.Name = "buttonSaveUjEtel";
            this.buttonSaveUjEtel.Size = new System.Drawing.Size(75, 27);
            this.buttonSaveUjEtel.TabIndex = 38;
            this.buttonSaveUjEtel.Text = "Mentés";
            this.buttonSaveUjEtel.UseVisualStyleBackColor = false;
            this.buttonSaveUjEtel.Click += new System.EventHandler(this.buttonSaveUjEtel_Click);
            // 
            // textBoxMennyiseg
            // 
            this.textBoxMennyiseg.Location = new System.Drawing.Point(66, 144);
            this.textBoxMennyiseg.Name = "textBoxMennyiseg";
            this.textBoxMennyiseg.Size = new System.Drawing.Size(100, 20);
            this.textBoxMennyiseg.TabIndex = 12;
            // 
            // textBoxKaloria
            // 
            this.textBoxKaloria.Location = new System.Drawing.Point(66, 120);
            this.textBoxKaloria.Name = "textBoxKaloria";
            this.textBoxKaloria.Size = new System.Drawing.Size(100, 20);
            this.textBoxKaloria.TabIndex = 11;
            this.textBoxKaloria.TextChanged += new System.EventHandler(this.textBoxKaloria_TextChanged);
            // 
            // textBoxCh
            // 
            this.textBoxCh.Location = new System.Drawing.Point(66, 66);
            this.textBoxCh.Name = "textBoxCh";
            this.textBoxCh.Size = new System.Drawing.Size(100, 20);
            this.textBoxCh.TabIndex = 10;
            this.textBoxCh.TextChanged += new System.EventHandler(this.textBoxCh_TextChanged);
            // 
            // textBoxZsir
            // 
            this.textBoxZsir.Location = new System.Drawing.Point(66, 93);
            this.textBoxZsir.Name = "textBoxZsir";
            this.textBoxZsir.Size = new System.Drawing.Size(100, 20);
            this.textBoxZsir.TabIndex = 9;
            this.textBoxZsir.TextChanged += new System.EventHandler(this.textBoxZsir_TextChanged);
            // 
            // textBoxEtelNev
            // 
            this.textBoxEtelNev.Location = new System.Drawing.Point(66, 10);
            this.textBoxEtelNev.Name = "textBoxEtelNev";
            this.textBoxEtelNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxEtelNev.TabIndex = 8;
            // 
            // Feherje
            // 
            this.Feherje.Location = new System.Drawing.Point(66, 36);
            this.Feherje.Name = "Feherje";
            this.Feherje.Size = new System.Drawing.Size(100, 20);
            this.Feherje.TabIndex = 7;
            this.Feherje.TextChanged += new System.EventHandler(this.Feherje_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label7.Location = new System.Drawing.Point(3, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Zsír";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label6.Location = new System.Drawing.Point(2, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kalória";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label5.Location = new System.Drawing.Point(2, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mennyiség";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Szénhidrát";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fehérje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Étel";
            // 
            // buttonUjEtkezes
            // 
            this.buttonUjEtkezes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonUjEtkezes.FlatAppearance.BorderSize = 0;
            this.buttonUjEtkezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUjEtkezes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUjEtkezes.ForeColor = System.Drawing.Color.White;
            this.buttonUjEtkezes.Location = new System.Drawing.Point(505, 75);
            this.buttonUjEtkezes.Name = "buttonUjEtkezes";
            this.buttonUjEtkezes.Size = new System.Drawing.Size(144, 27);
            this.buttonUjEtkezes.TabIndex = 42;
            this.buttonUjEtkezes.Text = "Étkezés hozzáadás";
            this.buttonUjEtkezes.UseVisualStyleBackColor = false;
            this.buttonUjEtkezes.Click += new System.EventHandler(this.buttonUjEtkezes_Click);
            // 
            // panelEtkezes
            // 
            this.panelEtkezes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelEtkezes.Controls.Add(this.label9);
            this.panelEtkezes.Controls.Add(this.buttonSaveUjEtkezes);
            this.panelEtkezes.Controls.Add(this.label8);
            this.panelEtkezes.Controls.Add(this.dateTimePickerIdopont);
            this.panelEtkezes.Location = new System.Drawing.Point(32, 303);
            this.panelEtkezes.Name = "panelEtkezes";
            this.panelEtkezes.Size = new System.Drawing.Size(406, 78);
            this.panelEtkezes.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Válassz időpontot";
            // 
            // buttonSaveUjEtkezes
            // 
            this.buttonSaveUjEtkezes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSaveUjEtkezes.FlatAppearance.BorderSize = 0;
            this.buttonSaveUjEtkezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveUjEtkezes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveUjEtkezes.ForeColor = System.Drawing.Color.White;
            this.buttonSaveUjEtkezes.Location = new System.Drawing.Point(190, 41);
            this.buttonSaveUjEtkezes.Name = "buttonSaveUjEtkezes";
            this.buttonSaveUjEtkezes.Size = new System.Drawing.Size(75, 27);
            this.buttonSaveUjEtkezes.TabIndex = 39;
            this.buttonSaveUjEtkezes.Text = "Mentés";
            this.buttonSaveUjEtkezes.UseVisualStyleBackColor = false;
            this.buttonSaveUjEtkezes.Click += new System.EventHandler(this.buttonSaveUjEtkezes_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label8.Location = new System.Drawing.Point(3, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Időpont";
            // 
            // dateTimePickerIdopont
            // 
            this.dateTimePickerIdopont.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerIdopont.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIdopont.Location = new System.Drawing.Point(61, 42);
            this.dateTimePickerIdopont.Name = "dateTimePickerIdopont";
            this.dateTimePickerIdopont.Size = new System.Drawing.Size(123, 20);
            this.dateTimePickerIdopont.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(32, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Kiválasztott ételek";
            // 
            // comboBoxEtel
            // 
            this.comboBoxEtel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxEtel.FormattingEnabled = true;
            this.comboBoxEtel.Location = new System.Drawing.Point(134, 78);
            this.comboBoxEtel.Name = "comboBoxEtel";
            this.comboBoxEtel.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEtel.TabIndex = 45;
            this.comboBoxEtel.SelectedIndexChanged += new System.EventHandler(this.comboBoxEtel_SelectedIndexChanged);
            // 
            // buttonDeleteEtel
            // 
            this.buttonDeleteEtel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonDeleteEtel.FlatAppearance.BorderSize = 0;
            this.buttonDeleteEtel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteEtel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteEtel.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteEtel.Location = new System.Drawing.Point(384, 75);
            this.buttonDeleteEtel.Name = "buttonDeleteEtel";
            this.buttonDeleteEtel.Size = new System.Drawing.Size(84, 27);
            this.buttonDeleteEtel.TabIndex = 41;
            this.buttonDeleteEtel.Text = "Étel törlés";
            this.buttonDeleteEtel.UseVisualStyleBackColor = false;
            this.buttonDeleteEtel.Click += new System.EventHandler(this.buttonDeleteEtel_Click);
            // 
            // errorProviderEtelNev
            // 
            this.errorProviderEtelNev.ContainerControl = this;
            // 
            // errorProviderFeherje
            // 
            this.errorProviderFeherje.ContainerControl = this;
            // 
            // errorProviderEnevFirstLetter
            // 
            this.errorProviderEnevFirstLetter.ContainerControl = this;
            // 
            // errorProviderMennyiseg
            // 
            this.errorProviderMennyiseg.ContainerControl = this;
            // 
            // errorProviderMindenMezo
            // 
            this.errorProviderMindenMezo.ContainerControl = this;
            // 
            // Etelek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(713, 438);
            this.Controls.Add(this.buttonDeleteEtel);
            this.Controls.Add(this.comboBoxEtel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panelEtkezes);
            this.Controls.Add(this.buttonUjEtkezes);
            this.Controls.Add(this.panelEtel);
            this.Controls.Add(this.buttonUjEtel);
            this.Controls.Add(this.dataGridViewEtelek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Etelek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etelek";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtelek)).EndInit();
            this.panelEtel.ResumeLayout(false);
            this.panelEtel.PerformLayout();
            this.panelEtkezes.ResumeLayout(false);
            this.panelEtkezes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEtelNev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFeherje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEnevFirstLetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMennyiseg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMindenMezo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEtelek;
        private System.Windows.Forms.Button buttonUjEtel;
        private System.Windows.Forms.Panel panelEtel;
        private System.Windows.Forms.TextBox textBoxMennyiseg;
        private System.Windows.Forms.TextBox textBoxKaloria;
        private System.Windows.Forms.TextBox textBoxCh;
        private System.Windows.Forms.TextBox textBoxZsir;
        private System.Windows.Forms.TextBox textBoxEtelNev;
        private System.Windows.Forms.TextBox Feherje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveUjEtel;
        private System.Windows.Forms.Button buttonUjEtkezes;
        private System.Windows.Forms.Panel panelEtkezes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerIdopont;
        private System.Windows.Forms.Button buttonSaveUjEtkezes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxEtel;
        private System.Windows.Forms.Button buttonDeleteEtel;
        private System.Windows.Forms.ErrorProvider errorProviderEtelNev;
        private System.Windows.Forms.ErrorProvider errorProviderFeherje;
        private System.Windows.Forms.ErrorProvider errorProviderEnevFirstLetter;
        private System.Windows.Forms.ErrorProvider errorProviderMennyiseg;
        private System.Windows.Forms.ErrorProvider errorProviderMindenMezo;
    }
}