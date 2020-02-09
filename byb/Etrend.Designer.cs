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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonEtelek = new System.Windows.Forms.Button();
            this.dataGridViewEtelek = new System.Windows.Forms.DataGridView();
            this.buttonEtkezesek = new System.Windows.Forms.Button();
            this.panelEtelek = new System.Windows.Forms.Panel();
            this.buttonTorolEtel = new System.Windows.Forms.Button();
            this.errorProviderEtelTorles = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewEtkezesek = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtelek)).BeginInit();
            this.panelEtelek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEtelTorles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtkezesek)).BeginInit();
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
            this.dataGridViewEtelek.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEtelek.Name = "dataGridViewEtelek";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.dataGridViewEtelek.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEtelek.Size = new System.Drawing.Size(593, 283);
            this.dataGridViewEtelek.TabIndex = 1;
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
            // panelEtelek
            // 
            this.panelEtelek.Controls.Add(this.buttonTorolEtel);
            this.panelEtelek.Controls.Add(this.dataGridViewEtelek);
            this.panelEtelek.Location = new System.Drawing.Point(16, 69);
            this.panelEtelek.Name = "panelEtelek";
            this.panelEtelek.Size = new System.Drawing.Size(709, 344);
            this.panelEtelek.TabIndex = 4;
            // 
            // buttonTorolEtel
            // 
            this.buttonTorolEtel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(12)))));
            this.buttonTorolEtel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTorolEtel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTorolEtel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTorolEtel.ForeColor = System.Drawing.Color.White;
            this.buttonTorolEtel.Location = new System.Drawing.Point(12, 305);
            this.buttonTorolEtel.Name = "buttonTorolEtel";
            this.buttonTorolEtel.Size = new System.Drawing.Size(84, 32);
            this.buttonTorolEtel.TabIndex = 5;
            this.buttonTorolEtel.Text = "Törlés";
            this.buttonTorolEtel.UseVisualStyleBackColor = false;
            this.buttonTorolEtel.Click += new System.EventHandler(this.buttonTorolEtel_Click);
            // 
            // errorProviderEtelTorles
            // 
            this.errorProviderEtelTorles.ContainerControl = this;
            // 
            // dataGridViewEtkezesek
            // 
            this.dataGridViewEtkezesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEtkezesek.Location = new System.Drawing.Point(78, 372);
            this.dataGridViewEtkezesek.Name = "dataGridViewEtkezesek";
            this.dataGridViewEtkezesek.Size = new System.Drawing.Size(591, 150);
            this.dataGridViewEtkezesek.TabIndex = 5;
            // 
            // Etrend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dataGridViewEtkezesek);
            this.Controls.Add(this.panelEtelek);
            this.Controls.Add(this.buttonEtkezesek);
            this.Controls.Add(this.buttonEtelek);
            this.Name = "Etrend";
            this.Size = new System.Drawing.Size(777, 525);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtelek)).EndInit();
            this.panelEtelek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEtelTorles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtkezesek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEtelek;
        private System.Windows.Forms.DataGridView dataGridViewEtelek;
        private System.Windows.Forms.Button buttonEtkezesek;
        private System.Windows.Forms.Panel panelEtelek;
        private System.Windows.Forms.Button buttonTorolEtel;
        private System.Windows.Forms.ErrorProvider errorProviderEtelTorles;
        private System.Windows.Forms.DataGridView dataGridViewEtkezesek;
    }
}
