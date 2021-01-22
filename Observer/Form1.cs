using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        public Form1()
        {

          
            InitializeComponent();
            
        }
        
        // nesnemizi oluşturuyoruz
         Temperatures temp = new Temperatures();
        //private Temperatures temp;

        private void button2_Click(object sender, EventArgs e)
        {
            // girilen değerleri parametrelere aktarıyoruz
            temp.temperature = Convert.ToInt32(textBox3.Text);
            temp.name = comboBox1.Text;


        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            // concrate observerlarımızı listemize ekliyoruz.
            AnneForm af = new AnneForm();
            temp.RegisterObserver(af);
            af.Show();
            OgretmenForm kf = new OgretmenForm();
            temp.RegisterObserver(kf);
            kf.Show();
            BabaForm sf = new BabaForm();
            temp.RegisterObserver(sf);
            sf.Show();
            

            if(comboBox2.Text=="bakıcı" && textBox2.Text == "1523")
            {
                comboBox2.Visible = false;
                textBox2.Visible = false;
                comboBox1.Visible = true;
                textBox3.Visible = true;
                button1.Visible = false;
                button2.Visible = true;
                label2.Text = "ATEŞ ÖLÇÜMÜ";             
                label3.Text = "LÜTFEN AD SOYAD VE ATEŞ ÖLÇÜMÜ GİRİŞİ YAPIN";
                
            }
            else if (comboBox2.Text == "KenanAnne" && textBox2.Text == "1523")
            {
              
                af.Show();
               
            }
            else if (comboBox2.Text == "KenanBaba" && textBox2.Text == "1523")
            {
              
                sf.Show();
                
            }
            else if (comboBox2.Text == "KenanOgretmen" && textBox2.Text == "1523")
            {
                kf.Show();
                
            }
           

        }
        
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
