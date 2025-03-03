using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace aodev1
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

           
            class Car
            {
                public string Marka { get; set; }
                public string VitesTür { get; set; }

                public void ShowInfo()
                {
                    MessageBox.Show($"{Marka} → {VitesTür}."); 
                }
            }

           
            class BMW : Car { public BMW() {Marka = "BMW"; VitesTür = "Düz viteslidir"; } }
            class Porsche : Car { public Porsche() { Marka = "Porsche"; VitesTür = "Otomatik viteslidir"; } }
            class Mercedes : Car { public Mercedes() { Marka= "Mercedes"; VitesTür = "Otomatik viteslidir"; } }
            class Togg : Car { public Togg() { Marka = "Togg"; VitesTür = "Otomatik viteslidir"; } }
            class Audi : Car { public Audi() { Marka = "Audi"; VitesTür = "Otomatik viteslidir"; } }
            class Toyota : Car { public Toyota() { Marka = "Toyota"; VitesTür = "Düz viteslidir"; } }

            private void Form1_Load(object sender, EventArgs e)
            {
                
                Car[] cars = { new BMW(), new Porsche(), new Mercedes(), new Togg(), new Audi(), new Toyota() };

                
                foreach (var car in cars)
                {
                    car.ShowInfo();
                }
            }

        private void Form1_Load_1(object sender, EventArgs e)
        {
              
                Car[] cars = { new BMW(), new Porsche(), new Mercedes(), new Togg(), new Audi(), new Toyota() };

              
                foreach (var car in cars)
                {
                    MessageBox.Show($"{car.Marka} → {car.VitesTür}.");
                }
            }

        }
    }
    



         