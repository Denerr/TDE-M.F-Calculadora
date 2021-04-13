
namespace TDE_M.F_Calculadora
{
    partial class Form4
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblJuros = new System.Windows.Forms.Label();
            this.lblCapital = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnPercent = new System.Windows.Forms.Button();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtResultado.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtResultado.Location = new System.Drawing.Point(270, 100);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(202, 34);
            this.txtResultado.TabIndex = 3;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnResultado
            // 
            this.btnResultado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnResultado.FlatAppearance.BorderSize = 2;
            this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultado.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnResultado.ForeColor = System.Drawing.Color.White;
            this.btnResultado.Location = new System.Drawing.Point(270, 172);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(114, 42);
            this.btnResultado.TabIndex = 4;
            this.btnResultado.Text = "Resolver";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            this.btnResultado.MouseEnter += new System.EventHandler(this.btnResultado_MouseEnter);
            this.btnResultado.MouseLeave += new System.EventHandler(this.btnResultado_MouseLeave);
            // 
            // lblJuros
            // 
            this.lblJuros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblJuros.AutoSize = true;
            this.lblJuros.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuros.ForeColor = System.Drawing.Color.White;
            this.lblJuros.Location = new System.Drawing.Point(33, 26);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(63, 27);
            this.lblJuros.TabIndex = 5;
            this.lblJuros.Text = "Juros";
            // 
            // lblCapital
            // 
            this.lblCapital.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCapital.AutoSize = true;
            this.lblCapital.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapital.ForeColor = System.Drawing.Color.White;
            this.lblCapital.Location = new System.Drawing.Point(32, 100);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(75, 27);
            this.lblCapital.TabIndex = 6;
            this.lblCapital.Text = "Capital";
            // 
            // lblTempo
            // 
            this.lblTempo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.White;
            this.lblTempo.Location = new System.Drawing.Point(33, 174);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(71, 27);
            this.lblTempo.TabIndex = 7;
            this.lblTempo.Text = "Tempo";
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(319, 49);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(100, 27);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // btnPercent
            // 
            this.btnPercent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPercent.FlatAppearance.BorderSize = 2;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercent.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPercent.ForeColor = System.Drawing.Color.White;
            this.btnPercent.Location = new System.Drawing.Point(415, 172);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(57, 42);
            this.btnPercent.TabIndex = 9;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            this.btnPercent.MouseEnter += new System.EventHandler(this.btnPercent_MouseEnter);
            this.btnPercent.MouseLeave += new System.EventHandler(this.btnPercent_MouseLeave);
            // 
            // txtJuros
            // 
            this.txtJuros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtJuros.Location = new System.Drawing.Point(38, 56);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(167, 20);
            this.txtJuros.TabIndex = 0;
            // 
            // txtCapital
            // 
            this.txtCapital.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCapital.Location = new System.Drawing.Point(37, 130);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(167, 20);
            this.txtCapital.TabIndex = 1;
            // 
            // txtTempo
            // 
            this.txtTempo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTempo.Location = new System.Drawing.Point(37, 204);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(167, 20);
            this.txtTempo.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(535, 288);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblCapital);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.txtJuros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form4";
            this.Text = "Calculo de Taxa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtTempo;
    }
}