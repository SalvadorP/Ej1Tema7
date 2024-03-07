using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Tema_7
{
    internal class Persona
    {
        //Miembros
        public string nom;
        public int ed;
        public string tel;
        public char sex;
        public bool casado;

        public const int ERROR_DATOS = -1;
        //Propiedades

        public int Ed
        {
            get { return ed; }
            set
            {
                if (value >= 0) {
                    if (value <= 100) {
                        ed = value;
                    }
                }
                else {
                    ed = Persona.ERROR_DATOS;
                }
                if (value != Persona.ERROR_DATOS) {
                    ed = value;
                }
            }
        }

        //Métodos
        public string mostrarDatos(nom, ed, tel)
        {
            string texto;

            texto = "Datos de la persona:\n";
            texto += "Nombre: " + nom + "\n";
            texto += "Edad: " + ed + "\n";
            texto += "Teléfono: " + tel + "\n";

            if (sex == 'M')
            {
                texto += "Sexo: Masculino\n";
            }
            else
            {
                texto += "Sexo: Femenino\n";
            }

            if (casado)
            {
                texto += "Estado civil: Casado/a";
            }
            else
            {
                texto += "Estado civil: Soltero/a";
            }

            return texto;
        }

        public calculaDiasVivo(edad) {
            // Dada la edad de la persona calcula el numero de dias vivo mEdad*365.
            int diasVivo = 0;
            if (ed > 0) {
                diasVivo = ed * 365;
            } else {
                diasVivo = Persona.ERROR_DATOS;
            }
            return diasVivo;
        }

        public esperanzaVida(nom, tel) {
            int esperanzaVida = 0;
            if (ed < 50) {
                esperanzaVida = ed + 50;
            }
            if (ed > 50)  {
                esperanzaVida = ed + 25;
            }

        }
    }
}

/*
Renombrar
Encapsular campo -> make public private
Extraer metodo -> codigo comun, refactorizar
Qutiar parametros -> si hay parametros extra quitarlos.
Reordenar parametros.
Reemplazar numero magico por constate.
*/