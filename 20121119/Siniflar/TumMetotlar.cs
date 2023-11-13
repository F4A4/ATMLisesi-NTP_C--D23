using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Siniflar
{
    public class Arac
    {
        public string kullanimAmaci="askeri";
    }
    public class KaraAracı : Arac
    {
        public int tekerSayisi = 4;
        public int kapıSayisi = 4;
        public int motorGücü = 18;
    }
    public class DenizAracı : Arac
    {

    }
    public class HavaAracı : Arac
    {

    }
    public class HafifKaraAracı : KaraAracı
    {
        public string marka;
    }
    public class Otomobil : HafifKaraAracı
    {
        public bool abs = true;
        public bool esp = false;
        public bool esr = true;
    }
    public class Motor : HafifKaraAracı
    {
        public int cc;
        public string sogutmaCinsi = "Sulu Soğutma";
    }
    public class AğırKaraAracı : KaraAracı
    {
    }
    public class Kamyon : AğırKaraAracı
    {
        public int dingil = 15;
    }
    public class Tır : AğırKaraAracı
    {
        public int cekici = 24;
    }
    public class Tank : AğırKaraAracı
    {
        public int mermi = 5;
        public string menzil = "1800 km/h";
        public string mermiCinsi;
    }
}
