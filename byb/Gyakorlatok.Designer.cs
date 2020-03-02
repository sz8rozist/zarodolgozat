namespace byb
{
    partial class Gyakorlatok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gyakorlatok));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewGyakorlatok = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxIdopont = new System.Windows.Forms.ComboBox();
            this.dataGridViewEdzesek = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGyakorlatok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdzesek)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(194, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Válassz izomcsoportot:";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1050, 56);
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
            // dataGridViewGyakorlatok
            // 
            this.dataGridViewGyakorlatok.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGyakorlatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGyakorlatok.Location = new System.Drawing.Point(35, 141);
            this.dataGridViewGyakorlatok.Name = "dataGridViewGyakorlatok";
            this.dataGridViewGyakorlatok.Size = new System.Drawing.Size(253, 233);
            this.dataGridViewGyakorlatok.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(408, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Válassz időpontot:";
            // 
            // comboBoxIdopont
            // 
            this.comboBoxIdopont.FormattingEnabled = true;
            this.comboBoxIdopont.Location = new System.Drawing.Point(542, 90);
            this.comboBoxIdopont.Name = "comboBoxIdopont";
            this.comboBoxIdopont.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIdopont.TabIndex = 31;
            this.comboBoxIdopont.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdopont_SelectedIndexChanged);
            // 
            // dataGridViewEdzesek
            // 
            this.dataGridViewEdzesek.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEdzesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEdzesek.Location = new System.Drawing.Point(411, 141);
            this.dataGridViewEdzesek.Name = "dataGridViewEdzesek";
            this.dataGridViewEdzesek.Size = new System.Drawing.Size(590, 354);
            this.dataGridViewEdzesek.TabIndex = 32;
            // 
            // Gyakorlatok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 538);
            this.Controls.Add(this.dataGridViewEdzesek);
            this.Controls.Add(this.comboBoxIdopont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewGyakorlatok);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gyakorlatok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gyakorlatok";
            this.Load += new System.EventHandler(this.Gyakorlatok_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGyakorlatok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdzesek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewGyakorlatok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxIdopont;
        private System.Windows.Forms.DataGridView dataGridViewEdzesek;
    }
}