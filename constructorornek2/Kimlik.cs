using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorornek2
{
    internal class Kimlik
    {
        string ad;
        string soyad;
        string memleket;
        int yas;
        char medenihal;

       public string AD
        {
            get { return ad; }
            set { ad = value.ToLower(); }
        }

       public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }   

        public string MEMLEKET
        {
            get { return memleket; }
            set { memleket = value; }
        }

        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }

        public char Medenihal
        {
            get { return medenihal; }
            set { medenihal = value; }
        }

        public Kimlik()
        {
            ad = "";
            soyad = "";
            memleket = "";
            yas = 0;
            medenihal = 'B';
        }
    }
}
