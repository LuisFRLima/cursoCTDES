using luisfelipe_d3_avaliacao.Interfaces;
using luisfelipe_d3_avaliacao.Models;
using System.Data.SqlClient;

namespace luisfelipe_d3_avaliacao.Repositorios
{

    internal class UsuarioRepositorio : IUser
    {
        
         private readonly string stringConexao = "Data Source=DESKTOP-H6E3AOD\\DESKTOPH6E3AOD;Initial Catalog=luisfelipe-d3-avaliacao;User id=sa;pwd=mudar@123;";
       
        public void Create(Usuario user)
        {
            using (SqlConnection con = new(stringConexao))
            {
                string queryInsert = "INSERT INTO Usuario (Id, Nome, Senha, Email) VALUES (@Id, @Nome, @Senha, @Email)";
                using (SqlCommand cmd = new(queryInsert, con))
                {
                   
                    cmd.Parameters.AddWithValue("@Id", user.Id);
                    cmd.Parameters.AddWithValue("@Nome", user.Nome);
                    cmd.Parameters.AddWithValue("@Senha", user.Senha);
                    cmd.Parameters.AddWithValue("@Email", user.Email);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
      
    }
}
