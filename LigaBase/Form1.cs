using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace LigaBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Aguarde ...";
            Application.DoEvents();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = new SqlConnection(getCon());
                SqlCommand cmd = new SqlCommand("", conn);

                cmd.CommandText =
                    "CREATE DATABASE CEF ON " +
                    "PRIMARY ( FILENAME =  '" + Regex.Escape(txtCaminho.Text) + "\\CEF.mdf' ), " +
                    "FILEGROUP CEF_Log ( FILENAME = '" + Regex.Escape(txtCaminho.Text) + "\\CEF_log.ldf') " +
                    "FOR ATTACH";

                conn.Open();

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                toolStripStatusLabel1.Text = "Base ligada com sucesso!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar base: " + ex.Message.ToString());
                toolStripStatusLabel1.Text = "Erro ao ligar base";
            }
            finally
            {
                conn.Dispose();
            }
        }

        public String getCon()
        {
            string caminhobd;
            List<string> arqlinha = new List<string>();

            string strLine = "";

            String caminho = Environment.CurrentDirectory + "\\ArqID.txt";
            FileStream file = new FileStream(caminho, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(file);

            while ((strLine = sr.ReadLine()) != null)
            {
                arqlinha.Add(strLine);
            }

            sr.Close();

            file.Close();

            caminhobd = @"Server=" + arqlinha[0].ToString() + ";User ID=" + arqlinha[1].ToString() + ";Password=" + arqlinha[2].ToString();

            return caminhobd;

        }
    }
}
