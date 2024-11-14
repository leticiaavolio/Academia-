namespace PrjAcademia
{
    partial class FormAtividade
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
            btnSalvar = new Button();
            label1 = new Label();
            btnMostrar = new Button();
            txtTempo = new TextBox();
            txtNome = new TextBox();
            label4 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(595, 542);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(266, 47);
            btnSalvar.TabIndex = 32;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic Medium", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(430, 42);
            label1.Name = "label1";
            label1.Size = new Size(342, 45);
            label1.TabIndex = 19;
            label1.Text = "Lista de Atividades";
            label1.Click += label1_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrar.Location = new Point(309, 542);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(266, 47);
            btnMostrar.TabIndex = 33;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtTempo
            // 
            txtTempo.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTempo.Location = new Point(638, 143);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(329, 38);
            txtTempo.TabIndex = 37;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(203, 143);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(335, 38);
            txtNome.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(638, 113);
            label4.Name = "label4";
            label4.Size = new Size(172, 27);
            label4.TabIndex = 35;
            label4.Text = "Tempo(em Min):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(203, 113);
            label2.Name = "label2";
            label2.Size = new Size(76, 27);
            label2.TabIndex = 34;
            label2.Text = "Nome:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(203, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(764, 308);
            dataGridView1.TabIndex = 38;
            // 
            // FormRoleta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 631);
            Controls.Add(dataGridView1);
            Controls.Add(txtTempo);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnMostrar);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Name = "FormRoleta";
            Text = "FormExercicios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Label label1;
        private Button btnMostrar;
        private TextBox txtTempo;
        private TextBox txtNome;
        private Label label4;
        private Label label2;
        private DataGridView dataGridView1;
    }
}