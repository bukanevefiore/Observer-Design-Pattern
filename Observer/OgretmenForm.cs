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
    public partial class OgretmenForm : Form,IObserverBakıcı
    {
        public OgretmenForm()
        {
            InitializeComponent();
        }
        // propertylerimiz
        public int Ortsicaklik = 0;
        public int Sayac { get; set; }
            
        public string Textt { get; set; }

        public void Update(float temperature, string name)
        {
            setText(temperature, name);
        }

        // ubdate methodu çalıştığında tüm sıcaklık girişlerini dosyayaya kaydedip ortalama sıcaklığı hesaplıyruz
        private void setText(float temperature, string name)
        {
            string fileName = @"C:/Users/pc/Desktop/yazılım mimarisifinal/kenankayıtlar.txt";

           
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();

            File.AppendAllText(fileName, Environment.NewLine  + temperature);


          
            StreamReader oku;
            oku = new StreamReader(@"C:/Users/pc/Desktop/yazılım mimarisifinal/kenankayıtlar.txt");
           
            while ((Textt = oku.ReadLine()) != null)      
            {
               
                    Ortsicaklik= ((Convert.ToInt32(Textt)+Ortsicaklik) );
                 Sayac++;
            }

            
            oku.Close();               //okumayı kapat

            label2.Text = Convert.ToString( Ortsicaklik / Sayac);

        }

        private void KerimVeliForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
