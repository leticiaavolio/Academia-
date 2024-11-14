using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;

namespace PrjAcademia
{
    public partial class FormCadCliente : Form
    {
        string connectionString = "Server=localhost;DATABASE=tbacademia; UID=root; PASSWORD='';";
        public FormCadCliente()
        {
            InitializeComponent();
        }

        private void FormCadCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            DateOnly nascimento = DateOnly.FromDateTime(dtpNasc.Value);
            DateTime matricula = DateTime.Now;
            string email = txtEmail.Text;
            string telefone = mtbTele.Text;
            string endereco = txtEnde.Text;
            decimal peso;
            decimal altura;
            if (!decimal.TryParse(txtPeso.Text, out peso) || !decimal.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Peso e altura devem ser números válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            altura /= 100;

            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(telefone) && !string.IsNullOrEmpty(endereco))
            {
                decimal imc = CalcularIMC(peso, altura);

                SalvarDados(nome, nascimento, matricula, email, telefone, endereco, peso, altura, imc);
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nudAltura_ValueChanged(object sender, EventArgs e)
        {

        }
        private void SalvarDados(string nome, DateOnly nascimento, DateTime matricula, string email, string telefone, string endereco, decimal peso, decimal altura, decimal imc)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO cadaluno(nome, dataNascimento, endereco, telefone, email, dataMatricula, peso, altura, imc) VALUES (@nome, @nascimento, @endereco, @telefone, @email, @matricula, @peso, @altura, @imc)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@nascimento", nascimento.ToDateTime(new TimeOnly(0, 0)));
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@matricula", matricula);
                        cmd.Parameters.AddWithValue("@peso", peso);
                        cmd.Parameters.AddWithValue("@altura", altura *100);
                        cmd.Parameters.AddWithValue("@imc", imc);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show($"Dados Cadastrados com sucesso!\n IMC: {imc:N2};\n Classificação: {IMCTipos(imc)}", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtEnde.Text = "";
                txtEmail.Text = "";
                dtpNasc.Value = DateTime.Today;
                txtAltura.Text = "";
                txtPeso.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal CalcularIMC(decimal peso, decimal altura)
        {
            if (altura > 0)
            {
                return peso / (altura * altura);
            }
            else
            {
                MessageBox.Show("Altura deve ser maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private string IMCTipos(decimal imc)
        {
            if (imc <= 18.5m)
            {
                return "Abaixo do Ideal";
            }
            else if (imc <= 24.9m)
            {
                return "Ideal";
            }
            else if (imc <= 29.9m)
            {
                return "Sobrepeso";
            }
            else if (imc <= 34.9m)
            {
                return "Obesidade Grau I";
            }
            else if (imc <= 39.9m)
            {
                return "Obesidade Grau II";
            }
            else // Caso imc > 40
            {
                return "Obesidade Grau III";
            }
        }
    }
}
