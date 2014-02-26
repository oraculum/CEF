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
    public class ClienteDAL
    {
        public static void set(Cliente o)
        {
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "INSERT INTO Cliente (Codigo, Nome, Fantasia, CNPJ, IE, Endereco, " +
                        "Numero, Complemento, Bairro, Cidade, UF, CEP) VALUES (@Codigo, @Nome, " +
                        "@Fantasia, @CNPJ, @IE, @Endereco, @Numero, @Complemento, @Bairro, @Cidade, @UF, @CEP)";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@Codigo", o.Codigo);
                    cmd.Parameters.AddWithValue("@Nome", o.Nome);
                    cmd.Parameters.AddWithValue("@Fantasia", o.Fantasia);
                    cmd.Parameters.AddWithValue("@CNPJ", o.CNPJ);
                    cmd.Parameters.AddWithValue("@IE", o.IE);
                    cmd.Parameters.AddWithValue("@Endereco", o.Endereco);
                    cmd.Parameters.AddWithValue("@Numero", o.Numero);
                    cmd.Parameters.AddWithValue("@Complemento", o.Complemento);
                    cmd.Parameters.AddWithValue("@Bairro", o.Bairro);
                    cmd.Parameters.AddWithValue("@Cidade", o.Cidade);
                    cmd.Parameters.AddWithValue("@UF", o.UF);
                    cmd.Parameters.AddWithValue("@CEP", o.CEP);

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

        public static void up(Cliente o)
        {
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "UPDATE Cliente SET Nome = @Nome, Fantasia = @Fantasia, " +
                        "CNPJ = @CNPJ, IE = @IE, Endereco = @Endereco, Numero = @Numero, " +
                        "Complemento = @Complemento, Bairro = @Bairro, Cidade = @Cidade, " +
                        "UF = @UF, CEP = @CEP WHERE (Codigo = @Codigo)";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@Nome", o.Nome);
                    cmd.Parameters.AddWithValue("@Fantasia", o.Fantasia);
                    cmd.Parameters.AddWithValue("@CNPJ", o.CNPJ);
                    cmd.Parameters.AddWithValue("@IE", o.IE);
                    cmd.Parameters.AddWithValue("@Endereco", o.Endereco);
                    cmd.Parameters.AddWithValue("@Numero", o.Numero);
                    cmd.Parameters.AddWithValue("@Complemento", o.Complemento);
                    cmd.Parameters.AddWithValue("@Bairro", o.Bairro);
                    cmd.Parameters.AddWithValue("@Cidade", o.Cidade);
                    cmd.Parameters.AddWithValue("@UF", o.UF);
                    cmd.Parameters.AddWithValue("@CEP", o.CEP);
                    cmd.Parameters.AddWithValue("@Codigo", o.Codigo);

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

        public static void del(Int32 codigo)
        {
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "DELETE FROM Cliente WHERE (Codigo = @Codigo)";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

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

        public static Boolean val(Int32 codigo)
        {
            Boolean val = false;
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "SELECT COUNT(Codigo) AS Expr1 FROM Cliente WHERE (Codigo = @Codigo)";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    con.Open();
                    Int16 i = Int16.Parse(cmd.ExecuteScalar().ToString());

                    if (i == 0)
                        val = true;
                    else
                        val = false;
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
            return val;
        }

        public static Int32 getLast()
        {
            Int32 last = new Int32();
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "SELECT IsNull(Max(Codigo), 0) FROM Cliente";

                    SqlCommand cmd = new SqlCommand(SQL, con);

                    con.Open();
                    last = Int16.Parse(cmd.ExecuteScalar().ToString());
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
            return last;
        }

        public static Cliente get(Int32 codigo)
        {
            Cliente o = new Cliente();
            SqlDataReader dr = null;
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "SELECT Codigo, Nome, Fantasia, CNPJ, IE, Endereco, Numero, " +
                        "Complemento, Bairro, Cidade, UF, CEP FROM Cliente WHERE Codigo = @Codigo";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    con.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {
                        o.Codigo = Int32.Parse(dr[0].ToString());
                        o.Nome = dr[1].ToString();
                        o.Fantasia = dr[2].ToString();
                        o.CNPJ = dr[3].ToString();
                        o.IE = dr[4].ToString();
                        o.Endereco = dr[5].ToString();
                        o.Numero = dr[6].ToString();
                        o.Complemento = dr[7].ToString();
                        o.Bairro = dr[8].ToString();
                        o.Cidade = dr[9].ToString();
                        o.UF = dr[10].ToString();
                        o.CEP = dr[11].ToString();
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

        public static List<Cliente> list(String nome)
        {
            List<Cliente> lo = new List<Cliente>();
            SqlDataReader dr = null;

            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "SELECT Codigo, Nome, Fantasia, CNPJ, IE, Endereco, Numero, " +
                        "Complemento, Bairro, Cidade, UF, CEP FROM Cliente " +
                        "WHERE (Nome LIKE @Nome) OR (Fantasia LIKE @Nome) ORDER BY Nome";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@Nome", nome + "%");


                    con.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {
                        Cliente o = new Cliente();
                        o.Codigo = Int32.Parse(dr[0].ToString());
                        o.Nome = dr[1].ToString();
                        o.Fantasia = dr[2].ToString();
                        o.CNPJ = dr[3].ToString();
                        o.IE = dr[4].ToString();
                        o.Endereco = dr[5].ToString();
                        o.Numero = dr[6].ToString();
                        o.Complemento = dr[7].ToString();
                        o.Bairro = dr[8].ToString();
                        o.Cidade = dr[9].ToString();
                        o.UF = dr[10].ToString();
                        o.CEP = dr[11].ToString();

                        lo.Add(o);
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

            return lo;
        }

        public static List<Cliente> listAll()
        {
            List<Cliente> lo = new List<Cliente>();
            SqlDataReader dr = null;

            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "SELECT Codigo, Nome, Fantasia, CNPJ, IE, Endereco, Numero, " +
                        "Complemento, Bairro, Cidade, UF, CEP FROM Cliente ORDER BY Nome";

                    SqlCommand cmd = new SqlCommand(SQL, con);

                    con.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {
                        Cliente o = new Cliente();
                        o.Codigo = Int32.Parse(dr[0].ToString());
                        o.Nome = dr[1].ToString();
                        o.Fantasia = dr[2].ToString();
                        o.CNPJ = dr[3].ToString();
                        o.IE = dr[4].ToString();
                        o.Endereco = dr[5].ToString();
                        o.Numero = dr[6].ToString();
                        o.Complemento = dr[7].ToString();
                        o.Bairro = dr[8].ToString();
                        o.Cidade = dr[9].ToString();
                        o.UF = dr[10].ToString();
                        o.CEP = dr[11].ToString();

                        lo.Add(o);
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

            return lo;
        }
    }
}
