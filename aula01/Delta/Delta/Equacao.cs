using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta
{
    internal class Equacao
    {
        private String a;
        private String b;
        private String c;
        /*private readonly String Delta;*/


        public void setA(String _a) { a = _a; } //escrita
        public String getA() { return a; } //leitura
        public void setB(String _b) { b = _b; }
        public String getB() { return b; }
        public void setC(String _c) { c = _c; }
        public String getC() { return c; }

        public String getDelta() { return (Math.Pow(double.Parse(b), 2) - 4 * double.Parse(a) * double.Parse(c) ).ToString(); }
        public String getX1() { return (-(double.Parse(b) - Math.Sqrt(double.Parse(getDelta()))) / (2 * double.Parse(a))).ToString(); }
        public String getX2() { return (-((double.Parse(b)) + Math.Sqrt(double.Parse(getDelta()))) / (2 * double.Parse(a))).ToString(); }
    }
}
