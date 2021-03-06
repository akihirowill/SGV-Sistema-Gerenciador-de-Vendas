﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace Biblioteca.Util
{
    class Registro
    {
        private String strCaminho;

        public Registro()
        {
            //strCaminho = "HKEY_CURRENT_USER\\SistemaBiblioteca2013\\";
            strCaminho = "HKEY_CURRENT_USER\\Software\\SistemaBiblioteca2013\\";
        }

        //método que seta um "valor" no campo "campo"
        public void setValor(String campo, String valor)
        {
            Registry.SetValue(strCaminho, campo, valor, RegistryValueKind.String);

        }
        //método que recupera o conteúdo que está no "registro".
        public String getValor(String campo)
        {
            try
            {
                return Registry.GetValue(strCaminho, campo, "").ToString();
            }
            catch (Exception ex)
            {
                Registry.SetValue(strCaminho, campo, "", RegistryValueKind.String);
                throw new Exception("SubChave '" + campo + "' nao existe.");
            }
        }
    }
}
