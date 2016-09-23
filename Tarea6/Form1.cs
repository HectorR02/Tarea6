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
        public Form1()
        {
            InitializeComponent();
        }
        
       public float sumatoriaCalf(ArrayList notas)
        {
            float sumatoria = 0.0f;
            foreach (ArrayList dato in notas)
                sumatoria += dato;
            return sumatoria;
        }

        public float promedioCalf(ArrayList notas)
        {
            return sumatoriaCalf(notas) / notas.Count;
        }
    }
}
