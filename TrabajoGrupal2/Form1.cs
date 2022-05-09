using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoGrupal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double subTotal=0, impuesto, descuento, total;
            string resumen = txtNombre.Text+", su orden incluye: \r\n";
            int edad, indice = lstbTamanos.SelectedIndex;

            if (rbPanPizza.Checked)
            {
                subTotal += 50.00;
                resumen += "> Masa Pan Pizza: L. 50.00 \r\n";
            } 
            else
            {
                if (rbArtesanal.Checked)
                {
                    subTotal += 40.00;
                    resumen += "> Masa Artesanal: L.40.00 \r\n";
                }
                else
                {
                    if (rbDelgada.Checked)
                    {
                        subTotal += 30.00;
                        resumen += "> Masa Delgada: L.30.00 \r\n";
                    } 
                }
            }

            /*if (rbGrande.Checked)
                subTotal += 75.00;
            else
             if (rbExtraGrande.Checked)
                subTotal += 85.00;*/

            if(lstbTamanos.SelectedIndex != -1)
            {
                if (lstbTamanos.Items[lstbTamanos.SelectedIndex] == "Grande")
                {
                    subTotal += 75.00;
                    resumen += "> Pizza Grande: L. 75.00 \r\n";
                }
                else
                {
                    subTotal += 85.00;
                    resumen += "> Pizza Extra Grande: L. 85.00 \r\n";
                }
            }

            if (chkPepperoni.Checked)
            {
                subTotal += 35.00;
                resumen += "> Pepperoni: L.35.00 \r\n";
            }

            if (chkHongos.Checked)
            {
                subTotal += 15.00;
                resumen += "> Hongos: L.15.00 \r\n";
            }    

            if (chkSalchicha.Checked)
            {
                subTotal += 40.00;
                resumen += "> Salchicha: L.40.00 \r\n";
            }

            if (chkAceitunas.Checked)
            {
                subTotal += 10.00;
                resumen += "> Aceitunas: L.10.00 \r\n";
            }

            edad = Convert.ToInt32(txtEdad.Text);

            if (edad >= 60)
            {
                descuento = subTotal * 0.25;
                subTotal = subTotal - descuento;
            }
            else
                descuento = 0.00;

            impuesto = subTotal * 0.15;

            total = subTotal - descuento + impuesto;

            txtSubTotal.Text = subTotal.ToString("n2");
            txtDescuento.Text = descuento.ToString("n2");
            txtImpuesto.Text = impuesto.ToString("n2");
            txtTotal.Text = total.ToString("n2");
            txtResumen.Text = resumen;
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbEdad_Scroll(object sender, EventArgs e)
        {
            txtEdad.Text = tbEdad.Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSubTotal.Text = "0.00";
            txtDescuento.Text = "0.00";
            txtImpuesto.Text = "0.00";
            txtTotal.Text = "0.00";
            tbEdad.Value = 0;
            txtEdad.Text = tbEdad.Value.ToString();
            txtResumen.Clear();
            txtNombre.Clear();
            chkAceitunas.Checked = false;
            chkHongos.Checked = false;
            chkJamon.Checked = false;
            chkPepperoni.Checked = false;
            chkSalchicha.Checked = false;
            lstbTamanos.ClearSelected();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void txtResumen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
