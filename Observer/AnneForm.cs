using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Observer
{
       
    public partial class AnneForm : Form, IObserverBakıcı
    {
        public AnneForm()
        {
            InitializeComponent();
        }

            public string WriteTarih { get; set; }
            public string Yazi { get; set; }

        // ubdate içerisinde dosyaya kayıt işlmeleri yapıyoruz
       public void Update(float temperature, string name)
        {
            SetText(temperature, name);
        }

        private void SetText(float temperature, string name)
        {
               // tüm kayıtları dosyaya yazdırıyoruz
                string fileName = @"C:/Users/pc/Desktop/yazılım mimarisifinal/tümkayıtlar.txt";

                WriteTarih = DateTime.Now.ToString(); // tarih ve saat;

           
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();

                File.AppendAllText(fileName, Environment.NewLine + "**  " + WriteTarih + "----" + name + " 'in vücut sıcaklığı " + temperature + "C ölçüldü.");


            // anlık tüm verileri listboxa yazdırırız
            textBox1.Text= WriteTarih + "----" + name + " 'in vücut sıcaklığı " + temperature + "C ölçüldü.";

        }

        public void DosyaCek()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("***Kenan 'a ait ateş ölçümleri***");
            StreamReader oku;
            oku = new StreamReader(@"C:/Users/pc/Desktop/yazılım mimarisifinal/tümkayıtlar.txt");

            while ((Yazi = oku.ReadLine()) != null)      //satır boş olana kadar satır satır okumaya devam eder
            {
                listBox1.Items.Add(Yazi.ToString());
            }
            oku.Close();               //okumayı kapat
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DosyaCek();

        }
        private void AnneForm_Load(object sender, EventArgs e)
        {

        }

    }
}
