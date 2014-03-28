using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace SistemaGerenciadordeVendas.Resources
{
    class Registro
    {
        private String strCaminho;
        public Registro()
        {
            strCaminho = "HKEY_CURRENT_USER\\Software\\SistemaGerenciadordeVendas\\";
        }
        public void setValor(String campo, String valor)
        {
            Registry.SetValue(strCaminho, campo, valor, RegistryValueKind.String);
        }

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

