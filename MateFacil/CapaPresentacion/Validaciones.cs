using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CapaNegocio
{
    class Validaciones
    {
        public static void ArrobaYPunto(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("@"))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        public static void LetrasYNumeros(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        public static void SoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


        }
        public static void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public static void NumeroDecimal(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
