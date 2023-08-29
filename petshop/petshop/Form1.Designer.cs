namespace petshop
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
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnAgendamento = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnRaca = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.PanelTop.SuspendLayout();
            this.PanelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PanelTop.Controls.Add(this.btnMinimize);
            this.PanelTop.Controls.Add(this.btnMaximize);
            this.PanelTop.Controls.Add(this.btnSair);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1106, 55);
            this.PanelTop.TabIndex = 1;
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelLateral.Controls.Add(this.btnInicio);
            this.PanelLateral.Controls.Add(this.btnRaca);
            this.PanelLateral.Controls.Add(this.btnAnimal);
            this.PanelLateral.Controls.Add(this.btnAgendamento);
            this.PanelLateral.Controls.Add(this.btnServicos);
            this.PanelLateral.Controls.Add(this.btnCliente);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 55);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(200, 388);
            this.PanelLateral.TabIndex = 2;
            // 
            // btnCliente
            // 
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(6, 62);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(10, 13, 1, 3);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(190, 50);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.Location = new System.Drawing.Point(6, 260);
            this.btnServicos.Margin = new System.Windows.Forms.Padding(10, 13, 1, 3);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(190, 50);
            this.btnServicos.TabIndex = 1;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.UseVisualStyleBackColor = true;
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamento.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamento.Location = new System.Drawing.Point(6, 326);
            this.btnAgendamento.Margin = new System.Windows.Forms.Padding(10, 13, 1, 3);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Size = new System.Drawing.Size(190, 50);
            this.btnAgendamento.TabIndex = 2;
            this.btnAgendamento.Text = "Agendamento";
            this.btnAgendamento.UseVisualStyleBackColor = true;
            // 
            // btnAnimal
            // 
            this.btnAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimal.Location = new System.Drawing.Point(6, 194);
            this.btnAnimal.Margin = new System.Windows.Forms.Padding(10, 13, 1, 3);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(190, 50);
            this.btnAnimal.TabIndex = 3;
            this.btnAnimal.Text = "Animal";
            this.btnAnimal.UseVisualStyleBackColor = true;
            // 
            // btnRaca
            // 
            this.btnRaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaca.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaca.Location = new System.Drawing.Point(6, 128);
            this.btnRaca.Margin = new System.Windows.Forms.Padding(10, 13, 1, 3);
            this.btnRaca.Name = "btnRaca";
            this.btnRaca.Size = new System.Drawing.Size(190, 50);
            this.btnRaca.TabIndex = 4;
            this.btnRaca.Text = "Raça";
            this.btnRaca.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(6, 0);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(10, 13, 1, 3);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(190, 50);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.PanelCentral.BackgroundImage = global::petshop.Properties.Resources._17344_cachorro_de_oculos_meme_do_doge_ja_foi_articles_media_desktop_2;
            this.PanelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(200, 55);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(906, 388);
            this.PanelCentral.TabIndex = 3;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::petshop.Properties.Resources.minimize_removebg_preview;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(953, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 37);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackgroundImage = global::petshop.Properties.Resources.maximize_removebg_preview;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(1002, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(43, 37);
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::petshop.Properties.Resources.close_removebg_preview;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(1051, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(43, 37);
            this.btnSair.TabIndex = 5;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 443);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.PanelLateral);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnRaca;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnAgendamento;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel PanelCentral;
    }
}

