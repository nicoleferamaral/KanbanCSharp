using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using static iText.Bouncycastleconnector.BouncyCastleFactoryCreator;

namespace GerenciadorDeTarefas
{
    public partial class FormRelatorio : Form
    {
        private List<Tarefa> tarefas;
        private ListView listViewRelatorio;
        private Button btnExportar;
        public FormRelatorio(List<Tarefa> tarefas)
        {
            InitializeComponent();
            this.tarefas = tarefas;
            this.Text = "📊 Relatório Estatístico";
            this.Size = new Size(800, 900);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Habilita o scroll automático
            this.AutoScroll = true;

            CarregarGraficos();
            CarregarRelatorio();

        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
        }
        private void CarregarGraficos()
        {
            Chart chartStatus = CriarGrafico("Tarefas por Status", DockStyle.Top, 250);
            Chart chartPrioridade = CriarGrafico("Tarefas por Prioridade", DockStyle.Top, 300);

            var porStatus = tarefas
                .GroupBy(t => t.Status.ToLower())
                .ToDictionary(g => g.Key, g => g.Count());

            foreach (var item in porStatus)
            {
                int ponto = chartStatus.Series[0].Points.AddXY(item.Key, item.Value);

                switch (item.Key)
                {
                    case "fazer":
                        chartStatus.Series[0].Points[ponto].Color = Color.LightBlue;
                        break;
                    case "fazendo":
                        chartStatus.Series[0].Points[ponto].Color = Color.DeepSkyBlue;
                        break;
                    case "finalizado":
                        chartStatus.Series[0].Points[ponto].Color = Color.DodgerBlue;
                        break;
                }
            }

            var porPrioridade = tarefas
                .GroupBy(t => t.Prioridade.ToLower())
                .ToDictionary(g => g.Key, g => g.Count());

            foreach (var item in porPrioridade)
            {
                int ponto = chartPrioridade.Series[0].Points.AddXY(item.Key, item.Value);

                switch (item.Key)
                {
                    case "alta":
                        chartPrioridade.Series[0].Points[ponto].Color = Color.Red;
                        break;
                    case "média":
                        chartPrioridade.Series[0].Points[ponto].Color = Color.Yellow;
                        break;
                    case "baixa":
                        chartPrioridade.Series[0].Points[ponto].Color = Color.Green;
                        break;
                }
            }

            chartStatus.Series[0].ChartType = SeriesChartType.Column;
            chartPrioridade.Series[0].ChartType = SeriesChartType.Pie;

            Controls.Add(chartPrioridade);
            Controls.Add(chartStatus);
        }

        private Chart CriarGrafico(string titulo, DockStyle dock, int altura = 300)
        {
            var chart = new Chart
            {
                Dock = dock,
                Height = altura,
                BackColor = Color.WhiteSmoke
            };

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series();
            chart.Series.Add(series);

            Title title = new Title
            {
                Text = titulo,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.DarkSlateGray,
                Docking = Docking.Top
            };

            chart.Titles.Add(title);

            return chart;
        }

        private void CarregarRelatorio()
        {
            listViewRelatorio = new ListView
            {
                View = View.Details,
                FullRowSelect = true,
                Width = this.ClientSize.Width - 40,
                Height = 200,
                Location = new Point(20, this.ClientSize.Height - 280),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            listViewRelatorio.Columns.Add("Título", 150);
            listViewRelatorio.Columns.Add("Prioridade", 100);
            listViewRelatorio.Columns.Add("Status", 100);
            listViewRelatorio.Columns.Add("Vencimento", 100);

            foreach (var tarefa in tarefas)
            {
                var item = new ListViewItem(tarefa.Titulo);
                item.SubItems.Add(tarefa.Prioridade);
                item.SubItems.Add(tarefa.Status);
                item.SubItems.Add(tarefa.DataVencimento.ToString("dd/MM/yyyy"));

                switch (tarefa.Prioridade.ToLower())
                {
                    case "alta":
                        item.BackColor = Color.Red;
                        break;
                    case "média":
                        item.BackColor = Color.Yellow;
                        break;
                    case "baixa":
                        item.BackColor = Color.LightGreen;
                        break;
                }

                listViewRelatorio.Items.Add(item);
            }

            Controls.Add(listViewRelatorio);

            btnExportar = new Button
            {
                Text = "📤 Exportar Relatório",
                Width = 180,
                Height = 40,
                Location = new Point(20, this.ClientSize.Height - 70),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };
            btnExportar.Click += BtnExportarPDF_Click;
            Controls.Add(btnExportar);
        }

        private void BtnExportarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Salvar Relatório em PDF",
                FileName = "relatorio_tarefas.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (PdfWriter writer = new PdfWriter(saveFileDialog.FileName))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document doc = new Document(pdf);
                        doc.Add(new Paragraph("📊 Relatório de Tarefas").SetFontSize(18).SetTextAlignment(TextAlignment.CENTER));
                        doc.Add(new Paragraph($"Data de geração: {DateTime.Now:dd/MM/yyyy HH:mm}\n\n"));

                        var porStatus = tarefas.GroupBy(t => t.Status)
                            .ToDictionary(g => g.Key, g => g.Count());

                        doc.Add(new Paragraph("Tarefas por Status:"));
                        foreach (var item in porStatus)
                            doc.Add(new Paragraph($"{item.Key}: {item.Value}"));

                        doc.Add(new Paragraph("\nTarefas por Prioridade:"));
                        var porPrioridade = tarefas.GroupBy(t => t.Prioridade)
                            .ToDictionary(g => g.Key, g => g.Count());

                        foreach (var item in porPrioridade)
                            doc.Add(new Paragraph($"{item.Key}: {item.Value}"));

                        doc.Add(new Paragraph("\nDetalhes das Tarefas:\n"));

                        Table table = new Table(4).UseAllAvailableWidth();
                        table.AddHeaderCell("Título");
                        table.AddHeaderCell("Prioridade");
                        table.AddHeaderCell("Status");
                        table.AddHeaderCell("Vencimento");

                        foreach (var tarefa in tarefas)
                        {
                            table.AddCell(tarefa.Titulo);
                            table.AddCell(tarefa.Prioridade);
                            table.AddCell(tarefa.Status);
                            table.AddCell(tarefa.DataVencimento.ToString("dd/MM/yyyy"));
                        }

                        doc.Add(table);
                        doc.Close();
                    }

                    MessageBox.Show("PDF exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


    }
}
