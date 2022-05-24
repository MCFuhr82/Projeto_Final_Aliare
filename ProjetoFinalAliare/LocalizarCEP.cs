using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correios.Net;

namespace ProjetoFinalAliare
{
    public static class LocalizarCEP
    {
        public static string estado;
        public static string cidade;
        public static string rua;
        public static bool LocalizaCEP(string txtcep)
        {
            if (!string.IsNullOrWhiteSpace(txtcep))
            {
                Address endereco = SearchZip.GetAddress(txtcep);
                if (endereco.Zip != null)
                {
                    estado = endereco.State;
                    cidade = endereco.City;
                    rua = endereco.Street;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
