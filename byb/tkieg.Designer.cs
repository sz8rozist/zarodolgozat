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
            this.buttonUj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            // buttonUj
            // 
            this.buttonUj.Location = new System.Drawing.Point(47, 230);
            this.buttonUj.Name = "buttonUj";
            this.buttonUj.Size = new System.Drawing.Size(75, 23);
            this.buttonUj.TabIndex = 13;
            this.buttonUj.Text = "Mentés";
            this.buttonUj.UseVisualStyleBackColor = true;
            this.buttonUj.Click += new System.EventHandler(this.buttonUj_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxKnev);
            this.panel1.Controls.Add(this.buttonUj);
            this.panel1.Controls.Add(this.textBoxKTipus);
            this.panel1.Controls.Add(this.textBoxKgyarto);
            this.panel1.Location = new System.Drawing.Point(682, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 333);
            this.panel1.TabIndex = 14;
            // 
            // tkieg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.Button buttonUj;
        private System.Windows.Forms.Panel panel1;
    }
}
