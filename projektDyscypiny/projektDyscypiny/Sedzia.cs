using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektDyscypiny
{
    public class Sedzia
    {
        private String imieSedzia;
        private String nazwiskoSedzia;
        private int idSedzia;
        private static int iloscSedziow;

        public Sedzia(String imieSedzia, String nazwiskoSedzia)
        {
            this.imieSedzia = imieSedzia;
            this.nazwiskoSedzia = nazwiskoSedzia;
            //idk jakie ID przypisać
        }
        public int getID_Sedzia() { return idSedzia; }
        public String getImie_Sedzia() { return imieSedzia; }
        public String getNazwisko_Sedzia() { return nazwiskoSedzia; }
    }
}
