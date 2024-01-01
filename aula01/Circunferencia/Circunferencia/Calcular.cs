using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circunferencia
{
    internal class Calcular
    {
        private String raio;

        public void setRaio(String _raio) { raio = _raio; }
        public String getRaio() { return raio; }

        public String getArea() { return (3.14159265358979323846 * Math.Pow(double.Parse(raio), 2)).ToString(); }
        public String getPerimetro() { return (2 * 3.14159265358979323846 * double.Parse(raio)).ToString(); }
    }
}
