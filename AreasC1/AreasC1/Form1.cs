using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasC1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmAreaC_Click(object sender, EventArgs e)
        {
            
           decimal resultado = AreasC.Cuadrado(numAreaC.Value);
            lblAreaC.Text = resultado + "";
        }

        private void btmAreaT_Click(object sender, EventArgs e)
        {
            
            decimal resultado = AreasC.Triangulo(numAreaT.Value, numAreaT1.Value);
            lblAreaT.Text = resultado + "";
        }

        private void btmAreaCi_Click(object sender, EventArgs e)
        {
            
            decimal resultado = AreasC.Circulo(numAreaCi.Value);
            lblAreaCi.Text = resultado + "";
        }

        private void btmAreaR_Click(object sender, EventArgs e)
        {
           
            decimal resultado = AreasC.Rectangulo(numAreaR.Value, numAreaR1.Value);
            lblAreaR.Text = resultado + "";
        }

        private void btmAreaP_Click(object sender, EventArgs e)
        {
          
            decimal resultado = AreasC.Poligono(numAreaP.Value, numAreaP1.Value);
            lblAreaP.Text = resultado + "";
        }

        private void btmAreaRo_Click(object sender, EventArgs e)
        {
            
            decimal resultado = AreasC.Rombo(numAreaRo.Value, numAreaRo1.Value);
            lblAreaRo.Text = resultado + "";
        }
    }
}
