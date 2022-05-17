using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_Ultimato
{
    public class Connection
    {
        //Credenciais do Banco
        public static SqlConnection con = new SqlConnection(
            "Data Source = .\\SQLEXPRESS;" +
            "Initial Catalog = dbBarDoZe;" +
            "Integrated Security = True;");

        //Tentativa de Conexão
        public static void OpenDb()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

        //Criação de Linha no Banco
        public static void Create(string pNome, string pEmail, string pSenha, string pEndereco)
        {
            SqlCommand cmd = new SqlCommand(
            "INSERT INTO tbFuncionarios (Nome, Email, Senha, Endereco)" +
            "VALUES (@nome, @email, @senha, @endereco)", con);

            cmd.Parameters.AddWithValue("@nome", pNome.ToUpper());
            cmd.Parameters.AddWithValue("@email", pEmail.ToUpper());
            cmd.Parameters.AddWithValue("@senha", pSenha.ToUpper());
            cmd.Parameters.AddWithValue("@endereco", pEndereco.ToUpper());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Usuário Criado com Sucesso");
        }

        //Leitura do Banco
        public static void Read(BindingSource pbs)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbFuncionarios;", con);

            dt.Load(cmd.ExecuteReader());
            pbs.DataSource = dt;
        }

        //Atualizar Cadastro
        public static void Update(string pNome, string pEmail, string pSenha, string pEndereco, string pID)
        {
            SqlCommand cmd = new SqlCommand("UPDATE tbFuncionarios SET Nome = @nome, Email = @email, Senha = @senha, Endereco = @endereco" +
                " WHERE ID = '" + Convert.ToInt32(pID) + "'", con);

            cmd.Parameters.AddWithValue("@nome", pNome.ToUpper());
            cmd.Parameters.AddWithValue("@email", pEmail.ToUpper());
            cmd.Parameters.AddWithValue("@senha", pSenha.ToUpper());
            cmd.Parameters.AddWithValue("@endereco", pEndereco.ToUpper());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Usuário Atualizado com Sucesso");
        }

        //Deletar Cadastro
        public static void Delete(string pID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tbFuncionarios WHERE ID = '" + Convert.ToInt32(pID) + "'", con);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Usuário Deletado com Sucesso");
        }
    }
}
