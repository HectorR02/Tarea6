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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TBCadena.Text.Trim()))
            {
                string[] cadenasSeparadas = TBCadena.Text.Split(' ');
                Separadas.Clear();
                for (int x = 0; x < cadenasSeparadas.Length; ++x)
                    Separadas.AppendText(cadenasSeparadas[x] + "\n");
                TBCadena.Text = null;
                TBCadena.Focus();
            }
        }
    }
}
