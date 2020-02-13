namespace byb
{
    partial class tkieg
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
            this.buttonKiegek = new System.Windows.Forms.Button();
            this.panelKiegek = new System.Windows.Forms.Panel();
            this.dataGridViewKiegek = new System.Windows.Forms.DataGridView();
            this.buttonKeres = new System.Windows.Forms.Button();
            this.comboBoxTkiegFajtak = new System.Windows.Forms.ComboBox();
            this.panelKiegek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKiegek)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKiegek
            // 
            this.buttonKiegek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.buttonKiegek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonKiegek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKiegek.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKiegek.ForeColor = System.Drawing.Color.White;
            this.buttonKiegek.Location = new System.Drawing.Point(17, 18);
            this.buttonKiegek.Name = "buttonKiegek";
            this.buttonKiegek.Size = new System.Drawing.Size(91, 32);
            this.buttonKiegek.TabIndex = 1;
            this.buttonKiegek.Text = "Kiegészítők";
            this.buttonKiegek.UseVisualStyleBackColor = false;
            this.buttonKiegek.Click += new System.EventHandler(this.buttonKiegek_Click);
            // 
            // panelKiegek
            // 
            this.panelKiegek.Controls.Add(this.dataGridViewKiegek);
            this.panelKiegek.Location = new System.Drawing.Point(17, 56);
            this.panelKiegek.Name = "panelKiegek";
            this.panelKiegek.Size = new System.Drawing.Size(676, 506);
            this.panelKiegek.TabIndex = 10;
            // 
            // dataGridViewKiegek
            // 
            this.dataGridViewKiegek.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKiegek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKiegek.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewKiegek.Name = "dataGridViewKiegek";
            this.dataGridViewKiegek.Size = new System.Drawing.Size(635, 252);
            this.dataGridViewKiegek.TabIndex = 5;
            // 
            // buttonKeres
            // 
            this.buttonKeres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.buttonKeres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonKeres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeres.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKeres.ForeColor = System.Drawing.Color.White;
            this.buttonKeres.Location = new System.Drawing.Point(462, 18);
            this.buttonKeres.Name = "buttonKeres";
            this.buttonKeres.Size = new System.Drawing.Size(91, 32);
            this.buttonKeres.TabIndex = 12;
            this.buttonKeres.Text = "Keres";
            this.buttonKeres.UseVisualStyleBackColor = false;
            // 
            // comboBoxTkiegFajtak
            // 
            this.comboBoxTkiegFajtak.FormattingEnabled = true;
            this.comboBoxTkiegFajtak.Location = new System.Drawing.Point(216, 25);
            this.comboBoxTkiegFajtak.Name = "comboBoxTkiegFajtak";
            this.comboBoxTkiegFajtak.Size = new System.Drawing.Size(220, 21);
            this.comboBoxTkiegFajtak.TabIndex = 6;
            // 
            // tkieg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxTkiegFajtak);
            this.Controls.Add(this.buttonKeres);
            this.Controls.Add(this.panelKiegek);
            this.Controls.Add(this.buttonKiegek);
            this.Name = "tkieg";
            this.Size = new System.Drawing.Size(727, 579);
            this.Load += new System.EventHandler(this.tkieg_Load);
            this.panelKiegek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKiegek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKiegek;
        private System.Windows.Forms.Panel panelKiegek;
        private System.Windows.Forms.DataGridView dataGridViewKiegek;
        private System.Windows.Forms.Button buttonKeres;
        private System.Windows.Forms.ComboBox comboBoxTkiegFajtak;
    }
}
