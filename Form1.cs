using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TPConstruccion
{  
    public partial class Form1 : Form
    {
        const string ARCHIVO = @"C:\Users\Usuario\OneDrive\Documentos\Facu\3ro\Construcción de software\TP\rifasVendidas.txt";
            
        public Form1()
        {
            InitializeComponent();
        }

        private void cambiarEstadoBtnGuardar()
        {
            if (nombreValido() && apellidoValido() && numeroValido())
            {
                btn_Guardar.Enabled = true;
            }
            else
            {
                btn_Guardar.Enabled = false;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
          
            string numeroIngresado = tbox_NroRifa.Text;
            string nombre = tbox_Nombre.Text;
            string apellido = tbox_Apellido.Text;

            if (numeroDisponible(numeroIngresado))
            {
                guardarRifa(nombre, apellido, numeroIngresado);
                mostrarMensaje($"El numero {numeroIngresado} ha sido asignado a {nombre} {apellido}");
                limpiarDatosRifa();
            }
            else
            {
                mostrarMensaje($"El numero {numeroIngresado} ya fue seleccionado. Ingrese otro numero.");
                limpiarNumeroRifa();
            }
        }

        private void guardarRifa(string nombre, string apellido, string numeroRifa)
        {
            using (StreamWriter sw = new StreamWriter(ARCHIVO, true))
            {
                sw.WriteLine($"{nombre},{apellido},{numeroRifa},{DateTime.Now}");
            }
        }

        private bool numeroDisponible(string numeroIngresado)
        {
            const int POSICION_NUMERO_RIFA = 2;

            bool estaDisponible = true;
            
            using (StreamReader archivo = new StreamReader(ARCHIVO))
            {
                string? linea = archivo.ReadLine();
                
                while (linea != null)
                {
                    string[] datos = linea.Split(',');
                    if (datos[POSICION_NUMERO_RIFA].Equals(numeroIngresado))
                    {
                        estaDisponible = false;
                    }
                    linea = archivo.ReadLine();
                }
            }
            return estaDisponible;
        }

        private void limpiarDatosRifa()
        {
            tbox_Nombre.Clear();
            tbox_Apellido.Clear();
            tbox_NroRifa.Clear();
        }

        private void limpiarNumeroRifa()
        {
            tbox_NroRifa.Clear();
        }

        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private bool nombreValido()
        {
            bool formatoValido = Regex.Match(tbox_Nombre.Text, @"^[A-Za-z]{3,13}$|^[A-Za-z]{3,13}\s[A-Za-z]{3,13}$").Success;

            return formatoValido;
        }

        private bool apellidoValido()
        {
            bool formatoValido = Regex.Match(tbox_Apellido.Text, @"^[A-Za-z]{3,13}$|^[A-Za-z]{3,13}\s[A-Za-z]{3,13}$").Success;

            return formatoValido;
        }

        private bool numeroValido()
        {
            bool formatoValido = Regex.Match(tbox_NroRifa.Text, @"^(?:0|[1-9]\d{0,2})$").Success;
           
            return formatoValido;
        }

        private void tbox_Nombre_TextChanged(object sender, EventArgs e)
        {
            cambiarEstadoBtnGuardar();
        }

        private void tbox_Apellido_TextChanged(object sender, EventArgs e)
        {
            cambiarEstadoBtnGuardar();
        }

        private void tbox_NroRifa_TextChanged(object sender, EventArgs e)
        {
            cambiarEstadoBtnGuardar();
        }
    }
}