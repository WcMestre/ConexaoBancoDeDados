using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConexaoBancoDeDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conexaoNova = new SqlConnection("Server=179.108.180.209;Database=SistemaWendel;User Id=sa;Password=senac123;");
            conexaoNova.Open();

            //criando o select e o objeto de consulta
            string sql = "SELECT * FROM Clientes";
            SqlCommand cmd = new SqlCommand(sql, conexaoNova);
            cmd.Connection = conexaoNova;
            cmd.CommandText = sql;

            // cria o dataadapter...
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // preenche o dataset...
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dtview.DataSource = dataSet;
            dtview.DataMember = dataSet.Tables[0].TableName;
         
            conexaoNova.Close();            
        }

        private void dtview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Clientes (nome,cpf)" + "VALUES ('" + txtnome.Text + "', '" + txtcpf.Text + "')";

            SqlConnection conexaoNova = new SqlConnection("Server=179.108.180.209;Database=SistemaWendel;User Id=sa;Password=senac123;");
            SqlCommand comando = new SqlCommand(sql, conexaoNova);
            comando.CommandType = CommandType.Text;
            conexaoNova.Open();
            comando.ExecuteNonQuery();
            conexaoNova.Close();
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            SqlConnection conexaoNova = new SqlConnection("Server=179.108.180.209;Database=SistemaWendel;User Id=sa;Password=senac123;");
            conexaoNova.Open();

            //criando o select e o objeto de consulta
            string sql = "SELECT * FROM Clientes";
            SqlCommand cmd = new SqlCommand(sql, conexaoNova);
            cmd.Connection = conexaoNova;
            cmd.CommandText = sql;

            // cria o dataadapter...
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // preenche o dataset...
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dtview.DataSource = dataSet;
            dtview.DataMember = dataSet.Tables[0].TableName;

            conexaoNova.Close();
        }
    }
}
