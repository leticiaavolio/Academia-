using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PrjAcademia.FormAtividade;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PrjAcademia
{
    public partial class FormAtividade : Form
    {
        string connectionString = "Server=localhost;DATABASE=tbacademia; UID=root; PASSWORD='';";
        public FormAtividade()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string tempo = txtTempo.Text;

            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(tempo))
            {
                SalvarDados(nome, tempo);
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
        private void SalvarDados(string nome,string tempo)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO tbatividade(nome, tempo) VALUES (@nome, @tempo)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@tempo", tempo);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show($"Dados Cadastrados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtTempo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarDados()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM tbatividade";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar os dados:" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
