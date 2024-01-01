using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    internal class Livro
    {
        private string titulo;
        private string autor;
        private string editora;
        private string anoedit;
        private string local;

        public void setTitulo(String _titulo) { titulo = _titulo; } //escrita
        public String getTitulo() { return titulo; } //leitura
        public void setAutor(String _autor) { autor = _autor; }
        public String getAutor() { return autor; }
        public void setEditora(String _editora) { editora = _editora; }
        public String getEditora() { return editora; }
        public void setAnoedit(String _anoedit) { anoedit = _anoedit; }
        public string getAnoedit() { return (int.Parse(anoedit)).ToString(); }
        public void setLocal(String _local) { local = _local; }
        public String getLocal() { return local; }
    }
}
