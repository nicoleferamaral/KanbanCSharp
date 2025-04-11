namespace GerenciadorDeTarefas
{
    partial class Filtrar
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
            this.button1 = new System.Windows.Forms.Button();
            this.Cadastro = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxFiltrarData = new System.Windows.Forms.CheckBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "◀️ Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cadastro
            // 
            this.Cadastro.AutoSize = true;
            this.Cadastro.BackColor = System.Drawing.Color.MidnightBlue;
            this.Cadastro.Font = new System.Drawing.Font("News706 BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cadastro.Location = new System.Drawing.Point(-26, 0);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(882, 57);
            this.Cadastro.TabIndex = 2;
            this.Cadastro.Text = "                         Filtrar                             ";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("NewsGoth BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(211, 189);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(505, 33);
            this.comboBoxStatus.TabIndex = 4;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // comboBoxPrioridade
            // 
            this.comboBoxPrioridade.Font = new System.Drawing.Font("NewsGoth BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrioridade.FormattingEnabled = true;
            this.comboBoxPrioridade.Location = new System.Drawing.Point(211, 265);
            this.comboBoxPrioridade.Name = "comboBoxPrioridade";
            this.comboBoxPrioridade.Size = new System.Drawing.Size(505, 33);
            this.comboBoxPrioridade.TabIndex = 5;
            this.comboBoxPrioridade.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrioridade_SelectedIndexChanged);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Font = new System.Drawing.Font("NewsGoth BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitulo.Location = new System.Drawing.Point(211, 120);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(505, 33);
            this.textBoxTitulo.TabIndex = 6;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBoxTitulo_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("NewsGoth BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(306, 345);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(410, 33);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBoxFiltrarData
            // 
            this.checkBoxFiltrarData.AutoSize = true;
            this.checkBoxFiltrarData.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFiltrarData.Location = new System.Drawing.Point(306, 404);
            this.checkBoxFiltrarData.Name = "checkBoxFiltrarData";
            this.checkBoxFiltrarData.Size = new System.Drawing.Size(221, 29);
            this.checkBoxFiltrarData.TabIndex = 8;
            this.checkBoxFiltrarData.Text = "Filtrar essa data ?";
            this.checkBoxFiltrarData.UseVisualStyleBackColor = true;
            this.checkBoxFiltrarData.CheckedChanged += new System.EventHandler(this.checkBoxFiltrarData_CheckedChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFiltrar.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFiltrar.Location = new System.Drawing.Point(295, 481);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(222, 46);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prioridade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data de vencimento";
            // 
            // Filtrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(787, 594);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.checkBoxFiltrarData);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.comboBoxPrioridade);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cadastro);
            this.Name = "Filtrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtrar";
            this.Load += new System.EventHandler(this.Filtrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxPrioridade;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxFiltrarData;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}