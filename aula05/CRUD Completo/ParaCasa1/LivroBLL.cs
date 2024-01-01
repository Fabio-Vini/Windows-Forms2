using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ParaCasa1
{
    class LivroBLL
    {
        public static void conecta()
        {
            LivroDAL.conecta();
        }

        public static void desconecta()
        {
            LivroDAL.desconecta();
        }

        public static void validaCodigo(Livro umlivro, char op)
        {
            Erro.setErro(false);
            if (umlivro.getCodigo().Equals(""))
            {
                Erro.setMsg("O código é de preenchimento obrigatório!");
                return;
            }
            if (op == 'c')
                LivroDAL.consultaUmLivro(umlivro);
            else
                LivroDAL.excluiUmLivro(umlivro);
        }

        public static void validaDados(Livro umlivro, char op)
        {
            Erro.setErro(false);
            if (umlivro.getCodigo().Equals(""))
            {
                Erro.setMsg("O código é de preenchimento obrigatório!");
                return;
            }
            if (umlivro.getFabricante().Equals(""))
            {
                Erro.setMsg("O Fabricante é de preenchimento obrigatório!");
                return;
            }
            if (umlivro.getQuantidade().Equals(""))
            {
                Erro.setMsg("A quantidade é de preenchimento obrigatório!");
                return;

            }
            if (umlivro.getDescricao().Equals(""))
            {
                Erro.setMsg("A descricao é de preenchimento obrigatório!");
                return;
            }
            if (umlivro.getValor().Equals(""))
            {
                Erro.setMsg("O valor é de preenchimento obrigatório!");
                return;
            }


            try
            {
                int.Parse(umlivro.getValor());
            }
            catch (Exception)
            {
                Erro.setMsg("O valor  deve ser numérico!");
                return;
            }


            if (int.Parse(umlivro.getValor()) <= 0)
            {
                Erro.setMsg("O valor  deve ser numérico e positivo!");
                return;
            }
            if (op == 'i')
            {


                LivroDAL.inseriUmLivro(umlivro);
            }
            else
                LivroDAL.atualizaUmLivro(umlivro);

        }

    }
}