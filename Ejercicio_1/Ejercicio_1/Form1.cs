using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {

        Libreria lib = new Libreria();

        public Form1()
        {
            InitializeComponent();
        }

        private void vender_Click(object sender, EventArgs e)
        {

            if (prod_comboBox.Text!="" && prod_comboBox.Text!="Elija un producto"
                && cant_textbox.Text!="")
            {
                float impVenta = lib.venderProducto(int.Parse(prod_comboBox.Text.Substring(0, 3)),
                    int.Parse(cant_textbox.Text));

                lbl_total.Text = lib.getRecaudacionTotal().ToString();

                Producto procesado = lib.obtenerProducto(int.Parse(prod_comboBox.Text.Substring(0, 3)));

                listBox_ventas.Items.Add("----Venta N° " + lib.getCantVentas());
                listBox_ventas.Items.Add(" ");
                listBox_ventas.Items.Add("Producto vendido: " + procesado.getNombre());
                listBox_ventas.Items.Add(procesado.getDescripcion());
                listBox_ventas.Items.Add("Cantidad vendida: " + int.Parse(cant_textbox.Text));
                listBox_ventas.Items.Add("Importe total obtenido de la venta: " + impVenta);
                listBox_ventas.Items.Add(" ");
                listBox_ventas.Items.Add("############");

            }
            else
            {
                /*Form lala = new FormError();
                lala.Show();*/
                lbl_msjError.Text = "ERROR! Debe ingresar un producto y la cantidad vendida.";


            }


            
        }

        private void titulo_txtbox_TextChanged(object sender, EventArgs e)
        {
            lib.setNombre(titulo_txtbox.Text);
           // titulo_txtbox.Enabled = false;
        }
    }
}
