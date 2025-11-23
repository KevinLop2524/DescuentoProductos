using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularDescuento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ResultadoButton_Click(object sender, EventArgs e)
        {

            string nombreProducto = NombreProducto.Text;

            if (nombreProducto == "" || nombreProducto == null) 
            { 
                MessageBox.Show("El nombre ingresado no es valido"); return;
             };
            string tipo_producto = TipoProducto.Text;
            try { decimal precio = int.Parse(PrecioProducto.Text);

                switch (tipo_producto)
                {
                    case "Tecnología":
                        decimal resultado = (precio * 0.10m);
                        MessageBox.Show($"El precio total con el descuento es de {resultado:C}$");
                        break;
                    case "Alimento":
                        decimal resultado2 = (precio * 0.2m);
                        MessageBox.Show($"El precio total con el descuento es de {resultado2:C}$");
                        break;
                    case "General":
                        decimal resultado3 = (precio * 0.5m);
                        MessageBox.Show($"El precio total con el descuento es de {resultado3:C}$");
                        break;

                    default:
                        MessageBox.Show("Opción no valida");
                        break;
                }


            } catch { MessageBox.Show("El valor ingresado del producto es invalido"); };
        }

        private void TipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
