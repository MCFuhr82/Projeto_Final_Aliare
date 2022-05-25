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
        //public static string estado;
        public static string cidade;
        public static string rua;
        public static string estado;
        public static bool LocalizaCEP(string txtcep)
        {
            string cep = txtcep.Replace("-", "");
            
            if (!string.IsNullOrWhiteSpace(cep))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(cep.Trim());

                        cidade = endereco.cidade;
                        rua = endereco.end;
                        estado = endereco.uf;

                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            
        }
    }
}
