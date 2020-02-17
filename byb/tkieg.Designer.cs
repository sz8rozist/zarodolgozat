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
            this.dataGridViewKiegek = new System.Windows.Forms.DataGridView();
            this.textBoxKnev = new System.Windows.Forms.TextBox();
            this.textBoxKgyarto = new System.Windows.Forms.TextBox();
            this.textBoxKTipus = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUj = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKiegek)).BeginInit();
            this.panel1.SuspendLayout();
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
            // dataGridViewKiegek
            // 
            this.dataGridViewKiegek.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKiegek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKiegek.Location = new System.Drawing.Point(17, 65);
            this.dataGridViewKiegek.Name = "dataGridViewKiegek";
            this.dataGridViewKiegek.Size = new System.Drawing.Size(646, 333);
            this.dataGridViewKiegek.TabIndex = 5;
            // 
            // textBoxKnev
            // 
            this.textBoxKnev.Location = new System.Drawing.Point(47, 29);
            this.textBoxKnev.Name = "textBoxKnev";
            this.textBoxKnev.Size = new System.Drawing.Size(100, 20);
            this.textBoxKnev.TabIndex = 7;
            // 
            // textBoxKgyarto
            // 
            this.textBoxKgyarto.Location = new System.Drawing.Point(47, 140);
            this.textBoxKgyarto.Name = "textBoxKgyarto";
            this.textBoxKgyarto.Size = new System.Drawing.Size(100, 20);
            this.textBoxKgyarto.TabIndex = 11;
            // 
            // textBoxKTipus
            // 
            this.textBoxKTipus.Location = new System.Drawing.Point(47, 82);
            this.textBoxKTipus.Name = "textBoxKTipus";
            this.textBoxKTipus.Size = new System.Drawing.Size(100, 20);
            this.textBoxKTipus.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.textBoxKnev);
            this.panel1.Controls.Add(this.textBoxKTipus);
            this.panel1.Controls.Add(this.textBoxKgyarto);
            this.panel1.Location = new System.Drawing.Point(682, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 333);
            this.panel1.TabIndex = 14;
            // 
            // buttonUj
            // 
            this.buttonUj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.buttonUj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUj.ForeColor = System.Drawing.Color.White;
            this.buttonUj.Location = new System.Drawing.Point(133, 18);
            this.buttonUj.Name = "buttonUj";
            this.buttonUj.Size = new System.Drawing.Size(91, 32);
            this.buttonUj.TabIndex = 15;
            this.buttonUj.Text = "Új";
            this.buttonUj.UseVisualStyleBackColor = false;
            this.buttonUj.Click += new System.EventHandler(this.buttonUj_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(14, 220);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 32);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Mentés";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tkieg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewKiegek);
            this.Controls.Add(this.buttonKiegek);
            this.Name = "tkieg";
            this.Size = new System.Drawing.Size(940, 495);
            this.Load += new System.EventHandler(this.tkieg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKiegek)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKiegek;
        private System.Windows.Forms.DataGridView dataGridViewKiegek;
        private System.Windows.Forms.TextBox textBoxKnev;
        private System.Windows.Forms.TextBox textBoxKgyarto;
        private System.Windows.Forms.TextBox textBoxKTipus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUj;
        private System.Windows.Forms.Button buttonSave;
    }
}
