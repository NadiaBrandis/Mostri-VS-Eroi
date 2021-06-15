using MostriVSEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MostriVSEroi.mokRepository
{
    public class UtenteMokRepository : IUtenteRepository
    {
        
        const string connectionString = @"Data Source= (localdb)\MSSQLLocalDB;" +
                                        "Initial Catalog = MostriVSEroi;" + "integrated Security=true;";

        public static List<Utente> GetUtenti()
        {

            List<Utente> utenti = new List<Utente>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand
            {

                Connection = connection,

                CommandType = System.Data.CommandType.Text,

                CommandText = "select * from dbo.Utenti"
            };
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var id = reader[0];
                var username = reader[1];
                var password = reader[2];


                Utente utente = new Utente((string)username, (string)password);
                utenti.Add(utente);

            }
            connection.Close();
            return utenti;
        }
        public static void InserisciUtente(string username, string password)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "insert into dbo.Utenti values (@Username,@Password) ";
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }

    }

