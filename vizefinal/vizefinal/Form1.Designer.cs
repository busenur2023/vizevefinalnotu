namespace vizefinal
{
    partial class Form1
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
            this.lblvize = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblvize
            // 
            this.lblvize.AutoSize = true;
            this.lblvize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblvize.Location = new System.Drawing.Point(26, 26);
            this.lblvize.Name = "lblvize";
            this.lblvize.Size = new System.Drawing.Size(47, 24);
            this.lblvize.TabIndex = 0;
            this.lblvize.Text = "vize";
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfinal.Location = new System.Drawing.Point(25, 62);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(48, 24);
            this.lblfinal.TabIndex = 1;
            this.lblfinal.Text = "final";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalama.Location = new System.Drawing.Point(26, 136);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(99, 24);
            this.lblOrtalama.TabIndex = 2;
            this.lblOrtalama.Text = "Ortalama;";
            // 
            // txtVize
            // 
            this.txtVize.BackColor = System.Drawing.Color.Gray;
            this.txtVize.Location = new System.Drawing.Point(98, 26);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(135, 20);
            this.txtVize.TabIndex = 3;
            // 
            // txtFinal
            // 
            this.txtFinal.BackColor = System.Drawing.Color.Gray;
            this.txtFinal.Location = new System.Drawing.Point(98, 67);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(135, 20);
            this.txtFinal.TabIndex = 4;
            // 
            // btnhesapla
            // 
            this.btnhesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnhesapla.Location = new System.Drawing.Point(239, 26);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(113, 71);
            this.btnhesapla.TabIndex = 5;
            this.btnhesapla.Text = "hesapla";
            this.btnhesapla.UseVisualStyleBackColor = false;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(26, 180);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(78, 24);
            this.lblDurum.TabIndex = 6;
            this.lblDurum.Text = "Durum;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 335);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblfinal);
            this.Controls.Add(this.lblvize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvize;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label lblDurum;
    }
}

