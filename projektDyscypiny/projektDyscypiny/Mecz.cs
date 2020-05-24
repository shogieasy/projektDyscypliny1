using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektDyscypiny
{
    public class Mecz
    {
        private Druzyna druzyna1;
        private Druzyna druzyna2;
        private int idMeczu;
        private Sedzia sedzia1;
        private Sedzia sedzia2;
        private Sedzia sedzia3;
        private int punkty_Dr1;
        private int punkty_Dr2;

        public Mecz(Druzyna druzyna1, Druzyna druzyna2, Sedzia sedzia1)
        {
            this.druzyna1 = druzyna1;
            this.druzyna2 = druzyna2;
            this.sedzia1 = sedzia1;
        }
        public Mecz(Druzyna druzyna1, Druzyna druzyna2, Sedzia sedzia1, Sedzia sedzia2, Sedzia sedzia3)
        {
            this.druzyna1 = druzyna1;
            this.druzyna2 = druzyna2;
            this.sedzia1 = sedzia1;
            this.sedzia2 = sedzia2;
            this.sedzia3 = sedzia3;
        }
        public void wpiszWynik(int punkty_Dr1, int punkty_Dr2)
        {
            this.punkty_Dr1 = punkty_Dr1;
            this.punkty_Dr2 = punkty_Dr2;
        }
    }
}
