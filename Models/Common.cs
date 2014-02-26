using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Common
    {
        public static DataTable converteListDataTable<T>(List<T> list)
        {
            DataTable dt = new DataTable();

            foreach (PropertyInfo info in typeof(T).GetProperties())
            {
                dt.Columns.Add(new DataColumn(info.Name, info.PropertyType));
            }
            foreach (T t in list)
            {
                DataRow row = dt.NewRow();
                foreach (PropertyInfo info in typeof(T).GetProperties())
                {
                    row[info.Name] = info.GetValue(t, null);
                }
                dt.Rows.Add(row);
            }
            return dt;
        }

        public static String getCon()
        {
            string caminhobd;
            List<string> arqlinha = new List<string>();

            string strLine = "";

            FileStream file = new FileStream(Environment.CurrentDirectory + "\\ArqID.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(file);

            while ((strLine = sr.ReadLine()) != null)
            {
                arqlinha.Add(strLine);
            }

            sr.Close();

            file.Close();

            caminhobd = @"Data Source=" + arqlinha[0].ToString() + ";Initial Catalog=CEF;User ID=" + arqlinha[1].ToString() + ";Password=" + arqlinha[2].ToString();

            return caminhobd;
        }
        
    }
}
