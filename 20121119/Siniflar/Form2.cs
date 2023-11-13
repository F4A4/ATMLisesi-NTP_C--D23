using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Siniflar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int a = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 3;
            Arac arc = new Arac();
            arc.kullanimAmaci = "sivil";//sadece bu görünür.

            KaraAracı karc = new KaraAracı();
            karc.kullanimAmaci = "";
            karc.kapıSayisi = 3;
            karc.motorGücü = 1600;
            karc.tekerSayisi = 3;
            //bu görünenler hem arac hemde karaaracı
            //sınıflarından geliyor.

            HafifKaraAracı harc = new HafifKaraAracı();
            harc.kullanimAmaci = "";
            harc.kapıSayisi = 3;
            harc.motorGücü = 1600;
            harc.tekerSayisi = 3;
            harc.marka = "BMW";
            //bu görünenler hem arac hem karaaracı
            //hemde hafif sınıflarından geliyor.

            Otomobil otm = new Otomobil();
            otm.kullanimAmaci = "sivil";
            otm.kapıSayisi = 3;
            otm.motorGücü = 1600;
            otm.tekerSayisi = 3;
            otm.marka = "BMW";
            otm.esr = true;
            otm.esp = true;
            otm.abs = true;
            MessageBox.Show(otm.kullanimAmaci);
        }
    }
}
