using System;

namespace Trabalhoc_
{
    partial class Telaconsulta
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
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rua = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.TextBox();
            this.bairro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numerocep = new System.Windows.Forms.TextBox();
            this.Consultar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(45, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "CEP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rua);
            this.groupBox1.Controls.Add(this.estado);
            this.groupBox1.Controls.Add(this.bairro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(53, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(557, 336);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // rua
            // 
            this.rua.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rua.Location = new System.Drawing.Point(118, 260);
            this.rua.Name = "rua";
            this.rua.Size = new System.Drawing.Size(439, 35);
            this.rua.TabIndex = 25;
            // 
            // estado
            // 
            this.estado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.estado.Location = new System.Drawing.Point(118, 92);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(439, 35);
            this.estado.TabIndex = 19;
            // 
            // bairro
            // 
            this.bairro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bairro.Location = new System.Drawing.Point(118, 208);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(439, 35);
            this.bairro.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Estado :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(27, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Rua :";
            // 
            // cidade
            // 
            this.cidade.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cidade.Location = new System.Drawing.Point(118, 150);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(439, 35);
            this.cidade.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(27, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Bairro :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(21, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cidade :";
            // 
            // numerocep
            // 
            this.numerocep.BackColor = System.Drawing.SystemColors.Info;
            this.numerocep.Location = new System.Drawing.Point(53, 59);
            this.numerocep.Name = "numerocep";
            this.numerocep.Size = new System.Drawing.Size(195, 29);
            this.numerocep.TabIndex = 19;
            // 
            // Consultar
            // 
            this.Consultar.BackgroundImage = global::Trabalhoc_.Properties.Resources.busca_cep;
            this.Consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Consultar.Location = new System.Drawing.Point(579, 15);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(207, 99);
            this.Consultar.TabIndex = 18;
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Limpar.Image = global::Trabalhoc_.Properties.Resources.atualizar__3_;
            this.Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Limpar.Location = new System.Drawing.Point(5, 471);
            this.Limpar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(323, 90);
            this.Limpar.TabIndex = 6;
            this.Limpar.Text = "limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Sair
            // 
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Sair.Image = global::Trabalhoc_.Properties.Resources.sair2;
            this.Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sair.Location = new System.Drawing.Point(502, 471);
            this.Sair.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(323, 90);
            this.Sair.TabIndex = 7;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Telaconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 604);
            this.Controls.Add(this.numerocep);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Sair);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "Telaconsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telaconsulta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Label label5;
        
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rua;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.TextBox numerocep;
    }
}