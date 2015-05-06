using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Boleto
    {
        public Int32 ID { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime Vencimento { get; set; }
        public Decimal Valor { get; set; }
        public String NossoNum { get; set; }
        public String Obs1 { get; set; }
        public String Obs2 { get; set; }
        public String Obs3 { get; set; }
        public Boolean Recebido { get; set; }
        public DateTime DataRecebido { get; set; }
        public Decimal ValorRecebido { get; set; }

        public Decimal Valor_Bruto { get; set; }
        
        public Boleto()
        {
            Cliente = new Cliente();
            Emissao = DateTime.Now.Date;
            NossoNum = "";
            DataRecebido = DateTime.Parse("1/1/1900");
            ValorRecebido = 0;
            Valor_Bruto = 0;
        }

        public String Cliente_Nome
        {
            get { return Cliente.Nome; }
        }

        public String Cliente_Nome_Fantasia
        {
            get { return Cliente.Fantasia; }
        }

        public String Cliente_Nome_Razao
        {
            get
            {
                int max = 30;
                if (Cliente.Nome.Length < 30)
                    max = Cliente.Nome.Length;

                return Cliente.Nome.Substring(0, max);
            }
        }

        public Int32 Cliente_Codigo
        {
            get { return Cliente.Codigo; }
        }

        public String DataRecebido_Format
        {
            get { return (DataRecebido == DateTime.Parse("1/1/1900") ? "" : DataRecebido.ToShortDateString()); }
        }
    }
}
