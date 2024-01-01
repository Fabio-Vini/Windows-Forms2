using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta
{
    internal class DeltaBLL
    {
        public static void validaDados(Equacao delta)
        {
            Erro.setErro(false);

            //CONDIÇÃO DO CAMPO A
            if(delta.getA().Length == 0)
            {
                Erro.setErro("O campo A é de preenchimento obrigatório!");
                return;
            }
            else
            {
                try
                {
                    float.Parse(delta.getA());
                }
                catch
                {
                    Erro.setErro("O campo A deve ser numérico!");
                    return;
                }
            }

            //CONDIÇÃO DO CAMPO B
            if (delta.getB().Length == 0)
            {
                Erro.setErro("O campo B é de preenchimento obrigatório!");
                return;
            }
            else
            {
                try
                {
                    float.Parse(delta.getB());
                }
                catch
                {
                    Erro.setErro("O campo B deve ser numérico!");
                    return;
                }
            }


            //CONDIÇÃO DO CAMPO C
            if (delta.getC().Length == 0)
            {
                Erro.setErro("O campo C é de preenchimento obrigatório!");
                return;
            }
            else
            {
                try
                {
                    float.Parse(delta.getC());
                }
                catch
                {
                    Erro.setErro("O campo C deve ser numérico!");
                    return;
                }
            }
        }
    }
}
