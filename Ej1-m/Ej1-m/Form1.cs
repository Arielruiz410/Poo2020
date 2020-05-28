using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1_m
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_CodigoProducto.Text) ||
                string.IsNullOrEmpty(txtBox_DescripcionProducto.Text) ||
                string.IsNullOrEmpty(txtBox_NombreProducto.Text) ||
                string.IsNullOrEmpty(txtBox_PrecioProducto.Text))
            {
                MessageBox.Show("Datos de producto incompletos");
            }
            else if (float.Parse(txtBox_PrecioProducto.Text) < 0)
            {
                MessageBox.Show("El precio no puede ser menor que 0");
            }
            else
            {
                Libreria libreria = new Libreria();
                float precio = float.Parse(txtBox_PrecioProducto.Text);
                libreria.AgregarProducto (txtBox_CodigoProducto.Text,
                                          txtBox_DescripcionProducto.Text,
                                          txtBox_NombreProducto.Text,
                                          precio);
            }
            
        }
    }
}
