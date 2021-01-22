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
    public partial class BabaForm : Form,IObserverBakıcı
    {
        public BabaForm()
        {
            InitializeComponent();
        }

        // Son değere göre rahatsızlıkları listeliyoruz
        public void Update(float temperature, string name)
        {
            setText(temperature, name);
        }

        private void setText(float temperature, string name)

        {
            if (temperature >= 40)
            {
                listBox1.Items.Clear();
                label1.Text = "KENAN IN VÜCUT SICAKLIĞI" + temperature + " C ACİLEN GELMENİZ GEREKİYOR";

                listBox1.Items.Add("KALP KRİZİ");
                listBox1.Items.Add("SAYIKLAMA");
                listBox1.Items.Add("HAVALE");
            }
            else if (temperature <= 35)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("HİPOTERMİ");
                label1.Text = "KENAN IN VÜCUT SICAKLIĞI " + temperature + " C ACİLEN GELMENİZ GEREKİYOR";
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("YOK");
                label1.Text = "KENAN IN VÜCUT SICAKLIĞI " + temperature + "HERŞEY NORMAL";
            }

           
        }

        private void SedefVeliForm_Load(object sender, EventArgs e)
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
