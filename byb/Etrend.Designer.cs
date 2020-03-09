namespace byb
{
    partial class Etrend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Etrend));
            this.dataGridViewEtkezesek = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxIdopontok = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveUjEtkezes = new System.Windows.Forms.Button();
            this.textBoxMennyiseg = new System.Windows.Forms.TextBox();
            this.textBoxKaloria = new System.Windows.Forms.TextBox();
            this.textBoxCh = new System.Windows.Forms.TextBox();
            this.textBoxZsir = new System.Windows.Forms.TextBox();
            this.Feherje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonUjEtkezes = new System.Windows.Forms.Button();
            this.comboBoxEtelNevek = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtkezesek)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEtkezesek
            // 
            this.dataGridViewEtkezesek.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEtkezesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEtkezesek.Location = new System.Drawing.Point(12, 104);
            this.dataGridViewEtkezesek.Name = "dataGridViewEtkezesek";
            this.dataGridViewEtkezesek.Size = new System.Drawing.Size(621, 325);
            this.dataGridViewEtkezesek.TabIndex = 22;
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
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(918, 56);
            this.panel3.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(564, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Étkezések";
            // 
            // comboBoxIdopontok
            // 
            this.comboBoxIdopontok.FormattingEnabled = true;
            this.comboBoxIdopontok.Location = new System.Drawing.Point(124, 72);
            this.comboBoxIdopontok.Name = "comboBoxIdopontok";
            this.comboBoxIdopontok.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIdopontok.TabIndex = 36;
            this.comboBoxIdopontok.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdopontok_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Válassz időpontot!";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(387, 446);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxEtelNevek);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.buttonSaveUjEtkezes);
            this.panel1.Controls.Add(this.textBoxMennyiseg);
            this.panel1.Controls.Add(this.textBoxKaloria);
            this.panel1.Controls.Add(this.textBoxCh);
            this.panel1.Controls.Add(this.textBoxZsir);
            this.panel1.Controls.Add(this.Feherje);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(669, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 227);
            this.panel1.TabIndex = 39;
            // 
            // buttonSaveUjEtkezes
            // 
            this.buttonSaveUjEtkezes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSaveUjEtkezes.FlatAppearance.BorderSize = 0;
            this.buttonSaveUjEtkezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveUjEtkezes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveUjEtkezes.ForeColor = System.Drawing.Color.White;
            this.buttonSaveUjEtkezes.Location = new System.Drawing.Point(66, 197);
            this.buttonSaveUjEtkezes.Name = "buttonSaveUjEtkezes";
            this.buttonSaveUjEtkezes.Size = new System.Drawing.Size(75, 27);
            this.buttonSaveUjEtkezes.TabIndex = 38;
            this.buttonSaveUjEtkezes.Text = "Mentés";
            this.buttonSaveUjEtkezes.UseVisualStyleBackColor = false;
            this.buttonSaveUjEtkezes.Click += new System.EventHandler(this.buttonSaveUjEtkezes_Click);
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
            // 
            // textBoxCh
            // 
            this.textBoxCh.Location = new System.Drawing.Point(66, 66);
            this.textBoxCh.Name = "textBoxCh";
            this.textBoxCh.Size = new System.Drawing.Size(100, 20);
            this.textBoxCh.TabIndex = 10;
            // 
            // textBoxZsir
            // 
            this.textBoxZsir.Location = new System.Drawing.Point(66, 93);
            this.textBoxZsir.Name = "textBoxZsir";
            this.textBoxZsir.Size = new System.Drawing.Size(100, 20);
            this.textBoxZsir.TabIndex = 9;
            // 
            // Feherje
            // 
            this.Feherje.Location = new System.Drawing.Point(66, 36);
            this.Feherje.Name = "Feherje";
            this.Feherje.Size = new System.Drawing.Size(100, 20);
            this.Feherje.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Zsír";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kalória";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mennyiség";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Szénhidrát";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fehérje";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Étel";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // buttonUjEtkezes
            // 
            this.buttonUjEtkezes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonUjEtkezes.FlatAppearance.BorderSize = 0;
            this.buttonUjEtkezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUjEtkezes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUjEtkezes.ForeColor = System.Drawing.Color.White;
            this.buttonUjEtkezes.Location = new System.Drawing.Point(669, 79);
            this.buttonUjEtkezes.Name = "buttonUjEtkezes";
            this.buttonUjEtkezes.Size = new System.Drawing.Size(75, 27);
            this.buttonUjEtkezes.TabIndex = 41;
            this.buttonUjEtkezes.Text = "Új étkezés";
            this.buttonUjEtkezes.UseVisualStyleBackColor = false;
            this.buttonUjEtkezes.Click += new System.EventHandler(this.buttonUjEtkezes_Click);
            // 
            // comboBoxEtelNevek
            // 
            this.comboBoxEtelNevek.FormattingEnabled = true;
            this.comboBoxEtelNevek.Location = new System.Drawing.Point(66, 9);
            this.comboBoxEtelNevek.Name = "comboBoxEtelNevek";
            this.comboBoxEtelNevek.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEtelNevek.TabIndex = 42;
            // 
            // Etrend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 484);
            this.Controls.Add(this.buttonUjEtkezes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxIdopontok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewEtkezesek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Etrend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etkezes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtkezesek)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewEtkezesek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxIdopontok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSaveUjEtkezes;
        private System.Windows.Forms.TextBox textBoxMennyiseg;
        private System.Windows.Forms.TextBox textBoxKaloria;
        private System.Windows.Forms.TextBox textBoxCh;
        private System.Windows.Forms.TextBox textBoxZsir;
        private System.Windows.Forms.TextBox Feherje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonUjEtkezes;
        private System.Windows.Forms.ComboBox comboBoxEtelNevek;
    }
}