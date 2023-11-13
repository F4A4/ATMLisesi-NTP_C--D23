using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SınıfModülü
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
            //STATİC OLMAYAN CLASSLARI TÜRETEREK ÇAĞIRIRIZ
            Dede dd = new Dede();//CLASS TÜRETME İŞLEMİ
            dd.Deneme();//TÜRETİLEN CLASSDAKİ NESNELERE ERİŞME İŞLEMİ 
            MessageBox.Show("Dedenin Mesleği : "+dd.Meslek);
            Baba bb = new Baba();//CLASS TÜRETME İŞLEMİ
            bb.Deneme();//TÜRETİLEN CLASSDAKİ NESNELERE ERİŞME İŞLEMİ 
            MessageBox.Show("Babanın Mesleği : " + bb.Meslek);
            Cocuk cck = new Cocuk();//CLASS TÜRETME İŞLEMİ
            cck.Deneme();//TÜRETİLEN CLASSDAKİ NESNELERE ERİŞME İŞLEMİ 
            MessageBox.Show("Çocuğun Mesleği : " + cck.Meslek);

        }
    }
    //EN ÜSTTEKİ ANA SINIFIMIZ İNSAN SINIFI OLSUN
    //HER İNSANIN BİR MESLEĞİ OLDUĞUNU VAR SAYARSAK,
    //BU SINIFI MİRAS ALAN DİĞER TÜM SINIFLARIDA 
    //BU MESLEK DEĞİŞKENİNİ(ALANINI) KULLANABİLDİKLERİNİ
    //GÖRÜRÜZ.ÇÜNKÜ MESLEK ALANI PRİVATE DEĞİLDİR.
    public class İnsan
    {
        public string Meslek;
        
    }
    //DEDENİN MESLEĞİNİ BELİRLEMEK İÇİN ÇEŞİTLİ YOLLAR VARDIR
    //BUNLARDAN BİRİ(MESELA) BUTONDA ÇAĞIRIRKEN BABA.MESLEK="";
    //ŞEKLİNDEDİR.DİĞER YOL, SINIFLAR TÜRETİLİRKEN OTOMATİK OLARAK
    //ÇALIŞAN CONSTRUCTOR METOTLARINI KULLANMAKTIR.
    public class Dede:İnsan
    {
        public Dede()//
        {
            Meslek = "tornacı";
        }
        public void Deneme()
        {
 
        }
        public void Deneme2()
        {
 
        }

    }
    public class Baba:Dede
    {
        public Baba()
        {
            Meslek = "prof";
        }
        

    }
    public class Cocuk:Dede
    {
        public Cocuk()
        {
            Meslek = "doktor";
        }

    }
}
