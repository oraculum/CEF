using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Configuracao
    {
        public String Agencia { get; set; }
        public String Conta { get; set; }
        public String ContaDigito { get; set; }
        public String Cedente { get; set; }
        public String CNPJ { get; set; }
        public String RazaoSocial { get; set; }
        public String Descricao { get; set; }

        public Configuracao()
        {
            ContaDigito = String.Empty;
            Descricao = String.Empty;
        }

        public String Conta_Format
        {
            get
            {
                if (Conta.Length > 8)
                    return Conta.Substring(0, 8).PadLeft(8-Conta.Length, '0');
                else
                    return Conta.PadLeft(8 - Conta.Length, '0');
            }
            private set { }
        }
    }
}
