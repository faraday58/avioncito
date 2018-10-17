using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avioncito
{
    public partial class Form1 : Form
    {
        int X, Y,Xm,Ym;
        public Form1()
        {
            InitializeComponent();
            X = pc_avion.Location.X;
            Y = pc_avion.Location.Y;
            Xm = pc_misil.Location.X;
            Ym = pc_misil.Location.Y; 
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            tiempojuego.Start();
        }

        private void tiempojuego_Tick(object sender, EventArgs e)
        {
            pc_misil.Location = new Point(Xm+=1, Ym+=1);

        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            tiempojuego.Stop();
        }

        private void btn_arriba_Click(object sender, EventArgs e)
        {
            pc_avion.Location = new Point(X, Y-=5);
        }

        private void btn_izquierda_Click(object sender, EventArgs e)
        {
            pc_avion.Location = new Point(X-=5, Y);
        }

        private void btn_derecha_Click(object sender, EventArgs e)
        {
            pc_avion.Location = new Point(X+=5, Y);
        }

        private void btn_abajo_Click(object sender, EventArgs e)
        {
            pc_avion.Location = new Point(X, Y+=5);
        }
               

        
        

    }
}
