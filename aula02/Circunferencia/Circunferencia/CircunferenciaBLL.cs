using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circunferencia
{
    internal class CircunferenciaBLL
    {
        public static void validaDados(Calcular area)
        {
            Erro.setErro(false);
            if(area.getRaio().Length == 0 )
            {
                Erro.setErro("O campo RAIO é de preenchimento obrigatório!");
                return;
            }
            else
            {
                try
                {
                    float.Parse(area.getRaio());
                }
                catch
                {
                    Erro.setErro("O campo Raio deve ser numérico!");
                    return;
                }
            }
        }
    }
}
