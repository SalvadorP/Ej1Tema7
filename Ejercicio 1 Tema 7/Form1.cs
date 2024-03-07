using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_Tema_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Persona persona = new Persona();

        private void leerBtn_Click(object sender, EventArgs e)
        {
            resultadoLabel.Text = "";

            string sexo;
            DialogResult casado;

            persona.Nombre = Interaction.InputBox("Introduzca el nombre:", "Ejercicio 1");
            persona.Edad = int.Parse(Interaction.InputBox("Introduzca la edad:", "Ejercicio 1"));
            persona.Telefono = Interaction.InputBox("Introduzca el teléfono:", "Ejercicio 1");

            persona.Sexo = Interaction.InputBox("Introduzca el sexo (M - Masculino / F - Femenino)", "Ejercicio 1");

            persona.Casado = MessageBox.Show("¿Está casado/a)", "Estado civil", MessageBoxButtons.YesNo);

        }

        private void mostrarBtn_Click(object sender, EventArgs e)
        {
            string texto = persona.mostrarDatos();
            persona.Edad = 0;
            int diasVivo = persona.calculaDiasVivo();
            texto += 'Dias Vivo = ' + diasVivo;

            resultadoLabel.Text = texto;
        }
    }
}
