using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;



namespace ParaCasa1
{
    class Livro
{
    private String codigo;
    private String descricao;
    private String fabricante;
    private String quantidade;
    private String valor;

    public void setCodigo(String _codigo) { codigo = _codigo; }

    public void setDescricao(String _descricao) { descricao = _descricao; }
    public void setFabricante(String _fabricante) { fabricante = _fabricante; }

    public void setQuantidade(String _quantidade) { quantidade = _quantidade;}
        public void setValor(String _valor) { valor = _valor;}
  

    public String getCodigo() { return codigo; }
    public String getDescricao() { return descricao; }
    public String getFabricante() { return fabricante; }
    public String getQuantidade() { return quantidade; }
    public String getValor() { return valor; }
}
}
