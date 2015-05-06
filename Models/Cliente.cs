using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente
    {
        public Int32 Codigo { get; set; }
        public String Nome { get; set; }
        public String Fantasia { get; set; }
        public String CNPJ { get; set; }
        public String IE { get; set; }
        public String Endereco { get; set; }
        public String Numero { get; set; }
        public String Complemento { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String UF { get; set; }
        public String CEP { get; set; }
        public Decimal Valor_Contrato { get; set; }
        public Decimal Valor_Bruto { get; set; }
        public Boolean Contrato_Ativo { get; set; }

        public Cliente()
        {
            Valor_Contrato = 0;
            Valor_Bruto = 0;
            Contrato_Ativo = false;
        }

    }
}
