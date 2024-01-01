using Livros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Livros
{
    internal class LivroBLL
    {
        public static void validaDados(Livro cadastro)
        {
            Erro.setErro(false);

            if (cadastro.getTitulo() == "")
            {
                Erro.setErro("O campo 'Titulo' é de preenchimento obrigatório!");
                return;
            }
            else if (cadastro.getAutor() == "")
            {
                Erro.setErro("O campo 'Autor' é de preenchimento obrigatório!");
                return;
            }
            else if (cadastro.getEditora() == "")
            {
                Erro.setErro("O campo 'Editora' é de preenchimento obrigatório!");
                return;
            }
            else if (cadastro.getLocal() == "")
            {
                Erro.setErro("O campo 'Local' é de preenchimento obrigatório!");
                return;
            }


            else if (!Regex.IsMatch(cadastro.getAutor(),  @"^[a-zA-Z]+$") )
            {
                Erro.setErro("Há números no campo 'Autor'");
                return;
            }
            else if (!Regex.IsMatch(cadastro.getEditora(), @"^[a-zA-Z]+$"))
            {
                Erro.setErro("Há números no campo 'Editora'");
                return;
            }
            else if (!Regex.IsMatch(cadastro.getLocal(), @"^[a-zA-Z]+$"))
            {
                Erro.setErro("Há números no campo 'Local'");
                return;
            }
        }
    }
}