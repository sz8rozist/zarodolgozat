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
            // dataGridViewKiegek
            // 
            this.dataGridViewKiegek.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKiegek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKiegek.Location = new System.Drawing.Point(102, 72);
            this.dataGridViewKiegek.Name = "dataGridViewKiegek";
            this.dataGridViewKiegek.Size = new System.Drawing.Size(706, 333);
            this.dataGridViewKiegek.TabIndex = 5;
            // 
            // tkieg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewKiegek);
            this.Controls.Add(this.buttonKiegek);
            this.Name = "tkieg";
            this.Size = new System.Drawing.Size(940, 495);
            this.Load += new System.EventHandler(this.tkieg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKiegek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKiegek;
        private System.Windows.Forms.DataGridView dataGridViewKiegek;
    }
}
