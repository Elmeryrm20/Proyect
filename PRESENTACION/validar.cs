﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;

namespace PRESENTACION
{
    class validar
    {
        public static void soloNumeros(KeyPressEventArgs pE)
        {

            if (Char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        public static void SoloLetras(KeyPressEventArgs pE)
        {
            if (char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = true;
            }
            else
            {
                pE.Handled = true;
            }
        }
        public void Texto_Inmodificable(KeyPressEventArgs pE)
        {
            pE.Handled = true;
        }


    }
}
