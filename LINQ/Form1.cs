using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        int[] sayilar = { -9, -5, 3, 8, 12, 25 };
        List<string> isimler = new List<string>();
        public Form1()
        {
            InitializeComponent();
            isimler.Add("Duygu");
            isimler.Add("Dicle");
            isimler.Add("Buket");
            isimler.Add("Furkan");
            isimler.Add("Hatice");
            isimler.Add("Berna");
        }

        private void tumSayiler_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.ToList();
        }

        private void sayilar_negatif_Click(object sender, EventArgs e)
        {
            //lambda expression
            //=> lambda
            //Foreach ile dolaşabildiğimiz generiz bir interface
            //interface yenenek belirtir bunu yeneteği foreach ile dolaşabilmektir
            IEnumerable<int> n = sayilar.Where(birsey => birsey < 0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void sayilar_pozitif_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = sayilar.Where(x => x > 0); // sayi öyleki büyük olsun sıfırdan
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void sayilar_cift_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = sayilar.Where(x => x % 2 == 0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();

        }

        private void sayılar_tek_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = sayilar.Where(x => x % 2 !=0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void sayilar_enbüyük_Click(object sender, EventArgs e)
        {
          int enBuyukSayi =   sayilar.Max(x=>x);
            MessageBox.Show(enBuyukSayi.ToString());
        }

        private void sayılar_enkucuk_Click(object sender, EventArgs e)
        {
            int EnKucukSayi = sayilar.Min(x => x);
            MessageBox.Show(EnKucukSayi.ToString());
        }

        private void sayilar_kactane_Click(object sender, EventArgs e)
        {
            int kacTaneSayiVar = sayilar.Length;//tercih
            int kacTaneSayiVar2 = sayilar.Count();
            MessageBox.Show(kacTaneSayiVar.ToString());
        }

        private void alfabetikSirali_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            IOrderedEnumerable<string> sirali=isimler.OrderBy(x => x);
            listBox1.DataSource = isimler.OrderBy(x => x).ToList();
            //Tolist()->List<string>
        }

        private void AlfabetikTersSirali_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.OrderByDescending(x => x).ToList();
        }

        private void Uzunluklar_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Select(x => x.Length).ToList();


        }

        private void Ibarındıranlar_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
          
            listBox1.DataSource = isimler.Where(x => x.Contains("i")||x.Contains("İ")).ToList();

        }

        private void Dilebaslayanlar_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Where(x => x.StartsWith("D")).ToList();
        }

        private void btnTumSiparisler_Click(object sender, EventArgs e)
        {
           
            List<Order> orders = new Order().GetOrders();
            //dataGridView1.DataSource= o.GetOrders();
            var gorunen = orders.Select(satir => new
            {
                SiparisNo = satir.OrderID,
                Tarih = satir.OrderDate,
                Musteri = satir.Customer.ContactName,
            });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gorunen.ToList();
        }

        private void btnSadeceTarih_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Select(x => x.OrderDate).ToList();
        }

        private void btnIlkBesTariih_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            //orders.skip(10).Take(5)
            //10 kayıt atla sıradaki 5 kaydı al
            dataGridView1.DataSource = orders.Take(5).ToList();
        }

        private void btnSonBesTarih_Click(object sender, EventArgs e)
        {

            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.OrderByDescending(x => x.OrderID).Take(5).Select(x => new
            {
                x.OrderID,
                x.Customer.ContactName,
                x.OrderDate
            }).ToList(); 
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();

            dataGridView1.DataSource = null;
            var filter = orders.Where(x => x.Customer.ContactName == "Yang Wang").ToList();
            dataGridView1.DataSource = filter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            int sayi = orders.Count;
            MessageBox.Show(sayi.ToString());
        }
    }
}
