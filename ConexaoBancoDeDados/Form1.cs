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
            SqlConnection sqlConnection1 = new SqlConnection("Server=179.108.180.209;Database=wendel;User Id=sa;Password=senac123;");
            
            sqlConnection1.Open();

            //criando o select e o objeto de consulta
            string sql = "SELECT * FROM CIDADES";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection1);
            cmd.Connection = sqlConnection1;
            cmd.CommandText = sql;

            // cria o dataadapter...
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // preenche o dataset...
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dtview.DataSource = dataSet;
            dtview.DataMember = dataSet.Tables[0].TableName;
         
            sqlConnection1.Close();            
        }

        private void dtview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
