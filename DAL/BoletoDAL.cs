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
    public class BoletoDAL
    {
        public static Int32 set(Boleto o)
        {
            Int32 id = 0;
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "INSERT INTO Boleto (Cliente, Emissao, Vencimento, " +
                        "Valor, NossoNum, Obs1, Obs2, Obs3, Recebido, DataRecebido, ValorRecebido) " +
                        "VALUES (@Cliente, @Emissao, @Vencimento, " +
                        "@Valor, @NossoNum, @Obs1, @Obs2, @Obs3, @Recebido, @DataRecebido, " +
                        "@ValorRecebido); SELECT @@Identity";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@Cliente", o.Cliente.Codigo);
                    cmd.Parameters.AddWithValue("@Emissao", o.Emissao);
                    cmd.Parameters.AddWithValue("@Vencimento", o.Vencimento);
                    cmd.Parameters.AddWithValue("@Valor", o.Valor);
                    cmd.Parameters.AddWithValue("@NossoNum", o.NossoNum);
                    cmd.Parameters.AddWithValue("@Obs1", o.Obs1);
                    cmd.Parameters.AddWithValue("@Obs2", o.Obs2);
                    cmd.Parameters.AddWithValue("@Obs3", o.Obs3);
                    cmd.Parameters.AddWithValue("@Recebido", o.Recebido);
                    cmd.Parameters.AddWithValue("@DataRecebido", o.DataRecebido);
                    cmd.Parameters.AddWithValue("@ValorRecebido", o.ValorRecebido);

                    con.Open();
                    id = Int32.Parse(cmd.ExecuteScalar().ToString());
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
            return id;
        }

        public static void up(Boleto o)
        {
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "UPDATE Boleto SET Cliente = @Cliente, Emissao = @Emissao, " +
                        "Vencimento = @Vencimento, Valor = @Valor, " +
                        "NossoNum = @NossoNum, Obs1 = @Obs1, Obs2 = @Obs2, Obs3 = @obs3, " +
                        "Recebido = @Recebido, DataRecebido = @DataRecebido, ValorRecebido = @ValorRecebido " +
                        "WHERE (ID = @ID)";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@Cliente", o.Cliente.Codigo);
                    cmd.Parameters.AddWithValue("@Emissao", o.Emissao);
                    cmd.Parameters.AddWithValue("@Vencimento", o.Vencimento);
                    cmd.Parameters.AddWithValue("@Valor", o.Valor);
                    cmd.Parameters.AddWithValue("@NossoNum", o.NossoNum);
                    cmd.Parameters.AddWithValue("@Obs1", o.Obs1);
                    cmd.Parameters.AddWithValue("@Obs2", o.Obs2);
                    cmd.Parameters.AddWithValue("@Obs3", o.Obs3);
                    cmd.Parameters.AddWithValue("@Recebido", o.Recebido);
                    cmd.Parameters.AddWithValue("@DataRecebido", o.DataRecebido);
                    cmd.Parameters.AddWithValue("@ValorRecebido", o.ValorRecebido);
                    cmd.Parameters.AddWithValue("@ID", o.ID);

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

        public static void del(Int32 id)
        {
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "DELETE FROM Boleto WHERE (ID = @ID)";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@ID", id);

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

        public static Int32 getNext()
        {
            Int32 last = new Int32();
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "SELECT IsNull(Max(ID), 0) FROM Boleto";

                    SqlCommand cmd = new SqlCommand(SQL, con);

                    con.Open();
                    last = Int32.Parse(cmd.ExecuteScalar().ToString());
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

            last += 1;
            return last;
        }

        public static Boolean val(Int32 id)
        {
            Boolean val = false;
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "SELECT COUNT(ID) AS Expr1 FROM Boleto WHERE (ID = @ID)";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@ID", id);

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

        public static Boleto get(Int32 id)
        {
            Boleto o = new Boleto();
            SqlDataReader dr = null;
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "SELECT ID, Cliente, Emissao, Vencimento, " +
                        "Valor, NossoNum, Obs1, Obs2, Obs3, Recebido, DataRecebido, ValorRecebido " +
                        "FROM Boleto WHERE ID = @ID";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {
                        o.ID = Int32.Parse(dr[0].ToString());
                        o.Cliente = DAL.ClienteDAL.get(Int32.Parse(dr[1].ToString()));
                        o.Emissao = DateTime.Parse(dr[2].ToString());
                        o.Vencimento = DateTime.Parse(dr[3].ToString());
                        o.Valor = Decimal.Parse(dr[4].ToString());
                        o.NossoNum = dr[5].ToString();
                        o.Obs1 = dr[6].ToString();
                        o.Obs2 = dr[7].ToString();
                        o.Obs3 = dr[8].ToString();
                        o.Recebido = Boolean.Parse(dr[9].ToString());
                        o.DataRecebido = DateTime.Parse(dr[10].ToString());
                        o.ValorRecebido = Decimal.Parse(dr[11].ToString());
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

        public static Boleto get(String nossonum)
        {
            Boleto o = new Boleto();
            SqlDataReader dr = null;
            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "SELECT ID, Cliente, Emissao, Vencimento, " +
                        "Valor, NossoNum, Obs1, Obs2, Obs3, Recebido, DataRecebido, ValorRecebido " +
                        "FROM Boleto WHERE NossoNum = @NossoNum";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@NossoNum", nossonum);

                    con.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {
                        o.ID = Int32.Parse(dr[0].ToString());
                        o.Cliente = DAL.ClienteDAL.get(Int32.Parse(dr[1].ToString()));
                        o.Emissao = DateTime.Parse(dr[2].ToString());
                        o.Vencimento = DateTime.Parse(dr[3].ToString());
                        o.Valor = Decimal.Parse(dr[4].ToString());
                        o.NossoNum = dr[5].ToString();
                        o.Obs1 = dr[6].ToString();
                        o.Obs2 = dr[7].ToString();
                        o.Obs3 = dr[8].ToString();
                        o.Recebido = Boolean.Parse(dr[9].ToString());
                        o.DataRecebido = DateTime.Parse(dr[10].ToString());
                        o.ValorRecebido = Decimal.Parse(dr[11].ToString());
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

        public static List<Boleto> listTodas(DateTime datain, DateTime datafn, String nome)
        {
            List<Boleto> lo = new List<Boleto>();
            SqlDataReader dr = null;

            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "SELECT ID, Cliente, Emissao, Vencimento, " +
                        "Valor, NossoNum, Obs1, Obs2, Obs3, Recebido, DataRecebido, ValorRecebido, Valor_Bruto " +
                        "FROM Boleto INNER JOIN Cliente ON Boleto.Cliente = Cliente.Codigo " +
                        "WHERE ((Cliente.Nome LIKE @Nome) OR (Cliente.Fantasia LIKE @Nome)) AND " +
                        "(Vencimento BETWEEN @DataIN AND @DataFN) " +
                        "ORDER BY ID";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");
                    cmd.Parameters.AddWithValue("@DataIN", datain);
                    cmd.Parameters.AddWithValue("@DataFN", datafn);


                    con.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {
                        Boleto o = new Boleto();
                        o.ID = Int32.Parse(dr[0].ToString());
                        o.Cliente = DAL.ClienteDAL.get(Int32.Parse(dr[1].ToString()));
                        o.Emissao = DateTime.Parse(dr[2].ToString());
                        o.Vencimento = DateTime.Parse(dr[3].ToString());
                        o.Valor = Decimal.Parse(dr[4].ToString());
                        o.NossoNum = dr[5].ToString();
                        o.Obs1 = dr[6].ToString();
                        o.Obs2 = dr[7].ToString();
                        o.Obs3 = dr[8].ToString();
                        o.Recebido = Boolean.Parse(dr[9].ToString());
                        o.DataRecebido = DateTime.Parse(dr[10].ToString());
                        o.ValorRecebido = Decimal.Parse(dr[11].ToString());
                        o.Valor_Bruto = Decimal.Parse(dr[12].ToString());

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

        public static List<Boleto> listNossoNum(String nossonum)
        {
            List<Boleto> lo = new List<Boleto>();
            SqlDataReader dr = null;

            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "SELECT ID, Cliente, Emissao, Vencimento, " +
                        "Valor, NossoNum, Obs1, Obs2, Obs3, Recebido, DataRecebido, ValorRecebido " +
                        "FROM Boleto WHERE (NossoNum LIKE @NossoNum) " +
                        "ORDER BY ID";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@NossoNum", "%" + nossonum + "%");


                    con.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {
                        Boleto o = new Boleto();
                        o.ID = Int32.Parse(dr[0].ToString());
                        o.Cliente = DAL.ClienteDAL.get(Int32.Parse(dr[1].ToString()));
                        o.Emissao = DateTime.Parse(dr[2].ToString());
                        o.Vencimento = DateTime.Parse(dr[3].ToString());
                        o.Valor = Decimal.Parse(dr[4].ToString());
                        o.NossoNum = dr[5].ToString();
                        o.Obs1 = dr[6].ToString();
                        o.Obs2 = dr[7].ToString();
                        o.Obs3 = dr[8].ToString();
                        o.Recebido = Boolean.Parse(dr[9].ToString());
                        o.DataRecebido = DateTime.Parse(dr[10].ToString());
                        o.ValorRecebido = Decimal.Parse(dr[11].ToString());

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

        public static List<Boleto> listSituacao(DateTime datain, DateTime datafn, String nome, 
            Boolean recebido)
        {
            List<Boleto> lo = new List<Boleto>();
            SqlDataReader dr = null;

            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = "SELECT ID, Cliente, Emissao, Vencimento, " +
                        "Valor, NossoNum, Obs1, Obs2, Obs3, Recebido, DataRecebido, ValorRecebido, Cliente.Valor_Bruto " +
                        "FROM Boleto INNER JOIN Cliente ON Boleto.Cliente = Cliente.Codigo " +
                        "WHERE ((Cliente.Nome LIKE @Nome) OR (Cliente.Fantasia LIKE @Nome)) AND " +
                        "(Vencimento BETWEEN @DataIN AND @DataFN) AND (Recebido = @Recebido)" +
                        "ORDER BY ID";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");
                    cmd.Parameters.AddWithValue("@DataIN", datain);
                    cmd.Parameters.AddWithValue("@DataFN", datafn);
                    cmd.Parameters.AddWithValue("@Recebido", recebido);


                    con.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {
                        Boleto o = new Boleto();
                        o.ID = Int32.Parse(dr[0].ToString());
                        o.Cliente = DAL.ClienteDAL.get(Int32.Parse(dr[1].ToString()));
                        o.Emissao = DateTime.Parse(dr[2].ToString());
                        o.Vencimento = DateTime.Parse(dr[3].ToString());
                        o.Valor = Decimal.Parse(dr[4].ToString());
                        o.NossoNum = dr[5].ToString();
                        o.Obs1 = dr[6].ToString();
                        o.Obs2 = dr[7].ToString();
                        o.Obs3 = dr[8].ToString();
                        o.Recebido = Boolean.Parse(dr[9].ToString());
                        o.DataRecebido = DateTime.Parse(dr[10].ToString());
                        o.ValorRecebido = Decimal.Parse(dr[11].ToString());
                        o.Valor_Bruto = Decimal.Parse(dr[12].ToString());

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

        public static List<Boleto> listByVencimento(DateTime datain, DateTime datafn, Boolean recebido)
        {
            List<Boleto> lo = new List<Boleto>();
            SqlDataReader dr = null;

            using (SqlConnection con = new SqlConnection(Common.getCon()))
            {
                try
                {
                    const string SQL = @"SELECT ID, Cliente, Emissao, Vencimento, 
                        Valor, NossoNum, Obs1, Obs2, Obs3, Recebido, DataRecebido, ValorRecebido, Cliente.Valor_Bruto 
                        FROM Boleto INNER JOIN Cliente ON Boleto.Cliente = Cliente.Codigo 
                        WHERE (Vencimento BETWEEN @DataIN AND @DataFN) AND (Recebido = @Recebido)
                        ORDER BY Cliente.Fantasia";

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@DataIN", datain);
                    cmd.Parameters.AddWithValue("@DataFN", datafn);
                    cmd.Parameters.AddWithValue("@Recebido", recebido);


                    con.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {
                        Boleto o = new Boleto();
                        o.ID = Int32.Parse(dr[0].ToString());
                        o.Cliente = DAL.ClienteDAL.get(Int32.Parse(dr[1].ToString()));
                        o.Emissao = DateTime.Parse(dr[2].ToString());
                        o.Vencimento = DateTime.Parse(dr[3].ToString());
                        o.Valor = Decimal.Parse(dr[4].ToString());
                        o.NossoNum = dr[5].ToString();
                        o.Obs1 = dr[6].ToString();
                        o.Obs2 = dr[7].ToString();
                        o.Obs3 = dr[8].ToString();
                        o.Recebido = Boolean.Parse(dr[9].ToString());
                        o.DataRecebido = DateTime.Parse(dr[10].ToString());
                        o.ValorRecebido = Decimal.Parse(dr[11].ToString());
                        o.Valor_Bruto = Decimal.Parse(dr[12].ToString());

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
