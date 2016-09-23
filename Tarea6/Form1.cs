using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea6
{
    public partial class Form1 : Form
    {
        ArrayList notas;
        Hashtable diccionario;
        public Form1()
        {
            InitializeComponent();
            notas = new ArrayList();
            diccionario = new Hashtable();
        }
        
       public float sumatoriaCalf(ArrayList notas)
        {
            float sumatoria = 0.0f;
            foreach (float dato in notas)
                sumatoria += dato;
            return sumatoria;
        }

        public float promedioCalf(ArrayList notas)
        {
            return sumatoriaCalf(notas) / notas.Count;
        }

        public float calfMax(ArrayList notas)
        {
            float max = 0.0f;
            foreach (float dato in notas)
                if (max < dato)
                    max = dato;
            return max;
        }

        public float calfMin(ArrayList notas)
        {
            float min = 101.0f;
            foreach (float dato in notas)
                if (min > dato)
                    min = dato;
            return min;
        }

        private void AgrCalf_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TBCalf.Text))
            {
                notas.Add(Convert.ToSingle(TBCalf.Text));
                TBCalf.Clear();
                TBCalf.Focus();
                if (!Resultados.Enabled)
                    Resultados.Enabled = true;
                if (!string.IsNullOrEmpty(TBMax.Text))
                    TBMax.Text = TBMin.Text = TBProm.Text = null;
            }
        }

        private void Resultados_Click(object sender, EventArgs e)
        {
            TBMax.Text = Convert.ToString(calfMax(notas));
            TBMin.Text = Convert.ToString(calfMin(notas));
            TBProm.Text = Convert.ToString(promedioCalf(notas));
            notas.Clear();
            TBCalf.Focus();
            Resultados.Enabled = false;
        }
    }
}
