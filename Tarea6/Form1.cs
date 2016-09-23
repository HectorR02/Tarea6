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
        //para el ejercicio 1
        ArrayList notas;
        //para el ejercicio 2
        Hashtable diccionario;
        //Para el ejercicio 3
        Queue clientes;
        //Para el ejercicio 5
        Hashtable agenda;
        public Form1()
        {
            InitializeComponent();
            notas = new ArrayList();
            diccionario = new Hashtable();
            clientes = new Queue();
            agenda = new Hashtable();
        }
       //Funciones o metodos para el ejercicio 1
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
        //Fin de las funciones o metodos para el ejercicio 1

        //Funciones o metodos para el ejercicio 2
        private void Agregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBPal.Text) && !string.IsNullOrEmpty(TBDes.Text))
            {
                diccionario.Add(TBPal.Text, TBDes.Text);
                TBPal.Text = TBDes.Text = null;
                TBPal.Focus();
                if (!Dicc.Enabled)
                    Dicc.Enabled = true;
            }
        }
        private void Dicc_Click(object sender, EventArgs e)
        {
            foreach (DictionaryEntry palabra in diccionario)
                ContPal.AppendText(palabra.Key + ": " + palabra.Value + "\n");
        }
        //Fin de las funciones o metodos para el ejercicio 2   

        //Funciones o metodos para el ejercicio 3       
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBCliente.Text))
            {
                clientes.Enqueue(TBCliente.Text);
                if (!AtClient.Enabled)
                    AtClient.Enabled = true;
                TBCliente.Clear();
                TBCliente.Focus();
                mostrarClientes(clientes);
            }
        }
        private void mostrarClientes(Queue clientes)
        {
            ContClient.Clear();
            int pos = 1;
            foreach(string cliente in clientes)
                ContClient.AppendText(Convert.ToString(pos++) + " - " + cliente + "\n");
        }
        private void AtClient_Click(object sender, EventArgs e)
        {
            if(clientes.Count > 0)
                clientes.Dequeue();
            mostrarClientes(clientes);
            if (clientes.Count == 0)
                AtClient.Enabled = false;
        }
        //Fin de las funciones o metodos para el ejercicio 3
        //Funciones o metodos para el ejercicio 5
        private void Agendar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TBNombre.Text) && !string.IsNullOrEmpty(TBTalf.Text))
            {
                agenda.Add(TBNombre.Text, TBTalf.Text);
                if (!BAgenda.Enabled)
                    BAgenda.Enabled = true;
                TBTalf.Text = TBNombre.Text = null;
                TBNombre.Focus();
            }
        }
        private void BAgenda_Click(object sender, EventArgs e)
        {
            ContContactos.Clear();
            foreach (DictionaryEntry contacto in agenda)
                ContContactos.AppendText(contacto.Key + " - " + contacto.Value + "\n");
        }
        //Fin de las funciones o metodos para el ejercicio 5
    }
}
