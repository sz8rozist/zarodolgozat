﻿namespace byb
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
            this.labelFeherje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSzenhidrat = new System.Windows.Forms.Label();
            this.labelZsír = new System.Windows.Forms.Label();
            this.labelKaloraBevitel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonTorolEtkezes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtkezesek)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEtkezesek
            // 
            this.dataGridViewEtkezesek.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewEtkezesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEtkezesek.Location = new System.Drawing.Point(32, 104);
            this.dataGridViewEtkezesek.Name = "dataGridViewEtkezesek";
            this.dataGridViewEtkezesek.Size = new System.Drawing.Size(621, 268);
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
            this.panel3.Size = new System.Drawing.Size(716, 56);
            this.panel3.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(584, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Étkezések";
            // 
            // comboBoxIdopontok
            // 
            this.comboBoxIdopontok.FormatString = "d";
            this.comboBoxIdopontok.Location = new System.Drawing.Point(136, 72);
            this.comboBoxIdopontok.Name = "comboBoxIdopontok";
            this.comboBoxIdopontok.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIdopontok.TabIndex = 36;
            this.comboBoxIdopontok.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdopontok_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Válassz időpontot!";
            // 
            // labelFeherje
            // 
            this.labelFeherje.AutoSize = true;
            this.labelFeherje.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeherje.Location = new System.Drawing.Point(127, 31);
            this.labelFeherje.Name = "labelFeherje";
            this.labelFeherje.Size = new System.Drawing.Size(0, 16);
            this.labelFeherje.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Fehérje bevitel(gr):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Kalória bevitel(Kcal):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(14, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Zsír bevitel(gr):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(14, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Szénhidrát bevitel(gr):";
            // 
            // labelSzenhidrat
            // 
            this.labelSzenhidrat.AutoSize = true;
            this.labelSzenhidrat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSzenhidrat.Location = new System.Drawing.Point(147, 47);
            this.labelSzenhidrat.Name = "labelSzenhidrat";
            this.labelSzenhidrat.Size = new System.Drawing.Size(0, 16);
            this.labelSzenhidrat.TabIndex = 43;
            // 
            // labelZsír
            // 
            this.labelZsír.AutoSize = true;
            this.labelZsír.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZsír.Location = new System.Drawing.Point(106, 60);
            this.labelZsír.Name = "labelZsír";
            this.labelZsír.Size = new System.Drawing.Size(0, 16);
            this.labelZsír.TabIndex = 44;
            // 
            // labelKaloraBevitel
            // 
            this.labelKaloraBevitel.AutoSize = true;
            this.labelKaloraBevitel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKaloraBevitel.Location = new System.Drawing.Point(141, 78);
            this.labelKaloraBevitel.Name = "labelKaloraBevitel";
            this.labelKaloraBevitel.Size = new System.Drawing.Size(0, 16);
            this.labelKaloraBevitel.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Napi makrotápanyag bevitel";
            // 
            // buttonTorolEtkezes
            // 
            this.buttonTorolEtkezes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonTorolEtkezes.FlatAppearance.BorderSize = 0;
            this.buttonTorolEtkezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTorolEtkezes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTorolEtkezes.ForeColor = System.Drawing.Color.White;
            this.buttonTorolEtkezes.Location = new System.Drawing.Point(537, 382);
            this.buttonTorolEtkezes.Name = "buttonTorolEtkezes";
            this.buttonTorolEtkezes.Size = new System.Drawing.Size(116, 27);
            this.buttonTorolEtkezes.TabIndex = 47;
            this.buttonTorolEtkezes.Text = "Étkezés törlése";
            this.buttonTorolEtkezes.UseVisualStyleBackColor = false;
            this.buttonTorolEtkezes.Click += new System.EventHandler(this.buttonTorolEtkezes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelFeherje);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelKaloraBevitel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelZsír);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelSzenhidrat);
            this.panel1.Location = new System.Drawing.Point(32, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 99);
            this.panel1.TabIndex = 48;
            // 
            // Etrend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(716, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonTorolEtkezes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxIdopontok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewEtkezesek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label labelFeherje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSzenhidrat;
        private System.Windows.Forms.Label labelZsír;
        private System.Windows.Forms.Label labelKaloraBevitel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonTorolEtkezes;
        private System.Windows.Forms.Panel panel1;
    }
}