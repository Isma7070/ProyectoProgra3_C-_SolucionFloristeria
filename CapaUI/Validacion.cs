using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUI
{
    public class Validacion
    {
        public static void SoloLetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }else
            {
                if (char.IsSeparator(v.KeyChar))
                {
                    v.Handled = false;
                }else
                {
                    if (char.IsControl(v.KeyChar))
                    {
                        v.Handled = false;
                    }else
                    {
                        v.Handled = true;
                        MessageBox.Show("Solo puede ingresar letras.");
                    }
                }
            }
        }



        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                if (char.IsSeparator(v.KeyChar))
                {
                    v.Handled = false;
                }
                else
                {
                    if (char.IsControl(v.KeyChar))
                    {
                        v.Handled = false;
                    }
                    else
                    {
                        v.Handled = true;
                        MessageBox.Show("Solo puede ingresar numeros enteros.");
                    }
                }
            }
        }

        public static void SoloNumerosDecimales(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo puede ingresar numeros enteros o con punto decimal.");
            }
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static bool VacioNullEnBlanco(string hilera)
        {
            if (string.IsNullOrWhiteSpace(hilera))
            {
                return true;
            }
            return false;
        }
    }
}
