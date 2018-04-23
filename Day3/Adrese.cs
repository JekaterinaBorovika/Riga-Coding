using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Adrese
    {
        public string Valsts;
        public string Pilseta;
        public string Iela;
        public string MajasNr;
        public string DzivoklaNr;

        public string PilnaAdrese()
        {
            //atgriež adresi no visām sastāvdaļām:
            //valsts + pilsēta + iela +..


            string adrese = Valsts + ", " + Pilseta + ", " + Iela + " " + MajasNr + " " + DzivoklaNr;

            return adrese
        }
    }
}
