using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felvételi
{
    internal class Diak
    {
        string az;
        string nev;
        string ertCím;
        DateTime szülDatum;
        string email;
        int matekPontok;
        int magyarPontok;
        string telefon;
        string iskola;

        public Diak(string az, string nev, string ertCím, DateTime szülDatum, string email, int matekPontok, int magyarPontok, string telefon, string iskola)
        {
            this.az = az;
            this.nev = nev;
            this.ertCím = ertCím;
            this.szülDatum = szülDatum;
            this.email = email;
            this.matekPontok = matekPontok;
            this.magyarPontok = magyarPontok;
            this.telefon = telefon;
            this.iskola = iskola;
        }

        public string Az { get => az; set => az = value; }
        public string Nev { get => nev; set => nev = value; }
        public string ErtCím { get => ertCím; set => ertCím = value; }
        public DateTime SzülDatum { get => szülDatum; set => szülDatum = value; }
        public string Email { get => email; set => email = value; }
        public int MatekPontok { get => matekPontok; set => matekPontok = value; }
        public int MagyarPontok { get => magyarPontok; set => magyarPontok = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Iskola { get => iskola; set => iskola = value; }
    }
}
