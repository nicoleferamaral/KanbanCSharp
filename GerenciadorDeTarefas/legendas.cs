using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTarefas
{
    public partial class legendas : Form
    {
        public legendas()
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

        private void legendas_Load(object sender, EventArgs e)
        {
            ArredondarBotao(button1, 40);
          
            ConfigurarBotaoSair(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConfigurarBotaoSair(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat; // Deixa o botão sem borda elevada
            btn.FlatAppearance.BorderSize = 0; // Remove a borda
            btn.FlatAppearance.MouseOverBackColor = Color.LightCoral; // Azul claro ao passar o mouse
            btn.FlatAppearance.MouseDownBackColor = Color.Red; // Azul mais escuro ao clicar
        }
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
    }
}
