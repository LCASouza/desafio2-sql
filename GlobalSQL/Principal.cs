using System;
using System.Data;
using System.Data.SqlClient;

namespace GlobalSQL
{
    public partial class Principal : Form
    {
        SqlConnection conexao = new SqlConnection("");
        public Principal()
        {
            InitializeComponent();
        }

        private void preencherLista(SqlCommand comandoSQL, int tipoConta)
        {
            SqlDataReader dataReader = comandoSQL.ExecuteReader();

            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(dataReader["Numero"].ToString());
                item.SubItems.Add(dataReader["Nome"].ToString());
                item.SubItems.Add("R$ " + dataReader["Valor"].ToString());
                item.SubItems.Add(dataReader["DataVencimento"].ToString());
                if (tipoConta == 0)
                {
                    item.SubItems.Add(dataReader["DataProrrogacao"].ToString());
                    item.SubItems.Add("Aguardando");
                    item.SubItems.Add("NÃO");
                }
                else
                {
                    item.SubItems.Add(dataReader["DataVencimento"].ToString());
                    item.SubItems.Add(dataReader["DataPagamento"].ToString());
                    item.SubItems.Add("SIM");
                }

                listaConsulta.Items.Add(item);
            }

            dataReader.Close();
        }

        private void consulta()
        {
            try
            {
                listaConsulta.Items.Clear();
                conexao = new SqlConnection(@"Data Source=LSOUZA\SQLEXPRESS;Initial Catalog=Globaltec;Integrated Security=True");
                conexao.Open();
                SqlCommand comandoSQL = new SqlCommand("");
                comandoSQL = new SqlCommand("SELECT * FROM ContasAPagar INNER JOIN Pessoas ON ContasAPagar.CodigoFornecedor = Pessoas.Codigo", conexao);
                preencherLista(comandoSQL, 0);

                comandoSQL = new SqlCommand("SELECT * FROM ContasPagas INNER JOIN Pessoas ON ContasPagas.CodigoFornecedor = Pessoas.Codigo", conexao);
                preencherLista(comandoSQL, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void consultarButton_Click(object sender, EventArgs e)
        {
            consulta();
        }
    }
}