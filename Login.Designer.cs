namespace Trabalhoc_
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabelcadastro = new System.Windows.Forms.LinkLabel();
            this.campoemail = new System.Windows.Forms.TextBox();
            this.camposenha = new System.Windows.Forms.TextBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(46, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira seu email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(46, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insira sua senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(159, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seja bem vindo ao consulta de CEP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(228, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Efetue login para prosseguir";
            // 
            // linkLabelcadastro
            // 
            this.linkLabelcadastro.AutoSize = true;
            this.linkLabelcadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.linkLabelcadastro.Location = new System.Drawing.Point(268, 377);
            this.linkLabelcadastro.Name = "linkLabelcadastro";
            this.linkLabelcadastro.Size = new System.Drawing.Size(214, 29);
            this.linkLabelcadastro.TabIndex = 4;
            this.linkLabelcadastro.TabStop = true;
            this.linkLabelcadastro.Text = "Não tem cadastro?";
            this.linkLabelcadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelcadastro_LinkClicked);
            // 
            // campoemail
            // 
            this.campoemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.campoemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.campoemail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.campoemail.Location = new System.Drawing.Point(297, 160);
            this.campoemail.Name = "campoemail";
            this.campoemail.Size = new System.Drawing.Size(278, 38);
            this.campoemail.TabIndex = 5;
            this.campoemail.HideSelectionChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.campoemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // camposenha
            // 
            this.camposenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.camposenha.Location = new System.Drawing.Point(297, 257);
            this.camposenha.Name = "camposenha";
            this.camposenha.PasswordChar = '*';
            this.camposenha.Size = new System.Drawing.Size(278, 38);
            this.camposenha.TabIndex = 6;
            this.camposenha.TextChanged += new System.EventHandler(this.camposenha_TextChanged);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonEntrar.Location = new System.Drawing.Point(311, 319);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(122, 40);
            this.buttonEntrar.TabIndex = 7;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.ButtonEntrar);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Trabalhoc_.Properties.Resources.Captura_de_tela_2023_11_12_004600;
            this.pictureBox2.Location = new System.Drawing.Point(726, 89);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalhoc_.Properties.Resources.Captura_de_tela_2023_11_12_004111;
            this.pictureBox1.Location = new System.Drawing.Point(632, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.camposenha);
            this.Controls.Add(this.campoemail);
            this.Controls.Add(this.linkLabelcadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabelcadastro;
        private System.Windows.Forms.TextBox campoemail;
        private System.Windows.Forms.TextBox camposenha;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

