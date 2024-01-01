using System;
using System.Data.OleDb;

namespace ParaCasa1
{
    class LivroDAL
    {
        private static string strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDLivros.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;

        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                Erro.setMsg("Problemas ao se conectar ao Banco de Dados");
            }
        }

        public static void desconecta()
        {
            conn.Close();
        }

        public static void inseriUmLivro(Livro umlivro)
        {
            string aux = "insert into TabProduto (codigo, descricao, fabricante, quantidade, valor) values (@codigo, @descricao, @fabricante, @quantidade, @valor)";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@codigo", OleDbType.VarChar).Value = umlivro.getCodigo();
            strSQL.Parameters.Add("@descricao", OleDbType.VarChar).Value = umlivro.getDescricao();
            strSQL.Parameters.Add("@fabricante", OleDbType.VarChar).Value = umlivro.getFabricante();
            strSQL.Parameters.Add("@quantidade", OleDbType.VarChar).Value = umlivro.getQuantidade();
            strSQL.Parameters.Add("@valor", OleDbType.VarChar).Value = umlivro.getValor();
            Erro.setErro(false);

            try
            {
                strSQL.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                if (ex.ErrorCode == -2147467259)
                {
                    Erro.setMsg("Chave Duplicada!");
                }
                else
                {
                 
                    throw;
                }
            }
        }

        public static void excluiUmLivro(Livro umlivro)
        {
            string aux = "Delete from TabProduto where codigo=@codigo";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@codigo", OleDbType.VarChar).Value = umlivro.getCodigo();
            strSQL.ExecuteNonQuery();
        }

        public static void atualizaUmLivro(Livro umlivro)
        {
            string aux = "Update TabProduto set valor= @valor, quantidade= @quantidade, fabricante= @fabricante, descricao= @descricao where codigo = @codigo";
            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@valor", OleDbType.VarChar).Value = umlivro.getValor();
            strSQL.Parameters.Add("@quantidade", OleDbType.VarChar).Value = umlivro.getQuantidade();
            strSQL.Parameters.Add("@fabricante", OleDbType.VarChar).Value = umlivro.getFabricante();
            strSQL.Parameters.Add("@descricao", OleDbType.VarChar).Value = umlivro.getDescricao();
            strSQL.Parameters.Add("@codigo", OleDbType.VarChar).Value= umlivro.getCodigo();
            strSQL.ExecuteNonQuery();

        }

        public static void consultaUmLivro(Livro umlivro)
        {
            String aux = "select * from TabProduto where codigo ='" + umlivro.getCodigo() + "'";
            strSQL = new OleDbCommand(aux, conn);
            result = strSQL.ExecuteReader();
            Erro.setErro(false);
            if (result.Read())
            {
                

                    umlivro.setFabricante(result.GetString(1));
                    umlivro.setDescricao(result.GetString(2));
                    umlivro.setQuantidade(result.GetString(3));
                    umlivro.setValor(result.GetString(4));
                    Erro.setErro(false);
                }
                else
                {
                    Erro.setMsg("Produto não cadastrado.");
                }
            }
           
        }
    }
