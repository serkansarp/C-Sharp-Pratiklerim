using System;
using System.Drawing;
using System.Windows.Forms;

namespace SekilCiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);  // Paint olayı yakalanır
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Kalem (siyah renk, 2 piksel kalınlık)
            Pen kalem = new Pen(Color.Black, 2);

            // Dikdörtgen çiz: (x=50, y=50) konumunda, genişlik=200, yükseklik=100
            g.DrawRectangle(kalem, 50, 50, 200, 100);

            // Kalemi serbest bırak
            kalem.Dispose();
        }
    }
}
