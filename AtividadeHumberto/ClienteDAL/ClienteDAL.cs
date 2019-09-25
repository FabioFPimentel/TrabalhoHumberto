using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeHumberto.Models;
using AtividadeHumberto.ICliente;

namespace AtividadeHumberto.ClienteDAL
{
    public class ClienteDAL : InterCliente
    {
        private string connectionString = @"Server=localhost\MSSQLSERVER01; 
                                            Database=master;
                                            Trusted_Connection=True";
        public void Delete(int idCliente)
        {
            throw new NotImplementedException();
        }
        public void Insert(Cliente cCliente)
        {
            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                string commandSQL = @"Insert into Cliente
                                (nome, cpf, dataNascimento, endereco, bairro, estado)
                                values(@nome, @cpf, @dataNascimento, @endereco, @bairro, @estado)";

                SqlCommand cmd = new SqlCommand(commandSQL, cnx);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", cCliente.nome);
                cmd.Parameters.AddWithValue("@cpf", cCliente.cpf);
                cmd.Parameters.AddWithValue("@dataNascimento", cCliente.dataNascimento);
                cmd.Parameters.AddWithValue("@endereco", cCliente.endereco);
                cmd.Parameters.AddWithValue("@bairro", cCliente.bairro);
                cmd.Parameters.AddWithValue("@estado", cCliente.estado);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
        }

        public Cliente Create(int idCliente)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente cCliente)
        {
            throw new NotImplementedException();
        }
    }
}
