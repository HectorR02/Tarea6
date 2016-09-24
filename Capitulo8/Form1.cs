using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo8
{
    public partial class Capitulo8 : Form
    {
        public Capitulo8()
        {
            InitializeComponent();
            CBJustificar.SelectedIndex = 0;
            CBOperacion.SelectedIndex = 0;
        }
        //Ejercicio 1
        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TBCadena.Text))
            {
                string[] cadenasSeparadas = TBCadena.Text.Split(' ');
                Separadas.Clear();
                for (int x = 0; x < cadenasSeparadas.Length; ++x)
                    Separadas.AppendText(cadenasSeparadas[x] + "\n");
                TBCadena.Text = null;
                TBCadena.Focus();
            }
        }
        //Ejercicio 2
        private void AgrJust_Click(object sender, EventArgs e)
        {
            string cadena;
            if(!string.IsNullOrEmpty(TBCad.Text) && CBJustificar.SelectedIndex > 0)
            {
                cadena = TBCad.Text;
                if (CBJustificar.SelectedIndex == 1)
                    RTBPalJust.AppendText(cadena.PadRight(20)+"\n");
                else
                    if (CBJustificar.SelectedIndex == 2)
                        RTBPalJust.AppendText(cadena.PadLeft(20) + "\n");
                TBCad.Clear();
                TBCad.Focus();
            }
            

        }
        //Ejercicio 3
        private void ActHora_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBDatTim.Text))
                TBDatTim.Clear();
            string fecha = string.Format("{0:h:mm tt yy/dd/MM}", DateTime.Now);
            TBDatTim.Text = fecha;
        }
        //Ejercicio 4
        private void Resultado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBNum1.Text) && !string.IsNullOrEmpty(TBnum2.Text))
            {
                int num1 = Convert.ToInt32(TBNum1.Text), num2 = Convert.ToInt32(TBnum2.Text);
                if (CBOperacion.SelectedIndex == 0)
                {
                    if (num1 + num2 > 0)
                        TBResultado.Text = (num1 + num2).ToString();
                    else
                        TBResultado.Text = '(' + (num1 + num2).ToString() + ')';
                }
                else
                {
                    if (num1 - num2 > 0)
                        TBResultado.Text = (num1 - num2).ToString();
                    else
                        TBResultado.Text = '(' + (num1 - num2).ToString() + ')';
                }
                TBNum1.Text = TBnum2.Text = null;
                TBNum1.Focus();
            }
        }
        //Ejercicio 5
        private void ordenarCadenas(string cad1, string cad2)
        {
            int tam = Math.Min(cad1.Length,cad2.Length);
            char[] arr1 = cad1.ToCharArray();
            char[] arr2 = cad2.ToCharArray();
            bool huboM = false;
            for(int x = 0; x < tam; ++x)
            {
                int a = Convert.ToInt32(arr1[x]), b = Convert.ToInt32(arr2[x]);
                if (a < b)
                {
                    RTBOrdenadas.AppendText(cad1 + "\n" + cad2);
                    huboM = true;
                    break;
                }
                if (b < a)
                {
                    RTBOrdenadas.AppendText(cad2 + "\n" + cad1);
                    huboM = true;
                    break;
                }
            }
            if(!huboM)
            {
                if (cad1.Length > cad2.Length)
                    RTBOrdenadas.AppendText(cad2 + "\n" + cad1);
                else
                    RTBOrdenadas.AppendText(cad1 + "\n" + cad2);
            }

        }
        private void ordenar_Click(object sender, EventArgs e)
        {
            RTBOrdenadas.Clear();
            if (!string.IsNullOrEmpty(TBCad1.Text) && !string.IsNullOrEmpty(TBCad2.Text))
                ordenarCadenas(TBCad1.Text, TBCad2.Text);
            TBCad1.Text = TBCad2.Text = null;
            TBCad1.Focus();
        }        
    }
}
