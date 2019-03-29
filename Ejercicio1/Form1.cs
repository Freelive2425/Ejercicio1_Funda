using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        CEmpleado objempleado = null; 
        public Form1()
        {
            InitializeComponent();
            llenarcombocategorias();
            configurarlistaempleados();
        }
        void llenarcombocategorias()
        {
            comboBox1.Items.Add("A");
            comboBox1.Items.Add("B");
            comboBox1.Items.Add("C");
            comboBox1.Items.Add("D");
        }
        void configurarlistaempleados()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("Empleado",120);
            listView1.Columns.Add("Categoria", 80);
            listView1.Columns.Add("Minutos tardanza", 120);
            listView1.Columns.Add("Llamadas atencion", 120);
            listView1.Columns.Add("Pago", 120);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objempleado = new CEmpleado();
            objempleado.Nombres = txtNombres.Text;
            objempleado.Categoria = comboBox1.Text;
            objempleado.Tardanza = Convert.ToInt32(txtMinutos.Text);
            objempleado.Atencion = Convert.ToInt32(txtAtencion.Text);
            ListViewItem fila = new ListViewItem(objempleado.Nombres);
            fila.SubItems.Add(objempleado.Categoria);
            fila.SubItems.Add(objempleado.Tardanza.ToString());
            fila.SubItems.Add(objempleado.Atencion.ToString());
            fila.SubItems.Add(objempleado.Calcular_pago().ToString());
            listView1.Items.Add(fila);
            lblNombres.Text = listView1.Items.Count.ToString();
            txtNombres.Clear();
            txtMinutos.Clear();
            txtAtencion.Clear();
            comboBox1.SelectedIndex = -1;
            txtNombres.Focus();
          

        }
    }
}
