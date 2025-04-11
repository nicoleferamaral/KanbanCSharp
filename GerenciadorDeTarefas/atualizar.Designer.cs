namespace GerenciadorDeTarefas
{
    partial class atualizar
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
            this.botaoAtualizar = new System.Windows.Forms.Button();
            this.dataVencimento = new System.Windows.Forms.DateTimePicker();
            this.prioridade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Cadastro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoAtualizar
            // 
            this.botaoAtualizar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoAtualizar.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAtualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoAtualizar.Location = new System.Drawing.Point(264, 502);
            this.botaoAtualizar.Name = "botaoAtualizar";
            this.botaoAtualizar.Size = new System.Drawing.Size(261, 54);
            this.botaoAtualizar.TabIndex = 20;
            this.botaoAtualizar.Text = "Atualizar";
            this.botaoAtualizar.UseVisualStyleBackColor = false;
            this.botaoAtualizar.Click += new System.EventHandler(this.botaoAtualizar_Click);
            // 
            // dataVencimento
            // 
            this.dataVencimento.CalendarFont = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVencimento.Font = new System.Drawing.Font("NewsGoth BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVencimento.Location = new System.Drawing.Point(325, 357);
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.Size = new System.Drawing.Size(395, 30);
            this.dataVencimento.TabIndex = 30;
            this.dataVencimento.ValueChanged += new System.EventHandler(this.dataVencimento_ValueChanged);
            // 
            // prioridade
            // 
            this.prioridade.Font = new System.Drawing.Font("NewsGoth BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prioridade.FormattingEnabled = true;
            this.prioridade.Items.AddRange(new object[] {
            "Alta",
            "Baixa",
            "Média"});
            this.prioridade.Location = new System.Drawing.Point(325, 414);
            this.prioridade.Name = "prioridade";
            this.prioridade.Size = new System.Drawing.Size(395, 30);
            this.prioridade.TabIndex = 29;
            this.prioridade.Text = "Baixa";
            this.prioridade.SelectedIndexChanged += new System.EventHandler(this.prioridade_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Prioridade";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Data de vencimento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // descricao
            // 
            this.descricao.Font = new System.Drawing.Font("NewsGoth BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.Location = new System.Drawing.Point(188, 174);
            this.descricao.Multiline = true;
            this.descricao.Name = "descricao";
            this.descricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descricao.Size = new System.Drawing.Size(529, 148);
            this.descricao.TabIndex = 26;
            this.descricao.TextChanged += new System.EventHandler(this.descricao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // titulo
            // 
            this.titulo.Font = new System.Drawing.Font("NewsGoth BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(191, 108);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(529, 30);
            this.titulo.TabIndex = 24;
            this.titulo.TextChanged += new System.EventHandler(this.titulo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Título";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 40);
            this.button1.TabIndex = 22;
            this.button1.Text = "◀️ Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Cadastro
            // 
            this.Cadastro.AutoSize = true;
            this.Cadastro.BackColor = System.Drawing.Color.MidnightBlue;
            this.Cadastro.Font = new System.Drawing.Font("News706 BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cadastro.Location = new System.Drawing.Point(-34, 0);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(876, 57);
            this.Cadastro.TabIndex = 21;
            this.Cadastro.Text = "                         Atualizar                        ";
            // 
            // atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(787, 594);
            this.Controls.Add(this.dataVencimento);
            this.Controls.Add(this.prioridade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cadastro);
            this.Controls.Add(this.botaoAtualizar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "atualizar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "atualizar";
            this.Load += new System.EventHandler(this.atualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botaoAtualizar;
        private System.Windows.Forms.DateTimePicker dataVencimento;
        private System.Windows.Forms.ComboBox prioridade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Cadastro;
    }
}