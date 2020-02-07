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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonEtelek = new System.Windows.Forms.Button();
            this.dataGridViewEtelek = new System.Windows.Forms.DataGridView();
            this.listViewEtkezesek = new System.Windows.Forms.ListView();
            this.buttonEtkezesek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtelek)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEtelek
            // 
            this.buttonEtelek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(12)))));
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
            this.dataGridViewEtelek.Location = new System.Drawing.Point(83, 84);
            this.dataGridViewEtelek.Name = "dataGridViewEtelek";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.dataGridViewEtelek.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewEtelek.Size = new System.Drawing.Size(593, 283);
            this.dataGridViewEtelek.TabIndex = 1;
            // 
            // listViewEtkezesek
            // 
            this.listViewEtkezesek.HideSelection = false;
            this.listViewEtkezesek.Location = new System.Drawing.Point(83, 84);
            this.listViewEtkezesek.Name = "listViewEtkezesek";
            this.listViewEtkezesek.Size = new System.Drawing.Size(593, 283);
            this.listViewEtkezesek.TabIndex = 2;
            this.listViewEtkezesek.UseCompatibleStateImageBehavior = false;
            // 
            // buttonEtkezesek
            // 
            this.buttonEtkezesek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(12)))));
            this.buttonEtkezesek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEtkezesek.FlatAppearance.BorderSize = 0;
            this.buttonEtkezesek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEtkezesek.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEtkezesek.ForeColor = System.Drawing.Color.White;
            this.buttonEtkezesek.Location = new System.Drawing.Point(658, 14);
            this.buttonEtkezesek.Name = "buttonEtkezesek";
            this.buttonEtkezesek.Size = new System.Drawing.Size(84, 32);
            this.buttonEtkezesek.TabIndex = 3;
            this.buttonEtkezesek.Text = "Étkezések";
            this.buttonEtkezesek.UseVisualStyleBackColor = false;
            this.buttonEtkezesek.Click += new System.EventHandler(this.buttonEtkezesek_Click);
            // 
            // Etrend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.buttonEtkezesek);
            this.Controls.Add(this.listViewEtkezesek);
            this.Controls.Add(this.dataGridViewEtelek);
            this.Controls.Add(this.buttonEtelek);
            this.Name = "Etrend";
            this.Size = new System.Drawing.Size(777, 525);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtelek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEtelek;
        private System.Windows.Forms.DataGridView dataGridViewEtelek;
        private System.Windows.Forms.ListView listViewEtkezesek;
        private System.Windows.Forms.Button buttonEtkezesek;
    }
}
