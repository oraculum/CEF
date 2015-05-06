using Entity;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteBLL
    {
        public static void save(Cliente o)
        {
            if (ClienteDAL.val(o.Codigo))
                ClienteDAL.set(o);
            else
                ClienteDAL.up(o);
        }

        public static void del(Int32 codigo)
        {
            ClienteDAL.del(codigo);
        }

        public static Int32 nextCodigo()
        {
            String last = ClienteDAL.getLast().ToString();
            return Int32.Parse(last) + 1;
        }

        public static Cliente get(Int32 codigo)
        {
            return ClienteDAL.get(codigo);
        }

        public static List<Cliente> list(String nome)
        {
            return ClienteDAL.list(nome);
        }

        public static List<Cliente> listAll()
        {
            return ClienteDAL.listAll();
        }

        public static List<Cliente> listAll__Contrato_Ativo()
        {
            return ClienteDAL.listAll__Contrato_Ativo();
        }
    }
}
