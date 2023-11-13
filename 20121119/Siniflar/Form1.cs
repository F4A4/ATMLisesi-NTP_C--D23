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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Framework kullanan her kodlama dili
            //nesne tabanlıdır. Aşağıdaki i bir nesnedir;
            int i = 3;

            //Nesneler forma çeşitli şekillerde eklenebilir;
            Button btnDeneme = new Button();
            btnDeneme.Name = "btnDeneme";
            btnDeneme.Text = "deneme";
            btnDeneme.Location = new System.Drawing.Point(80, 77);
            btnDeneme.Size = new System.Drawing.Size(100, 50);
            this.Controls.Add(btnDeneme);

            //static class'ları aşağıdaki gibi çağırırız;
            //DenemeClass.Deneme();

            //static olmayan class'ları türeterek çağırırız;
            Baba bb = new Baba(); //class türetme işlemi
            bb.Deneme();//türetilen classdaki nesnelere erişme işlemi.
            //bb.Deneme2 görünmez, çünki private o sınıfa özeldir.

            MessageBox.Show("Babanın mesleği : " + bb.meslek);

            Kardes krt = new Kardes();
            MessageBox.Show("Kardeşin mesleği : " + krt.meslek);

            Cocuk cck = new Cocuk();
            MessageBox.Show("Çocuğun mesleği : " + cck.meslek);
            cck.meslek = "Amele";
            MessageBox.Show("Çocuğun mesleği : " + cck.meslek);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
    //En üstteki ana sınfımız insan sınıfı olsun.
    //her insanın bir mesleği olduğunu var sayarsak,
    //bu sınıfı miras alan diğer tüm sınıflarında
    //bu meslek değişkenini (alanını) kullanabildiklerini
    //görürüz. Çünkü meslek alanı private değildir.
    public class Insan
    {
        //bu değişken bu class'ı miras alan
        //diğer class'lar tarafından da 
        //kullanılabilecek.
        public string meslek;
    }
    //babanın mesleğini belirlemek için çeşitli yollar vardır.
    //bunlardan biri (mesela) butonda çağırırken baba.meslek=""
    //şeklindedir. Diğer yol, sınıflar türetilirken otomatik olarak 
    //çalışan constructor metotlarını kullanmaktır.
    public class Baba:Insan
    {
        //Constructor: (class tanımlanırken otomatik çalışır)
        public Baba()
        {
            meslek = "Tornacı";
        }

        public void Deneme()
        {
        }
        private void Deneme2()
        { }
    }
    public class Kardes:Baba
    {
        public Kardes()
        {
            meslek = "Prof";
        }
    }
    public class Cocuk:Baba
    {
        public Cocuk()//constructor
        {
            meslek = "Doktor";
        }

        int yas = 13;
        string okul = "mtml";
    }
}
