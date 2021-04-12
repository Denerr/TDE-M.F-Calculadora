
namespace TDE_M.F_Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnJuros = new System.Windows.Forms.Button();
            this.btnCapital = new System.Windows.Forms.Button();
            this.btnTaxa = new System.Windows.Forms.Button();
            this.btnTempo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnClose.Location = new System.Drawing.Point(698, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 48);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnJuros
            // 
            this.btnJuros.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnJuros.FlatAppearance.BorderSize = 2;
            this.btnJuros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuros.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuros.ForeColor = System.Drawing.Color.White;
            this.btnJuros.Location = new System.Drawing.Point(47, 207);
            this.btnJuros.Name = "btnJuros";
            this.btnJuros.Size = new System.Drawing.Size(293, 69);
            this.btnJuros.TabIndex = 1;
            this.btnJuros.Text = "Juros";
            this.btnJuros.UseVisualStyleBackColor = true;
            this.btnJuros.MouseEnter += new System.EventHandler(this.btnJuros_MouseEnter);
            this.btnJuros.MouseLeave += new System.EventHandler(this.btnJuros_MouseLeave);
            // 
            // btnCapital
            // 
            this.btnCapital.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCapital.FlatAppearance.BorderSize = 2;
            this.btnCapital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapital.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapital.ForeColor = System.Drawing.Color.White;
            this.btnCapital.Location = new System.Drawing.Point(443, 207);
            this.btnCapital.Name = "btnCapital";
            this.btnCapital.Size = new System.Drawing.Size(293, 69);
            this.btnCapital.TabIndex = 2;
            this.btnCapital.Text = "Capital";
            this.btnCapital.UseVisualStyleBackColor = true;
            this.btnCapital.MouseEnter += new System.EventHandler(this.btnCapital_MouseEnter);
            this.btnCapital.MouseLeave += new System.EventHandler(this.btnCapital_MouseLeave);
            // 
            // btnTaxa
            // 
            this.btnTaxa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTaxa.FlatAppearance.BorderSize = 2;
            this.btnTaxa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaxa.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaxa.ForeColor = System.Drawing.Color.White;
            this.btnTaxa.Location = new System.Drawing.Point(47, 326);
            this.btnTaxa.Name = "btnTaxa";
            this.btnTaxa.Size = new System.Drawing.Size(293, 69);
            this.btnTaxa.TabIndex = 3;
            this.btnTaxa.Text = "Taxa Unitária";
            this.btnTaxa.UseVisualStyleBackColor = true;
            this.btnTaxa.MouseEnter += new System.EventHandler(this.btnTaxa_MouseEnter);
            this.btnTaxa.MouseLeave += new System.EventHandler(this.btnTaxa_MouseLeave);
            // 
            // btnTempo
            // 
            this.btnTempo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTempo.FlatAppearance.BorderSize = 2;
            this.btnTempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTempo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempo.ForeColor = System.Drawing.Color.White;
            this.btnTempo.Location = new System.Drawing.Point(443, 326);
            this.btnTempo.Name = "btnTempo";
            this.btnTempo.Size = new System.Drawing.Size(293, 69);
            this.btnTempo.TabIndex = 4;
            this.btnTempo.Text = "Periodo de Tempo";
            this.btnTempo.UseVisualStyleBackColor = true;
            this.btnTempo.MouseEnter += new System.EventHandler(this.btnTempo_MouseEnter);
            this.btnTempo.MouseLeave += new System.EventHandler(this.btnTempo_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTempo);
            this.Controls.Add(this.btnTaxa);
            this.Controls.Add(this.btnCapital);
            this.Controls.Add(this.btnJuros);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnJuros;
        private System.Windows.Forms.Button btnCapital;
        private System.Windows.Forms.Button btnTaxa;
        private System.Windows.Forms.Button btnTempo;
    }
}

