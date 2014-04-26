using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConfiguracaoBLL
    {
        public static void save(Configuracao o)
        {
            DAL.ConfiguracaoDAL.del();
            DAL.ConfiguracaoDAL.set(o);
        }

        public static Configuracao get()
        {
            return DAL.ConfiguracaoDAL.get();
        }
    }
}
