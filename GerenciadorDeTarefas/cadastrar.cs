using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace GerenciadorDeTarefas
{
    public partial class cadastrar : Form
    {
        public cadastrar()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove a borda padrão
            this.StartPosition = FormStartPosition.CenterParent; // Centraliza
            this.BackColor = Color.AliceBlue; // Cor de fundo

            this.ShowInTaskbar = false; // Oculta da barra de tarefas
            this.TopMost = true; // Mantém sobre os outros

            this.Padding = new Padding(2); // Espaço para a borda
            this.Resize += (s, e) => ArredondarJanela(); // Atualiza região ao redimensionar

        }






        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Desenha a borda preta
            using (Pen borda = new Pen(Color.Black, 2))
            {
                int raio = 40;
                GraphicsPath path = new GraphicsPath();
                path.StartFigure();
                path.AddArc(0, 0, raio, raio, 180, 90);
                path.AddArc(this.Width - raio, 0, raio, raio, 270, 90);
                path.AddArc(this.Width - raio, this.Height - raio, raio, raio, 0, 90);
                path.AddArc(0, this.Height - raio, raio, raio, 90, 90);
                path.CloseAllFigures();

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(borda, path);
            }

        }


        private void ArredondarJanela()
        {
            int raio = 40;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(this.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(this.Width - raio, this.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, this.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
            this.Invalidate(); // Redesenha o formulário
        }

        private void cadastrar_Load(object sender, EventArgs e)
        {
            ArredondarBotao(button1, 40);
            ArredondarBotao(botaoCadastrar, 50);
            ConfigurarBotao(botaoCadastrar);
            ConfigurarBotaoSair(button1);


        }

        //  ===================================     Aparencias do form     ================================================


        private void ArredondarBotao(Button botao, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(botao.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(botao.Width - raio, botao.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, botao.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            botao.Region = new Region(path);
        } // Fim 
      

        private void ConfigurarBotao(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat; // Deixa o botão sem borda elevada
            btn.FlatAppearance.BorderSize = 0; // Remove a borda
            btn.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue; // Azul claro ao passar o mouse
            btn.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue; // Azul mais escuro ao clicar
        }

        private void ConfigurarBotaoSair(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat; // Deixa o botão sem borda elevada
            btn.FlatAppearance.BorderSize = 0; // Remove a borda
            btn.FlatAppearance.MouseOverBackColor = Color.LightCoral; // Azul claro ao passar o mouse
            btn.FlatAppearance.MouseDownBackColor = Color.Red; // Azul mais escuro ao clicar
        }

        // ==========================================  BACK ==========================================================

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tituloF = titulo.Text;
            var descricaoF = descricao.Text;
            var dataVencimentoF = DateTime.Parse(dataVencimento.Text);
            var prioridadeF = prioridade.Text;

            var DAO = new DAO();

            DAO.Inserir(tituloF, descricaoF, dataVencimentoF, prioridadeF, "fazer");

            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void titulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataVencimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void prioridade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Click(object sender, EventArgs e)
        {

        }
    }
}
