using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoLojaGeek
{
    class Cliente
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string data_nascimento { get; set; }
        public string celular { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aluno\source\repos\AvaliacaoLojaGeek\AvaliacaoLojaGeek\DbLojaGeek.mdf;Integrated Security=True");

        public List<Cliente> listacliente()
        {
            List<Cliente> li = new List<Cliente>();
            string sql = "SELECT * FROM Cliente";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cliente c = new Cliente();
                c.Id = (int)dr["Id"];
                c.nome = dr["nome"].ToString();
                c.cpf = dr["cpf"].ToString();
                c.data_nascimento = dr["data_nascimento"].ToString();
                c.celular = dr["celular"].ToString();
                c.cep = dr["cep"].ToString();
                c.endereco = dr["endereco"].ToString();
                c.bairro = dr["bairro"].ToString();
                c.cidade = dr["cidade"].ToString();
                li.Add(c);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void Inserir(string nome, string cpf, string data_nascimento, string celular, string cep, string endereco, string bairro, string cidade)
        {
            string sql = "INSERT INTO Cliente(nome,cpf,data_nascimento,celular,cep,endereco,bairro,cidade) VALUES('" + nome + "','" + cpf + "','" + data_nascimento + "','" + celular + "','" + cep + "','" + endereco + "','" + bairro + "','" + cidade + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Atualizar(int Id, string nome, string cpf, string data_nascimento, string celular, string cep, string endereco, string bairro, string cidade)
        {
            string sql = "UPDATE Cliente SET nome='" + nome + "',cpf='" + cpf + "',data_nascimento='" + data_nascimento + "',celular='" + celular + "', cep='" + cep + "', endereco='" + endereco + "', bairro='" + bairro + "', cidade='" + cidade + "' WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
           
        public void Excluir(int Id)
        {
            string sql = "DELETE FROM Cliente WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Localizar(int Id)
        {
            string sql = "SELECT * FROM Cliente WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                cpf = dr["cpf"].ToString();
                data_nascimento = dr["data_nascimento"].ToString();
                celular = dr["celular"].ToString();
                cep = dr["cep"].ToString();
                endereco = dr["endereco"].ToString();
                bairro = dr["bairro"].ToString();
                cidade = dr["cidade"].ToString();

            }
            dr.Close();
            con.Close();
        }

        public bool RegistroRepetido(string nome, string cpf)
        {
            string sql = "SELECT * FROM Cliente WHERE nome='" + nome + "' AND cpf='" + cpf + "' ";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return (int)result > 0;
            }
            con.Close();
            return false;
        }


    }
}
