using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public class Validar
    {
        public static void LimpiarCajaTexto(Form formulario)
        {            
            foreach (Control control in formulario.Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control caja in control.Controls)
                    {
                        if (caja is TextBox)
                        {
                            caja.Text = string.Empty;
                        }
                    }
                }
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }
        }

        public static void DeshabilitarCajaTexto(Form formulario)
        {
            foreach (Control control in formulario.Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control caja in control.Controls)
                    {
                        if (caja is TextBox)
                        {
                            caja.Enabled = false;
                        }
                    }
                }
                if (control is TextBox)
                {
                    control.Enabled = false;
                }
            }
        }
    }
}
