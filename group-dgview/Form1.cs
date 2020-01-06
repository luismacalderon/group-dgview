using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group_dgview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Empleado> ListaEmpleado = new List<Empleado>();
        Subro.Controls.DataGridViewGrouper grupperListaEmpleados = new Subro.Controls.DataGridViewGrouper();

        private void Form1_Shown(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = "Luis Manuel Calderón Molina";
            empleado.Pais = "Nicaragua";
            empleado.Edad = 39;
            ListaEmpleado.Add(empleado);

            empleado = new Empleado();
            empleado.Nombre = "Scarleth Moreno";
            empleado.Pais = "Nicaragua";
            empleado.Edad = 40;
            ListaEmpleado.Add(empleado);

            empleado = new Empleado();
            empleado.Nombre = "Derek Calderón";
            empleado.Pais = "Nicaragua";
            empleado.Edad = 12;
            ListaEmpleado.Add(empleado);

            empleado = new Empleado();
            empleado.Nombre = "Juan Pérez";
            empleado.Pais = "Londres";
            empleado.Edad = 18;
            ListaEmpleado.Add(empleado);

            empleado = new Empleado();
            empleado.Nombre = "Jhonn Steven";
            empleado.Pais = "Londres";
            empleado.Edad = 28;
            ListaEmpleado.Add(empleado);

            empleado = new Empleado();
            empleado.Nombre = "Christopher Smith";
            empleado.Pais = "USA";
            empleado.Edad = 60;
            ListaEmpleado.Add(empleado);

            empleado = new Empleado();
            empleado.Nombre = "Antony Brooks";
            empleado.Pais = "USA";
            empleado.Edad = 36;
            ListaEmpleado.Add(empleado);

            dataGridView1.DataSource = ListaEmpleado;
            dataGridView1.Columns["Nombre"].Width = 250;
            dataGridView1.AllowUserToAddRows = false;

            grupperListaEmpleados = new Subro.Controls.DataGridViewGrouper(dataGridView1);

        }

        private void AgruparListaEmpleados(bool Valor)
        {
            if (Valor == true)
            {
                grupperListaEmpleados.RemoveGrouping();
                grupperListaEmpleados.SetGroupOn("Pais");
                grupperListaEmpleados.Options.ShowGroupName = false;
                grupperListaEmpleados.Options.GroupSortOrder = System.Windows.Forms.SortOrder.None;
                dataGridView1.Columns["Pais"].Visible = false;

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.ClearSelection();
            }
            else
            {
                grupperListaEmpleados.RemoveGrouping();
                dataGridView1.RowHeadersVisible = true;
                dataGridView1.Columns["Pais"].Visible = true;
            }
        }

        private void chkAgrupar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgrupar.CheckState == CheckState.Checked)
            {
                AgruparListaEmpleados(true);
            }
            else
            {
                AgruparListaEmpleados(false);
            }
        }

        private void chkContraerColapsar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContraerColapsar.CheckState == CheckState.Checked)
            {
                grupperListaEmpleados.CollapseAll();
            }
            else
            {
                grupperListaEmpleados.ExpandAll();
            }
        }
    }

    class Empleado
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public int Edad { get; set; }
    }
}
