using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poblacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuintaParte_Click(object sender, EventArgs e)
        {
            int cantidadAnimales = Convert.ToInt32(txtCantidadAnimales.Text);
            int cantidadAnios = Convert.ToInt32(txtCantidadAnios.Text);

            double cantidadAnimalesRestantes = cantidadAnimales / Math.Pow(5, cantidadAnios);
            txtResultado.Text = Convert.ToString(cantidadAnimalesRestantes);
            
            
        }
    }
}
