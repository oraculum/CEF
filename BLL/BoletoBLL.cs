using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BoletoBLL
    {
        public static void save(ref Boleto o)
        {
            if (BoletoDAL.val(o.ID))
                o.ID = BoletoDAL.set(o);
            else
                BoletoDAL.up(o);
        }

        public static void del(Int32 id)
        {
            BoletoDAL.del(id);
        }

        public static Int32 getNext()
        {
            return BoletoDAL.getNext();
        }

        public static Boleto get(Int32 id)
        {
            return BoletoDAL.get(id);
        }

        public static Boleto get(String nossonum)
        {
            return BoletoDAL.get(nossonum);
        }

        public static List<Boleto> listBySituacao(String nome, DateTime datain, DateTime datafn, 
            Int32 situacao, String numdoc, String nossonum)
        {
            if (numdoc.Length > 0)
            {
                List<Boleto> lo = new List<Boleto>();
                lo.Add(get(Int32.Parse(numdoc)));
                return lo;
            }
            else if (nossonum.Length > 0)
                return BoletoDAL.listNossoNum(nossonum);
            else
            {
                if (situacao == 1)
                    return BoletoDAL.listSituacao(datain, datafn, nome, false);
                else if (situacao == 2)
                    return BoletoDAL.listSituacao(datain, datafn, nome, true);
                else
                    return BoletoDAL.listTodas(datain, datafn, nome);
            }
        }

        public static List<Boleto> listBoletos(DateTime datain, DateTime datafn, Boolean recebido)
        {
            return BoletoDAL.listByVencimento(datain, datafn, recebido);
        }
    }
}
