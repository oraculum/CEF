using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConfiguracaoDAL
    {
        public static void set(Configuracao o)
        {
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "INSERT INTO Configuracao (Agencia, Conta, ContaDigito, Cedente, CNPJ, RazaoSocial, Descricao) VALUES (@Agencia, @Conta, @ContaDigito, @Cedente, @CNPJ, @RazaoSocial, @Descricao)";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@Agencia", o.Agencia);
                    cmd.Parameters.AddWithValue("@Conta", o.Conta);
                    cmd.Parameters.AddWithValue("@ContaDigito", o.ContaDigito);
                    cmd.Parameters.AddWithValue("@Cedente", o.Cedente);
                    cmd.Parameters.AddWithValue("@CNPJ", o.CNPJ);
                    cmd.Parameters.AddWithValue("@RazaoSocial", o.RazaoSocial);
                    cmd.Parameters.AddWithValue("@Descricao", o.Descricao);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public static void del()
        {
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "DELETE FROM Configuracao";

                    SqlCommand cmd = new SqlCommand(SQL, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public static Configuracao get()
        {
            Configuracao o = new Configuracao();
            SqlDataReader dr = null;
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "SELECT Agencia, Conta, ContaDigito, Cedente, CNPJ, RazaoSocial, Descricao FROM Configuracao";

                    SqlCommand cmd = new SqlCommand(SQL, con);

                    con.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {
                        o.Agencia = dr[0].ToString();
                        o.Conta = dr[1].ToString();
                        o.ContaDigito = dr[2].ToString();
                        o.Cedente = dr[3].ToString();
                        o.CNPJ = dr[4].ToString();
                        o.RazaoSocial = dr[5].ToString();
                        o.Descricao = dr[6].ToString();
                        break;
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
            return o;
        }
    }
}
