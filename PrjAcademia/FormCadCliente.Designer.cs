namespace PrjAcademia
{
    partial class FormCadCliente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtEnde = new TextBox();
            mtbTele = new MaskedTextBox();
            dtpNasc = new DateTimePicker();
            button1 = new Button();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic Medium", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(410, 28);
            label1.Name = "label1";
            label1.Size = new Size(355, 45);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(93, 141);
            label2.Name = "label2";
            label2.Size = new Size(76, 27);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(93, 238);
            label3.Name = "label3";
            label3.Size = new Size(218, 27);
            label3.TabIndex = 2;
            label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(593, 141);
            label4.Name = "label4";
            label4.Size = new Size(110, 27);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(93, 432);
            label5.Name = "label5";
            label5.Size = new Size(102, 27);
            label5.TabIndex = 4;
            label5.Text = "Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(93, 335);
            label6.Name = "label6";
            label6.Size = new Size(82, 27);
            label6.TabIndex = 5;
            label6.Text = "E-mail:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(593, 238);
            label8.Name = "label8";
            label8.Size = new Size(110, 27);
            label8.TabIndex = 7;
            label8.Text = "Peso(Kg):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(593, 335);
            label9.Name = "label9";
            label9.Size = new Size(125, 27);
            label9.TabIndex = 8;
            label9.Text = "Altura(Cm):";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(175, 140);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(335, 38);
            txtNome.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(181, 334);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(329, 38);
            txtEmail.TabIndex = 10;
            // 
            // txtEnde
            // 
            txtEnde.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnde.Location = new Point(709, 140);
            txtEnde.Name = "txtEnde";
            txtEnde.Size = new Size(329, 38);
            txtEnde.TabIndex = 11;
            // 
            // mtbTele
            // 
            mtbTele.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtbTele.Location = new Point(201, 431);
            mtbTele.Name = "mtbTele";
            mtbTele.Size = new Size(309, 38);
            mtbTele.TabIndex = 12;
            // 
            // dtpNasc
            // 
            dtpNasc.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNasc.Location = new Point(317, 231);
            dtpNasc.Name = "dtpNasc";
            dtpNasc.Size = new Size(193, 38);
            dtpNasc.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(410, 528);
            button1.Name = "button1";
            button1.Size = new Size(355, 47);
            button1.TabIndex = 16;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltura.Location = new Point(724, 334);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(314, 38);
            txtAltura.TabIndex = 17;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPeso.Location = new Point(709, 231);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(329, 38);
            txtPeso.TabIndex = 18;
            // 
            // FormCadCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 649);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(button1);
            Controls.Add(dtpNasc);
            Controls.Add(mtbTele);
            Controls.Add(txtEnde);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCadCliente";
            Text = "FormCadCliente";
            Load += FormCadCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtEnde;
        private MaskedTextBox mtbTele;
        private DateTimePicker dtpNasc;
        private Button button1;
        private TextBox txtAltura;
        private TextBox txtPeso;
    }
}