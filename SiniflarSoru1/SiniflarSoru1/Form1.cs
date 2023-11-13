using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SiniflarSoru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

    }
    public class Arac
    {
        public string KullanimAmaci;

    }
    public class KaraAracı : Arac
    {
        public int TekerSayısı = 0;
        public int KapıSayısı = 0;
        public int MotorGücü = 0;

    }
    public class DenizAracı : Arac
    {

    }
    public class HavaAracı : Arac
    {

    }
    public class HafifKaraAracı : KaraAracı
    {

    }
    public class Otomobil : HafifKaraAracı
    {
        public bool abs = false;
        public bool esp = false;
        public bool esr = false;

    }
    public class Motor : HafifKaraAracı
    {

    }
    public class AğırKaraAracı : KaraAracı
    {
        public int cc = 0;
        public string sogutmaCinsi = "";

    }
    public class Kamyon : AğırKaraAracı
    {
        public int dingil = 0;
    }
    public class Tır : AğırKaraAracı
    {
        public int cekici = 0;

    }
    public class Tank : AğırKaraAracı
    {
        public int mermi = 0;
        public string menzil = "";
        public string menzilcinsi = "";

    }

}
